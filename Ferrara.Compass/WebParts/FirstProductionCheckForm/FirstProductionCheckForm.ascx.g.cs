﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferrara.Compass.WebParts.FirstProductionCheckForm {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class FirstProductionCheckForm {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.LinkButton lbHelpDeskEmail;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divAccessDenied;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divAccessRequest;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.ValidationSummary ItemValidationSummary;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblItemNumber;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblItemDescription;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblPackingPlant;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblCurrentAvailableQuantity;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblDateofFirstProduction;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox lblQuantityofFirstProduction;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.Button btnDashboard;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HiddenField hiddenItemId;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HiddenField hdnProjectType;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl dvMain;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "17.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(FirstProductionCheckForm target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.LinkButton @__BuildControllbHelpDeskEmail() {
            global::System.Web.UI.WebControls.LinkButton @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.LinkButton();
            this.lbHelpDeskEmail = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lbHelpDeskEmail";
            @__ctrl.CausesValidation = false;
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("HelpDesk"));
            @__ctrl.Click -= new System.EventHandler(this.lbHelpDeskEmail_Click);
            @__ctrl.Click += new System.EventHandler(this.lbHelpDeskEmail_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivAccessDenied() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.divAccessDenied = @__ctrl;
            @__ctrl.ID = "divAccessDenied";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "col-xs-12 col-sm-12 col-md-12 AccessDenied");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            WARNING: You do not have access to update this page. Save functiona" +
                        "lity will be disabled! <br />If you require access, please email the\r\n          " +
                        "  "));
            global::System.Web.UI.WebControls.LinkButton @__ctrl1;
            @__ctrl1 = this.@__BuildControllbHelpDeskEmail();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(".<br />\r\n        "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivAccessRequest() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.divAccessRequest = @__ctrl;
            @__ctrl.ID = "divAccessRequest";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "col-xs-12 col-sm-12 col-md-12 AccessRequest");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            Your request for access has been sent!\r\n        "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ValidationSummary @__BuildControlItemValidationSummary() {
            global::System.Web.UI.WebControls.ValidationSummary @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ValidationSummary();
            this.ItemValidationSummary = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ItemValidationSummary";
            @__ctrl.Enabled = true;
            @__ctrl.HeaderText = "<strong><p style=\'font-size:medium\'>Submission Failed!</p></strong><br/>Please co" +
                "rrect the errors below:<br/>";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblItemNumber() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblItemNumber = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblItemNumber";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblItemDescription() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblItemDescription = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblItemDescription";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblPackingPlant() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblPackingPlant = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblPackingPlant";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblCurrentAvailableQuantity() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblCurrentAvailableQuantity = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblCurrentAvailableQuantity";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblDateofFirstProduction() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblDateofFirstProduction = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblDateofFirstProduction";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControllblQuantityofFirstProduction() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.lblQuantityofFirstProduction = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblQuantityofFirstProduction";
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.None;
            @__ctrl.ReadOnly = true;
            @__ctrl.CssClass = "form-control";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnDashboard() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnDashboard = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "btnDashboard";
            @__ctrl.Text = "Dashboard";
            @__ctrl.CssClass = "ButtonControlAutoSize";
            @__ctrl.CausesValidation = false;
            @__ctrl.Click -= new System.EventHandler(this.btnDashboard_Click);
            @__ctrl.Click += new System.EventHandler(this.btnDashboard_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhiddenItemId() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hiddenItemId = @__ctrl;
            @__ctrl.ID = "hiddenItemId";
            @__ctrl.ClientIDMode = global::System.Web.UI.ClientIDMode.Static;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhdnProjectType() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hdnProjectType = @__ctrl;
            @__ctrl.ID = "hdnProjectType";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldvMain() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.dvMain = @__ctrl;
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "container");
            @__ctrl.ID = "dvMain";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl1;
            @__ctrl1 = this.@__BuildControldivAccessDenied();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl2;
            @__ctrl2 = this.@__BuildControldivAccessRequest();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12"">
            <h1>First Production Check</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 CompassSeparator"">&nbsp;</div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12 ValidationSummary"">
            "));
            global::System.Web.UI.WebControls.ValidationSummary @__ctrl3;
            @__ctrl3 = this.@__BuildControlItemValidationSummary();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
            <div id=""dverror_message"" style=""display:none;""> <ul id=""error_message""></ul></div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-12 col-md-12"">
            <h2>Tracking Details</h2>
        </div>
    </div>
    <div class=""row RowBottomMargin"">
        <div class=""col-xs-12 col-sm-12 col-md-12 CompassSeparator"">&nbsp;</div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-6 col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"">Item #:</label>
                "));
            global::System.Web.UI.WebControls.TextBox @__ctrl4;
            @__ctrl4 = this.@__BuildControllblItemNumber();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xs-12 col-sm-6 col-" +
                        "md-8\">\r\n            <div class=\"form-group\">\r\n                <label class=\"cont" +
                        "rol-label\">Item Description:</label>\r\n                "));
            global::System.Web.UI.WebControls.TextBox @__ctrl5;
            @__ctrl5 = this.@__BuildControllblItemDescription();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        " +
                        "<div class=\"col-xs-12 col-sm-6 col-md-4\">\r\n            <div class=\"form-group\">\r" +
                        "\n                <label class=\"control-label\">Packing Plant:</label>\r\n          " +
                        "      "));
            global::System.Web.UI.WebControls.TextBox @__ctrl6;
            @__ctrl6 = this.@__BuildControllblPackingPlant();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-xs-12 col-sm-6 col-md-4"">
            <div class=""form-group"">
                <label class=""control-label"">Current Available Quantity:</label>
                "));
            global::System.Web.UI.WebControls.TextBox @__ctrl7;
            @__ctrl7 = this.@__BuildControllblCurrentAvailableQuantity();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xs-12 col-sm-6 col-" +
                        "md-4\">\r\n            <div class=\"form-group\">\r\n                <label class=\"cont" +
                        "rol-label\">Date of First Production:</label>\r\n                "));
            global::System.Web.UI.WebControls.TextBox @__ctrl8;
            @__ctrl8 = this.@__BuildControllblDateofFirstProduction();
            @__parser.AddParsedSubObject(@__ctrl8);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xs-12 col-sm-6 col-" +
                        "md-4\">\r\n            <div class=\"form-group\">\r\n                <label class=\"cont" +
                        "rol-label\">Quantity of First Production:</label>\r\n                "));
            global::System.Web.UI.WebControls.TextBox @__ctrl9;
            @__ctrl9 = this.@__BuildControllblQuantityofFirstProduction();
            @__parser.AddParsedSubObject(@__ctrl9);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        " +
                        "<div class=\"col-xs-12 col-sm-9 col-md-11\">\r\n            &nbsp;\r\n        </div>\r\n" +
                        "        <div class=\"col-xs-12 col-sm-3 col-md-1\">\r\n            "));
            global::System.Web.UI.WebControls.Button @__ctrl10;
            @__ctrl10 = this.@__BuildControlbtnDashboard();
            @__parser.AddParsedSubObject(@__ctrl10);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-1" +
                        "2 col-sm-12 col-md-12\">\r\n             "));
            global::System.Web.UI.WebControls.HiddenField @__ctrl11;
            @__ctrl11 = this.@__BuildControlhiddenItemId();
            @__parser.AddParsedSubObject(@__ctrl11);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n             "));
            global::System.Web.UI.WebControls.HiddenField @__ctrl12;
            @__ctrl12 = this.@__BuildControlhdnProjectType();
            @__parser.AddParsedSubObject(@__ctrl12);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </div>\r\n    </div>\r\n"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private void @__BuildControlTree(global::Ferrara.Compass.WebParts.FirstProductionCheckForm.FirstProductionCheckForm @__ctrl) {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl1;
            @__ctrl1 = this.@__BuildControldvMain();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}