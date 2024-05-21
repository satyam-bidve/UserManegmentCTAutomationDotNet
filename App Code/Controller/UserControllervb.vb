Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports ToDoApp.Model
Imports ToDoApp.Model.TodoListModel
Public Class UserControllervb
    ' here we communicate with database 

    'creating the object of connection string 
    Public Shared connectionString As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString
    Dim cnn As New SqlConnection(connectionString)

    'insert data in database by saveUserData Method create opration
    Public Function SaveUserData(User As UserModel) As UserModel
        cnn.Open() ' open connection 
        Dim cmd As SqlCommand = cnn.CreateCommand() 'create object of sqlCommand
        cmd.CommandText = "AddNewUsers"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Name", User.UserName)  ' add daat in sql query
        cmd.Parameters.AddWithValue("@User_Email", User.UserEmail)
        cmd.Parameters.AddWithValue("@User_Mob", User.UserPhone)
        cmd.Parameters.AddWithValue("@User_Role", User.UserRole)
        cmd.Parameters.AddWithValue("@HasCreateCT", User.HasCreatedCT)
        cmd.Parameters.AddWithValue("@CountOfCT", User.CountOfCT)
        cmd.Parameters.AddWithValue("@CratedCTAt", User.CreateCTAt)
        cmd.Parameters.AddWithValue("@User_ID", User.UserID)


        ' execute query
        cmd.ExecuteNonQuery()
        cnn.Close() 'close connection
        Return User 'return user object to web service back 
    End Function


    ' get data back from database and show list of it Read Opration
    Public Function GetUserData() As List(Of UserModel) ' getting data back from database in the form of list 
        ' creating list of user to show on webpage
        Dim usersList As New List(Of UserModel)
        cnn.Open() ' open connection
        Dim cmd As SqlCommand = cnn.CreateCommand() 'creating sql query object 
        cmd.CommandText = "GetallUserDetails"
        cmd.CommandType = CommandType.StoredProcedure
        ' cmd.Parameters.AddWithValue("@Firstname", Firstname)
        Dim reader = cmd.ExecuteReader() ' create reader that will serach and read data in database 
        Dim dt = New DataTable() ' and object of data table
        dt.Load(reader)
        Dim ds = New DataSet()
        ds.Tables.Add(dt)
        If (ds.Tables(0).Rows.Count > 0) Then  ' if there is data 
            For Each row As DataRow In ds.Tables(0).Rows
                usersList.Add(New UserModel With   ' adding data in list object by object
                                         {
                                             .UserID = row("UserID"),
                                             .UserName = row("UserName"),
                                             .UserEmail = row("UserEmail"),
                                             .UserRole = row("UserRole"),
                                             .UserPhone = row("UserPhone"),
                                             .HasCreatedCT = row("HasCreatedCT"),
                                             .CountOfCT = row("CountOfCT"),
                                             .CreateCTAt = row("CreatedAt")
                    })



            Next
        End If
        Return usersList  ' sending back the list to viwe in aspx
    End Function

    'getting data back from data base for selected user for edit and then update 
    Public Function GetUserDetailsByID(UserID) As UserModel
        cnn.Open()
        Try
            ' cmd.CommandText = "EXEC GetUserDetailsByIDs @User_ID = 'User02';"
            Dim cmd As SqlCommand = cnn.CreateCommand()
            cmd.CommandText = "GetUserDetailsByIDs"
            Dim user As New UserModel
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@User_ID", UserID)

            Dim reader = cmd.ExecuteReader()
            If (reader.Read()) Then
                user.UserName = reader("UserName")
                user.UserID = reader("UserID")
                user.UserEmail = reader("UserEmail")
                user.UserRole = reader("UserRole")
                user.UserPhone = reader("UserPhone")
                user.HasCreatedCT = reader("HasCreatedCT")
                user.CreateCTAt = reader("CreatedAt")
                user.CountOfCT = reader("CountOfCT")




                Return user
            End If
        Catch ex As FormatException

        Finally
            cnn.Close()
        End Try
    End Function

    Public Function DeleteUserByID(UserID)
        cnn.Open()
        Try
            Dim cmd As SqlCommand = cnn.CreateCommand()
            cmd.CommandText = "DeleteUserData"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@User_ID", UserID)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            cnn.Close()
        Catch ex As FormatException

        End Try
        Return UserID
    End Function


    Public Function UpdateUserData(User As UserModel) As UserModel
        cnn.Open() ' open connection 
        Dim cmd As SqlCommand = cnn.CreateCommand() 'create object of sqlCommand
        cmd.CommandText = "UpdateUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Name", User.UserName)  ' add daat in sql query
        cmd.Parameters.AddWithValue("@User_Email", User.UserEmail)
        cmd.Parameters.AddWithValue("@User_Mob", User.UserPhone)
        cmd.Parameters.AddWithValue("@User_Role", User.UserRole)
        'These values are calulated so may be nno need to update them
        'cmd.Parameters.AddWithValue("@HasCreateCT", User.HasCreatedCT)
        'cmd.Parameters.AddWithValue("@CountOfCT", User.CountOfCT)
        'cmd.Parameters.AddWithValue("@CratedCTAt", User.CreateCTAt)
        'cmd.Parameters.AddWithValue("@User_ID", User.UserID)


        ' execute query
        cmd.ExecuteNonQuery()
        cnn.Close() 'close connection
        Return User 'return user object to web service back 
    End Function

End Class
