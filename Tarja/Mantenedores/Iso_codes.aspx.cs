using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Iso_codes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarGrilla();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Principal princip = new Principal();
        string codigo=Convert.ToString(txtCodigos.Text);
        string nombre=Convert.ToString(txtDesc.Text);
        int tarad = Convert.ToInt32(txtTaraD.Text);
        int tarah = Convert.ToInt32(txtTaraH.Text);
        princip.insertarIsos(codigo, nombre, tarad, tarah);
    }

    public void cargarGrilla() {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "select iso_cod as 'Codigo ISO', iso_nom as Descripcion, iso_tarad as 'Tara Desde', iso_tarah as 'Tara Hasta' from iso_codes ";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvISO.DataSource = dt;
        gvISO.DataBind();
        c.Close();
    }
}