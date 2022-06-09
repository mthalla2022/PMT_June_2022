﻿using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.Practices.Unity;
using Ferrara.Compass.Abstractions.Interfaces;
using Ferrara.Compass.Abstractions.Models;
using Ferrara.Compass.Abstractions.Constants;
using Ferrara.Compass.DependencyResolution;
using Microsoft.SharePoint;
using Ferrara.Compass.Abstractions.Enum;
using Ferrara.Compass.Classes;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace Ferrara.Compass.WebParts.GraphicsRequestForm
{
    [ToolboxItemAttribute(false)]
    public partial class GraphicsRequestForm : WebPart
    {
        #region Member Variables
        private IGraphicsService graphicsService;
        private IPackagingItemService packagingItemService;
        private IExceptionService exceptionService;
        private IUtilityService utilityService;
        private IWorkflowService workflowService;
        private INotificationService notificationService;
        private IUserManagementService userMgmtService;
        private IPDFService pdfService;
        private IItemProposalService itemProposalService;
        private int iItemId = 0;
        #endregion

        #region Properties

        private string ProjectNumber
        {
            get
            {
                if (Page.Request.QueryString[GlobalConstants.QUERYSTRING_ProjectNo] != null)
                    return Page.Request.QueryString[GlobalConstants.QUERYSTRING_ProjectNo];
                return string.Empty;
            }
        }

        #endregion

        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public GraphicsRequestForm()
        {
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();

            graphicsService = DependencyResolution.DependencyMapper.Container.Resolve<IGraphicsService>();
            packagingItemService = DependencyResolution.DependencyMapper.Container.Resolve<IPackagingItemService>();
            utilityService = DependencyResolution.DependencyMapper.Container.Resolve<IUtilityService>();
            exceptionService = DependencyResolution.DependencyMapper.Container.Resolve<IExceptionService>();
            workflowService = DependencyResolution.DependencyMapper.Container.Resolve<IWorkflowService>();
            userMgmtService = DependencyResolution.DependencyMapper.Container.Resolve<IUserManagementService>();
            notificationService = DependencyResolution.DependencyMapper.Container.Resolve<INotificationService>();
            pdfService = DependencyResolution.DependencyMapper.Container.Resolve<IPDFService>();
            itemProposalService = DependencyResolution.DependencyMapper.Container.Resolve<IItemProposalService>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    this.divAccessDenied.Visible = false;
                    this.divAccessRequest.Visible = false;

                    // Check for a valid project number
                    if (!CheckProjectNumber())
                        return;

                    InitializeScreen();
                    LoadFormData();
                    GetNLEAAttachments();
                    GetPalletPatternAttachments();
                    btnGeneratePDFs_Click(new object(), new EventArgs());
                }
                catch (Exception exception)
                {
                    ErrorSummary.AddError(exception.Message, this.Page);
                    LoggingService.LogError(LoggingService.WebPartLoggingDiagnosticArea, CompassForm.Graphics.ToString() + ": " + exception.Message);
                    exceptionService.Handle(LogCategory.CriticalError, exception, CompassForm.Graphics.ToString(), "Page_Load");
                }
            }
            else
            {
                iItemId = Convert.ToInt32(hiddenItemId.Value);
            }
        }

        #region Private Methods
        private bool CheckProjectNumber()
        {
            iItemId = Utilities.GetItemIdFromProjectNumber(ProjectNumber);

            if (iItemId == 0)
            {
                // Invalid project Id supplied
                Page.Response.Redirect("/_layouts/Ferrara.Compass/AppPages/CompassErrorPage.aspx?ErrorId=1&ProjectNo=" + ProjectNumber, false);
                return false;
            }

            // Store Id in Hidden field
            this.hiddenItemId.Value = iItemId.ToString();
            return true;
        }
        private void InitializeScreen()
        {
            // If user does not belong to a valid group for the page, inform them that they do not hvae access rights
            if (!userMgmtService.HasReadAccess(CompassForm.Graphics))
            {
                this.divAccessDenied.Visible = true;
            }

            // If user does not have rights to save/submit the page, disable the Save and Submit buttons
            if (!userMgmtService.HasWriteAccess(CompassForm.Graphics))
            {
                this.btnSave.Enabled = false;
                //this.btnSubmit.Enabled = false;
            }

            string workflowPhase = utilityService.GetWorkflowPhase(iItemId);
            if ((string.Equals(workflowPhase, WorkflowStep.OnHold.ToString())) || (string.Equals(workflowPhase, WorkflowStep.Cancelled.ToString())) ||
                (string.Equals(workflowPhase, WorkflowStep.Completed.ToString())))
            {
                this.btnSave.Enabled = false;
                //this.btnSubmit.Enabled = false;
            }
        }
        private List<PackagingItem> GetGraphicsPackagingItems()
        {
            List<PackagingItem> dtPackingItem = new List<PackagingItem>();

            if (ViewState["GraphicsItems"] == null)
            {
                if (iItemId > 0)
                {
                    dtPackingItem = packagingItemService.GetGraphicsPackagingItemsForProject(iItemId);
                    ViewState["GraphicsItems"] = dtPackingItem;
                }
            }
            else
            {
                dtPackingItem = (List<PackagingItem>)ViewState["GraphicsItems"];
            }

            return dtPackingItem;
        }
        private ItemProposalItem GetItemProposalItem()
        {
            ItemProposalItem proposal = null;

            if (ViewState["ItemProposalItem"] == null)
            {
                if (iItemId > 0)
                {
                    proposal = itemProposalService.GetItemProposalItem(iItemId);
                    ViewState["ItemProposalItem"] = proposal;
                }
            }
            else
            {
                proposal = (ItemProposalItem)ViewState["ItemProposalItem"];
            }

            return proposal;
        }
        private Boolean SaveRepeaterItems()
        {
            foreach (RepeaterItem item in rptGraphics.Items)
            {
                if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                {
                    PackagingItem packagingItem = new PackagingItem();

                    packagingItem.CompassListItemId = iItemId.ToString();
                    packagingItem.Id = Convert.ToInt32(((HiddenField)item.FindControl("hdnItemID")).Value);
                    packagingItem.GraphicsBrief = ((TextBox)item.FindControl("txtGraphicsBrief")).Text;

                    packagingItemService.UpdatePackagingGraphicsBrief(packagingItem);
                }
            }

            ViewState["GraphicsItems"] = null;
            LoadFormData();

            return true;
        }
        #endregion

        #region Data Transfer Methods
        private void LoadFormData()
        {
            List<PackagingItem> packagingItems = GetGraphicsPackagingItems();
            ItemProposalItem proposal = GetItemProposalItem();

            txtBrand.Text = Utilities.GetDropDownDisplayValue(proposal.MaterialGroup1Brand);
            txtOBM.Text = proposal.PMName;
            txtSeason.Text = Utilities.GetDropDownDisplayValue(proposal.ProductHierarchyLevel1) + " " +
                Utilities.GetDropDownDisplayValue(proposal.ProductHierarchyLevel2);
            if (packagingItems.Count == 0)
            {
                rptGraphics.Visible = false;
                rptSummary.Visible = false;
                lblNoGraphics.Visible = true;
                btnGeneratePDFs.Visible = false;
            }
            else
            {
                rptGraphics.DataSource = packagingItems;
                rptGraphics.DataBind();
                rptSummary.DataSource = packagingItems;
                rptSummary.DataBind();
                btnGeneratePDFs.Visible = true;
                lblNoGraphics.Visible = false;
            }
        }
        private OBMFirstReviewItem ConstructFormData()
        {
            var item = new OBMFirstReviewItem();

            item.CompassListItemId = iItemId;

            item.LastUpdatedFormName = CompassForm.Graphics.ToString();

            return item;
        }
        private ApprovalItem ConstructApprovalData()
        {
            var item = new ApprovalItem();

            item.CompassListItemId = iItemId;
            item.ModifiedBy = SPContext.Current.Web.CurrentUser.Name;
            item.ModifiedDate = DateTime.Now.ToString();

            return item;
        }
        #endregion

        #region Attachment Methods
        private void GetPalletPatternAttachments()
        {
            var files = utilityService.GetUploadedCompassFilesByDocType(ProjectNumber, GlobalConstants.DOCTYPE_PalletPattern);
            if (files.Count > 0)
            {
                rpPalletPattern.Visible = true;
                lblNoPalletPattern.Visible = false;
                rpPalletPattern.DataSource = files;
                rpPalletPattern.DataBind();
            }
            else
            {
                rpPalletPattern.Visible = false;
                lblNoPalletPattern.Visible = true;
            }
        }
        protected void lnkPalletPatternFileDelete_Click(object sender, EventArgs e)
        {
            var lnkButton = (LinkButton)sender;
            if (!string.IsNullOrEmpty(lnkButton.CommandName))
            {
                utilityService.DeleteAttachment(lnkButton.CommandName);
                //GetAttachments();
            }
        }
        private void GetNLEAAttachments()
        {
            var files = utilityService.GetUploadedCompassFilesByDocType(ProjectNumber, GlobalConstants.DOCTYPE_NLEA);
            if (files.Count > 0)
            {
                rpNLEA.Visible = true;
                lblNoNLEA.Visible = false;
                rpNLEA.DataSource = files;
                rpNLEA.DataBind();
            }
            else
            {
                rpNLEA.Visible = false;
                lblNoNLEA.Visible = true;
            }
        }
        protected void lnkNLEAFileDelete_Click(object sender, EventArgs e)
        {
            var lnkButton = (LinkButton)sender;
            if (!string.IsNullOrEmpty(lnkButton.CommandName))
            {
                utilityService.DeleteAttachment(lnkButton.CommandName);
                //GetAttachments();
            }
        }
        #endregion

        #region Repeater Methods
        protected void rptSummary_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Repeater rptDieLines;
            PackagingItem packagingItem;
            HyperLink ancGR;
            if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
            {
                packagingItem = (PackagingItem)e.Item.DataItem;
                rptDieLines = (Repeater)e.Item.FindControl("rptDieLines");
                rptDieLines.DataSource = packagingItemService.GetUploadedFiles(ProjectNumber, packagingItem.Id, GlobalConstants.DOCTYPE_CADDrawing);
                rptDieLines.DataBind();
                ancGR = (HyperLink)e.Item.FindControl("ancGR");
                ancGR.NavigateUrl = string.Concat(SPContext.Current.Web.Url, "/pages/", GlobalConstants.PAGE_GraphicsRequestDetail,
                    "?", GlobalConstants.QUERYSTRING_ProjectNo, "=", ProjectNumber, "&", GlobalConstants.QUERYSTRING_PackagingItemId, "=", packagingItem.Id.ToString());
            }
        }
        protected void rptGraphics_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
            {
                PackagingItem packagingItem = (PackagingItem)e.Item.DataItem;

                TextBox txtNewExisting = (TextBox)e.Item.FindControl("lblNewExisting");
                if (txtNewExisting != null)
                {
                    if (!string.Equals(txtNewExisting.Text, "New"))
                    {
                        HtmlGenericControl likeMaterial = (HtmlGenericControl)e.Item.FindControl("dvLikeMaterial");
                        likeMaterial.Visible = false;
                        HtmlGenericControl likeMaterialDesc = (HtmlGenericControl)e.Item.FindControl("dvLikeMaterialDesc");
                        likeMaterialDesc.Visible = false;
                        HtmlGenericControl OldMaterial = (HtmlGenericControl)e.Item.FindControl("dvOldMaterial");
                        OldMaterial.Visible = false;
                        HtmlGenericControl OldMaterialDesc = (HtmlGenericControl)e.Item.FindControl("dvOldMaterialDesc");
                        OldMaterialDesc.Visible = false;
                        HtmlGenericControl whyLikeMaterial = (HtmlGenericControl)e.Item.FindControl("dvWhyLikeMaterial");
                        whyLikeMaterial.Visible = false;
                    }
                }

                HtmlImage imgAtt = (HtmlImage)e.Item.FindControl("btnAttachRendering");
                var files = packagingItemService.GetUploadedFiles(ProjectNumber, packagingItem.Id, GlobalConstants.DOCTYPE_Rendering);
                if (files.Count > 0)
                {
                    ImageButton btnDeleteRendering = (ImageButton)e.Item.FindControl("btnDeleteRendering");
                    HtmlAnchor anc = ((HtmlAnchor)e.Item.FindControl("ancRendering"));
                    btnDeleteRendering.Visible = true;
                    if (anc != null)
                    {
                        string fileName = files[0].FileName;
                        fileName = fileName.Replace("_", " ");
                        anc.InnerText = fileName;
                        anc.HRef = files[0].FileUrl;
                        btnDeleteRendering.CommandArgument = files[0].FileUrl;
                    }
                    imgAtt.Visible = false;
                }

                files = packagingItemService.GetUploadedFiles(ProjectNumber, packagingItem.Id, GlobalConstants.DOCTYPE_GraphicsRequest);
                if (files.Count > 0)
                {
                    HtmlAnchor anc = ((HtmlAnchor)e.Item.FindControl("ancGraphicsRequest"));
                    if (anc != null)
                    {
                        string fileName = files[0].FileName;
                        fileName = fileName.Replace("_", " ");
                        anc.InnerText = fileName;
                        anc.HRef = files[0].FileUrl;
                    }

                    HtmlAnchor anc2 = ((HtmlAnchor)e.Item.FindControl("ancGraphicsRequest2"));
                    if (anc2 != null)
                    {
                        string fileName = files[0].FileName;
                        fileName = fileName.Replace("_", " ");
                        fileName = fileName.Replace(".pdf", "");
                        anc2.InnerText = fileName + " Link";
                        anc2.HRef = string.Concat(SPContext.Current.Web.Url, "/pages/", GlobalConstants.PAGE_GraphicsRequestDetail, "?", GlobalConstants.QUERYSTRING_ProjectNo, "=", ProjectNumber, "&", GlobalConstants.QUERYSTRING_PackagingItemId, "=", packagingItem.Id.ToString());
                    }
                }

                files = packagingItemService.GetUploadedFiles(ProjectNumber, packagingItem.Id, GlobalConstants.DOCTYPE_CADDrawing);
                if (files.Count > 0)
                {
                    HtmlAnchor anc = ((HtmlAnchor)e.Item.FindControl("ancDieline1"));
                    if (anc != null)
                    {
                        string fileName = files[0].FileName;
                        fileName = fileName.Replace("_", " ");
                        anc.InnerText = fileName;
                        anc.HRef = files[0].FileUrl;
                    }
                    if (files.Count > 1)
                    {
                        HtmlAnchor anc2 = ((HtmlAnchor)e.Item.FindControl("ancDieline2"));
                        if (anc2 != null)
                        {
                            string fileName = files[1].FileName;
                            fileName = fileName.Replace("_", " ");
                            anc2.InnerText = fileName;
                            anc2.HRef = files[1].FileUrl;
                        }
                    }
                }
            }
        }
        protected void rptGraphics_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            List<PackagingItem> lst = GetGraphicsPackagingItems();

            if (e.CommandName.ToLower() == "deleterendering")
            {
                utilityService.DeleteAttachment(e.CommandArgument.ToString());
            }

            rptGraphics.DataSource = lst;
            rptGraphics.DataBind();
            ViewState["GraphicsItems"] = lst;
        }
        #endregion

        #region Button Methods
        protected void lbHelpDeskEmail_Click(object sender, EventArgs e)
        {
            notificationService.SendHelpDeskAccessEmail(SPContext.Current.Web.CurrentUser.LoginName, SPContext.Current.Web.CurrentUser.Email, "Graphics Request");
            this.divAccessDenied.Visible = false;
            this.divAccessRequest.Visible = true;
        }
        protected void btnGeneratePDFs_Click(object sender, EventArgs e)
        {
            List<PackagingItem> packagingItems = GetGraphicsPackagingItems();

            // Generate ALL Graphics Request PDFs
            try
            {
                foreach (PackagingItem packagingItem in packagingItems)
                {
                    foreach (RepeaterItem item in rptGraphics.Items)
                    {
                        HiddenField piId = ((HiddenField)item.FindControl("hdnItemID"));
                        int hiddenPID = Convert.ToInt32(piId.Value);
                        if (hiddenPID == packagingItem.Id)
                        {
                            HtmlAnchor anc = ((HtmlAnchor)item.FindControl("ancGraphicsRequest"));
                            if (!String.IsNullOrEmpty(anc.HRef))
                            {
                                utilityService.DeleteAttachment(anc.HRef);
                            }
                            break;
                        }
                    }

                    pdfService.CreateGraphicsRequestPDF(iItemId, packagingItem.Id);
                }
                lblPdfGenerated.Text = "PDF Files Generated: " + DateTime.Now.ToString();
            }
            catch (Exception exc)
            {
                ErrorSummary.AddError(exc.Message, this.Page);
                LoggingService.LogError(LoggingService.WebPartLoggingDiagnosticArea, CompassForm.Graphics.ToString() + ": btnGeneratePDFs_Click: " + exc.Message);
                exceptionService.Handle(LogCategory.CriticalError, exc, CompassForm.Graphics.ToString(), "btnGeneratePDFs_Click");
            }

            rptGraphics.DataSource = packagingItems;
            rptGraphics.DataBind();
            ViewState["GraphicsItems"] = packagingItems;
        }
        protected void btnReloadAttachment_Click(object sender, EventArgs e)
        {
            List<PackagingItem> lst = GetGraphicsPackagingItems();

            rptGraphics.DataSource = lst;
            rptGraphics.DataBind();
            ViewState["GraphicsItems"] = lst;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userMgmtService.HasWriteAccess(CompassForm.Graphics))
                {
                    ErrorSummary.AddError("You do not have proper access rights to save this page!", this.Page);
                    return;
                }
                if (iItemId <= 0)
                {
                    ErrorSummary.AddError("Invalid Item Id! Project cannot be updated!", this.Page);
                    return;
                }

                ApprovalItem approvalItem = ConstructApprovalData();
                graphicsService.UpdateGraphicsApprovalItem(approvalItem, false);

                SaveRepeaterItems();

                lblSavedMessage.Text = "Changes Saved: " + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                ErrorSummary.AddError(ex.Message, this.Page);
                LoggingService.LogError(LoggingService.WebPartLoggingDiagnosticArea, CompassForm.Graphics.ToString() + ": btnSave_Click: " + ex.Message);
                exceptionService.Handle(LogCategory.CriticalError, ex, CompassForm.Graphics.ToString(), "btnSave_Click");
            }
        }
        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!userMgmtService.HasWriteAccess(CompassForm.Graphics))
        //        {
        //            ErrorSummary.AddError("You do not have proper access rights to save this page!", this.Page);
        //            return;
        //        }
        //        if (iItemId <= 0)
        //        {
        //            ErrorSummary.AddError("Invalid Item Id! Project cannot be updated!", this.Page);
        //            return;
        //        }

        //        ApprovalItem approvalItem = ConstructApprovalData();
        //        graphicsService.UpdateGraphicsApprovalItem(approvalItem, false);

        //        SaveRepeaterItems();

        //        // Complete the workflow task
        //        workflowService.CompleteWorkflowTask(iItemId, WorkflowStep.Graphics);

        //        // Redirect to Home page after successfull Submit                    
        //        Page.Response.Redirect(Utilities.RedirecttoHomePage(), true);
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorSummary.AddError(ex.Message, this.Page);
        //        LoggingService.LogError(LoggingService.WebPartLoggingDiagnosticArea, CompassForm.Graphics.ToString() + ": btnSubmit_Click: " + ex.Message);
        //        exceptionService.Handle(LogCategory.CriticalError, ex, CompassForm.Graphics.ToString(), "btnSubmit_Click");
        //    }
        //}
        #endregion

    }
}
