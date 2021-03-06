Module ModuleTopping
    Sub loadCategoryTopping()
        Dim selectCategoryTopping As DataTable = executesql("SELECT CategoryToppingId,CategoryToppingName,CategoryToppingName2 FROM CategoryTopping")
        FrmToppings.ComboBox1.Items.Clear()
        FrmToppings.RadDropDownListCateToppingSearch.Properties.Items.Clear()
        If IsNothing(selectCategoryTopping) Then
            Exit Sub
        ElseIf selectCategoryTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectCategoryTopping.Rows.Count - 1
            FrmToppings.ComboBox1.Items.Add(selectCategoryTopping(i)("CategoryToppingName"))
            FrmToppings.RadDropDownListCateToppingSearch.Properties.Items.Add(selectCategoryTopping(i)("CategoryToppingName"))
        Next
        FrmToppings.txtToppingCode.Clear()
    End Sub
    Sub getToppingCode()
        Dim selecCateCode As DataTable = executesql("SELECT CateToppingCode,NumberToppingCode FROM CategoryTopping WHERE CategoryToppingName ='" & FrmToppings.ComboBox1.Text & "'")
        Dim selectCountToppingCode As DataTable = executesql("SELECT COUNT(ToppingId) AS CountTopping FROM Topping")
        Dim numItemCount As Integer = selectCountToppingCode(0)("CountTopping") + 1
        FrmToppings.txtToppingCode.Text = selecCateCode(0)("CateToppingCode") & numItemCount.ToString("D" & selecCateCode(0)("NumberToppingCode"))
    End Sub
    Sub showData()
        Dim selectData As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId) WHERE Topping.ToppingId='" & FrmToppings.toppingIds & "'")
        FrmToppings.txtToppingCode.Text = selectData(0)("ToppingCode")
        FrmToppings.txtNameTopping.Text = selectData(0)("ToppingName")
        FrmToppings.txtToppingNameEN.Text = selectData(0)("ToppingName2")
        FrmToppings.txtToppingCosting.Text = selectData(0)("Costing")
        FrmToppings.txtPricing.Text = selectData(0)("Pricing")
        FrmToppings.ComboBox1.Text = selectData(0)("CategoryToppingName")
        'FrmToppings.RadDropDownListCateTopping.Items.Clear()
        'loadCategoryTopping()
    End Sub
    Sub loadData()
        FrmToppings.DataGridViewToppingList.Rows.Clear()
        Dim selectTopping As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)")
        If IsNothing(selectTopping) Then
            Exit Sub
        ElseIf selectTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        For i As Integer = 0 To selectTopping.Rows.Count - 1
            FrmToppings.DataGridViewToppingList.Rows.Add(selectTopping(i)("ToppingId"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("ToppingName"), selectTopping(i)("ToppingCode"))
            'Item.DataGridViewShowToppingList.Rows.Add(selectTopping(i)("CateToppingCode"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("CategoryToppingId"))
        Next
        Item.ComboBoxToppingList.Properties.Items.Clear()
        Dim selectCateTopping As DataTable = executesql("SELECT * FROM CategoryTopping")
        If IsNothing(selectCateTopping) Then
            Exit Sub
        ElseIf selectCateTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        For Each tp As DataRow In selectCateTopping.Rows
            Item.ComboBoxToppingList.Properties.Items.Add(tp("CategoryToppingName"))
        Next

        'Item.ComboBoxTopping.DisplayMember = "CategoryToppingName"
    End Sub
    Sub addToppingToDatagrid(itoppings As iTopping)
        'If Item.DataGridView1.Rows.Count = 0 Then
        '    Item.DataGridView1.Rows.Add(itoppings.id, itoppings.code, itoppings.name)
        'Else
        '    Dim ch As Boolean = False
        '    For i As Integer = 0 To Item.DataGridView1.Rows.Count - 1
        '        If itoppings.id = Item.DataGridView1.Rows(i).Cells(0).Value Then
        '            ch = True
        '            Exit For
        '        End If
        '    Next
        '    If ch = False Then
        '        Item.DataGridView1.Rows.Add(itoppings.id, itoppings.code, itoppings.name)
        '    End If
        'End If


        If Item.ItemIdSend = 0 Then
            MsgBox("กรุณาเลือกรายการสินค้า", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If itoppings.id = 0 Then
            MsgBox("กรุณาเลือก Topping", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim ItemTopping As DataTable = executesql("SELECT * FROM ItemTopping WHERE ItemId='" & Item.ItemIdSend & "' AND CategoryToppingId = '" & Item.toppingId & "' AND Active='1'")

            If ItemTopping.Rows.Count > 0 Then
                Exit Sub
            Else
                executesql("INSERT INTO ItemTopping(ItemId,CategoryToppingId,Active) VALUES('" & Item.ItemIdSend & "','" & itoppings.id & "','1')")
                ShowItemTopping()

            End If

        End If
    End Sub
    Sub btnSave()
        Dim ToppingCode As String = FrmToppings.txtToppingCode.Text
        Dim ToppingName As String = FrmToppings.txtNameTopping.Text
        Dim ToppingNameEN As String = FrmToppings.txtToppingNameEN.Text
        'Dim ToppingCosting As String = FrmToppings.txtToppingCosting.Text
        Dim ToppingCosting As String = "0"
        Dim ToppingPricing As String = FrmToppings.txtPricing.Text
        Dim CategoryTopping As String = FrmToppings.ComboBox1.Text
        If ToppingCode = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ToppingName = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If ToppingNameEN = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'If ToppingCosting = "" Then
        '    MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If ToppingPricing = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If CategoryTopping = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Dim selectToppings As DataTable = executesql("SELECT * FROM Topping WHERE ToppingCode='" & ToppingCode & "'")
        'If selectToppings.Rows.Count > 0 Then
        '    MsgBox("รหัส Topping ซ้ำ !!", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Dim selecToppingCategoryId As DataTable = executesql("SELECT CategoryToppingId FROM CategoryTopping WHERE CategoryToppingName='" & CategoryTopping & "'")
        Dim insertDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm", New System.Globalization.CultureInfo("en-US"))
        Dim userId As Integer = Frm_Login.UserId
        If FrmToppings.toppingIds = 0 Then
            executesql("INSERT INTO Topping(CategoryToppingId,ToppingName,ToppingName2,ToppingCode,Costing,Pricing,InsertDate,UserId) VALUES ('" & selecToppingCategoryId(0)("CategoryToppingId") & "','" & ToppingName & "','" & ToppingNameEN & "','" & ToppingCode & "','" & ToppingCosting & "','" & ToppingPricing & "','" & insertDate & "','" & userId & "')")
        Else
            executesql("UPDATE Topping SET CategoryToppingId='" & selecToppingCategoryId(0)("CategoryToppingId") & "',ToppingName='" & ToppingName & "',ToppingName2='" & ToppingNameEN & "',ToppingCode='" & ToppingCode & "',Costing='" & ToppingCosting & "',Pricing='" & ToppingPricing & "',UpdateDate='" & insertDate & "',UserId='" & userId & "' WHERE ToppingId='" & FrmToppings.toppingIds & "'")
        End If
        FrmToppings.DataGridViewToppingList.Rows.Clear()
        'loadData()
        clearData()
    End Sub
    Sub clearData()
        FrmToppings.toppingIds = 0
        FrmToppings.txtToppingCode.Clear()
        FrmToppings.txtNameTopping.Clear()
        FrmToppings.txtToppingNameEN.Clear()
        FrmToppings.txtToppingCosting.Clear()
        FrmToppings.txtPricing.Clear()
        FrmToppings.ComboBox1.Items.Clear()
        FrmToppings.DataGridViewToppingReceipe.Rows.Clear()
        loadCategoryTopping()
    End Sub
    Sub ShowItemTopping()

        Item.DataGridViewItemTopping.Rows.Clear()
        Dim selectItemTopping As DataTable = executesql("SELECT CategoryTopping.*,ItemTopping.* FROM ItemTopping INNER JOIN CategoryTopping ON(CategoryTopping.CategoryToppingId = ItemTopping.CategoryToppingId) WHERE ItemTopping.Active='1' AND ItemTopping.ItemId='" & Item.ItemIdSend & "'")
        If IsNothing(selectItemTopping) Then
            Exit Sub
        ElseIf selectItemTopping.Rows.Count = 0 Then
            Exit Sub
        End If
        Console.WriteLine(selectItemTopping.Rows.Count)
        For i As Integer = 0 To selectItemTopping.Rows.Count - 1
            Item.DataGridViewItemTopping.Rows.Add(selectItemTopping(i)("CategoryToppingId"), selectItemTopping(i)("CateToppingCode"), selectItemTopping(i)("CategoryToppingName"))
        Next
    End Sub
    Sub btnSearch()
        Dim ToppingName As String = FrmToppings.txtNameSearch.Text
        Dim CateTopping As String = FrmToppings.RadDropDownListCateToppingSearch.Text
        If ToppingName = "" And CateTopping = "" Then
            Dim selectTopping As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId)")
            FrmToppings.DataGridViewToppingList.Rows.Clear()
            For i As Integer = 0 To selectTopping.Rows.Count - 1
                FrmToppings.DataGridViewToppingList.Rows.Add(selectTopping(i)("ToppingId"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("ToppingName"), selectTopping(i)("ToppingCode"))
            Next
        ElseIf ToppingName IsNot "" And CateTopping = "" Then
            Dim selectTopping As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId) WHERE Topping.ToppingName LIKE '%" & ToppingName & "%'")
            FrmToppings.DataGridViewToppingList.Rows.Clear()
            For i As Integer = 0 To selectTopping.Rows.Count - 1
                FrmToppings.DataGridViewToppingList.Rows.Add(selectTopping(i)("ToppingId"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("ToppingName"), selectTopping(i)("ToppingCode"))
            Next
        ElseIf ToppingName = "" And CateTopping IsNot "" Then
            Dim selectTopping As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId) WHERE CategoryTopping.CategoryToppingName LIKE '%" & CateTopping & "%'")
            FrmToppings.DataGridViewToppingList.Rows.Clear()
            For i As Integer = 0 To selectTopping.Rows.Count - 1
                FrmToppings.DataGridViewToppingList.Rows.Add(selectTopping(i)("ToppingId"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("ToppingName"), selectTopping(i)("ToppingCode"))
            Next
        ElseIf ToppingName IsNot "" And CateTopping IsNot "" Then
            Dim selectTopping As DataTable = executesql("SELECT Topping.*,CategoryTopping.* FROM Topping INNER JOIN CategoryTopping ON(Topping.CategoryToppingId = CategoryTopping.CategoryToppingId) WHERE Topping.ToppingName LIKE '%" & ToppingName & "%' AND CategoryTopping.CategoryToppingName LIKE '%" & CateTopping & "%'")
            FrmToppings.DataGridViewToppingList.Rows.Clear()
            For i As Integer = 0 To selectTopping.Rows.Count - 1
                FrmToppings.DataGridViewToppingList.Rows.Add(selectTopping(i)("ToppingId"), selectTopping(i)("CategoryToppingName"), selectTopping(i)("ToppingName"), selectTopping(i)("ToppingCode"))
            Next
        End If
    End Sub

    'Sub delItemTopping()
    '    If Item.toppingId = 0 Then
    '        MsgBox("กรุณาเลือก Topping ที่ต้องการลบ", MsgBoxStyle.Critical)
    '        Exit Sub
    '    ElseIf MsgBox("ต้องการลบข้อมูลนี้หรือไม่", MsgboxStyle.YesNo) = MsgBoxResult.Yes Then
    '        executesql("UPDATE ItemTopping SET Active='0' WHERE ItemId = '" & Item.ItemIdSend & "' AND CategoryToppingId = '" & Item.toppingId & "'")
    '    End If
    '    ShowItemTopping()
    '    Item.toppingId = 0
    'End Sub
End Module
Public Class iTopping
    Public id As Integer?
    Public code As String
    Public name As String
End Class