<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ManageUser.aspx.vb" Inherits="UserManegmentCTAutomation.ManageUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
  
 <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
 <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script> 
      <script type="text/javascript" src="/JS/UserManagement.js"></script>
</head>
<body>
    <form runat ="server" >
        <asp:GridView ID="showListUser" runat ="server" AutoGenerateColumns ="false">
    <Columns >
        <asp:TemplateField HeaderText="User ID">
            <ItemTemplate>
                <%#Eval("UserID") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Name">
              <ItemTemplate>
                  <%#Eval("UserName") %>
               </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Role">
                <ItemTemplate>
                  <%#Eval("UserRole") %>
                 </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Email ID ">
                  <ItemTemplate>
                    <%#Eval("UserEmail") %>
                  </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Mobile NO">
                <ItemTemplate>
                    <%#Eval("UserPhone") %>
                 </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User Has Created CT">
                <ItemTemplate>
                     <%#Eval("HasCreatedCT") %>
                </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Amount of CT Created">
                <ItemTemplate>
                   <%#Eval("CountOfCT") %>
                 </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Amount of CT Created">
                <ItemTemplate>
                     <%#Eval("CreateCTAt") %>
                 </ItemTemplate>
           </asp:TemplateField>
         <asp:TemplateField>
                    <ItemTemplate>
                        
                           <button type ="button" id="btnEditUser" class="btn btn-primary btn-block mb-4 Edit-button" data-id=" <%#Eval("UserID") %>">Edit</button>
                       
                     </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField >
                      <ItemTemplate>
                         <button type ="button" id="btnDeleteUser" class="btn btn-primary btn-block mb-4 delete-button" data-id=" <%#Eval("UserID") %>">Delete</button>
                          
                     </ItemTemplate>
        </asp:TemplateField>

        
       
    </Columns>

</asp:GridView>
    </form>
</body>
</html>
