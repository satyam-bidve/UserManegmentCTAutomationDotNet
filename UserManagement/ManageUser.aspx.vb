Public Class ManageUser
    Inherits System.Web.UI.Page

    ' Global object of web service 
    Public Userservice As New Lazy(Of UserWebService)

    'on page load we directly show list of avilabe users on web page 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'calling the web service no need to send any object or model as we are getting data back from database 
        Dim result = Userservice.Value.GetUserData()
            'bind result object which contain list of users to the grid view
            showListUser.DataSource = result
            showListUser.DataBind()


    End Sub

    'Protected Sub showListUser_RowCommand(sender As Object, e As CommandEventArgs)
    '    ' Determine the action based on the CommandName
    '    Select Case e.CommandName
    '        Case "Update"
    '            ' Handle update action
    '            Dim userIdToUpdate As String = e.CommandArgument.ToString()
    '            EditUser(userIdToUpdate)
    '        Case "Delete"
    '            ' Handle delete action
    '            Dim userIdToDelete As String = e.CommandArgument.ToString()
    '            DeleteUser(userIdToDelete)
    '    End Select
    'End Sub

    Public Function EditUser(userId As String) As Object
        Dim UserIDs = userId

    End Function

    Public Function DeleteUser(userId As String) As Object

    End Function



End Class