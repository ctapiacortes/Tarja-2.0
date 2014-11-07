using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Gruas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarGrilla();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);

    }

    public void cargarGrilla()
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "select grua_cod as Código, patente as Patente, marcamod 'Marca/Modelo', prop_rut 'Rut Propietario' from gruas";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvGruas.DataSource = dt;
        gvGruas.DataBind();
        c.Close();
    }
}