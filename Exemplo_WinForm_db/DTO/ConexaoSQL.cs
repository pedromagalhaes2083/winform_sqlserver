using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class ConexaoSQL
    {
        public SqlConnection Conectar
        {
            get
            {
                string NomeBanco = "Banco";
                return new SqlConnection($@"Data Source={Environment.MachineName}\SQLEXPRESS;Initial Catalog=  {NomeBanco} ; Integrated Security = True; Pooling= False;  MultipleActiveResultSets = true ");
            }
        }
    }
}
