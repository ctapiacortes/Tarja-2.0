<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Agencias.aspx.cs" MasterPageFile="~/Menu.master" Inherits="Mantenedores_Agencias" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    </p>
    <p>
        Nombre&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        <asp:Button ID="btnIngresar" runat="server" onclick="btnIngresar_Click" 
            Text="Ingresar" />
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Modificar" />
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
    <p style="margin-left: 40px">
        <asp:GridView ID="gvAgencias" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
