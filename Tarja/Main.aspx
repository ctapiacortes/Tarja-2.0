<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>

    <form id="form1" runat="server">

    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </p>
        <div id="body">
            <div id="cabecera">
                <img alt="logo saam" src="Imagenes/Logo_saam.jpg"  height="150px" width="900px"/>
            </div>
            <div id="barraMenu">
                
            </div>
            <div id="izquierda">
            <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblPermiso" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnSalir" runat="server" Text="Salir"/>
            </div>
            <div id="medio">
                            <br />
                                        <asp:Button ID="Button11" runat="server" onclick="Button11_Click" 
                                Text="Actualizar" />
                                        <br />
                                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                            <ContentTemplate>
<br />
                                                                <asp:GridView ID="gvTarja" runat="server" CellPadding="4" ForeColor="#333333" 
                                                                    GridLines="None" HorizontalAlign="Center" onrowdatabound="gvTarja_RowDataBound" 
                                                                    ShowFooter="true" style="margin-top: 0px">
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
<br />
<br />
<br />
<br />
                                                            </ContentTemplate>
                            </asp:UpdatePanel>
                                                        <br />
            </div>
            <div id="derecha">
                <h2>Mantenedores</h2>
                <br />
                <table style="width: 99%; height: 267px;">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Agencia" Width="109px" 
                                onclick="Button1_Click" />&nbsp;</td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Funciones" Width="109px" 
                                onclick="Button2_Click" />&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="Personas" onclick="Button3_Click" 
                                Width="109px" />&nbsp;</td>
                        <td>
                            <asp:Button ID="Button4" runat="server" Text="Codigos ISO" 
                                onclick="Button4_Click" />&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button5" runat="server" Text="Puertos" Width="109px" 
                                onclick="Button5_Click" />&nbsp;</td>
                        <td>
                            <asp:Button ID="Button6" runat="server" Text="Clientes" Width="109px" 
                                onclick="Button6_Click" />&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button7" runat="server" Text="Gruas" Width="109px" 
                                onclick="Button7_Click" />&nbsp;</td>
                        <td>
                            <asp:Button ID="Button8" runat="server" Text="Naves" Width="109px" 
                                onclick="Button8_Click" style="height: 26px" />&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button9" runat="server" Text="Propietarios" Width="109px" 
                                onclick="Button9_Click" />&nbsp;</td>
                        <td>
                            <asp:Button ID="Button10" runat="server" Text="Bultos" Width="109px" 
                                onclick="Button10_Click" />&nbsp;</td>
                    </tr>
                </table>
                <br />
&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
            </div>
            <div id="footer">
            </div>
        </div>
    </form>
</body>
</html>
