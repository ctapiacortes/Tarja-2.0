<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Desconsolidado.aspx.cs" Inherits="Planificacion_Desconsolidado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" />
&nbsp;
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
        <br />
        <br />
        <asp:Label ID="lblManif" runat="server" Text="Manifiesto"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMani" runat="server" Width="205px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Terminal"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="cbTerminal" runat="server" Height="16px" Width="150px">
        </asp:DropDownList>
        <br />
        Nave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:DropDownList ID="cbNaves" runat="server" Height="27px" Width="272px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Viaje&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="106px"></asp:TextBox>
        <br />
        Puerto de Origen&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cbPOrigen" runat="server" Height="21px" Width="273px">
        </asp:DropDownList>
        <br />
        Puerto de Destino&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cbPDestino" runat="server" Height="34px" Width="272px">
            <asp:ListItem>Seleccione</asp:ListItem>
            <asp:ListItem Value="PAQ">Placilla, Chile</asp:ListItem>
            <asp:ListItem Value="SAI">San Antonio, Chile</asp:ListItem>
        </asp:DropDownList>
        <br />
       Cliente&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cbClientes" runat="server" Height="31px" Width="270px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chKclienteNuevo" runat="server" Text="Cliente Nuevo" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Rut Cliente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="24px" 
            style="margin-left: 3px" Width="152px"></asp:TextBox>
&nbsp;-
        <asp:TextBox ID="TextBox4" runat="server" Width="20px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Razón Social"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="20px" Width="196px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Contenedor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Width="193px"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Código ISO"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="cbIso" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblSello1" runat="server" Text="Sello 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Width="202px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Sello 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Sello 3"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Width="200px"></asp:TextBox>
        <br />
    
    </div>
    </form>
</body>
</html>
