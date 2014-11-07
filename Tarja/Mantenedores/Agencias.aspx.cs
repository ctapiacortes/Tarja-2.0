using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Agencias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) {
            this.cargarGrilla();
        }
    }
    Principal pri = new Principal();
    Base b = new Base();
    SqlConnection c = new SqlConnection();
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(txtCodigo.Text);
        string nombre = txtNombre.Text;
        pri.procAgencias(1, codigo, nombre);
        Response.Redirect("Agencias.aspx");
    }

    private void cargarGrilla()
    {
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SPSelectAgencias";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvAgencias.DataSource = dt;
        gvAgencias.DataBind();
        c.Close();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(txtCodigo.Text);
        string nombre = txtNombre.Text;
        pri.procAgencias(2, codigo, nombre);
        Response.Redirect("Agencias.aspx");
    }
}