Public Class FrmCategoryTopping
    Private Sub btnDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleCategoryTopping.loadCateTopping()
        ModuleCategoryTopping.LoadPrinter()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ModuleCategoryTopping.AddCategoryTopping()
        loadCategoryTopping()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ModuleCategoryTopping.ClearData()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ModuleCategoryTopping.btndelete()
        loadCategoryTopping()
    End Sub
End Class