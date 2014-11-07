using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient ;
using System.IO;

public partial class clases_Inicio : System.Web.UI.Page
{
    Principal princip = new Principal();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string resultado, permiso;
        resultado = (String)princip.MostrarNombre(txtCodigoUs.Text);
        permiso = (String)princip.MostrarPermiso(txtCodigoUs.Text);
        lblNombreUsuario.Text = resultado;
        lblPermiso.Text = permiso;
        Boolean existe;
           existe = princip.UsuarioExiste(txtCodigoUs.Text, txtPass.Text);
        if (existe)
        {
            if (lblPermiso.Text.Equals("Administrador"))
            {
                HttpContext.Current.Session["nombreDeUsuario"] = lblNombreUsuario.Text;
                HttpContext.Current.Session["funcionUsuario"]=lblPermiso.Text;
                Response.Redirect("Principal.aspx");
            }
        }
       else
       {
            lblAviso.Text = "Nombre de Usuario o Contraseña Incorrectos";
        }
         
    }
}