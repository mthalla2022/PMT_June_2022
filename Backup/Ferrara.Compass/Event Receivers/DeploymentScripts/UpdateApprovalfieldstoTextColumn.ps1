Add-PSSnapin microsoft.sharepoint.powershell -ErrorAction SilentlyContinue  

[System.reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint")

$web = Get-SPWeb -identity "http://sjptn-spdev02/sites/CFTS/"  
$lib = $web.Lists["Compass Approval List"] 
$items = $lib.Items
write-host $items.Count -foregroundcolor blue

#for ($i = 1; $i -lt 2; $i++)
foreach ($item in $Items) 
{ 
#$item = $items[$i]
    $user = $item["IPF SubmittedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["IPF SubmittedBy Text"]  = $userObj.User.Name    
    
    $user = $item["IPF SavedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["IPF SavedBy Text"]  = $userObj.User.Name
    
    $user = $item["IPF ApprovedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["IPF ApprovedBy Text"]  = $userObj.User.Name

    $user = $item["SIR SAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["SIR SAP ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["OPS MFG ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["OPS MFG ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["OPS DIST ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["OPS DIST ModifiedBy Text"]  = $userObj.User.Name

    $user = $item["OPS RT ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["OPS RT ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["OPS CAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["OPS CAP ModifiedBy Text"]  = $userObj.User.Name
    
    
    $user = $item["QA QA ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["QA QA ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["QA RND ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["QA RND ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["QA PRC ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["QA PRC ModifiedBy Text"]  = $userObj.User.Name
    
    
    $user = $item["PE PE ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["PE PE ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["PE BM ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["PE BM ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["PE PRC ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["PE PRC ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["CMF CM ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["CMF CM ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["TBD SAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["TBD SAP ModifiedBy Text"]  = $userObj.User.Name
    
    
    
    $user = $item["ICF CC ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["ICF CC ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["ICF CST ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["ICF CST ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["ICF SLT ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["ICF SLT ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["IRF SAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["IRF SAP ModifiedBy Text"]  = $userObj.User.Name
    
    
    
    $user = $item["MN PE ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["MN PE ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["MN PUR ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["MN PUR ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["MN PE2 ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["MN PE2 ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["MN BM ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["MN BM ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["MN SAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["MN SAP ModifiedBy Text"]  = $userObj.User.Name
    
    
    $user = $item["RGF OBM ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["RGF OBM ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["RGF GR ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["RGF GR ModifiedBy Text"]  = $userObj.User.Name
    
    
    $user = $item["SIS SAP ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["SIS SAP ModifiedBy Text"]  = $userObj.User.Name
    
    ##
    
    $user = $item["FCF BM ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["FCF BM ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["FCF CC ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["FCF CC ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["FCF CST ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["FCF CST ModifiedBy Text"]  = $userObj.User.Name
    
    $user = $item["FCF SLT ModifiedBy"]
    $userObj = New-Object Microsoft.SharePoint.SPFieldUserValue($web, $user)   
    $item["FCF SLT ModifiedBy Text"]  = $userObj.User.Name
       
    
    $item.update()
    
    write-host "Updated - " $item.Id -foregroundcolor blue
    
    #$accountName.substring($accountName.IndexOf("\")+1) 
}

 write-host "All items Updated"  -foregroundcolor blue