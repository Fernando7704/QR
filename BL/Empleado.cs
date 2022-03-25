using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace BL
{
    public class Empleado
    {
        public static ML.Result GetAll()
        {
            
            ML.Result result = new ML.Result();
            try
            {
                using (MySqlConnection con = new MySqlConnection(DL.Conexion.Connection()))
                {
                    con.Open();
                    string sql = "SELECT * FROM entrada";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    //int numberOfResults = dt.Rows.Count;
                    //while (rdr.Read())
                    //{
                    if (dt.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (DataRow row in dt.Rows)
                        {
                            ML.Entrada entrada = new ML.Entrada();
                            entrada.IdEntrada = Convert.ToInt16(row["IdEntrada"]);
                            entrada.Descripcion = row["Descripcion"].ToString();
                            result.Objects.Add(entrada);
                        }
                        result.validacion = true;
                    }else
                    {
                        result.validacion = false;
                        result.Message = "No hay registro alguno";
                    }
                    
                      
                    //}
                    rdr.Close();
                }
            }
            catch(Exception ex)
            {
                result.validacion = false;
                result.Message = ex.Message;
            }
            return result;
           
        }

    }
}
