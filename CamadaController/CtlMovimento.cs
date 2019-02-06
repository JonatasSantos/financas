using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CamadaController
{
    class CtlMovimento
    {
        public Movimento _movimento = new Movimento();
        public string connectionString = ConfigurationManager.ConnectionStrings["db_FinancasConnectionString"].ConnectionString;
        public SqlConnection _sqlConnection;
        public SqlCommand _sqlCommand;
        public string query;
        public SqlDataReader reader;
        public List<Movimento> movimentos;

        public Movimento[] getMovimentos(int tipoMovimento)
        {
            query = @"SELECT ID_MOVIMENTO, TITULO_MOVIMENTO AS Título, DATA_MOVIMENTO AS Data, ID_TIPO_MOVIMENTO AS Tipo, VALOR AS Valor, OBSERVACOES
                AS OBS FROM TB_MOVIMENTOS WHERE ID_TIPO_MOVIMENTO = " + tipoMovimento;
            


            using (_sqlConnection = new SqlConnection(connectionString))
            {
                _sqlConnection.Open();

                using(_sqlCommand = new SqlCommand(query, _sqlConnection))
                {
                    reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        movimentos.Add(new Movimento
                        {
                            movimentos.id;
                        });
                    }
                    
                    
                }
            }
        }

    }
}
