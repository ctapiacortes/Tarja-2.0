using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Mantenedores_Funciones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false){
        this.llenarcbPermisos();
        this.cargarGrilla();
        }
    }

    Principal pri = new Principal();
    Base b = new Base();
    System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();

    public void llenarcbPermisos()
    {
        //string sql = "";
        try
        {
            
            b.abrir(c);
            string Sql = "";
            Sql += " exec dbo.SPSelectPermisos ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.cbFPermisos.DataSource = ds;
            this.cbFPermisos.DataValueField = "codigo";
            this.cbFPermisos.DataTextField = "nombre";
            this.cbFPermisos.DataBind();
            b.Cerrar(c);
        }
        catch (Exception e)
        {
            throw new Exception("Ha ocurrido el siguiente error: " + e.ToString());
        }
    }

    private void cargarGrilla()
    {
        b.abrir(c);
        string sql = "";
        sql += "exec dbo.SELECTFUNCIONES";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvFunciones.DataSource = dt;
        gvFunciones.DataBind();
        c.Close();

    }



    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        string fnombre = txtNomFun.Text;
        int pcodigo = Convert.ToInt32(cbFPermisos.SelectedValue);
        pri.AgregarFunciones(fnombre, pcodigo);
        LimpiarCampos();
        cargarGrilla();
    }
    protected void gvFunciones_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = gvFunciones.Rows[Convert.ToInt32(gvFunciones.SelectedIndex)];

        txtNomFun.Text = Convert.ToString(row.Cells[1].Text);
        cbFPermisos.SelectedIndex = (Convert.ToInt32(row.Cells[2].Text)-1);
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        GridViewRow row = gvFunciones.Rows[Convert.ToInt32(gvFunciones.SelectedIndex)];

        int codigo = Convert.ToInt32(row.Cells[1].Text);
        pri.eliminarFunciones(codigo);
        cargarGrilla();
        
    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        GridViewRow row = gvFunciones.Rows[Convert.ToInt32(gvFunciones.SelectedIndex)];

        int codigo = Convert.ToInt32(row.Cells[1].Text);
        string nombre = txtNomFun.Text;
        int pcodigo = Convert.ToInt32(cbFPermisos.SelectedValue);
        pri.modificarFunciones(codigo, nombre, pcodigo);
        LimpiarCampos();
        cargarGrilla();
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Main.aspx");
    }

    public void LimpiarCampos()
    {
        this.txtNomFun.Text = "";
        this.cbFPermisos.SelectedItem.Text="Administrador";
    }


    public void gvFunciones_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
{
	if (e.Row.RowType == DataControlRowType.Pager) {
	//bla bla bla
	} else if (e.Row.RowType == DataControlRowType.DataRow) {
		//APLICA ESTILOS A EVENTOS ON MOUSE OVER Y OUT
		e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);");
		e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);");
		//este es el atributio que hace marcar la fila 
		e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(this.gvFunciones, "Select$" + e.Row.RowIndex.ToString());
	}

}


    protected void txtNomFun_TextChanged(object sender, EventArgs e)
    {

    }
}
