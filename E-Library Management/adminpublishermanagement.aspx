<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminpublishermanagement.aspx.cs" Inherits="E_Library_Management.adminpublishermanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


              
            <script src="sweetalert/sweetalert.min.js"></script>
            <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
            
          <link href ="//cdn.datatables.net/1.12.0/css/jquery.dataTables.min.css" rel ="stylesheet"/>
          <script src="//cdn.datatables.net/1.12.0/js/jquery.dataTables.min.js"></script>
        <script>

            function alert() {
                swal("Done!", "Publisher was successfully added .", "success");
            }

            function alertn() {
                swal("Publisher Already Exist with this Publisher ID, try another ID");
            }
            function alertn2() {
                swal("No Publisher found");
            }

            function alertf() {
                swal("Publisher found!");
            }

            function alertu() {
                swal("Done!", "Publisher was successfully updated.", "success");
            }

            function alertd() {
                swal("Done!", "Publisher was successfully deleted.", "success");
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

     <div class="container">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Publisher Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="imgs/publisher.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>Publisher ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                              <asp:Button style ="margin-top:10px; margin-bottom:10px" class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Publisher Name</label>
                        <div class="form-group">
                           <asp:TextBox style ="margin-top:10px; margin-bottom:10px" CssClass="form-control" ID="TextBox2" runat="server" placeholder="Publisher Name"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-4">
                        <asp:Button style ="margin-top:20px; margin-bottom:10px" ID="Button2" class="w-100 btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click" />
                     </div>
                     <div class="col-4">
                        <asp:Button style ="margin-top:20px; margin-bottom:10px" ID="Button3" class="w-100 btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                     </div>
                     <div class="col-4">
                        <asp:Button style ="margin-top:20px; margin-bottom:10px" ID="Button4" class="w-100 btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click" />
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
                           <h4>Publisher List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:elibraryDBConnectionString %>" SelectCommand="SELECT * FROM [publisher_master_tbl]"></asp:SqlDataSource>
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns ="False" DataKeyNames ="publisher_id" DataSourceID="SqlDataSource1">
                               <Columns>
                                <asp:BoundField DataField="publisher_id" HeaderText="publisher_id" ReadOnly="True" SortExpression="publisher_id" />
                                <asp:BoundField DataField="publisher_name" HeaderText="publisher_name" SortExpression="publisher_name" />
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
