using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de Principal
/// </summary>
public class Principal
{

    public object MostrarPermiso(string nombre)
    {
        // Procecure Invocado desde sql
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        string retorno = null;

        try
        {
            sql += " select per.permiso as 'permiso' ";
            sql += " from permisoss per, funciones f, personas p ";
            sql += " where per.per_cod = f.per_cod and f.fun_cod=p.fun_cod and p.per_rut ='"+ nombre +"' ";

            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql, c);
            System.Data.SqlClient.SqlDataReader d = com.ExecuteReader();
            d.Read();
            if (d.HasRows )
            {
                retorno = (String)d["permiso"];
            }
            d.Close();
            com.Dispose();
            return retorno;
        }
        catch (Exception ex)
        {
            throw new Exception("Ha ocurrido un error: " +ex.ToString());
        }
        finally
        {
            b.Cerrar(c);
        }
    }

    public object MostrarNombre(string nombre)
    {
        // Procecure Invocado desde sql
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        string retorno = null;

        try
        {
            sql += " select per_nom as 'nombre' ";
            sql += " from personas ";
            sql += " where per_rut ='" + nombre + "' ";

            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql, c);
            System.Data.SqlClient.SqlDataReader d = com.ExecuteReader();
            d.Read();
            if (d.HasRows)
            {
                retorno = (String)d["nombre"];
            }
            d.Close();
            com.Dispose();
            return retorno;
        }
        catch (Exception ex)
        {
            throw new Exception("Ha ocurrido un error: " + ex.ToString());
        }
        finally
        {
            b.Cerrar(c);
        }
    }






    public Boolean UsuarioExiste(string rut, string password)
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        string sql = "";
        Boolean retorno = false;

        try
        {

            sql += "dbo.SPLogin";
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql, c);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@usuario", SqlDbType.Int);
            com.Parameters["@usuario"].Value = rut;
            com.Parameters.Add("@password", SqlDbType.NVarChar);
            com.Parameters["@password"].Value = password;
            com.ExecuteNonQuery();
            System.Data.SqlClient.SqlDataReader f = com.ExecuteReader(); 
            f.Read();
            if (f.HasRows)
            {
                retorno = true;
            }
            f.Close();
            com.Dispose();
            return retorno;
        }
        catch (Exception ex)
        {
            throw new Exception("Ha ocurrido un error: " + ex.ToString());
        }
        finally
        {
            b.Cerrar(c);
        }

        
    }

    public void agregarpersonas(int rut, string dv, string nombre, int fcod, string ppass, int agecod)
    {

        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        SqlCommand Query = new SqlCommand("dbo.SPIngresarPersonas", c);
        Query.CommandType = CommandType.StoredProcedure;

        Query.Parameters.Add("@RUT", SqlDbType.Int);
        Query.Parameters["@RUT"].Value = rut;
        Query.Parameters.Add("@DV", SqlDbType.NVarChar);
        Query.Parameters["@DV"].Value = dv;
        Query.Parameters.Add("@NOMBRE", SqlDbType.NVarChar);
        Query.Parameters["@NOMBRE"].Value = nombre;
        Query.Parameters.Add("@FUNCION", SqlDbType.Int);
        Query.Parameters["@FUNCION"].Value = fcod;
        Query.Parameters.Add("@PASSWORD", SqlDbType.NVarChar);
        Query.Parameters["@PASSWORD"].Value = ppass;
        Query.Parameters.Add("@AGENCIA", SqlDbType.Int);
        Query.Parameters["@AGENCIA"].Value = agecod;
        Query.Parameters.Add("@MENSAJE", SqlDbType.NVarChar);
        Query.Parameters["@MENSAJE"].Value = "";
        Query.ExecuteNonQuery();
        c.Close();
    }

    public void agregarNaves(string codigo, string nombre)
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new SqlConnection();
        b.abrir(c);
        SqlCommand com = new SqlCommand("dbo.INSERTARNAVES", c);
        com.CommandType = CommandType.StoredProcedure;

        com.Parameters.Add("@CODIGO", SqlDbType.NVarChar);
        com.Parameters["@CODIGO"].Value = codigo;
        com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar);
        com.Parameters["@NOMBRE"].Value = nombre;
        com.ExecuteNonQuery();
        c.Close();

    }
    public void AgregarFunciones(string nombre, int codpermiso)
    {
        Base b = new Base();
        System.Data.SqlClient.SqlConnection c = new System.Data.SqlClient.SqlConnection();
        b.abrir(c);
        SqlCommand Query = new SqlCommand("dbo.SPIngresarFunciones", c);
        Query.CommandType = CommandType.StoredProcedure;

        Query.Parameters.Add("@FNOM", SqlDbType.NVarChar);
        Query.Parameters["@FNOM"].Value = nombre;
        Query.Parameters.Add("@PCOD", SqlDbType.Int);
        Query.Parameters["@PCOD"].Value = codpermiso;
        Query.Parameters.Add("@MENSAJE", SqlDbType.NVarChar);
        Query.Parameters["@MENSAJE"].Value = "";
        Query.ExecuteNonQuery();
        c.Close();

    }

    public void eliminarFunciones(int codigo) 
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        SqlCommand Consulta = new SqlCommand("dbo.SPEliminarFunciones", c);

        Consulta.CommandType = CommandType.StoredProcedure;

        Consulta.Parameters.Add("@FCOD", SqlDbType.Int);
        Consulta.Parameters["@FCOD"].Value = codigo;
        Consulta.Parameters.Add("@MENSAJE", SqlDbType.NVarChar);
        Consulta.Parameters["@MENSAJE"].Value = " ";
        Consulta.ExecuteNonQuery();
        c.Close();
    
    }

    public void modificarFunciones(int codigo, string nombre, int codigoper)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        SqlCommand consulta = new SqlCommand("dbo.SPModificarFunciones", c);
        consulta.CommandType = CommandType.StoredProcedure;

        consulta.Parameters.Add("@FCOD", SqlDbType.Int);
        consulta.Parameters["@FCOD"].Value= codigo;
        consulta.Parameters.Add("@FNOM", SqlDbType.NVarChar);
        consulta.Parameters["@FNOM"].Value = nombre;
        consulta.Parameters.Add("@PCOD",SqlDbType.Int);
        consulta.Parameters["@PCOD"].Value = codigoper;
        consulta.Parameters.Add("@MENSAJE", SqlDbType.NVarChar);
        consulta.Parameters["@MENSAJE"].Value = "mensaje";
        try
        {
            consulta.ExecuteNonQuery();
            c.Close();
        }
        catch (Exception e){
            throw new Exception("Ha ocurrido el siguiente error " + e.ToString());
        }
    }

    public void procAgencias(int tipo, int codigo, string nombre) 
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        string proc ="";
        switch (tipo){
            case 1:
                proc = "dbo.SPIngresarAgencias";
                break;
            case 2:
                proc = "dbo.SPModificarAgencias";
                break;
            case 3:
                proc = "dbo.SPEliminarAgencias";
            break;
        }
        SqlCommand com = new SqlCommand(proc, c);
        com.CommandType = CommandType.StoredProcedure;

        com.Parameters.Add("@CODAGE", SqlDbType.Int);
        com.Parameters["@CODAGE"].Value= codigo;
        com.Parameters.Add("@AGENOM", SqlDbType.NVarChar);
        com.Parameters["@AGENOM"].Value = nombre;
        //agregamos mensaje de salida
        SqlParameter mensaje = new SqlParameter();
        mensaje.ParameterName= "@MENSAJE";
        mensaje.Size=100;
        mensaje.SqlDbType=SqlDbType.NVarChar;
        mensaje.Direction=ParameterDirection.Output;
        com.Parameters.Add(mensaje);
        try
        {
            com.ExecuteNonQuery();
            c.Close();
        }
        catch(Exception e) {
            throw new Exception("Ha ocurrido un problema: "+e.ToString());
        }
    }

    public void procNaves(int tipo, string codigo, string nombre)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);        
        SqlCommand comando = new SqlCommand("dbo.SPNaves", c);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.Add("@TIPO", SqlDbType.Int);
        comando.Parameters["@TIPO"].Value= tipo;
        comando.Parameters.Add("@CODIGO", SqlDbType.NVarChar);
        comando.Parameters["@CODIGO"].Value=codigo;
        comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar);
        comando.Parameters["@NOMBRE"].Value = nombre;
        try
        {
            comando.ExecuteNonQuery();
            c.Close();
        }catch(Exception e){
            throw new Exception("Ha ocurrido el siguiente error: " + e.ToString());   
        }
    }


    public void procPuertos(int tipo, string codigo, string nombre)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        SqlCommand comando = new SqlCommand("dbo.SPPuertos", c);
        comando.CommandType = CommandType.StoredProcedure;
        comando.Parameters.Add("@TIPO", SqlDbType.Int);
        comando.Parameters["@TIPO"].Value = tipo;
        comando.Parameters.Add("@CODIGO", SqlDbType.NVarChar);
        comando.Parameters["@CODIGO"].Value = codigo;
        comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar);
        comando.Parameters["@NOMBRE"].Value = nombre;
        try
        {
            comando.ExecuteNonQuery();
            c.Close();
        }
        catch (Exception e)
        {
            throw new Exception("Ha ocurrido el siguiente error: " + e.ToString());
        }
    }
   /* public void procAgencias(int opc, int codigo, string nombre)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        if(opc==
        SqlCommand com = new SqlCommand("dbo.SPModificarAgencias", c);
        com.CommandType = CommandType.StoredProcedure;

        com.Parameters.Add("@CODAGE", SqlDbType.Int);
        com.Parameters["@CODAGE"].Value = codigo;
        com.Parameters.Add("@AGENOM",SqlDbType.NVarChar);
        com.Parameters["@AGENOM"].Value = nombre;
        com.Parameters.Add("@MENSAJE", SqlDbType.NVarChar);
        com.Parameters["@MENSAJE"].Value = "";

    }
    */
    public void insertarIsos(string codigo, string nombre, int tarad, int tarah)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        string sql = "";
        sql += "SPInsertarISO";
        SqlCommand com = new SqlCommand(sql, c);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.Add("@CODIGO", SqlDbType.NVarChar);
        com.Parameters["@CODIGO"].Value = codigo;
        com.Parameters.Add("@NOMBRE", SqlDbType.NVarChar);
        com.Parameters["@NOMBRE"].Value=nombre;
        com.Parameters.Add("@TARAD",SqlDbType.Int);
        com.Parameters["@TARAD"].Value=tarah;
        com.Parameters.Add("@TARAH",SqlDbType.Int);
        com.Parameters["@TARAH"].Value=tarah;
        try{
        com.ExecuteNonQuery();
        c.Close();
        }
        catch(Exception e){
            throw new Exception("Ha ocurrido el siguiente error: " +e.ToString());        
        }
    }

    public void agregarGruas(int codigo, string patente, string marcamodelo, int rut)
    {
        Base b = new Base();
        SqlConnection c = new SqlConnection();
        b.abrir(c);
        string sql="dbo.SPAgregarGruas";
        SqlCommand com = new SqlCommand(sql, c);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.Add("@CODIGO", SqlDbType.Int);
        com.Parameters["@CODIGO"].Value=codigo;
        com.Parameters.Add("@PATENTE", SqlDbType.NVarChar);
        com.Parameters["@PATENTE"].Value=patente;
        com.Parameters.Add("@MARCAMOD", SqlDbType.NVarChar);
        com.Parameters["@MARCAMOD"].Value=marcamodelo;
        com.Parameters.Add("@PROP_RUT", SqlDbType.NVarChar);
        com.Parameters["@PROP_RUT"].Value=rut;
        try
        {
            com.ExecuteNonQuery();
            c.Close();
        }catch(Exception e){
            throw new Exception("Ha ocurrido un problema: " + e.ToString());
        }



    }
}