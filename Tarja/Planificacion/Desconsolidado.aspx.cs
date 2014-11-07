using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Planificacion_Desconsolidado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        llenarCBTerminales();
        llenarCBCodIso();
        llenarCBNaves();
        llenarCBPOrigen();
    }

    public void llenarCBTerminales()
    {
        try
        {
            Base b = new Base();
            System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
            b.abrir(c);
            string Sql = "";
            Sql += "exec dbo.PROSELECTAGENCIAS ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.cbTerminal.DataSource = ds;
            this.cbTerminal.DataValueField = "age_cod";
            this.cbTerminal.DataTextField = "age_nom";
            this.cbTerminal.DataBind();
        }
        catch (Exception ex)
        {
        }
    }

    public void llenarCBCodIso() 
    {
        try
        {
            Base b = new Base();
            System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
            b.abrir(c);
            string Sql = "";
            Sql += "select iso_cod as codigo from iso_codes ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.cbIso.DataSource = ds;
            this.cbIso.DataValueField = "codigo";
            this.cbIso.DataTextField = "codigo";
            this.cbIso.DataBind();
        }
        catch (Exception ex)
        {
        }
    }
    public void llenarCBNaves() 
    {
        try
        {
            Base b = new Base();
            System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
            b.abrir(c);
            string Sql = "";
            Sql += "select nav_nom as nombre, nav_cod as codigo from naves";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.cbNaves.DataSource = ds;
            this.cbNaves.DataValueField = "codigo";
            this.cbNaves.DataTextField = "nombre";
            this.cbNaves.DataBind();
                
        }
        catch (Exception ex)
        {
            txtMani.Text = ("Error: " + ex.ToString());
        }
    }
    public void llenarCBPOrigen(){
        try
        {
            Base b = new Base();
            System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
            b.abrir(c);
            string Sql = "";
            Sql += "select pue_nom as nombre, pue_cod as codigo from puertos";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.cbPOrigen.DataSource = ds;
            this.cbPOrigen.DataValueField = "codigo";
            this.cbPOrigen.DataTextField = "nombre";
            this.cbPOrigen.DataBind();

        }
        catch (Exception ex)
        {
            txtMani.Text = ("Error: " + ex.ToString());
        }
    }
}