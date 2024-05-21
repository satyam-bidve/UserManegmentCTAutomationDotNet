<%@ Page Language="vb"  AutoEventWireup="true" CodeBehind="UpdateUser.aspx.vb" Inherits="UserManegmentCTAutomation.UpdateUser" %>

<head>

       <title></title>
 
   <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
 
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script> 
     <script type="text/javascript" src="/JS/UserManagement.js"></script>

</head>
<body>


   <div>
            <h3>Update the user details </h3>
  <form >
  <!-- User Name input -->
  <div data-mdb-input-init class="form-outline mb-4">
    <label class="form-label" for="form2Example1">User Name</label>
   <asp:TextBox ID="User_Name"   type="text" class="form-control"  runat="server"></asp:TextBox>
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
  <asp:Button ID="btnUpdateUser" class="btn btn-primary btn-block mb-4" runat="server" Text="Update" OnServerClick="Update" />

  <!-- Register buttons -->

</form>
   </div>
  
</body>

