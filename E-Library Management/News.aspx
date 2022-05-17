<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="E_Library_Management.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="news/news.css" rel="stylesheet" />
    <script src="news/news.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        <table>
            <tr>
                <td align="center" class="style1">
                    <h3>
                        NEWS</h3>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="txtSubject" 
                    CssClass="textbox" onkeypress="return runScript(event)" />
                </td>
            </tr>
            <tr>
                <td align="right">
                 
                </td>
            </tr>
        </table>
        <div id="DivNews">
        </div>

    </div>
    <%--This Div is For Binding News--%>
    <div id="ProgressiveDiv" style="padding-left: 500px">
        <img src="Image/loading.gif" />
    </div>
  
   </asp:Content>
