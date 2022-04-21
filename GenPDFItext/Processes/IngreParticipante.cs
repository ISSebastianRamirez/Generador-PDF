using GenPDFItext.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GenPDFItext.Processes
{
    public class IngreParticipante:BDConexion
    {
        Participantes parti = new Participantes();
        public void LimpiarTabla(string NombreProcedimiento)
        {
            SqlConnection SqlConnection = new SqlConnection(conex);
            SqlCommand sqlComando = new SqlCommand();

            sqlComando.Connection = SqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = NombreProcedimiento;
            sqlComando.CommandTimeout = 3600;

            try
            {
                sqlComando.Connection.Open();
                sqlComando.ExecuteNonQuery();
                sqlComando.Connection.Close();

       
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlComando.Connection.Close();
            }
        }
        public void IngresarParticipante(string NombreProcedimiento, string Nombre, string Cargo, string Celular, string Email)
        {
            SqlConnection SqlConnection = new SqlConnection(conex);
            SqlCommand sqlComando = new SqlCommand();

            sqlComando.Connection = SqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = NombreProcedimiento;
            sqlComando.Parameters.AddWithValue("@nombre", Nombre);
            sqlComando.Parameters.AddWithValue("@cargo", Cargo);
            sqlComando.Parameters.AddWithValue("@celular", Celular);
            sqlComando.Parameters.AddWithValue("@email", Email);
            sqlComando.CommandTimeout = 3600;

            try
            {
                sqlComando.Connection.Open();
                sqlComando.ExecuteNonQuery();
                sqlComando.Connection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlComando.Connection.Close();
            }
        }
        public void IngresarConector(string NombreProcedimiento, string conector)
        {
            SqlConnection SqlConnection = new SqlConnection(conex);
            SqlCommand sqlComando = new SqlCommand();

            sqlComando.Connection = SqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = NombreProcedimiento;
            sqlComando.Parameters.AddWithValue("@conector", conector);
            sqlComando.CommandTimeout = 3600;

            try
            {
                sqlComando.Connection.Open();
                sqlComando.ExecuteNonQuery();
                sqlComando.Connection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlComando.Connection.Close();
            }
        }
        public void IngresarConsultaERP(string NombreProcedimiento, string Consulta, string Campos, string Filtros)
        {
            SqlConnection SqlConnection = new SqlConnection(conex);
            SqlCommand sqlComando = new SqlCommand();

            sqlComando.Connection = SqlConnection;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = NombreProcedimiento;
            sqlComando.Parameters.AddWithValue("@Consulta", Consulta);
            sqlComando.Parameters.AddWithValue("@Campos", Campos);
            sqlComando.Parameters.AddWithValue("@Filtros", Filtros);
            sqlComando.CommandTimeout = 3600;

            try
            {
                sqlComando.Connection.Open();
                sqlComando.ExecuteNonQuery();
                sqlComando.Connection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlComando.Connection.Close();
            }
        }
    }
}