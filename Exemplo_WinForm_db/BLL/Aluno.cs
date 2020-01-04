using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace BLL
{
    public class Aluno : DTO_Aluno
    {
        public void FpuInsert(DTO_Aluno aluno)
        {
            string Insert = "Insert into tb_Aluno (ID, Nome, Escola) values (@matricula, @nome, @nome_escola)";
            if(!(aluno is null))
            {
                FprSqlMetodo(aluno, Insert);
            }
        }
        public void FpuUpdate(DTO_Aluno aluno)
        {
            string Update = "Update tb_Aluno set ID = @matricula, Nome = @nome, Escola = @nome_escola where ID == @id";
            if (!(aluno is null))
            {
                FprSqlMetodo(aluno, Update);
            }
        }
        public void FpuDelete(DTO_Aluno aluno)
        {
            string Delete = "Delete from tb_Aluno where ID == @id";
            if (!(aluno is null))
            {
                FprSqlMetodo(aluno, Delete);
            }
        }
        private void FprSqlMetodo(DTO_Aluno aluno, string str_Command)
        {
            using (SqlConnection sqlConnection = new DTO.ConexaoSQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@nome", aluno.str_Nome);
                    _ = sqlCommand.Parameters.AddWithValue("@matricula", aluno.dec_Matriula);
                    _ = sqlCommand.Parameters.AddWithValue("@nome_escola", aluno.str_Nome_Escola);

                    _ = sqlCommand.CommandText = str_Command;

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
