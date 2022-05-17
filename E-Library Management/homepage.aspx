<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="E_Library_Management.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
      .heading {text-align: center;}
      .paragraph {text-align: center;}
      .paragraph1 {text-align:center;
            width:50%;
           display:block;
           margin:auto;}
      .centre {
           
           text-align:center;
            width:50%;
           display:block;
           margin:auto;
}
    </style>
    <section>
        <img src="imgs/home-bg.jpg" class ="img-fluid"/>
    </section>
    <section>
        <div class ="container">
            <div class ="row">
                <div class ="col-12">
                   
               
                    <h2 class ="heading">Our Features</h2>
                    <p class ="paragraph">Our Three Primary Features</p>

                    
                   
                </div>

           

          
                <div class ="col-md-4">
                   
                    <img  class = "centre"  src="imgs/digital-inventory.png" />
                    <h4 class  ="heading">Digital Book Inventory</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>
                </div>

           

             
                <div class ="col-md-4">
                   
                    <img class = "centre" src="imgs/search-online.png" />
                    <h4 class  ="heading">Search Books</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>

                </div>

           

              

                <div class ="col-md-4">
                   
                 <img class = "centre" src="imgs/defaulters-list.png" />
                    <h4 class  ="heading">Defaulters List</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>
                 </div>

              

        </div>
            </div>
    </section>

      <section>
        <img class ="img-fluid" src="imgs/in-homepage-banner.jpg" />
    </section>
        <section>
        <div class ="container">
            <div class ="row">
                <div class ="col-12">
                   
               
                    <h2 class ="heading">Our Processes</h2>
                    <p class ="paragraph">We have a simple 3-step process</p>

                    
                   
                </div>

           

          
                <div class ="col-md-4">
                   
                    <img class = "centre" src="imgs/sign-up.png" />
                    <h4 class  ="heading">Sign-Up</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>
                </div>

           

             
                <div class ="col-md-4">
                   
                    <img class = "centre" src="imgs/search-online.png" />
                    <h4 class  ="heading">Search Books</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>

                </div>

           

              

                <div class ="col-md-4">
                   
                 <img class ="centre" src="imgs/library.png" />
                    <h4 class  ="heading">Visit Us</h4>
                    <p class = "text-justify">
                        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's stand
                    </p>
                 </div>

              

        </div>
            </div>
    </section>
</asp:Content>
