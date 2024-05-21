<%@ Page Language="vb"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUserForm.aspx.vb" Inherits="UserManegmentCTAutomation.AddUserForm" %>

 <asp:Content  ID="SatyamContent" ContentPlaceHolderID="MainContent" runat="server">
     

  <form >
  <!-- User Name input -->
  <div data-mdb-input-init class="form-outline mb-4">
    <label class="form-label" for="form2Example1">User Name</label>
   <asp:TextBox ID="User_Name"   type="text" class="form-control"  runat="server"></asp:TextBox>
  </div>

      <div data-mdb-input-init class="form-outline mb-4">
     <label class="form-label" for="form2Example1">User ID</label>
    <asp:TextBox ID="User_ID"   type="text" class="form-control"  runat="server"></asp:TextBox>
    </div>

      <!-- Email input -->
  <div data-mdb-input-init class="form-outline mb-4">
    <label class="form-label" for="form2Example1">Email</label>
    <asp:TextBox ID="Email_ID"   type="Email" class="form-control" runat="server"></asp:TextBox>
  </div>

 <!-- mob input -->
 <div data-mdb-input-init class="form-outline mb-4">
   <label class="form-label" for="form2Example1">Mobile no</label>
   <asp:TextBox ID="Mobile_no"   type="text" class="form-control"  runat="server"></asp:TextBox>
 </div>

  <!-- Role input -->
  <div data-mdb-input-init class="form-outline mb-4">
    <label class="form-label" for="form2Example1">User Role</label>
   <asp:TextBox ID="Role_Name"   type="text" class="form-control"  runat="server"></asp:TextBox>
  </div>


 

 
 
  <!-- Submit button -->
 <%-- <button data-mdb-ripple-init type="button" class="btn btn-primary btn-block mb-4">Add User</button>--%>
  <asp:Button ID="btnAddUser" class="btn btn-primary btn-block mb-4" runat="server" Text="Add User" OnServerClick="Adduser" />

  <!-- Register buttons -->

</form>
  
 </asp:Content>
