using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Forwarders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarForwarders();
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {

    }

    public void cargarForwarders(){

        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql ="";
        sql += "select prov_rut as Rut, prov_dv as DV, prov_razon as Razon, prov_pass as Password, prov_fono1 as Fono, prov_email as EMail";
        sql += " from rut";
        System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvForwarders.DataSource = dt;
        gvForwarders.DataBind();
        c.Close();

    }
    protected void txtRut_TextChanged(object sender, EventArgs e)
    {

    }
}