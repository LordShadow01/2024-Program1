using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Torres_Anibal_Parcial
{
    class ConexionDB
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet bs = new DataSet();

        public ConexionDB()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            Conexion.ConnectionString = cadena;
            Conexion.Open();
        }
        public DataSet Obtener_datos()
        {
            bs.Clear();
            comandosSQL.Connection = Conexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "clientes");

            return bs;
        }

        public void movimiento_clientes(String[] datos , String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql ="insert into clientes(nombre,direccion,telefono,dui) values (" +
                    "'"+ datos[1]+"',"+
                    "'"+ datos[2]+"',"+
                    "'"+ datos[3]+"',"+
                    "'"+ datos[4]+"'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update clientes set " +
                    "nombre ='"             + datos[1] + "'," +
                    "direccion='"           + datos[2] + "'," +
                    "telefono='"            + datos[3] + "'," +
                    "dui='"                 + datos[4] + "'" +
                    "where idcliente ='"    + datos[0] + "'";
            }
            else if (accion== "Eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idcliente='" + datos[0] + "'";
            } 
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = Conexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }

}
