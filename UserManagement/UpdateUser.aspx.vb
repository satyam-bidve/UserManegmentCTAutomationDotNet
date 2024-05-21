Public Class UpdateUser
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function Adduser(sender As Object, e As EventArgs) Handles btnUpdateUser.Click 'handels btnID.Click event
        'creating local veriables and assigne them the input filed values that we get from aspx-HTML forms
        Dim username = User_Name.Text
        Dim Email = Email_ID.Text
        Dim MobileNo = Mobile_no.Text
        Dim Role = Role_Name.Text
        'create a object of model class to store data in it 
        Dim UserDetails As New UserModel
        UserDetails.UserName = username
        UserDetails.UserEmail = Email
        UserDetails.UserPhone = MobileNo
        UserDetails.UserRole = Role

        'create lazy object of web service to send data to web service
        Dim Userservice As New Lazy(Of UserWebService)
        'Here we call web service method by its object and send data object 
        Dim result = Userservice.Value.UpdateUserData(UserDetails)

        ' show some data fields on web page for testing
        Me.Page.Controls.Add(New LiteralControl($"FirstName: {username } --- "))
        Me.Page.Controls.Add(New LiteralControl($"Role: {Role}"))







    End Function

End Class