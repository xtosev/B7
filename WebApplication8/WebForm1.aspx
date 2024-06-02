<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><b>Mozete se logovati sledecim nalozima:</b></p>
    <table style="width: 30%;">
        <tr>
            <td>Korisnicko ime: Test1<br> Lozinka: test1123       </td>
            <td>Korisnicko ime: Test2<br> Lozinka: test2123       </td>
        </tr>
    </table>
    <hr />
    <p style="">Unesite parametre za logovanje. <b style="color: blue">Registrujte se</b> ako nemate nalog.</p>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Forma za logovanje" Width="30%">
        Korisnicko ime: <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="100%"></asp:TextBox>
        <br />
        Lozinka: <br />
        <asp:TextBox ID="TextBox2" runat="server" Width="100%"></asp:TextBox>
    </asp:Panel>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Prijava" style="margin-left: 27%" OnClick="Button1_Click"/>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <br />
    </asp:Content>
