//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferrara.Compass.WebParts.AllOpenProjectsForm {
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
    
    
    public partial class AllOpenProjectsForm {
        
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
        public static implicit operator global::System.Web.UI.TemplateControl(AllOpenProjectsForm target) 
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
            @__ctrl.Text = "All Open Projects";
            @__ctrl.Value = "All Open";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control4() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Completed Projects";
            @__ctrl.Value = "Completed";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control5() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Cancelled Projects";
            @__ctrl.Value = "Cancelled";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control6() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All On Hold Projects";
            @__ctrl.Value = "On Hold";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control7() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "All Projects";
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
        private void @__BuildControlTree(global::Ferrara.Compass.WebParts.AllOpenProjectsForm.AllOpenProjectsForm @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"


<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/jquery.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jszip.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/dataTables.buttons.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/buttons.html5.min.js""></script>

<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/Compass.js?v=115""></script>

<link href=""/_layouts/15/Ferrara.Compass/css/jquery.dataTables.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/Compass-Blue.css"" type=""text/css"" rel=""Stylesheet"" />

<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-grid.min.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-table.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap.min.css"" type=""text/css"" rel=""Stylesheet"" />

<div style=""min-width: 1000px; border: 0px solid black; padding: 3px; margin: 0 auto;"" id=""allProjectMainDiv"">
    "));
            global::System.Web.UI.WebControls.Panel @__ctrl1;
            @__ctrl1 = this.@__BuildControldashboardError();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    <h2>PMT Projects</h2>\r\n    "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl2;
            @__ctrl2 = this.@__BuildControlProjectStatusFilter();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    <table id=\'AllOpenProjects\' class=\'display\'>\r\n        <thead>\r\n            " +
                        "<tr>\r\n                <th>Parent Project Number</th>\r\n                <th>Projec" +
                        "t Workflow Link</th>\r\n                <th>Commercialization Link</th>\r\n         " +
                        "       <th>SAP Item #</th>\r\n                <th>SAP Description</th>\r\n          " +
                        "      <th>Revised First Ship Date</th>\r\n                \r\n                <th>Wo" +
                        "rkflow Phase</th>\r\n                <th>Product Hierarchy Level 1</th>\r\n         " +
                        "       <th>Material Group 1 Brand</th>\r\n                <th>Manufacturing Locati" +
                        "on</th>\r\n                <th>Packing Location</th>\r\n                <th>Project " +
                        "Type</th>\r\n                <th>Project Type SubCategory</th>\r\n                <t" +
                        "h>PM</th>\r\n                <th>Packaging Engineer</th>\r\n                <th>Init" +
                        "iator</th>\r\n                <th>Customer</th>\r\n                <th>Submitted Dat" +
                        "e</th>\r\n            </tr>\r\n        </thead>\r\n        <tfoot>\r\n            <tr>\r\n" +
                        "                <th>Parent Project Number</th>\r\n                <th>Project Work" +
                        "flow Link</th>\r\n                <th>Commercialization Link</th>\r\n               " +
                        " <th>SAP Item #</th>\r\n                <th>SAP Description</th>\r\n                " +
                        "<th>Revised First Ship Date</th>\r\n                \r\n                <th>Workflow" +
                        " Phase</th>\r\n                <th>Product Hierarchy Level 1</th>\r\n               " +
                        " <th>Material Group 1 Brand</th>\r\n                <th>Manufacturing Location</th" +
                        ">\r\n                <th>Packing Location</th>\r\n                <th>Project Type</" +
                        "th>\r\n                <th>Project Type SubCategory</th>\r\n                <th>PM</" +
                        "th>\r\n                <th>Packaging Engineer</th>\r\n                <th>Initiator<" +
                        "/th>\r\n                <th>Customer</th>\r\n                <th>Submitted Date</th>" +
                        "\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n    "));
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
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        AllProjectDisplay();
        $('#ProjectStatusFilter').on('change', function () {
            var filterVal = this.value;
            $('#AllOpenProjects').dataTable().fnDestroy();
            if (filterVal == ""All Open"") {
                AllProjectDisplay(""&$filter=(WorkflowPhase ne 'Completed' and WorkflowPhase ne 'On Hold' and WorkflowPhase ne 'Cancelled')"");
            } else if (filterVal == ""Completed"") {
                AllProjectDisplay(""&$filter=(WorkflowPhase eq 'Completed')"");

            } else if (filterVal == ""Cancelled"") {
                AllProjectDisplay(""&$filter=(WorkflowPhase eq 'Cancelled')"");

            } else if (filterVal == ""On Hold"") {
                AllProjectDisplay(""&$filter=(WorkflowPhase eq 'On Hold')"");

            } else if (filterVal == ""All Projects"") {
                AllProjectDisplay();

            }
        });
    });

</script>


"));
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
