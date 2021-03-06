<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=16.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=16.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=16.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=16.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WorldSyncRequestUpload.ascx.cs" Inherits="Ferrara.Compass.WebParts.WorldSyncRequestUpload.WorldSyncRequestUpload" %>

<script type="text/javascript" src="/_layouts/15/Ferrara.Compass/js/jquery.min.js"></script>
<script type="text/javascript" src="/_layouts/15/Ferrara.Compass/js/Bootstrap/bootstrap.min.js"></script>
<script type="text/javascript" src="/_layouts/15/Ferrara.Compass/js/Compass.js?v=21"></script>

<link href="/_layouts/15/Ferrara.Compass/css/Bootstrap/bootstrap.min.css" rel="Stylesheet" />
<link href="/_layouts/15/Ferrara.Compass/css/Compass-Blue.css" rel="Stylesheet" />
<div class="container" id="dvMain"> 
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h1>WorldSync Request Upload Form</h1>
        </div>
    </div>
     <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12 ValidationSummary">
            <asp:ValidationSummary ID="ItemValidationSummary" runat="server" Enabled="True" HeaderText="Submission Failed!<br/>Please correct the errors below:" />
            <div id="dverror_message" style="display:none;"> <ul id="error_message"></ul></div>
        </div>
    </div>
    <div class="row">
        <div id="divAccessDenied" runat="server" class="col-xs-12 col-sm-12 col-md-12 AccessDenied">
            WARNING: You do not have access to update this page. Save functionality will be disabled! <br />If you require access, please email the
            <asp:LinkButton ID="lbHelpDeskEmail" runat="server" CausesValidation="False" OnClick="lbHelpDeskEmail_Click" >HelpDesk</asp:LinkButton>.<br />
        </div>
    </div>
    <div class="row">
        <div id="divRequestUploaded" runat="server" visible="false" class="col-xs-12 col-sm-12 col-md-12 AccessDenied">
            This request has already been uploaded!<br />
        </div>
    </div>
    <div class="row">
        <div id="divAccessRequest" runat="server" class="col-xs-12 col-sm-12 col-md-12 AccessRequest">
            Your request for access has been sent!
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2><asp:Label ID="lblRequestType" runat="server" Text="Label"></asp:Label></h2>
        </div>
    </div>
    <div class="row RowBottomMargin">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <table><tr>
            <td><asp:Label ID="Label3" runat="server" Text="RequestId: " CssClass="LabelControl"></asp:Label></td>
            <td><asp:Label ID="lblRequestId" runat="server" CssClass="LabelControl" ClientIDMode="Static"></asp:Label></td>
            <td>&nbsp;&nbsp;&nbsp;</td>
            <td><asp:Label ID="Label1" runat="server" Text="SAP number: " CssClass="LabelControl"></asp:Label></td>
            <td><asp:Label ID="lblSAPnumber" runat="server" CssClass="LabelControl" ClientIDMode="Static"></asp:Label></td>
            <td>&nbsp;&nbsp;&nbsp;</td>
            <td><asp:Label ID="Label2" runat="server" Text="SAP description: " CssClass="LabelControl"></asp:Label></td>
            <td><asp:Label ID="lblSAPdescription" runat="server" Text="Label" CssClass="LabelControl"></asp:Label></td>
            </tr></table>
        </div>
    </div>
    <div class="row attachment">
        <div class="col-xs-12 col-sm-3 col-md-4">
            <label class="control-label">Attach your file request Here:</label>
        </div>
        <div class="col-xs-12 col-sm-9 col-md-4">  
            <asp:Button ID="btnUpload" Text="Upload" OnClientClick="validateForm(); return false;" CssClass="ButtonControlAutoSize" runat="server" ClientIDMode="Static" />
        </div>
    </div>
    <div class="row attachment">
        <div class="col-xs-12 col-sm-12 col-md-6">
            <table width="50%" id="tabAttachments">
                <asp:Repeater ID="rptAttachmentSpec"  ClientIDMode="Static" runat="server" >
                    <HeaderTemplate>
                        <thead>
                            <th>Action</th></tr>
                            <tr><th>Document Name</th>
                        </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                            <tr><td><a target='_blank' href='<%#Eval("FileUrl") %>'><%#Eval("FileName")%></a></td>
                            <td><asp:LinkButton ID="lnkNLEADelete"  ClientIDMode="Static" runat="server"  Text="Delete" CommandName='<%#Eval("FileUrl") %>' OnClientClick='javascript:return confirm("Are you sure you want to delete?")' OnClick="lnkDeleteAttachment_Click" CausesValidation="false"></asp:LinkButton></td></tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <p class="comment-block"><label id="lblItemNote" class="comment-block">A unique document is allowed.</label></p>
            <asp:Button ID="btnReloadAttachment" runat="server" Text="Reload Attachment" CssClass="ReloadAttachment" OnClick="btnReloadAttachment_Click"  />
        </div>
    </div>
    <div class="row RowBottomMargin">
        <div class="col-xs-12 col-sm-9 col-md-10"></div>
        <div class="col-xs-12 col-sm-3 col-md-1"></div>
        <div class="col-xs-12 col-sm-3 col-md-1">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="ButtonControl" OnClick="btnSubmit_Click" Enabled="false" />
        </div>
    </div>
    <asp:HiddenField ID="hddDocType" runat="server" ClientIDMode="Static" />
</div>
<script>
    $(document).ready(function () {
        var fileCounter;
        fileCounter = $('#tabAttachments >tbody >tr').length;
        $("#btnUpload").prop("disabled", fileCounter > 0);
    });
    function validateForm() {
        var parameters;
        parameters = '?DocType=' + $('#hddDocType').val() + '&SAPNo=' + $('#lblSAPnumber').text() + '&RequestId=' + $('#lblRequestId').text();
        openGenericDialog('Upload', parameters);
    }
</script>