using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarGrilla1();
        string nombresesion = (string)(Session["nombreDeUsuario"]);
        string permisos = (string)(Session["funcionUsuario"]);
    }


    public void cargarGrilla1()
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SPTarjas";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvTarja.DataSource = dt;
        gvTarja.DataBind();
        c.Close();
    }


    protected void btnMantPersonas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Personas.aspx");
    }
    protected void btnAgencias_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Agencias.aspx");
    }
    protected void btnFunciones_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Funciones.aspx");
    }

    int total = 0;
    int total1 = 0;
    protected void gvTarja_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowType != DataControlRowType.EmptyDataRow))
        {
            total += Convert.ToInt32(e.Row.Cells[1].Text);
            total1 += Convert.ToInt32(e.Row.Cells[2].Text);
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            e.Row.Cells[0].Text = "Totales";

            e.Row.Cells[1].Text = Convert.ToString(total);
            e.Row.Cells[2].Text = Convert.ToString(total1);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Personas.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Agencias.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Funciones.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Iso_codes.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Puertos.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Forwarders.aspx");
    }


    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Gruas.aspx");
    }


    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Naves.aspx");
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Mantenedores/Propietarios.aspx");
    }


    protected void Button10_Click(object sender, EventArgs e)
    {

    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        cargarGrilla1();
    }
}