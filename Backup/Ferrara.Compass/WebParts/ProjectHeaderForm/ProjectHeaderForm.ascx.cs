using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Ferrara.Compass.Abstractions.Constants;
using Ferrara.Compass.Classes;
using Ferrara.Compass.Abstractions.Interfaces;
using Ferrara.Compass.Abstractions.Enum;
using Ferrara.Compass.Abstractions.Models;
using Microsoft.Practices.Unity;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Ferrara.Compass.ControlTemplates.Ferrara.Compass;
using System.Web.UI;

namespace Ferrara.Compass.WebParts.ProjectHeaderForm
{
    [ToolboxItemAttribute(false)]
    public partial class ProjectHeaderForm : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]

        #region Member Variables
        private IProjectHeaderService headerService;
        private IPackagingItemService packagingItemService;
        private IExceptionService exceptionService;
        private IConfigurationManagementService configurationService;
        private IWorkflowService workflowService;
        private int iItemId = 0;
        public string versionNumber = "149";
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
        private string FormName
        {
            get
            {
                string filename;
                filename = System.IO.Path.GetFileName(Page.Request.Url.AbsolutePath);
                return filename;
            }
        }
        public ProjectHeaderForm()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
            headerService = DependencyResolution.DependencyMapper.Container.Resolve<IProjectHeaderService>();
            exceptionService = DependencyResolution.DependencyMapper.Container.Resolve<IExceptionService>();
            configurationService = DependencyResolution.DependencyMapper.Container.Resolve<IConfigurationManagementService>();
            workflowService = DependencyResolution.DependencyMapper.Container.Resolve<IWorkflowService>();
            packagingItemService = DependencyResolution.DependencyMapper.Container.Resolve<IPackagingItemService>();
            addPageJSScripts();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    string openWindow = @"javascript:window.open('CommercializationItem.aspx?ProjectNo=" + ProjectNumber + "'); return false;";
                    this.lbDisplayCommForm.Attributes.Add("onclick", openWindow);
                    string workflowStatusWindow = @"javascript:window.open('ProjectStatus.aspx?ProjectNo=" + ProjectNumber + "'); return false;";
                    this.lbProjectStatusForm.Attributes.Add("onclick", workflowStatusWindow);

                    if (!CheckProjectNumber())
                    {
                        this.divProjectHeader.Visible = false;
                        return;
                    }

                    LoadFormData();
                    InitializeScreen();
                }
                catch (Exception exception)
                {
                    LoggingService.LogError(LoggingService.WebPartLoggingDiagnosticArea, "Header: " + exception.Message);
                    exceptionService.Handle(LogCategory.CriticalError, exception, "Header", "Page_Load");
                }
            }
            else
            {
                if (!CheckProjectNumber())
                {
                    this.divProjectHeader.Visible = false;
                    return;
                }
                try
                {
                    if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_ItemProposal.ToLower()))
                    {
                        ProjectHeaderItem projectHeaderDets = headerService.GetProjectHeaderItem(iItemId);
                        this.lblProjectTitle.Text = SetProjectTitle(projectHeaderDets);
                        //this.lblCriticalInitiative.Text = headerItem.CriticalInitiative;
                        this.lblProjectType.Text = projectHeaderDets.ProjectType;
                        if (projectHeaderDets.ProjectTypeSubCategory == "NA")
                        {
                            divProjectTypeSubCategory.Style.Add("display", "none");
                        }
                        else
                        {
                            this.lblProjectTypeSubCategory.Text = projectHeaderDets.ProjectTypeSubCategory;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            string env = Page.Request.Url.Host.ToLower();
            if (env.Contains("spuat"))
            {
                UATMessage.Visible = true;
            }
            if (hddDeveloper.Value == "true")
            {
                btnDebugMode.Visible = true;
            }
        }

        #region Private Methods
        private bool CheckProjectNumber()
        {
            try
            {
                iItemId = Utilities.GetItemIdFromProjectNumber(ProjectNumber);

                if (iItemId == 0)
                    return false;
            }
            catch (Exception ex)
            {
                iItemId = 0;
                return false;
            }

            return true;
        }
        private void InitializeScreen()
        {
            hddOBMAdmin.Value = Utilities.CheckIfCurrentUserInGroup(GlobalConstants.GROUP_OBMAdmins).ToString().ToLower();
            hddPackingEngineer.Value = Utilities.CheckIfCurrentUserInGroup(GlobalConstants.GROUP_PackagingEngineer).ToString().ToLower();
            hddBrandManager.Value = Utilities.CheckIfCurrentUserInGroup(GlobalConstants.GROUP_Marketing).ToString().ToLower();
            hddDeveloper.Value = Utilities.CheckIfCurrentUserInGroup(GlobalConstants.GROUP_Developers).ToString().ToLower();
        }
        private void GetCompassMessage()
        {
            try
            {
                this.lblCompassMessage.Text = configurationService.GetConfiguration(SystemConfiguration.CompassMessage);
                if (string.Equals(this.lblCompassMessage.Text, "NA"))
                {
                    this.lblCompassMessage.Text = string.Empty;
                    this.divCompassMessage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                this.divCompassMessage.Visible = false;
                exceptionService.Handle(LogCategory.CriticalError, ex, "Project Header", "GetCompassMessage");
            }
        }
        public string SetProjectTitle(ProjectHeaderItem item)
        {
            string title = item.ProjectNumber + " : ";

            if (string.IsNullOrEmpty(item.SAPItemNumber))
                title = title + "XXXXX : ";
            else
                title = title + item.SAPItemNumber + " : ";

            if (string.IsNullOrEmpty(item.SAPDescription))
                title = title + "(Proposed)";
            else
                title = title + item.SAPDescription;

            return title;
        }
        private void registerJavascriptVariables(string submittedMessage)
        {
            string script;
            script = "var allMessages = {" + (submittedMessage == null ? "" : "submittedMessage: \"" + submittedMessage + "\"") + "};";
            litScript.Text = "<script>" + script + "</script>";
        }
        #endregion

        #region Data Transfer Methods
        private void LoadFormData()
        {
            ApprovalItem approval;
            string submittedMessage = null;
            ProjectHeaderItem headerItem = headerService.GetProjectHeaderItem(iItemId);

            // Set any Special Messages
            GetCompassMessage();
            approval = workflowService.GetApprovalItemByFormName(ProjectNumber, FormName);
            if (approval != null)
                submittedMessage = "Previously submitted by: " + approval.SubmittedBy + " " + approval.SubmittedDate;
            registerJavascriptVariables(submittedMessage);

            this.lblProjectTitle.Text = SetProjectTitle(headerItem);
            //this.lblCriticalInitiative.Text = headerItem.CriticalInitiative;
            this.lblProjectType.Text = headerItem.ProjectType;
            if (headerItem.ProjectTypeSubCategory == "NA")
            {
                divProjectTypeSubCategory.Style.Add("display", "none");
            }
            else
            {
                this.lblProjectTypeSubCategory.Text = headerItem.ProjectTypeSubCategory;
            }

            if (headerItem.WorkflowPhase == GlobalConstants.WORKFLOWPHASE_SrOBMInitialReview)
            {
                this.lblCurrentWorkflowPhase.Text = GlobalConstants.WORKFLOWPHASE_PMInitialReview;
            }
            else if (!string.IsNullOrWhiteSpace(headerItem.WorkflowPhase))
            {
                this.lblCurrentWorkflowPhase.Text = headerItem.WorkflowPhase.Replace("OBM", "PM");
            }

            if (string.Equals(headerItem.WorkflowPhase, GlobalConstants.WORKFLOWPHASE_Cancelled))
                lblCurrentWorkflowPhase.ForeColor = System.Drawing.Color.Red;
            if (string.Equals(headerItem.WorkflowPhase, GlobalConstants.WORKFLOWPHASE_OnHold))
                lblCurrentWorkflowPhase.ForeColor = System.Drawing.Color.Red;
            if (string.Equals(headerItem.WorkflowPhase, GlobalConstants.WORKFLOWPHASE_Completed))
                lblCurrentWorkflowPhase.ForeColor = System.Drawing.Color.Green;
            if (headerItem.TestProject.ToLower() == "yes")
            {
                btnDebugMode.Text = "Turn Debug Mode Off";
                DebugMessage.Visible = true;
            }
            else
            {
                btnDebugMode.Text = "Turn Debug Mode On";
                DebugMessage.Visible = false;
            }
        }
        #endregion

        protected void lbTaskDashboard_Click(object sender, EventArgs e)
        {
            // Redirect to Home page after successfull Submit                        
            Page.Response.Redirect(Utilities.RedirecttoHomePage(), false);
        }
        private void addPageJSScripts()
        {
            string jsURL = "";

            if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_PE.ToLower()) || string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_SAPInitialItemSetup.ToLower()))
            {
                jsURL = "PE";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_PE2.ToLower()))
            {
                jsURL = "PE2";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_Proc.ToLower()))
            {
                jsURL = "PROC";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_OBMFirstReview.ToLower()))
            {
                jsURL = "BOMRev1";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_OBMSecondReview.ToLower()))
            {
                jsURL = "BOMRev2";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_BOMSetupSAP.ToLower()))
            {
                jsURL = "BOMSetup";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_QA.ToLower()))
            {
                jsURL = "QA";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_ExternalManufacturing.ToLower()))
            {
                jsURL = "ExtMan";
            }
            else if (string.Equals(Utilities.GetCurrentPageName().ToLower(), GlobalConstants.PAGE_OPS.ToLower()))
            {
                jsURL = "QA";
            }
            if (jsURL != "")
            {
                var sharedJS = new HtmlGenericControl("script");

                sharedJS.Attributes["type"] = "text/javascript";
                sharedJS.Attributes["src"] = "/_layouts/15/Ferrara.Compass/js/sharedBOM.js?v=" + versionNumber;
                phJS.Controls.Add(sharedJS);

                var js = new HtmlGenericControl("script");

                js.Attributes["type"] = "text/javascript";
                js.Attributes["src"] = "/_layouts/15/Ferrara.Compass/js/" + jsURL + ".js?v=" + versionNumber;
                phJS.Controls.Add(js);
            }
        }
        protected void btnDebugMode_Click(object sender, EventArgs e)
        {
            string testProject = "";
            if (btnDebugMode.Text.Contains("On"))
            {
                testProject = "Yes";
            }
            else
            {
                testProject = "No";
            }
            headerService.updateDebugMode(iItemId, testProject);
            if (testProject.ToLower() == "yes")
            {
                btnDebugMode.Text = "Turn Debug Mode Off";
                DebugMessage.Visible = true;
            }
            else
            {
                btnDebugMode.Text = "Turn Debug Mode On";
                DebugMessage.Visible = false;
            }
        }
    }
}
