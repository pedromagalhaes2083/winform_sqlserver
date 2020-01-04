using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace BLL
{
    public class SqlChamadas
    {
        private static DataTable RetornarGrid(string sql)
        {

            using (SqlConnection sqlConnection = new DTO.ConexaoSQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();
                    sqlCommand.CommandText = sql;

                    SqlDataAdapter SDP = new SqlDataAdapter(sqlCommand);
                        DataTable RTB = new DataTable();
                       SDP.Fill(RTB);
                       sqlConnection.Close();
                       return RTB;
                }
            }
        }

        public static DataTable RetornarTable()
        {
            string Select = "Select ID, Nome, Escola from tb_Aluno";
            return RetornarGrid(Select);
        }
    }
}
