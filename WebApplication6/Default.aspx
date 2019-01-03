<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:TextBox ID="TextBoxScreen" runat="server" Height="50px" Width="75%" ReadOnly="True"></asp:TextBox>
    </div>

    <div class="row">
        <div class="col-md-3">
            <asp:Button ID="Button1" runat="server" Height="72px" OnClick="Button1_Click" Text="7" Width="191px" />
            <asp:Button ID="ButtonFour" runat="server" Height="72px" Text="4" Width="191px" OnClick="ButtonFour_Click" />
            <asp:Button ID="Button9" runat="server" Height="72px" Text="1" Width="191px" OnClick="Button9_Click" />
            <asp:Button ID="Button13" runat="server" Height="72px" Text="0" Width="191px" OnClick="Button13_Click" />   
        </div>
        <div class="col-md-3">
            <asp:Button ID="ButtonEight" runat="server" Height="72px" Text="8" Width="191px" OnClick="ButtonEight_Click" />
            <asp:Button ID="ButtonFive" runat="server" Height="72px" Text="5" Width="191px" OnClick="ButtonFive_Click" />
            <asp:Button ID="Button10" runat="server" Height="72px" Text="2" Width="191px" OnClick="Button10_Click" />
            <asp:Button ID="ButtonDivide" runat="server" Height="72px" Text="/" Width="191px" OnClick="ButtonDivide_Click" />
        </div>
        <div class="col-md-3">
            <asp:Button ID="ButtonNine" runat="server" Height="72px" Text="9" Width="191px" OnClick="ButtonNine_Click" />
            <asp:Button ID="ButtonSix" runat="server" Height="72px" Text="6" Width="191px" OnClick="ButtonSix_Click" />
            <asp:Button ID="Button11" runat="server" Height="72px" Text="3" Width="191px" OnClick="Button11_Click" />
            <asp:Button ID="ButtonMultiply" runat="server" Height="72px" Text="X" Width="191px" OnClick="ButtonMultiply_Click" />
            
        </div>
        <div class="col-md-3">
            <asp:Button ID="ButtonCE" runat="server" Height="72px" Text="CE" Width="191px" OnClick="ButtonCE_Click" />
            <asp:Button ID="ButtonAdd" runat="server" Height="72px" Text="+" Width="191px" OnClick="ButtonAdd_Click" />
            <asp:Button ID="ButtonSubtract" runat="server" Height="72px" Text="-" Width="191px" OnClick="ButtonSubtract_Click" />
            <asp:Button ID="ButtonEquals" runat="server" Height="72px" Text="=" Width="191px" OnClick="ButtonEquals_Click" />
        </div>
    </div>

</asp:Content>
