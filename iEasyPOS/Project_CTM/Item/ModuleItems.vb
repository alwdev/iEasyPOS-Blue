Module ModuleItems
    Dim table As String
    Dim field As String
    Dim where As String
    Dim value As String
    Dim _cultureEnInfo As New Globalization.CultureInfo("en-US")
    Dim _cultureTHInfo As New Globalization.CultureInfo("th-TH")
    Sub ClearDetailItems()
        Item.TxtNumber.Clear()
        Item.TxtItemName1.Clear()
        Item.TxtItemName2.Clear()
        Item.TxtPrice.Clear()
        Item.CheckBoxVat.Checked = False
        Item.CheckBoxDisCount.Checked = False
        Item.CheckBoxStock.Checked = False
        Item.CheckBoxPoint.Checked = False
        Item.CheckBoxPromotion.Checked = False
        Item.CheckBoxActive.Checked = False
        Item.TxtNumber.Text = Nothing
        Item.ItemIdSend = 0
        'Load Category
        'Item.DropDownCategory.Items.Clear()
        'Item.ComboBoxCategorysearch.Items.Clear()
        'LoadCategory()
        'Load Vat 
        Item.DropDownVat.Items.Clear()
        LoadRadDropDownVat()
        'Load UnitItem
        Item.DropDownUnitItem.Items.Clear()
        LoadUnit()
        'Load POUnitItem 
        Item.DropDownPOUnit.Items.Clear()
        LoadPOUnit()
        'Load POUnitItem2
        Item.DropDownPOUnit2.Items.Clear()
        LoadPOUnit2()
        'Load Printer 
        Item.DropDownPrinter.Items.Clear()
        LoadPrinter()
        'Load Data Items 
        'Item.DGItems.Rows.Clear()
        'LoadDataItem()
        'Load Tax
        LoadRadDropDownVat()
        Item.chkIsKiosk.Checked = False
    End Sub
    Sub LoadCategory()
        'Dim DataCategory As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=CategoryId,CategoryName&table=CategoryItem&where=Active=1 AND CateGroupId = 1")
        Dim DataCategory As DataTable = executesql("SELECT CategoryId,CategoryName FROM CategoryItem WHERE Active=1 AND CateGroupId = 1 ")
        If IsNothing(DataCategory) Then
            Exit Sub
        ElseIf DataCategory.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To DataCategory.Rows.Count - 1
            Item.DropDownCategory.Items.Add(DataCategory(i)("CategoryName"))
            Item.ComboBoxCategorysearch.Items.Add(DataCategory(i)("CategoryName"))
        Next
    End Sub
    Sub LoadUnit()
        Try
            'Load Units From ItemUnit
            'Dim DataUnits As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UnitUseName&table=ItemUseUnitDefault")
            Dim DataUnits As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE Active=1 AND Multiply=1")
            For i As Integer = 0 To DataUnits.Rows.Count - 1
                Dim UnitName As String = DataUnits(i)("ItemUnitName")
                Item.DropDownUnitItem.Items.Add(UnitName)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub LoadPOUnit()
        Try
            'Load Units From ItemUnit
            'Dim DataUnits As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UnitUseName&table=ItemUseUnitDefault")
            Dim DataUnits As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE Active=1")
            For i As Integer = 0 To DataUnits.Rows.Count - 1
                Dim UnitName As String = DataUnits(i)("ItemUnitName")
                Item.DropDownPOUnit.Items.Add(UnitName)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub LoadPOUnit2()
        'Dim DataUnits2 As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&field=UnitUseName&table=ItemUseUnitDefault")
        Dim DataUnits2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE Active=1")
        For i As Integer = 0 To DataUnits2.Rows.Count - 1
            Dim UnitName As String = DataUnits2(i)("ItemUnitName")
            Item.DropDownPOUnit2.Items.Add(UnitName)
        Next
    End Sub
    Sub LoadPrinter()
        Dim i As Integer
        Dim ItemPrinter As String
        For i = 0 To System.Drawing.Printing.PrinterSettings.
          InstalledPrinters.Count - 1
            ItemPrinter = System.Drawing.Printing.PrinterSettings.
              InstalledPrinters.Item(i)
            Item.DropDownPrinter.Items.Add(ItemPrinter)
        Next
    End Sub
    Sub AddItem()
        Dim CategoryName As String = Item.DropDownCategory.Text
        Dim ItemCode As String = Item.TxtNumber.Text
        Dim ItemName1 As String = Item.TxtItemName1.Text
        Dim ItemName2 As String = Item.TxtItemName2.Text
        'Dim InsertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim InsertDate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
        InsertDate = Now.ToString("yyyy-MM-dd HH:mm:ss", _cultureEnInfo)
        Dim UserId As Integer = Frm_Login.UserId
        'Dim Price As Double = CDbl(Item.TxtPrice.Text)
        Dim CheckBoxVat As Integer
        If Item.CheckBoxVat.Checked = True Then
            CheckBoxVat = 1
        ElseIf Item.CheckBoxVat.Checked = False Then
            CheckBoxVat = 0
        End If
        Dim DropDownVat As String = Item.DropDownVat.Text
        'Select TaxId FROM Tax 
        Dim DataTaxId As DataTable = executesql("SELECT TaxId FROM Tax WHERE TaxName='" & DropDownVat & "'")
        Dim TaxValue As Decimal = 0.00
        If IsNothing(DataTaxId) Then
            Frm_Critical.head_Label.Text = "กรุณาระบุภาษี"
            Frm_Critical.TableOkCancel.Visible = False
            Frm_Critical.Show()
            Exit Sub
        ElseIf DataTaxId.Rows.Count = 0 Then
            Frm_Critical.head_Label.Text = "กรุณาระบุภาษี"
            Frm_Critical.TableOkCancel.Visible = False
            Frm_Critical.Show()
            Exit Sub
        ElseIf DataTaxId.Rows.Count > 0 Then
            TaxValue = DataTaxId(0)("TaxId")
        End If
        Dim TaxId As Integer = TaxValue
        'Unit 
        Dim Unit As String = ""
        If Item.DropDownUnitItem.Text = "" Then
        Else
            Unit = Item.DropDownUnitItem.Text
        End If
        'POUnit 
        Dim POUnit As String = ""
        If Item.DropDownPOUnit.Text = "" Then
        Else
            POUnit = Item.DropDownPOUnit.Text
        End If
        'POUnit2 
        Dim POUnit2 As String = ""
        If Item.DropDownPOUnit.Text = "" Then
        Else
            POUnit2 = Item.DropDownPOUnit.Text
        End If
        'PrintName 
        Dim PrinterName As String = ""
        If Item.DropDownPrinter.Text = "" Then
        Else
            PrinterName = Item.DropDownPrinter.Text
        End If
        'Price
        Dim Price As Decimal = 0.00
        If Item.TxtPrice.Text = "" Then
        Else
            Price = Item.TxtPrice.Text
        End If
        Dim DisCount As Integer
        Dim Stock As Integer
        Dim Point As Integer
        Dim Promotion As Integer
        Dim ActiveStatusItem As Integer
        'Dim Active As Integer
        Dim BtnBackGround As Integer = -4473925
        Dim ForeColor As Integer = -1
        If CategoryName = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอก หมวดหมู่"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        If ItemCode = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอก Item Number"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        If ItemName1 = "" Or ItemName2 = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอกชื่อสินค้า"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'If Price = 0.00 Then
        '    Frm_Critical.head_Label.Text = "กรุณากรอก ราคา สินค้า"
        '    Frm_Critical.TableOkCancel.Visible = False
        '    Exit Sub
        'End If
        If Unit = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกหน่วยสินค้า"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        If POUnit = "" Then
            MsgBox("กรุณาเลือกนหน่วยสินค้า PO", MsgBoxStyle.Information, "")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากรอก หมวดหมู่"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        If POUnit2 = "" Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกนหน่วยสินค้า PO2"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'If PrinterName = "" Then
        '    Frm_Critical.Show()
        '    Frm_Critical.head_Label.Text = "กรุณาเลือก Printer"
        '    Frm_Critical.TableOkCancel.Visible = False
        '    Exit Sub
        'End If
        If Item.CheckBoxDisCount.Checked = False Then
            DisCount = 0
        ElseIf Item.CheckBoxDisCount.Checked = True Then
            DisCount = 1
        End If
        If Item.CheckBoxStock.Checked = False Then
            Stock = 0
        ElseIf Item.CheckBoxStock.Checked = True Then
            Stock = 1
        End If
        If Item.CheckBoxPoint.Checked = False Then
            Point = 0
        ElseIf Item.CheckBoxPoint.Checked = True Then
            Point = 1
        End If
        If Item.CheckBoxPromotion.Checked = False Then
            Promotion = 0
        ElseIf Item.CheckBoxPromotion.Checked = True Then
            Promotion = 1
        End If
        If Item.CheckBoxActive.Checked = False Then
            ActiveStatusItem = 0
        ElseIf Item.CheckBoxActive.Checked = True Then
            ActiveStatusItem = 1
        End If
        Dim IsKiosk As Integer
        If Item.chkIsKiosk.Checked = False Then
            IsKiosk = 0
        Else
            IsKiosk = 1
        End If
        'Select cateid
        Dim DataCateId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & CategoryName & "' AND Active =1")
        'Select UnitId 
        Dim DataUnitId As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & Unit & "' AND Active=1")
        'Select POUnit 
        Dim DataPOUnit As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & POUnit & "' AND Active=1 ")
        'Select POUnti2
        Dim DataPOUnit2 As DataTable = executesql("SELECT ItemUnitId FROM ItemUnit WHERE ItemUnitName='" & POUnit2 & "' AND Active=1")
        'Insert Into Items
        If Item.ItemIdSend = 0 Then

            executesql("INSERT INTO Item(ItemCode,ItemName,ItemName2,CategoryId,Active,InsertDate,UserId,USUnitId,POUnitId,POUnitId2,IsTrackStock,AllowRedeemPoint,IsPromotion,PrinterName,AllowDC,IsVatChecked,TaxId,ButtonColor,FontColor,ItemPrice,IsActive,ItemKiOsk) VALUES('" & ItemCode & "','" & ItemName1 & "','" & ItemName2 & "','" & DataCateId(0)("CategoryId") & "',1,'" & InsertDate & "','" & UserId & "','" & DataUnitId(0)("ItemUnitId") & "','" & DataPOUnit(0)("ItemUnitId") & "','" & DataPOUnit2(0)("ItemUnitId") & "','" & Stock & "','" & Point & "','" & Promotion & "','" & PrinterName & "','" & DisCount & "','" & CheckBoxVat & "','" & TaxId & "','" & BtnBackGround & "','" & ForeColor & "','" & Price & "','" & ActiveStatusItem & "','" & IsKiosk & "')")
            ClearDetailItems()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "เพิ่มข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
        Else
            executesql("Update Item Set ItemCode='" & ItemCode & "',ItemName='" & Item.TxtItemName1.Text & "',ItemName2='" & ItemName2 & "',CategoryId='" & DataCateId(0)("CategoryId") & "',UpdateDate='" & InsertDate & "',UserId='" & UserId & "',USUnitId='" & DataUnitId(0)("ItemUnitId") & "',POUnitId='" & DataPOUnit(0)("ItemUnitId") & "',POUnitId2='" & DataPOUnit2(0)("ItemUnitId") & "',IsTrackStock='" & Stock & "',AllowRedeemPoint='" & Point & "',IsPromotion='" & Promotion & "',PrinterName='" & PrinterName & "',AllowDC='" & DisCount & "',IsVatChecked='" & CheckBoxVat & "',TaxId='" & TaxId & "',ButtonColor='" & BtnBackGround & "',FontColor='" & ForeColor & "',ItemPrice='" & Price & "',IsActive='" & ActiveStatusItem & "',ItemKiOsk='" & IsKiosk & "'  WHERE ItemId='" & Item.ItemIdSend & "'")
            ClearDetailItems()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "เเก้ไขข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
        End If
    End Sub
    Sub LoadDataItem()
        'Select Data Item

        Dim DataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CateGroupId='1' AND CategoryItem.Active=1  ORDER BY ItemCode ASC")
        If IsNothing(DataItem) Then
            Exit Sub
        ElseIf DataItem.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        Dim RowsDataItem As Integer = DataItem.Rows.Count
        For i = 0 To RowsDataItem - 1
            Dim Qty As Decimal
            If DataItem(i)("IsTrackStock") = 0 Then
                Qty = 0
            ElseIf IsDBNull(DataItem(i)("QTY")) Then
                Qty = 0
            Else
                Qty = DataItem(i)("QTY")
            End If
            Item.DGItems.Rows.Add(DataItem(i)("Itemid"), DataItem(i)("ItemCode"), DataItem(i)("ItemName"), FormatNumber(DataItem(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
        Next
    End Sub
    Sub LoaddataDetailItem()
        Try
            Item.PictureBoxItemShow.BackgroundImage = Nothing
            Dim ItemId As Integer = Item.ItemIdSend

            Dim DataDetail As DataTable = executesql("SELECT itemid,Item.ItemCode, Item.ItemName, Item.ItemName2,Item.ItemPrice, Item.CategoryId, Item.USUnitId, Item.POUnitId,Item.POUnitId2, Item.IsTrackStock, Item.AllowRedeemPoint, Item.AllowDC, Item.IsVatChecked, Item.PrinterName, Item.IsPromotion, Item.TaxId,Item.IsActive,CategoryItem.CateGroupId,Item.ItemKiOsk FROM  Item INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId where CateGroupId = 1 AND ItemId='" & ItemId & "' AND Item.Active=1")

            Dim CateName As DataTable = executesql("SELECT CategoryName FROM CategoryItem WHERE CategoryId='" & DataDetail(0)("CategoryId") & "'")

            Dim UsUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataDetail(0)("USUnitId") & "'")

            Dim POUnitName As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataDetail(0)("POUnitId") & "'")

            Dim POUnitName2 As DataTable = executesql("SELECT ItemUnitName FROM ItemUnit WHERE ItemUnitId='" & DataDetail(0)("POUnitId") & "'")

            Dim DataColorImage As DataTable = executesql("SELECT ImageText,ButtonColor,FontColor FROM Item WHERE ItemId='" & ItemId & "'")

            Dim DataTaxName As DataTable = executesql("SELECT TaxName FROM Tax WHERE TaxId ='" & DataDetail(0)("TaxId") & "'")
            'Check Image And Color 
            If IsDBNull(DataColorImage(0)("ImageText")) Then
                Item.RadColorButton.Value = Color.FromArgb(DataColorImage(0)("ButtonColor"))
                Item.RadColorFont.Value = Color.FromArgb(DataColorImage(0)("FontColor"))
            ElseIf DataColorImage(0)("ImageText") = "" Then
                Item.RadColorButton.Value = Color.FromArgb(DataColorImage(0)("ButtonColor"))
                Item.RadColorFont.Value = Color.FromArgb(DataColorImage(0)("FontColor"))
            Else
                'Convert Base64String To Image 
                Dim img As System.Drawing.Image
                Dim Ms As System.IO.MemoryStream = New System.IO.MemoryStream
                Dim b() As Byte
                'Convert Base64 encoded msg To Image Data 
                b = Convert.FromBase64String(DataColorImage(0)("ImageText"))
                Ms = New System.IO.MemoryStream(b)
                'Create Image 
                img = System.Drawing.Image.FromStream(Ms)
                Item.PictureBoxItemShow.BackgroundImage = img
                Item.PictureBoxItemShow.BackgroundImageLayout = ImageLayout.Stretch
                Item.RadColorButton.Value = Color.FromArgb(DataColorImage(0)("ButtonColor"))
                Item.RadColorFont.Value = Color.FromArgb(DataColorImage(0)("FontColor"))
            End If
            Item.TxtItemId.Text = DataDetail(0)("itemid")
            If CateName.Rows.Count = 0 Then
                Item.DropDownCategory.Text = ""
            Else Item.DropDownCategory.Text = CateName(0)("CategoryName")
            End If

            If DataDetail.Rows.Count = 0 Then
                Item.TxtNumber.Text = ""
            Else Item.TxtNumber.Text = DataDetail(0)("ItemCode")
            End If

            If DataDetail.Rows.Count = 0 Then
                Item.TxtItemName1.Text = ""
            Else Item.TxtItemName1.Text = DataDetail(0)("ItemName")
            End If

            If DataDetail.Rows.Count = 0 Then
                Item.TxtItemName2.Text = ""
            Else Item.TxtItemName2.Text = DataDetail(0)("ItemName2")
            End If

            If DataDetail.Rows.Count = 0 Then
                Item.TxtPrice.Text = "0.00"
            Else Item.TxtPrice.Text = FormatNumber(DataDetail(0)("ItemPrice"), 2)
            End If

            If UsUnitName.Rows.Count = 0 Then
                Item.DropDownUnitItem.Text = ""
            Else Item.DropDownUnitItem.Text = UsUnitName(0)("ItemUnitName")
            End If

            If POUnitName.Rows.Count = 0 Then
                Item.DropDownPOUnit.Text = ""
            Else Item.DropDownPOUnit.Text = POUnitName(0)("ItemUnitName")
            End If
            If POUnitName2.Rows.Count = 0 Then
                Item.DropDownPOUnit2.Text = ""
            Else Item.DropDownPOUnit2.Text = POUnitName2(0)("ItemUnitName")
            End If

            If DataDetail.Rows.Count = 0 Then
                Item.DropDownPrinter.Text = ""
            Else Item.DropDownPrinter.Text = DataDetail(0)("PrinterName")
            End If
            If DataTaxName.Rows.Count = 0 Then
                Item.DropDownVat.Text = ""
            Else Item.DropDownVat.Text = DataTaxName(0)("TaxName")
            End If

            'CheckBox AllowDC
            If DataDetail(0)("AllowDC") = 0 Then
                Item.CheckBoxDisCount.Checked = False
            ElseIf DataDetail(0)("AllowDC") = 1 Then
                Item.CheckBoxDisCount.Checked = True
            End If

            'CheckBox Stock
            If DataDetail(0)("IsTrackStock") = 0 Then
                Item.CheckBoxStock.Checked = False
            ElseIf DataDetail(0)("IsTrackStock") = 1 Then
                Item.CheckBoxStock.Checked = True
            End If

            'CheckBox Point 
            If DataDetail(0)("AllowRedeemPoint") = 0 Then
                Item.CheckBoxPoint.Checked = False
            ElseIf DataDetail(0)("AllowRedeemPoint") = 1 Then
                Item.CheckBoxPoint.Checked = True
            ElseIf DataDetail(0)("AllowRedeemPoint") = 0 Then
                Item.CheckBoxPoint.Checked = False
            End If

            'CheckBox Promotion 
            If DataDetail(0)("IsPromotion") = 0 Then
                Item.CheckBoxPromotion.Checked = False
            ElseIf DataDetail(0)("IsPromotion") = 1 Then
                Item.CheckBoxPromotion.Checked = True
            End If

            'CheckBoxVat 
            If DataDetail(0)("IsVatChecked") = 0 Then
                Item.CheckBoxVat.Checked = False
            ElseIf DataDetail(0)("IsVatChecked") = 1 Then
                Item.CheckBoxVat.Checked = True
            End If

            'Check ItemActive 
            If DataDetail(0)("IsActive") = 0 Then
                Item.CheckBoxActive.Checked = False
            ElseIf DataDetail(0)("IsActive") = 1 Then
                Item.CheckBoxActive.Checked = True
            End If

            'KiOsk
            If DataDetail(0)("ItemKiOsk") = 0 Then
                Item.chkIsKiosk.Checked = False
            Else
                Item.chkIsKiosk.Checked = True
            End If

            'Load Data CategorySelection
            LoadCategorySelection()
            'LoadSelectionItemCombo()
        Catch ex As Exception

        End Try

    End Sub
    Sub SaveImageAndColorButtonItems()
        Dim ItemId As Integer = Item.ItemIdSend
        Dim BtnColor As Integer = Item.RadColorButton.Value.ToArgb
        Dim FontColor As Integer = Item.RadColorFont.Value.ToArgb
        'Set Default ButtonColor And FontColor 
        If BtnColor = Nothing Then
            BtnColor = -4473925
        End If
        If FontColor = Nothing Then
            FontColor = -16777216
        End If
        Dim ImageBase64String As String
        'Check Id Null
        If Item.ItemIdSend = Nothing Then
            MsgBox("กรุณาเลือกเมนูก่อน", MsgBoxStyle.Information, "")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณาเลือกสินค้าก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        If Item.RadBrowserImage.Value = "" Then
            executesql("UPDATE Item SET ButtonColor='" & BtnColor & "',FontColor='" & FontColor & "' WHERE ItemId='" & ItemId & "'")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
        ElseIf Item.ImageBase64String IsNot Nothing Then
            ImageBase64String = Item.ImageBase64String
            'Update Image
            'Set Default ButtonColor And FontColor 
            If BtnColor = Nothing Then
                BtnColor = -4473925
            End If
            If FontColor = Nothing Then
                FontColor = -16777216
            End If
            executesql("UPDATE Item SET ImageText='" & ImageBase64String & "',ButtonColor='" & BtnColor & "',FontColor='" & FontColor & "' WHERE ItemId='" & ItemId & "'")
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "บันทึกข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
        End If
    End Sub
    Sub SearchItems()
        Item.DGItems.Rows.Clear()
        Dim WordSearch As String = Item.TxtSerachItem.Text
        Dim CategoryName As String = Item.ComboBoxCategorysearch.Text
        Dim CateId As Integer
        'No CateName Search From All
        If CategoryName <> Nothing Then
            If CategoryName = "ทั้งหมด" Then
                'Search Item No CategoryName
                'Dim DataSearchAll As DataTable = executesql("SELECT ItemId,Item.ItemCode, Item.ItemName, Item.ItemName2,Item.ItemPrice FROM  Item INNER JOIN CategoryItem ON Item.CategoryId = CategoryItem.CategoryId where CateGroupId = 1 and Item.Active=1 ORDER BY Item.ItemCode ASC")

                Dim DataItem As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CateGroupId='1' AND CategoryItem.Active=1  ORDER BY ItemCode ASC")
                'Dim RowsDataSearchAll As Integer = DataSearchAll.Rows.Count
                Dim RowsDataItem As Integer = DataItem.Rows.Count
                For a As Integer = 0 To RowsDataItem - 1
                    Dim Qty As Decimal
                    If DataItem(a)("IsTrackStock") = 0 Then
                        Qty = 0
                    ElseIf IsDBNull(DataItem(a)("QTY")) Then
                        Qty = 0
                    Else
                        Qty = DataItem(a)("QTY")
                    End If
                    Item.DGItems.Rows.Add(DataItem(a)("Itemid"), DataItem(a)("ItemCode"), DataItem(a)("ItemName"), FormatNumber(DataItem(a)("ItemPrice"), 2), FormatNumber(Qty, 2))
                Next
                Exit Sub
            Else
                'Select CateID
                Dim DataCateId As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName='" & CategoryName & "'")
                CateId = DataCateId(0)("CategoryId")
            End If
        End If
        'No word And Search From Category
        If WordSearch = Nothing And CategoryName <> Nothing Then
            'No WordSearch 
            Dim DataCateIdNoWord As DataTable = executesql("SELECT CategoryId FROM CategoryItem WHERE CategoryName ='" & CategoryName & "'")
            Dim CateIdNoWord As Integer = DataCateIdNoWord(0)("CategoryId")
            'Dim DataNoWord As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ItemPrice FROM Item WHERE CategoryId='" & CateIdNoWord & "' and Active=1 ORDER BY ItemCode ASC")
            Dim DataNoWord As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CategoryId='" & CateIdNoWord & "'  ORDER BY ItemCode ASC")
            Dim RowsDataItems As Integer = DataNoWord.Rows.Count
            Dim j As Integer
            For j = 0 To RowsDataItems - 1

                Dim Qty As Decimal

                If DataNoWord(j)("IsTrackStock") = 0 Then
                    Qty = 0
                ElseIf IsDBNull(DataNoWord(j)("QTY")) Then
                    Qty = 0
                Else
                    Qty = DataNoWord(j)("Qty")
                End If
                Item.DGItems.Rows.Add(DataNoWord(j)("Itemid"), DataNoWord(j)("ItemCode"), DataNoWord(j)("ItemName"), FormatNumber(DataNoWord(j)("ItemPrice"), 2), FormatNumber(Qty, 2))

            Next
            Exit Sub
        End If
        'Search Item From categoryname 
        'Dim DataSearch As DataTable = executesql("SELECT ItemId,ItemCode,ItemName,ItemName2,ItemPrice FROM Item WHERE ItemName LIKE '%" & WordSearch & "%' AND CategoryId='" & CateId & "' and Active=1 ORDER BY ItemCode ASC")
        Dim DataSearch As DataTable = executesql("SELECT Item.ItemId,Item.ItemCode,Item.ItemName,Item.ItemPrice,CategoryItem.CategoryName,IsTrackStock,(Select QTY From UnitInStock where Item.ItemCode = UnitInStock.ItemCode ) AS QTY FROM Item INNER JOIN CategoryItem ON CategoryItem.CategoryId = Item.CategoryId WHERE Item.Active='1' AND CategoryItem.CategoryId='" & CateId & "' AND Item.ItemName LIKE '%" & WordSearch & "%' ORDER BY ItemCode ASC")
        Dim RowsDataSearch As Integer = DataSearch.Rows.Count
        Dim i As Integer
        For i = 0 To RowsDataSearch - 1

            Dim Qty As Decimal

            If DataSearch(i)("IsTrackStock") = 0 Then
                Qty = 0
            ElseIf IsDBNull(DataSearch(i)("QTY")) Then
                Qty = 0
            Else
                Qty = DataSearch(i)("Qty")
            End If
            'Item.DGItems.Rows.Add(ItemId, ItemCode, ItemName, FormatNumber(DataSearch(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
            Item.DGItems.Rows.Add(DataSearch(i)("Itemid"), DataSearch(i)("ItemCode"), DataSearch(i)("ItemName"), FormatNumber(DataSearch(i)("ItemPrice"), 2), FormatNumber(Qty, 2))
        Next
    End Sub

    Public Function SaveMaterialItem()
        If Item.ItemIdSend = 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากดเลือกสินค้าก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Return "NotInsert"
            Exit Function
        End If
        'Insert Into Receipe
        Dim MatId As Integer = FrmAddMaterialToItem.TxtMatid.Text
        Dim ItemCode As String = Item.TxtNumber.Text
        Dim ItemId As Integer = Item.ItemIdSend
        Dim UseUnitName As String = FrmAddMaterialToItem.ComboBoxUnitUseMaterial.Text
        'Select UseUnit In receipe 
        Dim DataUseUnit As DataTable = executesql("Select Multiply From ItemUnit Where ItemUnitName='" & UseUnitName & "'")
        Dim Multiply As Decimal = DataUseUnit(0)("Multiply")
        Dim Qty As Decimal = FormatNumber(CDbl(FrmAddMaterialToItem.TxtTakeAmount.Text) * Multiply, 2)
        Dim MatInitCost As Decimal = FrmAddMaterialToItem.TxtInitCost.Text
        Dim MatUnitCost As Decimal = FrmAddMaterialToItem.TxtUnitCost.Text
        Dim TotalInitCost As Decimal = FormatNumber(Qty * MatInitCost, 2)
        Dim TotalCost As Decimal = FormatNumber(Qty * MatUnitCost, 2)
        'Check Receipe
        Dim CheckMatInReceipe As DataTable = executesql("SELECT Id FROM Receipe WHERE ItemId='" & ItemId & "' AND MatId='" & MatId & "'")
        'MsgBox(CheckMatInReceipe.Rows.Count)
        Dim RowsCheckMatInReceipe As Integer = CheckMatInReceipe.Rows.Count
        If RowsCheckMatInReceipe > 0 Then
            Return "NotInsert"
            Exit Function
        ElseIf RowsCheckMatInReceipe = 0 Then
            'Receipe
            table = "Receipe"
            field = "ItemId,MatId,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost"
            value = "'" & ItemId & "','" & MatId & "','" & Qty & "','" & MatInitCost & "','" & MatUnitCost & "','" & TotalInitCost & "','" & TotalCost & "'"
            executesql("INSERT INTO Receipe(ItemId,MatId,Qty,MatInitCost,MatUnitCost,TotalInitCost,TotalCost) VALUES('" & ItemId & "','" & MatId & "','" & Qty & "','" & MatInitCost & "','" & MatUnitCost & "','" & TotalInitCost & "','" & TotalCost & "')")
            Return "Insert"
            Exit Function
        End If
    End Function
    Sub LoadRadDropDownVat()
        'Select Vat From Table Tax
        Item.DropDownVat.Items.Clear()
        Dim DataTax As DataTable = executesql("SELECT TaxName FROM Tax")
        If IsDBNull(DataTax) Then
            Exit Sub
        End If
        Dim RowsDataTax As Integer = DataTax.Rows.Count
        For i = 0 To RowsDataTax - 1
            Item.DropDownVat.Items.Add(DataTax(i)("TaxName"))
        Next
    End Sub

    'LoadCategorySelection 
    Sub LoadCategorySelection()
        Item.DgCateSelection.Rows.Clear()
        Dim ItemId As Integer = Item.TxtItemId.Text
        If ItemId = 0 Then
            Exit Sub
        End If
        Dim LoadDataCateslection As DataTable = executesql("SELECT CateSelectionId FROM ItemSelection WHERE Itemid='" & ItemId & "'")
        Dim RowsLoadDataCateSelection As Integer = LoadDataCateslection.Rows.Count
        If RowsLoadDataCateSelection = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To RowsLoadDataCateSelection - 1
            Dim CateSlcId As Integer = LoadDataCateslection(i)("CateSelectionId")
            Dim DataCateSlcName As DataTable = executesql("SELECT CategorySelectionName FROM CategorySelection WHERE CategorySelectionId='" & CateSlcId & "'")
            Dim CateSlcName As String = DataCateSlcName(0)("CategorySelectionName")
            Item.DgCateSelection.Rows.Add(CateSlcId, CateSlcName)
        Next
    End Sub
    'Delete Item
    Sub Delete_Item()
        Dim userId As Integer = Frm_Login.UserId
        Dim ItemId As Integer = Item.ItemIdSend

        If ItemId = 0 Then
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "กรุณากดเลือกสินค้าก่อน"
            Frm_Critical.TableOkCancel.Visible = False
            Exit Sub
        End If
        'Frm_Critical.Show()
        'Frm_Critical.head_Label.Text = "ต้องการลบรายการนี้หรือไม่"
        'Frm_Critical.TableOkCancel.Visible = True
        'Frm_Critical.Accep_Button.Visible = False
        Dim Answer As Integer = MsgBox("แน่ใจว่าต้องการลบข้อมูล", vbOKCancel, "")
        If Answer = vbOK Then
            executesql("UPDATE Item SET Active='0',DeleteDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',DeleteUserId='" & userId & "' WHERE ItemId='" & ItemId & "'")
            ClearDetailItems()
            Frm_Critical.Show()
            Frm_Critical.head_Label.Text = "ลบข้อมูลเรียบร้อย"
            Frm_Critical.Panel1.BackColor = Color.ForestGreen
            Frm_Critical.TableOkCancel.Visible = False
            ItemId = 0
        End If
    End Sub
    Sub LoadMaterialInReceipe()
        'Load Material
        Dim ItemId As Integer = Item.ItemIdSend
        If ItemId = 0 Then
            Exit Sub
        End If
        Item.DataGridViewMaterial.Rows.Clear()
        table = "Receipe"
        field = "MatId,Qty,TotalCost"
        where = "ItemId='" & ItemId & "'"
        Dim DataMaterial As DataTable = executesql("SELECT MatId,Qty,TotalCost FROM Receipe WHERE ItemId='" & ItemId & "'")
        Dim RowsDatamaterial As Integer = DataMaterial.Rows.Count
        If RowsDatamaterial = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To RowsDatamaterial - 1
            Dim MatId As String = DataMaterial(i)("MatId")
            Dim DataMatName As DataTable = executesql("SELECT ItemName,UsUnitId FROM Item WHERE ItemId='" & MatId & "'")
            Dim UseQty As Decimal = DataMaterial(i)("Qty")
            Dim DataUnitName As DataTable = executesql("SELECT UnitUseId,ItemUnitName,Multiply FROM ItemUnit WHERE ItemUnitId='" & DataMatName(0)("UsUnitId") & "'")
            Dim SumCostUnit As Decimal = FormatNumber(DataMaterial(i)("TotalCost"), 2)
            'Select Unit From UnitDefault
            Dim DataUnitDefault As DataTable = executesql("Select UnitUsename,Multiply From ItemUseUnitDefault Where UnitUseId='" & DataUnitName(0)("UnitUseId") & "'")

            'MsgBox(DataUnitName(0)("UnitUseId"))
            Item.DataGridViewMaterial.Rows.Add(DataMatName(0)("ItemName"), UseQty, 0, DataUnitName(0)("ItemUnitName"), "X หน่วยใช้", SumCostUnit, MatId)
        Next
    End Sub
    Sub CalCostMaterial()
        Item.TxtCost.Text = "0.00"
        Dim Costing As Decimal
        Dim RowsDgMaterial As Integer = Item.DataGridViewMaterial.Rows.Count
        If RowsDgMaterial = 0 Then
        Else
            Dim i As Integer
            For i = 0 To RowsDgMaterial - 1
                Costing += Item.DataGridViewMaterial.Rows(i).Cells(5).Value
            Next
            Item.TxtCost.Text = FormatNumber(Costing, 2).ToString
        End If
    End Sub
End Module
