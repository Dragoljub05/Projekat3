<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Projekat.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="max-width: 500px; margin: 50px auto; padding: 20px; background-color: aqua;">
        <div class="form-group" >
        <asp:Label ID="Label6" runat="server" Text="REGISTER" Font-Size="30px" Font-Bold="true" ForeColor="Blue" ></asp:Label>
        <br />
            </div>
    <br />
        <div class="form-group">
    <label for="ImeTxt" id="label1">Username    :</label>
        <asp:TextBox ID="TextBox1" runat="server" />
            </div>
    <br />
        <div class="form-group">
        <label for="EmailTxt" id="label2">Email     :</label>
        <asp:TextBox ID="TextBox2" runat="server" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTxt" Display="Dynamic" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    </div>  
            <br />
        <div class="form-group">
        <label for="SifraTxt" id="label3">Password   :</label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" />
            </div>
    <br />

        <div class="form-group">
        <label for="SifraTxtconfirm" id="label4">Confirm Password:</label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" />
            </div>
    <br />
    <br />
        <div class="form-group">
        <asp:Button ID="Registerdugme" runat="server" Text="Register" Onclick="Registerdugme_Click" BorderStyle="Solid" BorderColor="Black" BorderWidth="3px" Height="50px" Width="100px" CssClass="form-control"/>
       </div>
    <br />
    <br />
        <div class="form-group">
    <asp:Label ID="ErrorLabel" runat="server" Text="" ></asp:Label>
            </div>
        
        </div>
</asp:Content>


