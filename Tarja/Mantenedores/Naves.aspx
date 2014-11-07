<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="Naves.aspx.cs" Inherits="Mantenedores_Naves" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarja Funciones</title>
    <script type="texdt/javascript">
        function Resaltar_On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#819FF7";
            }
        }

        function Resaltar_Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
            }
        }
       </script>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodNave" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNomNave" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
            onclick="btnAgregar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnModificar" runat="server" Text="Modificar" 
            onclick="btnModificar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" 
            onclick="btnEliminar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Buscar" onclick="Button1_Click" />
    </p>
    <p>
        <asp:GridView ID="gvNaves" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" onrowdatabound="gvNaves_RowDataBound" 
            onselectedindexchanged="gvNaves_SelectedIndexChanged">
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
    <p>
        &nbsp;</p>
    <div>
    
    </div>
    </form>
</body>
</html>
