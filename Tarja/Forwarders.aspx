<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true"
    CodeFile="Forwarders.aspx.cs" Inherits="_Forwarders" %>

<script runat="server">
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 class="page-title">
        Forwarders <small>Sistema Tarja 2.0</small>
    </h3>
    <div class="page-bar">
        <ul class="page-breadcrumb">
            <li><i class="fa fa-home"></i><a href="principal.aspx">Home</a> <i class="fa fa-angle-right">
            </i></li>
            <li><a href="#">Mantenedores</a> <i class="fa  fa-database"></i></li>
        </ul>
    </div>
    <div class="row">
        <div class="col-md-6">
            <!-- BEGIN SAMPLE TABLE PORTLET-->
            <div class="portlet box blue-steel">
                <div class="portlet-title">
                    <div class="caption">
                        Formulario
                    </div>
                </div>
                <div class="portlet-body form">
                    <form role="form">
                    <div class="form-body">

                        <%--<div class="form-group">
                            <label>
                                Rut</label>
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="txtRut" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>--%>
                        <div class="form-group">
                            <label for="exampleInputPassword1">
                                Razon Social</label>
                            <div class="input-icon right">
                                <i class="fa fa-user"></i>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>
                                Password</label>
                            <div class="input-icon right">
                                <i class="fa icon-key"></i>
                                <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>
                                Telefono</label>
                            <div class="input-icon right">
                                <i class="fa icon-call-end"></i>
                                <asp:TextBox ID="txtFono" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>
                                Email</label>
                            <div class="input-icon right">
                                <i class="fa fa-envelope"></i>
                                <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <!-- BEGIN SAMPLE TABLE PORTLET-->
            <div class="portlet box blue-steel">
                <div class="portlet-title">
                    <div class="caption">
                        Listado
                    </div>
                </div>
                <div class="portlet-body form">
                    <div class="table-responsive">
                        <contenttemplate>
                                <asp:GridView ID="gvForwarders" runat="server" CellPadding="4" GridLines="None"
                                    HorizontalAlign="Center" CssClass="table table-bordered table-hover">
                                </asp:GridView>
                            </contenttemplate>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
