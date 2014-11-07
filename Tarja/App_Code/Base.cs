using Microsoft.VisualBasic ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Diagnostics;
 

/// <summary>
/// Descripción breve de Base
/// </summary>
public class Base
{
public void abrir(System.Data.SqlClient.SqlConnection c)
{
	try {
		//<add name="TCE_2008" connectionString="Provider=ASEOLEDB;Data Source=<MismoNombreDsEdit>;Password=<pass>;User ID=<user>;Initial Catalog=almacen_sti" providerName="System.Data.OleDb"/>
		c.ConnectionString = "Data Source={SQL Server};server='" + @"(LOCAL)\SQLEXPRESS2" + "';database='" + "desconsolidado" + "';uid='" + "SA" + "';pwd='" + "SAAM2014" + "'";
		//c.ConnectionString = "Provider=ASEOLEDB;Data Source='" & servidorBD & "';Password='" & claveBD & "';User ID='" & usuarioBD & ";Initial Catalog=almacen_sti; providerName=System.Data.OleDb;"
		//var con = new OleDbConnection(ConfigurationManager.ConnectionStrings["TCE_2008"].ConnectionString)
		c.Open();

	} catch (Exception ex) {
	}
}
    public void Cerrar(System.Data.SqlClient.SqlConnection c)
{
	try {
		c.Close();
        	} catch (Exception ex) {
	}
}
}
 