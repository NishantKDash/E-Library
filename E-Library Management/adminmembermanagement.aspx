<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminmembermanagement.aspx.cs" Inherits="E_Library_Management.adminmembermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


                <script src="sweetalert/sweetalert.min.js"></script>
            <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
            
          <link href ="//cdn.datatables.net/1.12.0/css/jquery.dataTables.min.css" rel ="stylesheet"/>
          <script src="//cdn.datatables.net/1.12.0/js/jquery.dataTables.min.js"></script>
        <script>

            function alert() {
                swal("Done!", "Member was successfully added .", "success");
            }

            function alertn() {
                swal("Member Already Exist with this Member ID, try another ID");
            }
            function alertn2() {
                swal("No Member found");
            }

            function alertf() {
                swal("Member found!");
            }

            function alertu() {
                swal("Done!", "Member was successfully updated.", "success");
            }

            function alertd() {
                swal("Done!", "Member was successfully deleted.", "success");
            }


            $(document).ready(function () {

                //$(document).ready(function () {
                //$('.table').DataTable();
                // });

                $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            });
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Member Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="imgs/generaluser.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>Member ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>
                              <asp:LinkButton style ="margin-top:10px; margin-bottom:10px" class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="LinkButton4_Click1"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Account Status</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control ms-1" ID="TextBox7" runat="server" placeholder="Account Status" ReadOnly="True"></asp:TextBox>
                              <asp:LinkButton style ="margin-top:10px; margin-bottom:10px" class="btn btn-success ms-1" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="fas fa-check-circle" title ="Activate"></i></asp:LinkButton>
                              <asp:LinkButton style ="margin-top:10px; margin-bottom:10px" class="btn btn-warning ms-1" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"><i class="far fa-pause-circle" title ="Pending"></i></asp:LinkButton>
                              <asp:LinkButton style ="margin-top:10px; margin-bottom:10px" class="btn btn-danger ms-1" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><i class="fas fa-times-circle" title ="Deactivate"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>DOB</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox8" runat="server" placeholder="DOB" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox3" runat="server" placeholder="Contact No" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Email ID</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email ID" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>State</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox9" runat="server" placeholder="State" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox10" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Pin Code</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox11" runat="server" placeholder="Pin Code" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-12">
                        <label>Full Postal Address</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox6" runat="server" placeholder="Full Postal Address" TextMode="MultiLine" Rows="2" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <asp:Button style ="margin-top:10px; margin-bottom:10px" ID="Button2" class="w-100 btn btn-lg btn-block btn-danger" runat="server" Text="Delete User" title ="Delete User Permanently" OnClick="Button2_Click" />
                     </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
         </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Member List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:elibraryDBConnectionString %>" SelectCommand="SELECT [full_name], [contact_no], [member_id], [account_status] FROM [member_master_tbl]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns ="False" DataKeyNames ="member_id" DataSourceID="SqlDataSource1">
                            <Columns>
                              <asp:BoundField DataField="member_id" HeaderText="member_id" ReadOnly="True" SortExpression="member_id" />
                              <asp:BoundField DataField="full_name" HeaderText="member_name" SortExpression="member_name" />
                              <asp:BoundField DataField="contact_no" HeaderText="contact_no" ReadOnly="True" SortExpression="contact_no" />
                              <asp:BoundField DataField="account_status" HeaderText="account_status" SortExpression="account_status" />
                            </Columns>  
                         
                        </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>


</asp:Content>
