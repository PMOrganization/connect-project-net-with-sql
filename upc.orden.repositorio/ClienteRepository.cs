using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.orden.repositorio
{
    public class ClienteRepository : IClienteRepository
    {
        SqlConnection SqlCon;
        Conexion Con;

        public ClienteRepository()
        {
            Con = new Conexion();
        }

        public DataTable ReaderByDni(int dni)
        {
                SqlCon = Con.GetConexion();
                SqlCon.Open();
                SqlDataAdapter Da = new SqlDataAdapter("listClienteByDNI", SqlCon);
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.Add("@Dni", SqlDbType.Int).Value = dni;
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;
            
          
        }

        public bool Create(Cliente c)
        {
            SqlCon = Con.GetConexion();

            SqlCommand Cmd = new SqlCommand("addCliente", SqlCon);
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.AddWithValue("@nombre", c.Nombre);
            Cmd.Parameters.AddWithValue("@dni", c.Dni);

            SqlCon.Open();
            int i = Cmd.ExecuteNonQuery();
            SqlCon.Close();

            if (i >= -1)
                return true;
            else
                return false;
        }

        public DataTable Reader()
        {
            SqlCon = Con.GetConexion();
            SqlCon.Open();
            SqlDataAdapter Da = new SqlDataAdapter("listCliente", SqlCon);
            Da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

    }
}
