//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferrara.Compass.WebParts.WorldSyncRequestDashboard {
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
    
    
    public partial class WorldSyncRequestDashboard {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.Panel dashboardError;
        
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
        protected global::System.Web.UI.WebControls.HyperLink hlkNewRequest;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl div1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.HyperLink hlkWorldSyncFuseFile;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divWorldSyncFuseFile;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal litScript;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "17.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(WorldSyncRequestDashboard target) 
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
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
            return @__ctrl;
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
                        "lity will be disabled!\r\n            <br />\r\n            If you require access, p" +
                        "lease email the\r\n            "));
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
        private global::System.Web.UI.WebControls.HyperLink @__BuildControlhlkNewRequest() {
            global::System.Web.UI.WebControls.HyperLink @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HyperLink();
            this.hlkNewRequest = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "hlkNewRequest";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("World Sync Request File"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldiv1() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.div1 = @__ctrl;
            @__ctrl.ID = "div1";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "col-xs-12 col-sm-12 col-md-12");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.HyperLink @__ctrl1;
            @__ctrl1 = this.@__BuildControlhlkNewRequest();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.WebControls.HyperLink @__BuildControlhlkWorldSyncFuseFile() {
            global::System.Web.UI.WebControls.HyperLink @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HyperLink();
            this.hlkWorldSyncFuseFile = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "hlkWorldSyncFuseFile";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("Create World Sync FUSE File"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "17.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivWorldSyncFuseFile() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.divWorldSyncFuseFile = @__ctrl;
            @__ctrl.ID = "divWorldSyncFuseFile";
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "col-xs-12 col-sm-12 col-md-12");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            global::System.Web.UI.WebControls.HyperLink @__ctrl1;
            @__ctrl1 = this.@__BuildControlhlkWorldSyncFuseFile();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        "));
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
        private void @__BuildControlTree(global::Ferrara.Compass.WebParts.WorldSyncRequestDashboard.WorldSyncRequestDashboard @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"

<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/jquery.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/jszip.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/dataTables.buttons.min.js""></script>
<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/DataTables/buttons.html5.min.js""></script>

<script type=""text/javascript"" src=""/_layouts/15/Ferrara.Compass/js/Compass.js""></script>

<link href=""/_layouts/15/Ferrara.Compass/css/jquery.dataTables.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/Compass-Blue.css"" type=""text/css"" rel=""Stylesheet"" />

<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-grid.min.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap-table.css"" type=""text/css"" rel=""Stylesheet"" />
<link href=""/_layouts/15/Ferrara.Compass/css/BootStrap/bootstrap.min.css"" type=""text/css"" rel=""Stylesheet"" />

<div style=""min-width: 1000px; padding: 3px;"" id=""myRequestMainDiv"">
    "));
            global::System.Web.UI.WebControls.Panel @__ctrl1;
            @__ctrl1 = this.@__BuildControldashboardError();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    <br />\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl2;
            @__ctrl2 = this.@__BuildControldivAccessDenied();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl3;
            @__ctrl3 = this.@__BuildControldivAccessRequest();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl4;
            @__ctrl4 = this.@__BuildControldiv1();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n    <div class=\"row\">\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl5;
            @__ctrl5 = this.@__BuildControldivWorldSyncFuseFile();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
    </div>
    <h2>My Current Requests</h2>
    <br />
    <table id='tabMyCurrentRequests' class='display'>
        <thead>
            <tr>
                <th>RequestId</th>
                <th>SAP Item #</th>
                <th>SAP Description</th>
                <th>Status</th>
                <th>Task</th>
                <th>Submitted Date</th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <th>RequestId</th>
                <th>SAP Item #</th>
                <th>SAP Description</th>
                <th>Status</th>
                <th>Task</th>
                <th>Submitted Date</th>
            </tr>
        </tfoot>
    </table>
    <h2>Open Requests</h2>
    <br />
    <table id='tabOpenRequests' class='display'>
        <thead>
            <tr>
                <th>RequestId</th>
                <th>SAP Item #</th>
                <th>SAP Description</th>
                <th>Status</th>
                <th>Step</th>
                <th>Request Type</th>
                <th>Submitted Date</th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <th>RequestId</th>
                <th>SAP Item #</th>
                <th>SAP Description</th>
                <th>Status</th>
                <th>Step</th>
                <th>Request Type</th>
                <th>Submitted Date</th>
            </tr>
        </tfoot>
    </table>
</div>
"));
            global::System.Web.UI.WebControls.Literal @__ctrl6;
            @__ctrl6 = this.@__BuildControllitScript();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<script>\r\n    function MyRequestsDisplay() {\r\n        var myOpenProjects = $(\'#" +
                        "tabMyCurrentRequests\').DataTable({\r\n            initComplete: function () {\r\n   " +
                        "             this.api().columns().every(function () {\r\n                    var c" +
                        "olumn = this;\r\n                    var select = $(\'<select><option value=\"\"></op" +
                        "tion></select>\')\r\n                        .appendTo($(column.footer()).empty())\r" +
                        "\n                        .on(\'change\', function () {\r\n                          " +
                        "  var val = $.fn.dataTable.util.escapeRegex(\r\n                                $(" +
                        "this).val()\r\n                            );\r\n\r\n                            colum" +
                        "n\r\n                                .search(val ? \'^\' + val + \'$\' : \'\', true, fal" +
                        "se)\r\n                                .draw();\r\n                            loadi" +
                        "ngIconAdded = true;\r\n                        });\r\n\r\n                    column.c" +
                        "ells(\'\', column[0]).render(\'display\').sort().unique().each(function (d, j) {\r\n  " +
                        "                      var val = $(\'<div/>\').html(d).text();\r\n                   " +
                        "     select.append(\'<option value=\"\' + val + \'\">\' + val + \'</option>\');\r\n       " +
                        "             });\r\n                });\r\n            },\r\n            data: MyWorld" +
                        "SyncReqTasks,\r\n            fixedColumns: true,\r\n            \"SubmittedDate\": [6," +
                        " \'desc\'],\r\n            \"lengthMenu\": [[10, 25, 50, -1], [10, 25, 50, \"All\"]],\r\n " +
                        "           columns: [\r\n            { \'data\': \'RequestId\' },\r\n            { \'data" +
                        "\': \'SAPnumber\' },\r\n            { \'data\': \'SAPdescription\' },\r\n            { \'dat" +
                        "a\': \'RequestStatus\' },\r\n            { \'data\': \'Task\' },\r\n                {\r\n    " +
                        "                \'data\': \'SubmittedDate\',\r\n                    \'render\': function" +
                        " (data) {\r\n                        return dateJavaScriptSerializer(data);\r\n     " +
                        "               }\r\n                }\r\n            ],\r\n            columnDefs: [\r\n" +
                        "            {\r\n                targets: 0,\r\n                className: \"text-cen" +
                        "ter\"\r\n            }]\r\n        });\r\n\r\n        loadingIconAdded = true;\r\n    }\r\n  " +
                        "  function OpenRequestsDisplay() {\r\n        var myOpenProjects = $(\'#tabOpenRequ" +
                        "ests\').DataTable({\r\n            initComplete: function () {\r\n                thi" +
                        "s.api().columns().every(function () {\r\n                    var column = this;\r\n " +
                        "                   var select = $(\'<select><option value=\"\"></option></select>\')" +
                        "\r\n                        .appendTo($(column.footer()).empty())\r\n               " +
                        "         .on(\'change\', function () {\r\n                            var val = $.fn" +
                        ".dataTable.util.escapeRegex(\r\n                                $(this).val()\r\n   " +
                        "                         );\r\n\r\n                            column\r\n             " +
                        "                   .search(val ? \'^\' + val + \'$\' : \'\', true, false)\r\n           " +
                        "                     .draw();\r\n                            loadingIconAdded = tr" +
                        "ue;\r\n                        });\r\n\r\n                    column.cells(\'\', column[" +
                        "0]).render(\'display\').sort().unique().each(function (d, j) {\r\n                  " +
                        "      var val = $(\'<div/>\').html(d).text();\r\n                        select.appe" +
                        "nd(\'<option value=\"\' + val + \'\">\' + val + \'</option>\');\r\n                    });" +
                        "\r\n                });\r\n            },\r\n            data: OpenWorldSyncReqTasks,\r" +
                        "\n            fixedColumns: true,\r\n            \"SubmittedDate\": [6, \'desc\'],\r\n   " +
                        "         \"lengthMenu\": [[10, 25, 50, -1], [10, 25, 50, \"All\"]],\r\n            col" +
                        "umns: [\r\n            { \'data\': \'RequestId\' },\r\n            { \'data\': \'SAPnumber\'" +
                        " },\r\n            { \'data\': \'SAPdescription\' },\r\n            { \'data\': \'RequestSt" +
                        "atus\' },\r\n            { \'data\': \'WorkflowStep\' },\r\n            { \'data\': \'Reques" +
                        "tType\' },\r\n                {\r\n                    \'data\': \'SubmittedDate\',\r\n    " +
                        "                \'render\': function (data) {\r\n                        return date" +
                        "JavaScriptSerializer(data);\r\n                    }\r\n                }\r\n         " +
                        "   ],\r\n            columnDefs: [\r\n            {\r\n                targets: 0,\r\n  " +
                        "              className: \"text-center\"\r\n            }]\r\n        });\r\n\r\n        l" +
                        "oadingIconAdded = true;\r\n    }\r\n    $(document).ready(function () {\r\n        MyR" +
                        "equestsDisplay();\r\n        OpenRequestsDisplay();\r\n    });\r\n</script>\r\n"));
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
