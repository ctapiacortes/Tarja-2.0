using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Naves : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarGrilla();
    }

    //instanciamos clases
    Principal ppal = new Principal();
    Base b = new Base();


    private void cargarGrilla()
    {

        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SPSelectNaves";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvNaves.DataSource = dt;
        gvNaves.DataBind();
        c.Close();

    }



    protected void btnAgregar_Click(object sender, EventArgs e)
    {

        string codigo = txtCodNave.Text;
        string nombre = txtNomNave.Text;
        ppal.procNaves(1, codigo, nombre);
        cargarGrilla();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        string codigo = txtCodNave.Text;
        string nombre = txtNomNave.Text;
        ppal.procNaves(2, codigo, nombre);
        cargarGrilla();
    }
    protected void gvNaves_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gvNaves.Rows[Convert.ToInt32(gvNaves.SelectedIndex)];

        txtNomNave.Text = Convert.ToString(row.Cells[1].Text);
        txtCodNave.Text = Convert.ToString(row.Cells[0].Text);
    }
    protected void gvNaves_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Pager)
        {
            //bla bla bla
        }
        else if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //APLICA ESTILOS A EVENTOS ON MOUSE OVER Y OUT
            e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);");
            e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);");
            //este es el atributio que hace marcar la fila 
            e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(this.gvNaves, "Select$" + e.Row.RowIndex.ToString());
        }
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        b.abrir(con);
        string codigo = txtCodNave.Text;
        string nombre = txtNomNave.Text;
        ppal.procNaves(3,codigo,nombre);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SPbuscarNaves";

    }
}


