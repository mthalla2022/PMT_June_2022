<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucBOM.ascx.cs" Inherits="Ferrara.Compass.ControlTemplates.Ferrara.Compass.ucBOM" %>
        <!-- Repeated data -->
              <h3 class="accordion"><asp:Label ID="lblTitle" ClientIDMode="Static" CssClass="titlelbl" runat="server"></asp:Label> <asp:Label ID="lblDesc" runat="server"></asp:Label></h3>
     <div class="panel" style="background-color:#BCD3F2;">
                    <div class="row RowBottomMargin">
                        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
                    </div>
                <div id="dvUCBomPE" class="bompe" runat="server">
             
                    <table class="container-fluid ucBOMTable">
                        <asp:Repeater ID="rptPackingItem" runat="server" OnItemCommand="rptPackingItem_ItemCommand" OnItemDataBound="rptPackingItem_ItemDataBound">
                            <HeaderTemplate>
                                <tr>
                                    <th>Select</th>
                                    <th><asp:Panel id="statusColumn" runat="server">Status</asp:Panel></th>
                                    <th>Component Type</th>
                                    <th>New/Existing</th>
                                    <th>Component #</th>
                                    <th>Component Description</th>
                                    <th class="hideItem">Like/Old Component #</th>
                                    <th class="hideItem">Like/Old Component Description</th>
                                    <th>Pack Unit</th>
                                    <th>Pack Qty</th>
                                    <th>Supplier</th>
                                    <th>SAP Material Group</th>
                                    <th>Delete</th>
                                </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr id="dvPackingItemRow" class="bomrow" style="<%# Container.ItemIndex % 2 == 0 ? "": "background-color:#BCD3F2;" %>">
                                    <td>
                                        <asp:ImageButton ID="test" CausesValidation="false" Height="16" Width="16" CssClass="select srreadonly" AlternateText="Select"  OnClientClick="hideSelectButton('Select');" CommandName="LoadControl" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' ImageUrl="/_layouts/15/Ferrara.Compass/images/Edit.gif" runat="server" />
                                        <asp:HiddenField ID="hdnComponentType" ClientIDMode="Static" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "PackagingComponent") %>' />
                                        <asp:HiddenField ID="hdnPackagingType" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "PackagingType") %>' />
                                        
                                        <asp:HiddenField ID="hdnParentID" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "ParentID") %>' />
                                    </td>
                                    <td style="width:30px; align:center;">
                                        <asp:Image ID="imgStatus" runat="server" BorderWidth="0" Height="25px" Width="25px" ImageUrl ="/_layouts/15/Ferrara.Compass/img/redCircle.png" />
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="drpComponent" runat="server" Enabled="false" CssClass="readOnly UCBOMrequired form-control">
                                            <asp:ListItem Text="Select..." Value="-1"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:HiddenField ID="hdnItemID" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "Id") %>' />
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="drpNew" Enabled="false" ReadOnly="false" onchange="BOMNewCondition(this);" runat="server" CssClass="readOnly UCBOMrequired form-control">
                                            <asp:ListItem Text="Select..." Value="-1"></asp:ListItem>
                                            <asp:ListItem Text="New" Value="New"></asp:ListItem>
                                            <asp:ListItem Text="Existing" Value="Existing"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMaterial" Enabled="false" ReadOnly="false" runat="server" class="UCBOMrequired minimumlength numericDecimal3 form-control Component" MaxLength="6" Text='<%# DataBinder.Eval(Container.DataItem, "MaterialNumber") %>'></asp:TextBox>
                                    </td>

                                    <td>
                                        <asp:TextBox ID="txtMaterialDesc" Enabled="false" ReadOnly="false" runat="server" MaxLength="40" class="readOnly UCBOMrequired form-control ComponentDesc" Text='<%# DataBinder.Eval(Container.DataItem, "MaterialDescription") %>'></asp:TextBox>
                                    </td>
                                    <td class="hideItem">
                                        <asp:TextBox ID="txtOldMaterial" Enabled="false" ReadOnly="true" runat="server" class="readOnly form-control Component" MaxLength="6" Text='<%# DataBinder.Eval(Container.DataItem, "currentLikeItem") %>'></asp:TextBox>
                                    </td>

                                    <td class="hideItem">
                                        <asp:TextBox ID="txtOldMaterialDesc" Enabled="false" ReadOnly="true" runat="server" class="readOnly form-control ComponentDesc" Text='<%# DataBinder.Eval(Container.DataItem, "currentLikeItemDescription") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="drpUnitOfMeasure" runat="server" Enabled="false" CssClass="readOnly UCBOMrequired form-control">
                                            <asp:ListItem Value="-1">Select...</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>  
                                        <asp:TextBox ID="txtPackQty" Enabled="false" ReadOnly="false" runat="server" class="readOnly UCBOMrequired numeric form-control numericDecimal3" Text='<%# DataBinder.Eval(Container.DataItem, "PackQuantity") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="drpPrinter" Enabled="false" runat="server" CssClass="readOnly form-control">
                                            <asp:ListItem Value="-1">Select...</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtSAPMatGroup" Enabled="false" ReadOnly="true" runat="server" class="readOnly form-control"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="btnDeleteAttachment" CssClass="readOnly" CausesValidation="false" AlternateText="Delete Attachment" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' ImageUrl="/_layouts/15/Ferrara.Compass/images/cancel.png" runat="server" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                   

                    <script type="text/javascript">
                        $("#lnkMain").click();
                    </script>

                    <a id="lnkMain" href="#dvUCBomPE"></a>
                </div>
<div class="OBMSetup miscOpsClass">
    <div class="row" id="dvAddFinishGoodItem" runat="server" visible="false">
        <div class="col-xs-12 col-sm-12 col-md-3">
            <asp:Button ID="btnAddNewPackagingItem" CssClass="ButtonControlAutoSize NonBOMPage" Text="Add New Packaging Component" CausesValidation="false" runat="server" OnClick="btnAddNewPackagingItem_Click" OnClientClick="javascript:showWaitPopup('Adding Packaging Component...', 'Please be patient, this may take a few seconds...');" />
            <asp:Button ID="btnreloadPackagingItem" CssClass="finish ReloadBOM HiddenButton" runat="server" />
            <asp:HiddenField ID="hdnPackagingItemCount" ClientIDMode="Static" runat="server" />
        </div>
    </div>
    <div class="row" id="dvAddTransferSemi" runat="server" visible="false">
        <div class="col-xs-12 col-sm-12 col-md-3">
            <asp:Button ID="btnAddTransferSemi" CssClass="ButtonControlAutoSize" Text="Add Transfer Semi Component" CausesValidation="false" runat="server" OnClick="btnAddTransferSemi_Click" />
        </div>
    </div>
</div>
<div id="dvElements" runat="server" class="miscOpsClass" >
    <asp:HiddenField ID="hiddenItemId" ClientIDMode="Static" runat="server" />
    <asp:HiddenField ID="hdnUCBOMComponentType" ClientIDMode="Static" runat="server"  />
    <asp:HiddenField ID="hdnUCSEMiBOMComponentType" ClientIDMode="Static" runat="server"  />

    <div id="dvTransferLocation" runat="server" visible="false"> 
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <div class="col-xs-12 col-sm-6 col-md-6">
                <h2>Transfer Location</h2>
                    </div>
            </div>
        </div>
        <div class="row RowBottomMargin FGItem">
                <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
            </div>
        <div class="row">
            <div class="col-xs-12 col-sm-6 col-md-6">
                <div class="form-group">
                    <span class="markrequired">*</span><label class="control-label">Make/Pack & Transfer Location</label>
                    <asp:DropDownList ID="drpTransferLocation" CssClass="readOnly form-control PCBOMrequired" runat="server">
                        <asp:ListItem Value="-1">Select...</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>
    </div>

    <div  id="dvPack" runat="server" class="OBMSetup">
     <div class="row FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2>Pack Trial</h2> 
        </div>

    </div>
    <div class="row RowBottomMargin FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
     <div class="row FGItem">
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
                <span class="markrequired">*</span><label class="control-label">Is a pack trial required?</label>
                <asp:DropDownList ID="ddlPackTrial" ClientIDMode="Static" runat="server" CssClass="readOnly PCBOMrequired form-control" onchange="OnPackTrialChange();" >
                    <asp:ListItem Text="Select..." Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                    <asp:ListItem Text="Unknown" Value="U"></asp:ListItem>
                    </asp:DropDownList>
            </div>
        </div>
       <div class="col-xs-12 col-sm-6 col-md-6 pe1proc">
            <div class="form-group">
                <span class="requiredpe2span markrequired">*</span> <label class="control-label">What was the result of the pack trial?</label>
                 <asp:DropDownList ID="ddlResultPackTrial" CssClass="readOnly form-control requiredpe2" runat="server">
                <asp:ListItem Value="-1">Select...</asp:ListItem>
                 </asp:DropDownList>
            </div>
        </div>
       
    </div>
    <div class="row FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12 pe1proc">
            <div class="form-group">
                <label class="control-label">Comments on Pack Trial:</label>
                <asp:TextBox ID="txtCommentPackTrial" runat="server" ClientIDMode="Static" TextMode="MultiLine" MaxLength="255" Rows="6" CssClass="readOnly form-control"></asp:TextBox>
            </div>
        </div>
    </div>

     <div class="row FGItem pe1proc">
            <div class="col-xs-12 col-sm-4 col-md-4">
           <span class="requiredpe2span markrequired">*</span>     <label class="control-label">Pack Trial File Attachment:</label>
            </div>
            <div class="col-xs-12 col-sm-8 col-md-8">  
                <input id="btnUploadPackTrial" runat="server" type="button" class="ButtonControlAutoSize" value="Upload Pack Trial Documents" onclick="openBasicDialog2('Upload Pack Trial Documents', 'PackTrial', this.className); return false;" />
            </div>
        </div>
        <div class="row FGItem pe1proc">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <table width="50%">
                <asp:Repeater ID="rptUploadPackTrial" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <th>Action</th>                            
                            <th>Document Name</th>                            
                        </tr>                            
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkPackTrialFileDelete" runat="server" Text="Delete" CommandName='<%#Eval("FileUrl") %>' OnClientClick='javascript:return confirm("Are you sure you want to delete?")' OnClick="lnkDeleteAttachment_Click"  CausesValidation="false"></asp:LinkButton>
                            </td>
                            <td>
                                <a target='_blank' href='<%#Eval("FileUrl") %>'><%#Eval("DisplayFileName")%></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                </table>
            </div>
             <asp:Button ID="btnReloadAttachment" runat="server" Text="Load Attachments" CssClass="ReloadAttachment HiddenButton" OnClick="btnReloadAttachment_Click" ></asp:Button>
        </div>
        </div>
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2>Unit Measurements</h2>
        </div>
    </div>

    <div class="row RowBottomMargin">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>

     <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-3">
            <div class="form-group">
               <span class="requiredpe2span markrequired">*</span> <label class="control-label">Net Unit Weight (oz):</label>
               <asp:TextBox ID="txtNetUnitWeight" runat="server" CssClass="readOnly decimaltwoplaces requiredpe2 form-control"></asp:TextBox>
            </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-9">
                <div class="form-group">
                    <span class="requiredpe2span markrequired">*</span><label class="control-label">Unit Dimensions:</label>
                    <div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">L</span><asp:TextBox ID="txtUnitMeasurementsL" Width="100" ClientIDMode="Static" runat="server" CssClass="readOnly form-control currencyMask requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                           <span class="dimension">X</span>
                                  </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtUnitMeasurementsW" Width="100" ClientIDMode="Static" runat="server" CssClass="readOnly form-control currencyMask requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                             <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtUnitMeasurementsH" Width="105" ClientIDMode="Static" runat="server" CssClass="readOnly form-control currencyMask requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>

    <div id="divMixes" runat="server" visible="false">
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <h2>Mixes</h2>
            </div>
        </div>
        <div class="row RowBottomMargin">
            <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
        </div>
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <table class="gridTable">
                    <asp:Repeater ID="rpMixesSummary" runat="server" OnItemDataBound="rpMixesSummary_ItemDataBound">
                        <HeaderTemplate>
                            <tr>
                            <th class="gridCellH">Item # in Mix</th>
                            <th class="gridCellH">Item Description</th>
                            <th class="gridCellH">Total Pieces per Selling Unit</th>
                            <th class="gridCellH">Ounces per Piece</th>
                            <th class="gridCellH">Ounces per Selling Unit</th>
                            <th class="gridCellH">Qty for Mix</th>
                            <th class="gridCellH">Lbs for FG BOM</th>
                            </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr <%# Container.ItemIndex % 2 == 0 ? "" : "class=\"gridRow2\""%>>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblMixItemNumber" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "ItemNumber") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblMixItemDescription" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "ItemDescription") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="Label1" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "NumberOfPieces") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="Label2" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "OuncesPerPiece") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblOzPerPiece" runat="server"></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblQtyMix" runat="server"></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblLbsForFGBOM" runat="server"></asp:Label></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </div>

    <div id="divShipper" runat="server" visible="false">
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <h2>Shippers</h2>
            </div>
        </div>
        <div class="row RowBottomMargin">
            <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
        </div>
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12">
                <table style="border-spacing: 8px; border-collapse: separate;">
                    <asp:Repeater ID="rpShipperSummary" runat="server">
                        <HeaderTemplate>
                            <tr>
                                <th>FG Item # in Display</th>
                                <th>FG Item Description</th>
                                <th># of Units</th>
                                <th>Ounces per Unit</th>
                                <th>Ounces per FG Unit</th>
                                <th>Pack Unit</th>
                            </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr <%# Container.ItemIndex % 2 == 0 ? "" : "class=\"gridRow2\""%>>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGItemDisplay" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "FGItemNumber") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGItemDescription" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "FGItemDescription") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGItemQuantity" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "FGItemNumberUnits") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGouncesPerUnit" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "FGItemOuncesPerUnit") %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGouncesPerFGunit" runat="server" 
                                Text='<%# Convert.ToInt32(DataBinder.Eval(Container.DataItem, "FGItemNumberUnits")) *
                                    Convert.ToDouble(DataBinder.Eval(Container.DataItem, "FGItemOuncesPerUnit")) %>'></asp:Label></td>
                            <td class="gridCell"><asp:Label CssClass="summary" ID="lblFGPackUnit" runat="server" 
                                Text='<%# DataBinder.Eval(Container.DataItem, "FGPackUnit") %>'></asp:Label></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </div>

    <div class="row">
    <div class="col-xs-12 col-sm-12 col-md-12">
        <h2>Case Measurements</h2>
    </div>
    </div>
    <div class="row RowBottomMargin">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>

     <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-3">
            <div class="form-group">
                <span class="requiredpe2span markrequired">*</span><label class="control-label">Case Pack:</label>
               <asp:TextBox ID="txtCasePack" ClientIDMode="Static"  CssClass="readOnly requiredpe2 form-control numericNoMask" runat="server"></asp:TextBox>
            </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-9">
                <div class="form-group">
                    <span class="requiredpe2span markrequired">*</span> <label class="control-label">Case Dimensions:</label>
                    <div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">L</span><asp:TextBox ID="txtCaseMeasurementsL" Width="100" ClientIDMode="Static" runat="server" CssClass="readOnly form-control decimalfourplaces requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                             <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtCaseMeasurementsW" Width="100"  ClientIDMode="Static"  runat ="server" CssClass="readOnly form-control decimalfourplaces requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                             <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtCaseMeasurementsH" Width="105" ClientIDMode="Static" runat="server" CssClass="readOnly form-control decimalfourplaces requiredpe2"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
               <span class="requiredpe2span markrequired">*</span> <label class="control-label">Case Cube (cubic ft):</label>
               <asp:TextBox ID="txtCaseCube" ClientIDMode="Static" Enabled="false"  CssClass="readOnly form-control decimaltwoplaces requiredpe2" runat="server"></asp:TextBox>
            </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-6">
                <div class="form-group">
                   <span class="requiredpe2span markrequired">*</span> <label class="control-label">Case Net Weight (lbs):</label>
                     <asp:TextBox ID="txtCaseNetWeight" Enabled="false" ClientIDMode="Static"  CssClass="readOnly form-control decimaltwoplaces requiredpe2" runat="server"></asp:TextBox>
                </div>
            </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
                <span class="requiredpe2span markrequired">*</span> <label class="control-label">Case Gross Weight (lbs):</label>
               <asp:TextBox ID="txtCaseGrossWeight" ClientIDMode="Static"  CssClass="readOnly form-control requiredpe2 decimaltwoplaces" runat="server"></asp:TextBox>
            </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-6">
             
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2>Pallet Measurements</h2>
        </div>
    </div>
    <div class="row RowBottomMargin">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
     <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
              <span class="requiredpe2span markrequired">*</span>  <label class="control-label">Cases per Pallet:</label>
               <asp:TextBox ID="txtCasesperPallet" ClientIDMode="Static"  CssClass="readOnly form-control requiredpe2 numericNoMask" runat="server"></asp:TextBox>
            </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-6">
                <div class="form-group">
                   <span class="requiredpe2span markrequired">*</span> <label class="control-label">Double Stackable?:</label>
                    <asp:DropDownList ID="ddlDoubleStackable" ClientIDMode="Static" runat="server" CssClass="readOnly requiredpe2 form-control" AppendDataBoundItems="true">
                        <asp:ListItem Text="Select..." Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
                        <asp:ListItem Text="No" Value="N"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
    </div>
    <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-9">
            <div class="form-group">
                    <span class="requiredpe2span markrequired">*</span><label class="control-label">Pallet Dimensions:</label>
                    <div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">L</span><asp:TextBox ID="txtPalletDimensionsL" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                           <span class="dimension">X</span>
                                  </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtPalletDimensionsW" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                             <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtPalletDimensionsH" Width="105" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
      <div class="col-xs-12 col-sm-6 col-md-3">
                <div class="form-group">
                  <span class="requiredpe2span markrequired">*</span>  <label class="control-label">Pallet Cube (cubic ft):</label>
                    <asp:TextBox ID="txtPalletCube" ClientIDMode="Static" Enabled="false" runat="server" CssClass="readOnly form-control requiredpe2 decimaltwoplaces"></asp:TextBox>
                </div>
            </div>
    </div>
     <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-6"> 
            <div class="form-group">
                   <span class="requiredpe2span markrequired">*</span> <label class="control-label">Pallet Weight (lbs):</label>
                    <asp:TextBox ID="txtPalletWeight" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimaltwoplaces requiredpe2"></asp:TextBox>
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
                   <span class="requiredpe2span markrequired">*</span> <label class="control-label">Pallet Gross Weight (lbs):</label>
                    <asp:TextBox ID="txtPalletGrossWeight" Enabled="false" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 decimaltwoplaces"></asp:TextBox>
             </div>
        </div>
     </div>

      <div class="row">
        <div class="col-xs-12 col-sm-6 col-md-6"> 
            <div class="form-group">
                   <span class="requiredpe2span markrequired">*</span> <label class="control-label">Cases per Layer:</label>
                    <asp:TextBox ID="txtCasesperLayer" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 numericNoMask"></asp:TextBox>
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 col-md-6">
            <div class="form-group">
                  <span class="requiredpe2span markrequired">*</span>  <label class="control-label">Layers per Pallet:</label>
                    <asp:TextBox ID="txtLayersperPallet" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control requiredpe2 numericNoMask"></asp:TextBox>
             </div>
        </div>
     </div>
    <div class="row OBMSetup palletPattern">
        <div class="col-xs-12 col-sm-6 col-md-3"> 
            <div class="form-group">
                <span id="spanPalletPatternChange" class="markrequired">*</span> <label class="control-label">Is Pallet Pattern Changing?:</label>
                <asp:DropDownList ID="drpPalletPatternChange" runat="server" CssClass="drpPalletPatternChange form-control" AppendDataBoundItems="true" onChange="palletPatternChange();" ClientIDMode="Static">
                    <asp:ListItem Text="Select..." Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
                    <asp:ListItem Text="No" Value="N"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
     </div>
    <div class="row OBMSetup palletPattern">
        <div class="col-xs-12 col-sm-6 col-md-6"> 
            <div class="form-group">
                    <label class="control-label palletUploadLbl">Pallet Pattern Upload:</label>
                    <input id="btnUploadPalletPatern" runat="server" type="button" class="ButtonControlAutoSize" value="Pallet Pattern Upload" onclick="openBasicDialog2('Upload Pallet Pattern', 'PalletPattern', this.className); return false;" />  
                <asp:HiddenField ID="hdnPalletPatterCount" ClientIDMode="Static" runat="server" />
            </div>
        </div>
     </div>

     <div class="row OBMSetup">
         <div class="col-xs-12 col-sm-6 col-md-6">
          <table width="50%">
                <asp:Repeater ID="rptPalletPattern"  ClientIDMode="Static" runat="server" >
                    <HeaderTemplate>
                        <tr>
                            <th>Action</th>
                            <th>Document Name</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:LinkButton ID="lnkPalletPatternDelete"  ClientIDMode="Static" runat="server"  Text="Delete" CommandName='<%#Eval("FileUrl") %>' OnClientClick='javascript:return confirm("Are you sure you want to delete?")' OnClick="lnkDeleteAttachment_Click" CausesValidation="false"></asp:LinkButton>
                            </td>
                            <td>
                                <a target='_blank' href='<%#Eval("FileUrl") %>'><%#Eval("DisplayFileName")%></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>

    <div id="dvSales"  runat="server">
     <div class="row FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2>Sales Dimensions</h2>
        </div>
    </div>
    <div class="row RowBottomMargin FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
     <div class="row FGItem">
        <div class="col-xs-12 col-sm-6 col-md-9">
            <div class="form-group">
                    <span class="requiredpe2span markrequired">*</span><label class="control-label">Unit Dimensions:</label>
                    <div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtSalesUnitDimensionsH" Width="100" ClientIDMode="Static" ReadOnly="true" runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>
                            </div>
                             
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtSalesUnitDimensionsw" Width="100" ClientIDMode="Static" ReadOnly="true"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>
                            </div>
                        </div>
                         <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">D</span><asp:TextBox ID="txtSalesUnitDimensionsd" Width="105" ClientIDMode="Static" ReadOnly="true"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>    
                        </div>
                    </div>
                </div>
        </div>
    </div>
      <div class="row FGItem">
        <div class="col-xs-12 col-sm-6 col-md-9">
            <div class="form-group">
                    <span class="requiredpe2span markrequired">*</span><label class="control-label">Case Dimensions:</label>
                    <div >
                         <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtSalesCaseDimensionsH" Width="100" ClientIDMode="Static" ReadOnly="true"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>  
                            </div>
                        </div>                 
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtSalesCaseDimensionsW" Width="100" ClientIDMode="Static" ReadOnly="true"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">D</span><asp:TextBox ID="txtSalesCaseDimensionsD" Width="105" ClientIDMode="Static" ReadOnly="true"  runat="server" CssClass="readOnly form-control requiredpe2 decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
        </div>
    <div id="dvDisplay" runat="server">
    <div class="row FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12">
            <h2>Display Dimensions</h2>
        </div>
    </div>
    <div class="row RowBottomMargin FGItem">
        <div class="col-xs-12 col-sm-12 col-md-12 CompassSeparator">&nbsp;</div>
    </div>
    <div class="row FGItem">
        <div class="col-xs-12 col-sm-6 col-md-9">
            <div class="form-group">
                   <label class="control-label">Display Dimensions:</label>
                    <div >
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">L</span><asp:TextBox ID="txtDisplayDimensionsL" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">W</span><asp:TextBox ID="txtDisplayDimensionsW" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6 col-md-3">
                            <div class="input-group">
                                <span class="input-group-addon">H</span><asp:TextBox ID="txtDisplayDimensionsH" Width="105" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
    <div class="row FGItem">
        <div class="col-xs-12 col-sm-6 col-md-9">
            <div class="form-group">
                <label class="control-label">Set Up Dimensions:</label>
                <div >
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="input-group">
                            <span class="input-group-addon">L</span><asp:TextBox ID="txtSetUpDimensionL" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                            <span class="dimension">X</span>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="input-group">
                            <span class="input-group-addon">W</span><asp:TextBox ID="txtSetUpDimensionW" Width="100" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                                <span class="dimension">X</span>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-3">
                        <div class="input-group">
                            <span class="input-group-addon">H</span><asp:TextBox ID="txtSetUpDimensionH" Width="105" ClientIDMode="Static"  runat="server" CssClass="readOnly form-control decimalfourplaces"></asp:TextBox><span class="input-group-addon">in.</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
       <div class="row RowBottomMargin OBMSetup">
        <div class="col-xs-12 col-sm-9 col-md-8">&nbsp;</div>
        <div class="col-xs-12 col-sm-3 col-md-1">
        </div>
        <div class="col-xs-12 col-sm-3 col-md-3">
             <asp:Button ID="btnSave" runat="server" Visible="false" OnClientClick="return validateBOMControl(this);" CssClass="NonBOMPage bomSavePage" CausesValidation="false"  OnClick="btnSave_Click" />
            <asp:HiddenField ID="hdnid" ClientIDMode="Static" runat="server" />
            <asp:HiddenField ID="hdnPackTrial" ClientIDMode="Static" runat="server" />
        </div>
    </div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        var projectType = $("#hdnProjectType").val();
    
        $(".numericNoMask").keypress(function (event) {
            // Backspace, tab, enter, end, home, left, right
            // We don't support the del key in Opera because del == . == 46.
            var controlKeys = [8, 9, 13, 35, 36, 37, 39];
            // IE doesn't support indexOf
            var isControlKey = controlKeys.join(",").match(new RegExp(event.which));
            // Some browsers just don't raise events for control keys. Easy.
            // e.g. Safari backspace.
            if (!event.which || // Control keys in most browsers. e.g. Firefox tab is 0
                (48 <= event.which && event.which <= 57) || // Always 1 through 9
                //    (48 == event.which && $(this).attr("value")) || // No 0 first digit
                (isControlKey || $(this).val().indexOf('.') != -1)) { // Opera assigns values for control keys.
                return;
            } else {
                event.preventDefault();
            }
        });
        palletPatternChange();
        dimensionsUpdate();
        OnPackTrialChange();

        /******* Following line is to disable Enter **************/
        document.onkeypress = stopRKey;
    });
    function palletPatternChange() {
        var url = window.location.href.toLocaleLowerCase();
        if (url.indexOf('bomsetuppe2.aspx') != -1) {
            $("#spanPalletPatternChange").show();
            $("#drpPalletPatternChange").addClass('PCBOMrequired');
        }
        else
            $("#spanPalletPatternChange").hide();
        $(".drpPalletPatternChange").each(function () {
            if ($(this).find("option:selected").text() == "Yes" && url.indexOf('bomsetuppe2.aspx') != -1) {
                $(this).parents(".miscOpsClass").find(".palletUploadLbl").html("<span class='markrequired'>*</span> Pallet Pattern Upload:</label>");
            } else {
                $(this).parents(".miscOpsClass").find(".palletUploadLbl").html("Pallet Pattern Upload:</label>");
            }
        });
        
    }
    function chkLength(ctrlId, lengthReq)
    {
        return checkNumberLength(ctrlId, lengthReq);
    }

    function changeRowColor(arg) {
        var anchor = $("#" + arg.id);
        anchor.addClass("hideItem");
        var dvMain = anchor.parent().parent();
        dvMain.addClass("bgcolor");
    }
    
    function NewPackagingItem()
    {
        var componentType = $("#drpPkgComponent option:selected").text();
        $("#hdnComponentType").val(componentType);
        pageLoadCheck();
    } 

    function ucBOMLoadCheck() {
        var v = $("#hdnUCSEMiBOMComponentType").val();
           // alert(v);
            if (v != null) {
                if (v.indexOf('Transfer') != -1) {
                    $('.FGItem').each(function (i, obj) {
                        $(this).addClass("hideItem");
                    });
                }
            }
    }
    
    //Following methods upload doc at project level
    function openBasicDialog2(tTitle, docType, cl) {
      //  alert('asdf:'+item);
      //  alert('h:' + $(this).attr('class'));
        var str = cl.split(" ");
        var id = str[2];
      
        var url ='';
        if(id=="0")
            url = '/_layouts/15/Ferrara.Compass/AppPages/UploadForm.aspx?PackagingItemId=0&DocType=' + docType + '&CompassItemId=' + $("#hiddenItemId").val();
        else
            url = '/_layouts/15/Ferrara.Compass/AppPages/UploadForm.aspx?PackagingItemId='+ id +'&DocType=' + docType + '&CompassItemId=' + $("#hiddenItemId").val();
        //  alert($("#hiddenItemId").val());
        
        var options = {
            url: url,
            title: tTitle,
            dialogReturnValueCallback: onPopUpCloseCallBack
        };
        SP.SOD.execute('sp.ui.dialog.js', 'SP.UI.ModalDialog.showModalDialog', options);
    }
    
</script>