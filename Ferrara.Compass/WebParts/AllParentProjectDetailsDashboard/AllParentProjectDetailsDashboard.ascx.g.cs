//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferrara.Compass.WebParts.AllParentProjectDetailsDashboard {
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
    
    
    public partial class AllParentProjectDetailsDashboard {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.Panel dashboardError;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.DropDownList ProjectStatusFilter;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HiddenField hidProjectGroup;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HiddenField hidProjectInitiator;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HiddenField hidTableDisplayType;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal litScript;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "17.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(AllParentProjectDetailsDashboard target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.Panel @__BuildControldashboardError() {
            global::System.Web.UI.WebControls.Panel @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Panel();
            this.dashboardError = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "dashboardError";
            @__ctrl.CssClass = "dashboardError";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control3() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Open Parent Projects";
            @__ctrl.Value = "All Open";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control4() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Completed Parent Projects";
            @__ctrl.Value = "Completed";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control5() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Cancelled Parent Projects";
            @__ctrl.Value = "Cancelled";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control6() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All On Hold Parent Projects";
            @__ctrl.Value = "OnHold";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control7() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Parent Projects";
            @__ctrl.Value = "All Projects";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.WebControls.ListItemCollection @__ctrl) {
            global::System.Web.UI.WebControls.ListItem @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control3();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.ListItem @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control4();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.ListItem @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control5();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.ListItem @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control6();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.ListItem @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control7();
            @__ctrl.Add(@__ctrl5);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlProjectStatusFilter() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ProjectStatusFilter = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ProjectStatusFilter";
            @__ctrl.AutoPostBack = true;
            this.@__BuildControl__control2(@__ctrl.Items);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhidProjectGroup() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hidProjectGroup = @__ctrl;
            @__ctrl.ID = "hidProjectGroup";
            @__ctrl.Value = "";
            @__ctrl.ClientIDMode = global::System.Web.UI.ClientIDMode.Static;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhidProjectInitiator() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hidProjectInitiator = @__ctrl;
            @__ctrl.ID = "hidProjectInitiator";
            @__ctrl.Value = "";
            @__ctrl.ClientIDMode = global::System.Web.UI.ClientIDMode.Static;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HiddenField @__BuildControlhidTableDisplayType() {
            global::System.Web.UI.WebControls.HiddenField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HiddenField();
            this.hidTableDisplayType = @__ctrl;
            @__ctrl.ID = "hidTableDisplayType";
            @__ctrl.Value = "false";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControllitScript() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.litScript = @__ctrl;
            @__ctrl.ID = "litScript";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private void @__BuildControlTree(global::Ferrara.Compass.WebParts.AllParentProjectDetailsDashboard.AllParentProjectDetailsDashboard @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"


<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/jquery.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jszip.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/dataTables.buttons.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/buttons.html5.min.js""></script>

<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/Compass.js?v=115""></script>

<link href=""/_layouts/15/Ferrara.Compass/css/jquery.dataTables.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/Compass-Blue.css?v=4"" type=""text/css"" rel=""Stylesheet"" />

<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-grid.min.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-table.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap.min.css"" type=""text/css"" rel=""Stylesheet"" />

<div style=""min-width: 1000px; border: 0px solid black; padding: 3px; margin: 0 auto;"" id=""allParentProjectMainDiv"">
    "));
            global::System.Web.UI.WebControls.Panel @__ctrl1;
            @__ctrl1 = this.@__BuildControldashboardError();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    <h2>All Parent Project Details</h2>\r\n    "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl2;
            @__ctrl2 = this.@__BuildControlProjectStatusFilter();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
    <table id='AllParentOpenProjects' class='display'>
        <thead>
            <tr>
                <th>Project Number</th>
                <th>Project Name</th>
                <th>Gate 0 Approved Date</th>
                <th>Desired 1st Ship Date</th>
                <th>Revised 1st Ship Date</th>
                <th>Current Project Stage</th>
                <th>Brand</th>
                <th>#SKUs</th>
                <th>Project Type</th>
                <th>Project Type SubCategory</th>
                <th>Project Manager</th>
                <th>Project Leader</th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <th>Project Number</th>
                <th>Project Name</th>
                <th>Gate 0 Approved Date</th>
                <th>Desired 1st Ship Date</th>
                <th>Revised 1st Ship Date</th>
                <th>Current Project Stage</th>
                <th>Brand</th>
                <th>#SKUs</th>
                <th>Project Type</th>
                <th>Project Type SubCategory</th>
                <th>Project Manager</th>
                <th>Project Leader</th>
            </tr>
        </tfoot>
    </table>
    "));
            global::System.Web.UI.WebControls.HiddenField @__ctrl3;
            @__ctrl3 = this.@__BuildControlhidProjectGroup();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
            global::System.Web.UI.WebControls.HiddenField @__ctrl4;
            @__ctrl4 = this.@__BuildControlhidProjectInitiator();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
            global::System.Web.UI.WebControls.HiddenField @__ctrl5;
            @__ctrl5 = this.@__BuildControlhidTableDisplayType();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</div>\r\n"));
            global::System.Web.UI.WebControls.Literal @__ctrl6;
            @__ctrl6 = this.@__BuildControllitScript();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        A" +
                        "llParentProjectDisplay();\r\n    });\r\n\r\n</script>\r\n\r\n\r\n"));
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
