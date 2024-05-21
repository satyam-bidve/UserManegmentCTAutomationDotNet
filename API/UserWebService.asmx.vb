Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class UserWebService
    Inherits System.Web.Services.WebService
    Public UserControl As New Lazy(Of UserControllervb) 'create lazy object of controller to call its methods
    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    'here we get the data from view code (aspx.vb) and send that data to controller also get data back from controller
    <WebMethod()>
    Public Function saveUserData(User As UserModel) As UserModel 'as UserModel define its datatype
        Return UserControl.Value.SaveUserData(User) 'call method of controller on its object and send data to controller
    End Function

    'Here we get data from controller in the form of list and then send it to the view code (aspx.vb) and there will show with grid view 
    <WebMethod()>
    Public Function GetUserData() As List(Of UserModel)
        Return UserControl.Value.GetUserData()
    End Function


    'here we get data from database for a specific user to update it letter 
    <WebMethod()>
    Public Function GetStudentDetailsByID(userid) As UserModel
        Return UserControl.Value.GetUserDetailsByID(userid)
    End Function

    'Here we delete the user by its id 
    <WebMethod()>
    Public Function DeleteUserByID(userid)
        Return UserControl.Value.DeleteUserByID(userid)
    End Function

    Public Function UpdateUserData(User As UserModel) As UserModel 'as UserModel define its datatype
        Return UserControl.Value.SaveUserData(User) 'call method of controller on its object and send data to controller
    End Function

End Class