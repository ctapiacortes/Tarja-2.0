<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Iso_codes.aspx.cs" Inherits="Mantenedores_Iso_codes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/Estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblCodISO" runat="server" Text="Codigo ISO:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodigos" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Descripción:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Tara Desde:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTaraD" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tara Hasta:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTaraH" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Agregar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Modificar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Eliminar" />
        <br />
        <br />
&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div id="grilla">
        <asp:GridView ID="gvISO" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
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
    </div>
    </div>
    </form>
</body>
</html>
