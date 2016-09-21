Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim cc As TestProject_2.Class1 = New TestProject_2.Class1
        cc.Test()

    End Sub

End Class