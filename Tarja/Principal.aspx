<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.master" AutoEventWireup="true"
    CodeFile="Principal.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <h3 class="page-title">
        Página Principal <small>Sistema Tarja 2.0</small>
    </h3>
    <div class="page-bar">
        <ul class="page-breadcrumb">
            <li><i class="fa fa-home"></i><a href="Principal.aspx">Home</a> <i class="fa fa-angle-right">
            </i></li>
            <li><a href="#">Pagina Principal</a> <i class="fa  fa-database"></i></li>
        </ul>
    </div>
    <div class="row">
        <div class="col-md-6">
            <!-- BEGIN SAMPLE TABLE PORTLET-->
            <div class="portlet box blue-steel">
                <div class="portlet-title">
                    <div class="caption">
                        Estados Tarja Desconsolidado</div>
                </div>
                <div class="portlet-body">
                    <div class="table-scrollable">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gvTarja" runat="server" CellPadding="4" GridLines="None" HorizontalAlign="Center"
                                    OnRowDataBound="gvTarja_RowDataBound" ShowFooter="true" 
                                    CssClass="table table-bordered table-hover" PageIndex="2" PageSize="2">
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <!-- END SAMPLE TABLE PORTLET-->
        </div>
        <div class="col-md-6">
            <!-- BEGIN SAMPLE TABLE PORTLET-->
            <div class="portlet box blue-steel">
                <div class="portlet-title">
                    <div class="caption">
                        Estados Tarja Consolidado</div>
                </div>
                <div class="portlet-body">
                    <div class="table-scrollable">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="GridView1" runat="server">
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <!-- END SAMPLE TABLE PORTLET-->
        </div>
    </div>
</asp:Content>
