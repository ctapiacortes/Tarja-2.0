using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Puertos : System.Web.UI.Page
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
        sql += "select pue_cod as codigo, pue_nom as nombre from puertos";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvPuertos.DataSource = dt;
        gvPuertos.DataBind();
        c.Close();

    }



    protected void btnAgregar_Click(object sender, EventArgs e)
    {

        string codigo = txtCodPue.Text;
        string nombre = txtNomPue.Text;
        ppal.procPuertos(1, codigo, nombre);
        cargarGrilla();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        string codigo = txtCodPue.Text;
        string nombre = txtNomPue.Text;
        ppal.procPuertos(2, codigo, nombre);
        cargarGrilla();
    }
    protected void gvNaves_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gvPuertos.Rows[Convert.ToInt32(gvPuertos.SelectedIndex)];

        txtNomPue.Text = Convert.ToString(row.Cells[1].Text);
        txtCodPue.Text = Convert.ToString(row.Cells[0].Text);
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
            e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(this.gvPuertos, "Select$" + e.Row.RowIndex.ToString());
        }
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        b.abrir(con);
        string codigo = txtCodPue.Text;
        string nombre = txtNomPue.Text;
        ppal.procPuertos(3,codigo,nombre);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SPbuscarNaves";

    }
}


