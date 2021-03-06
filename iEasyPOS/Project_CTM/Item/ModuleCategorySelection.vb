Module ModuleCategorySelection
    Sub ClearTextData()
        FrmAddCategorySelection.TxtCateSelectName.Text = ""
        FrmAddCategorySelection.TxtCateSelectName2.Text = ""
        LoadDataCateSelection()
    End Sub
    'Load Data Category Selection 
    Sub LoadDataCateSelection()
        FrmAddCategorySelection.DGDataCateSelection.Rows.Clear()
        Dim table As String = "CategorySelection"
        Dim field As String = "CategorySelectionId,CategorySelectionName"
        Dim where As String = "Active=1"
        'Dim DataCateSelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCateSelection As DataTable = executesql("SELECT CategorySelectionId,CategorySelectionName FROM CategorySelection WHERE Active=1")
        'executesql("SELECT CategorySelectionId,CategorySelectionName FROM CategorySelection WHERE Active=1")
        If IsDBNull(DataCateSelection) Then
            'MsgBox("IsNullDb")
            Exit Sub
        End If
        Dim RowsDataCateSelection As Integer = DataCateSelection.Rows.Count
        Dim i As Integer
        If RowsDataCateSelection = 0 Then
            'MsgBox("IsNullRow")
            Exit Sub
        Else
            For i = 0 To RowsDataCateSelection - 1
                Dim CateSelectionName As String = DataCateSelection(i)("CategorySelectionName")
                Dim CateSelectionid As Integer = DataCateSelection(i)("CategorySelectionId")
                FrmAddCategorySelection.DGDataCateSelection.Rows.Add(CateSelectionName, CateSelectionid)
            Next
        End If
    End Sub
    'Btn Save 
    Sub SaveData()
        Dim CateSelectionName As String = FrmAddCategorySelection.TxtCateSelectName.Text
        Dim CateSelectionName2 As String = FrmAddCategorySelection.TxtCateSelectName2.Text
        Dim UserId As Integer = Frm_Login.UserId
        Dim InsData As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim Active As Integer = 1
        If CateSelectionName = "" Or CateSelectionName2 = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        'Insert into CateSelection 
        Dim table As String = "CategorySelection"
        Dim value As String = "'" & CateSelectionName & "','" & CateSelectionName2 & "','" & InsData & "','" & UserId & "','" & Active & "'"
        Dim field As String = "CategorySelectionName,CategorySelectionName2,InsertDate,UserId,Active"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&table=" & table & "&value=" & value & "&field=" & field & "")
        executesql("INSERT INTO CategorySelection(CategorySelectionName,CategorySelectionName2,InsertDate,UserId,Active) VALUES ('" & CateSelectionName & "','" & CateSelectionName2 & "','" & InsData & "','" & UserId & "','" & Active & "')")

        'executesql("INSERT INTO CategorySelection(CategorySelectionName,CategorySelectionName2,InsertDate,UserId,Active) VALUES('" & CateSelectionName & "','" & CateSelectionName2 & "','" & InsData & "','" & UserId & "','" & Active & "')")
        MsgBox("บันทึกข้อมูลเรียบร้อย")
        ClearTextData()
        LoadDataCateSelection()
    End Sub
    'Current Rows Data 
    Sub DataSelectRows()
        Dim table As String = "CategorySelection"
        Dim field As String = "CategorySelectionName,CategorySelectionName2"
        Dim where As String = "CategorySelectionId='" & FrmAddCategorySelection.CateSelectionId & "' AND Active=1"
        'Dim DataSelect As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        'executesql("SELECT CategorySelectionName,CategorySelectionName2 FROM CategorySelection WHERE CategorySelectionId='" & FrmAddCategorySelection.CateSelectionId & "' AND Active=1")
        Dim DataSelect As DataTable = executesql("SELECT CategorySelectionName,CategorySelectionName2 FROM CategorySelection WHERE CategorySelectionId='" & FrmAddCategorySelection.CateSelectionId & "' AND Active=1")
        If IsDBNull(DataSelect) Then
            Exit Sub
        End If
        Dim RowsDataSelect As Integer = DataSelect.Rows.Count
        If RowsDataSelect = 0 Then
            Exit Sub
        End If
        FrmAddCategorySelection.TxtCateSelectName.Text = DataSelect(0)("CategorySelectionName")
        FrmAddCategorySelection.TxtCateSelectName2.Text = DataSelect(0)("CategorySelectionName2")
    End Sub
    'Updadate Data
    Sub UpdateDataCateSelection()
        Dim CateSelectionId As Integer = FrmAddCategorySelection.CateSelectionId
        Dim CateSelectionName As String = FrmAddCategorySelection.TxtCateSelectName.Text
        Dim CateSelectionName2 As String = FrmAddCategorySelection.TxtCateSelectName2.Text
        Dim UpdateDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
        Dim UserId As Integer = Frm_Login.UserId
        Dim table As String = "CategorySelection"
        Dim value As String = "CategorySelectionName='" & CateSelectionName & "',CategorySelectionName2='" & CateSelectionName2 & "',UserId='" & UserId & "',UpdateDate='" & UpdateDate & "'"
        Dim where As String = "CategorySelectionId='" & CateSelectionId & "'"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
        'executesql("UPDATE CategorySelection SET CategorySelectionName='" & CateSelectionName & "',CategorySelectionName2='" & CateSelectionName2 & "',UserId='" & UserId & "',UpdateDate='" & UpdateDate & "' WHERE CategorySelectionId='" & CateSelectionId & "'")
        executesql("UPDATE CategorySelection SET CategorySelectionName='" & CateSelectionName & "',CategorySelectionName2='" & CateSelectionName2 & "',UserId='" & UserId & "',UpdateDate='" & UpdateDate & "' WHERE CategorySelectionId='" & CateSelectionId & "'")
        LoadDataCateSelection()
    End Sub

    'Delete Active=0
    Sub DeleteCateSelection()
        Dim CateSelectionId As Integer = FrmAddCategorySelection.CateSelectionId
        If CateSelectionId = 0 Then
            Exit Sub
        ElseIf CateSelectionId <> 0
            Dim DeleteDate As String = Convert.ToDateTime(Now).ToString("yyyy-MM-dd HH:mm:ss", New System.Globalization.CultureInfo("th-TH"))
            Dim Active As Integer = 0
            Dim UserId As Integer = Frm_Login.UserId
            Dim table As String = "CategorySelection"
            Dim value As String = "DeleteDate='" & DeleteDate & "',UserId='" & UserId & "',Active='" & Active & "'"
            Dim where As String = "CategorySelectionId='" & CateSelectionId & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
            'executesql("UPDATE CategorySelection SET DeleteDate='" & DeleteDate & "',UserId='" & UserId & "',Active='" & Active & "' WHERE CategorySelectionId='" & CateSelectionId & "'")
            executesql("UPDATE CategorySelection SET DeleteDate='" & DeleteDate & "',UserId='" & UserId & "',Active='" & Active & "' WHERE CategorySelectionId='" & CateSelectionId & "'")
            LoadDataCateSelection()
        End If
    End Sub

    'Btn Search 
    Sub SearchDateCate()
        Dim WordSearch As String = FrmAddCategorySelection.TxtSrc.Text
        If WordSearch = "" Then
            LoadDataCateSelection()
            Exit Sub
        ElseIf WordSearch <> ""
            Dim table As String = "CategorySelection"
            Dim field As String = "CategorySelectionId,CategorySelectionName"
            Dim where As String = "CategorySelectionName LIKE '%" & WordSearch & "%' AND Active=1"
            'Dim DataSearch As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
            Dim DataSearch As DataTable = executesql("SELECT CategorySelectionId,CategorySelectionName FROM CategorySelection WHERE CategorySelectionName LIKE '%" & WordSearch & "%' AND Active=1")
            'executesql("SELECT CategorySelectionId,CategorySelectionName FROM CategorySelection WHERE CategorySelectionName LIKE '%" & WordSearch & "%' AND Active=1")
            Dim RowsDaataSearch As Integer = DataSearch.Rows.Count
            Dim i As Integer
            If RowsDaataSearch = 0 Then
                Exit Sub
            End If
            FrmAddCategorySelection.DGDataCateSelection.Rows.Clear()
            For i = 0 To RowsDaataSearch - 1
                Dim CateSelectionId As Integer = DataSearch(i)("CategorySelectionId")
                Dim CateSelectionName As String = DataSearch(i)("CategorySelectionName")
                FrmAddCategorySelection.DGDataCateSelection.Rows.Add(CateSelectionName, CateSelectionId)
            Next
        End If
    End Sub
    Sub LoadTabPageSelection()
        Dim CateSelctionId As Integer = FrmAddCategorySelection.CateSelectionId
        Dim table As String = "Selection"
        Dim field As String = "SelectionId,SelectionName,SelectionName2"
        Dim where As String = "CategorySelectionId='" & CateSelctionId & "'"
        'Dim DataSelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataSelection As DataTable = executesql("SELECT SelectionId,SelectionName,SelectionName2 FROM Selection WHERE CategorySelectionId='" & CateSelctionId & "' and active = 1")
        Dim RowsDataSelection As Integer = DataSelection.Rows.Count
        Dim i As Integer
        If IsDBNull(RowsDataSelection) Then
            Exit Sub
        End If
        If RowsDataSelection = 0 Then
            Exit Sub
        End If
        FrmAddCategorySelection.DgSelection.Rows.Clear()
        For i = 0 To RowsDataSelection - 1
            Dim SelectionId As Integer = DataSelection(i)("SelectionId")
            Dim SelectionName As String = DataSelection(i)("SelectionName")
            FrmAddCategorySelection.DgSelection.Rows.Add(SelectionName, SelectionId)
        Next
    End Sub
    Sub LoadCategorySelectionToComboSelection()
        Dim table As String = "CategorySelection"
        Dim field As String = "CategorySelectionId,CategorySelectionName"
        Dim where As String = "Active=1"
        'Dim DataCategorySelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCategorySelection As DataTable = executesql("SELECT CategorySelectionId,CategorySelectionName FROM CategorySelection WHERE Active=1")
        Dim RowsDataCategorySelection As Integer = DataCategorySelection.Rows.Count
        Dim i As Integer
        If IsDBNull(DataCategorySelection) Then
            Exit Sub
        End If
        If RowsDataCategorySelection = 0 Then
            Exit Sub
        ElseIf RowsDataCategorySelection <> 0
            FrmAddCategorySelection.ComboBoxSelection.Items.Clear()
            FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Items.Clear()
            For i = 0 To RowsDataCategorySelection - 1
                Dim CateSelectionName As String = DataCategorySelection(i)("CategorySelectionName")
                FrmAddCategorySelection.ComboBoxSelection.Items.Add(CateSelectionName)
                'AddComboBoxCateSelectionNameDetail
                FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Items.Add(CateSelectionName)
            Next
        End If
    End Sub
    Sub SelectTabComboChange()
        'TabSelection Change 
        Dim CateSelectionName As String = FrmAddCategorySelection.ComboBoxSelection.Text
        Dim table As String = "CategorySelection"
        Dim field As String = "CategorySelectionId"
        Dim where As String = "CategorySelectionName='" & CateSelectionName & "'"
        'Dim DataCateSelectionId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCateSelectionId As DataTable = executesql("SELECT CategorySelectionId FROM CategorySelection WHERE CategorySelectionName='" & CateSelectionName & "'")
        If IsDBNull(DataCateSelectionId) Then
            Exit Sub
        End If
        If DataCateSelectionId.Rows.Count = 0 Then
            Exit Sub
        End If
        table = "Selection"
        field = "SelectionId,SelectionName"
        where = "CategorySelectionId='" & DataCateSelectionId(0)("CategorySelectionId") & "' AND Active=1"
        'Dim DataSrcComboSelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataSrcComboSelection As DataTable = executesql("SELECT SelectionId,SelectionName FROM Selection WHERE CategorySelectionId='" & DataCateSelectionId(0)("CategorySelectionId") & "' AND Active=1")
        If IsDBNull(DataSrcComboSelection) Then
            FrmAddCategorySelection.DgSelection.Rows.Clear()
            Exit Sub
        End If
        If DataSrcComboSelection.Rows.Count = 0 Then
            FrmAddCategorySelection.DgSelection.Rows.Clear()
            Exit Sub
        End If
        Dim RowsDaTaSrcComboSelection As Integer = DataSrcComboSelection.Rows.Count
        Dim i As Integer
        FrmAddCategorySelection.DgSelection.Rows.Clear()
        For i = 0 To RowsDaTaSrcComboSelection - 1
            Dim SelectoinId As Integer = DataSrcComboSelection(i)("SelectionId")
            Dim SelectionName As String = DataSrcComboSelection(i)("SelectionName")
            FrmAddCategorySelection.DgSelection.Rows.Add(SelectionName, SelectoinId)
        Next
    End Sub
    Sub LoadCategorySelectionDetail()
        Dim table As String = "Selection"
        Dim field As String = "SelectionName,SelectionId"
        Dim where As String = "Active=1"
        'Dim DataSelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataSelection As DataTable = executesql("SELECT SelectionName,SelectionId FROM Selection WHERE Active=1")
        Dim RowsDataCategorySelection As Integer = DataSelection.Rows.Count
        Dim i As Integer
        If IsDBNull(DataSelection) Then
            Exit Sub
        End If
        If RowsDataCategorySelection = 0 Then
            Exit Sub
        End If
        'FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Items.Clear()
        FrmAddCategorySelection.DgSelection.Rows.Clear()
        For i = 0 To RowsDataCategorySelection - 1
            Dim SelectionName As String = DataSelection(i)("SelectionName")
            Dim SelectionId As String = DataSelection(i)("SelectionId")
            FrmAddCategorySelection.DgSelection.Rows.Add(SelectionName, SelectionId)
            'FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Items.Add(CategorySelectionName)
        Next
    End Sub
    Sub ClearTextDataSelection()
        FrmAddCategorySelection.TxtSelectionName.Clear()
        FrmAddCategorySelection.TxtSelectionName2.Clear()
        FrmAddCategorySelection.DgSelection.Rows.Clear()
        LoadCategorySelectionDetail()
    End Sub
    'Btn Save Selection 
    Sub SaveSelection()
        Dim SelectionName As String = FrmAddCategorySelection.TxtSelectionName.Text
        Dim SelectionName2 As String = FrmAddCategorySelection.TxtSelectionName2.Text
        Dim CategoryselectionName As String = FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Text
        Dim Active As Integer = 1
        Dim table As String = ""
        Dim field As String = ""
        Dim where As String = ""
        Dim value As String = ""
        If SelectionName = "" Or CategoryselectionName = "" Then
            MsgBox("กรุรากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        table = "CategorySelection"
        field = "CategorySelectionId"
        where = "CategorySelectionName='" & CategoryselectionName & "'"
        'Dim DataCateSelectionId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCateSelectionId As DataTable = executesql("SELECT CategorySelectionId FROM CategorySelection WHERE CategorySelectionName='" & CategoryselectionName & "'")
        Dim CateSelectionId As Integer
        If IsDBNull(DataCateSelectionId(0)("CategorySelectionId")) Then
            CateSelectionId = 0
        Else
            CateSelectionId = DataCateSelectionId(0)("CategorySelectionId")
        End If
        'Insert Into selection 
        table = "Selection"
        value = "'" & CateSelectionId & "','" & SelectionName & "','" & SelectionName2 & "','" & Active & "'"
        field = "CategorySelectionId,SelectionName,SelectionName2,Active"
        'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=INSERT&table=" & table & "&value=" & value & "&field=" & field & "")
        executesql("INSERT INTO Selection(CategorySelectionId,SelectionName,SelectionName2,Active) VALUES('" & CateSelectionId & "','" & SelectionName & "','" & SelectionName2 & "','" & Active & "')")
        ClearTextDataSelection()
        MsgBox("บันทึกเรียบร้อย")
    End Sub
    'Btn Delete Selection 
    Sub DeleteSelection()
        Dim SelectionId As Integer = FrmAddCategorySelection.SelectionidSend
        If SelectionId = 0 Then
            Exit Sub
        Else
            'Update Selection Active 
            Dim table As String = "Selection"
            Dim value As String = "Active=1"
            Dim where As String = "SelectionId='" & SelectionId & "'"
            'ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=UPDATE&table=" & table & "&value=" & value & "&where=" & where & "")
            executesql("UPDATE Selection SET Active=1 WHERE SelectionId='" & SelectionId & "'")
            ClearTextDataSelection()
        End If
    End Sub
    Sub DataSelectionDetail()
        Dim Selectionid As Integer = FrmAddCategorySelection.SelectionidSend
        Dim table As String = "Selection"
        Dim field As String = "CategorySelectionId,SelectionName,SelectionName2"
        Dim where As String = "SelectionId='" & Selectionid & "'"
        'Dim DataSelection As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataSelection As DataTable = executesql("SELECT CategorySelectionId,SelectionName,SelectionName2 FROM Selection WHERE SelectionId='" & Selectionid & "'")
        Dim RowsDataSelection As Integer = DataSelection.Rows.Count
        If IsDBNull(DataSelection(0)("SelectionName")) Then
            Exit Sub
        End If
        If RowsDataSelection = 0 Then
            Exit Sub
        End If
        Dim SelectionName As String
        Dim SelectionName2 As String
        If IsDBNull(DataSelection(0)("SelectionName2")) Then
            SelectionName2 = ""
        Else
            SelectionName2 = DataSelection(0)("SelectionName2")
        End If
        table = "CategorySelection"
        field = "CategorySelectionName"
        where = "CategorySelectionId='" & DataSelection(0)("CategorySelectionId") & "' AND Active=1"
        'Dim DataCategorySelectionId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataCategorySelectionId As DataTable = executesql("SELECT CategorySelectionName FROM CategorySelection WHERE CategorySelectionId='" & DataSelection(0)("CategorySelectionId") & "' AND Active=1")
        SelectionName = DataSelection(0)("SelectionName")
        FrmAddCategorySelection.TxtSelectionName.Text = SelectionName
        FrmAddCategorySelection.TxtSelectionName2.Text = SelectionName2
        FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Text = DataCategorySelectionId(0)("CategorySelectionName")
    End Sub

    Sub UpdateSelection()
        Dim SelectionId As Integer = FrmAddCategorySelection.SelectionidSend
        Dim CategorySelection As String = FrmAddCategorySelection.ComboBoxCateSelectionNameDetail.Text
        Dim SelectionName As String = FrmAddCategorySelection.TxtSelectionName.Text
        Dim SelectionName2 As String = FrmAddCategorySelection.TxtSelectionName2.Text
        Dim table As String = ""
        Dim value As String = ""
        Dim where As String = ""
        Dim field As String = ""
        If CategorySelection = "" Or SelectionName = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If
        'CateSelectionId
        table = "CategorySelection"
        field = "CategorySelectionId"
        where = "CategorySelectionName='" & CategorySelection & "'"
        'Dim DataSelectionId As DataTable = ModuleGetDataAPI.gett("http://testnoi.hiveup.co/api/vbapi.php?action=SELECT&table=" & table & "&field=" & field & "&where=" & where & "")
        Dim DataSelectionId As DataTable = executesql("SELECT CategorySelectionId FROM CategorySelection WHERE CategorySelectionName='" & CategorySelection & "'")
        If IsDBNull(DataSelectionId(0)(0)) Then
            Exit Sub
        End If
        If DataSelectionId.Rows.Count = 0 Then
            Exit Sub
        End If
        'UpdateSelection
        table = "Selection"
        field = "CategorySelectionId='" & DataSelectionId(0)(0) & "',SelectionName='" & SelectionName & "',SelectionName2='" & SelectionName2 & "'"
        where = "SelectionId='" & SelectionId & "'"


        executesql("UPDATE Selection SET CategorySelectionId='" & DataSelectionId(0)(0) & "',SelectionName='" & SelectionName & "',SelectionName2='" & SelectionName2 & "' WHERE SelectionId='" & SelectionId & "'")
        LoadTabPageSelection()
        MsgBox("บันทึกเรียบร้อย")
    End Sub
End Module
