using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class clases_Default : System.Web.UI.Page
{
    Principal princip = new Principal();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            this.llenarCBFunciones();
            //this.CBFunciones.Items.Insert(0,new ListItem("Seleccionar"));
            this.llenarCBAgencias();
            //this.CBAgencia.Items.Insert(0, new ListItem("Seleccionar"));
            this.llenargvPersonas();
            this.txtRut.Attributes.Add("onblur", this.Page.ClientScript.GetPostBackEventReference(this.lblValidacion, "Validado po choro"));
        }

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ValidaCampos() == true)
        {

        }
        else
        {
            try
            {
                int rut = Convert.ToInt32(txtRut.Text);
                int func = 0;
                func = Convert.ToInt32(CBFunciones2.SelectedValue);
                int codage = Convert.ToInt32(CBAgencia.SelectedValue);
                string dv = txtDV.Text;
                string nombre = txtNombre.Text;
                string pass = txtPass.Text;
                princip.agregarpersonas(rut, dv, nombre, func, pass, codage);
            }
            catch (Exception ex)
            {
                lblValidacion.Text=("Ha ocurrido el siguiente error"+ ex.ToString());
            }
        }
    }

    //valida que los campos no estén vacios
    public Boolean ValidaCampos()
    {
        bool retorno = false;
        if (this.txtDV.Text.Length == 0)
        {
            this.lblValidacion.Text = "Falta el digito verificador";
            retorno = true;
        }
        else if (this.CBFunciones2.SelectedItem.ToString().Equals("0"))
        {
            this.lblValidacion.Text = "Seleccione una función";
        }
        else if (this.txtNombre.Text.Length == 0)
        {
            this.lblValidacion.Text = "Ingrese su nombre";
        }
        else if (this.txtPass.Text.Length==0){
            this.lblValidacion.Text="Ingrese su contraseña";
        }
        else if(this.txtRut.Text.Length==0){
            this.lblValidacion.Text="Ingrese el rut, por favor";
        }
        return retorno;

    }

    public void llenarCBFunciones()
    {
        try
        {
            Base b = new Base();
            System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
            b.abrir(c);
            string Sql = "";
            Sql += " exec dbo.SELECTFUNCIONES ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, c);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            this.CBFunciones2.DataSource = ds;
            this.CBFunciones2.DataValueField = "codigo";
            this.CBFunciones2.DataTextField = "nombre";
            this.CBFunciones2.DataBind();
            b.Cerrar(c);
        }
        catch (Exception e)
        {
            throw new Exception("Ha ocurrido el siguiente error: "+ e.ToString() );
        }


    }

    public void llenarCBAgencias()
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
            this.CBAgencia.DataSource = ds;
            this.CBAgencia.DataValueField = "age_cod";
            this.CBAgencia.DataTextField = "age_nom";
            this.CBAgencia.DataBind();
        }
        catch (Exception ex)
        {
            throw new Exception("Ha ocurrido el siguiente error: " + ex.ToString());
        }
    }

    public void llenargvPersonas()
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += " exec SPSelectPersonas";
        SqlCommand com = new SqlCommand(sql, c);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvPersonas.DataSource = dt;
        gvPersonas.DataBind();
        c.Close();
    }

    public bool validarRut(string rut)
    {

        bool validacion = false;
        try
        {
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
        }
        catch (Exception)
        {
        }
        return validacion;
    }
    protected void txtRut_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtDV_TextChanged(object sender, EventArgs e)
    {
        string rutcompleto = txtRut.Text + txtDV.Text;

        if (validarRut(rutcompleto) == false)
        {
            lblValidacion.Text = "rut mal escrito";
        }
        else
        {
            lblValidacion.Text = "Muy bien";
        }
    }
}