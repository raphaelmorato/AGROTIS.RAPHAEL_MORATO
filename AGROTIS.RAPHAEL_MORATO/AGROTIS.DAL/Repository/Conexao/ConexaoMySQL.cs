using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Conexao
{
    public class ConexaoMySQL<T> : IConexaoBanco<T>
    {
        private readonly string _conexao;
        public ConexaoMySQL()
        {
            _conexao = AppConnection.ConnectionString;
        }
        private MySqlConnection connection { get; set; }
        public DbConnection Connection
        {
            get
            {
                return connection;
            }
            set
            {
                connection = (MySqlConnection)value;
            }
        }

        public void Conecta()
        {
            int tentativa = 3;

            do
            {
                try
                {
                    if (Connection == null)
                    {
                        Connection = new MySqlConnection(_conexao);
                    }
                    if (Connection.State != ConnectionState.Open)
                    {
                        Connection.Open();

                        if (Connection.State == ConnectionState.Open)
                        {
                            tentativa = 0;
                        }
                        else
                        {
                            tentativa--;
                            Thread.Sleep(10);
                        }
                    }
                    else
                    {
                        tentativa = 0;
                    }
                }
                catch (Exception ex)
                {
                    Connection = null;
                    tentativa--;
                    Thread.Sleep(10);
                }

            } while (tentativa != 0);


        }

        public void ComandoTransaction(object obj, string cmd)
        {
            Conecta();
            using (MySqlTransaction tran = (MySqlTransaction)Connection.BeginTransaction())
            {
                try
                {
                    Connection.Execute(cmd, obj, tran);
                    tran.Commit();
                }
                catch (MySqlException ex)
                {
                    tran.Rollback();
                    throw new Exception("Erro ao inserir o dado.", ex);
                }
            }
        }

        public int ComandoTransactionID(object obj, string cmd)
        {
            int id = 0;
            Conecta();
            using (MySqlTransaction tran = (MySqlTransaction)Connection.BeginTransaction())
            {
                try
                {
                    Connection.Execute(cmd, obj, tran);
                    id = Connection.Query<int>("SELECT LAST_INSERT_ID()", transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (MySqlException ex)
                {
                    tran.Rollback();
                    throw new Exception("Erro ao inserir o dado.", ex);
                }
            }
            return id;
        }

        public IEnumerable<T> Consulta(string consulta, object obj = null)
        {
            Conecta();
            return Connection.Query<T>(consulta, param: obj, commandType: CommandType.Text);
        }
    }
}
