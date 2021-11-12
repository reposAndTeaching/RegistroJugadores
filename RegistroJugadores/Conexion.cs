using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroJugadores
{
    class Conexion
    {
        private string server;
        private string catalog;
        private string user;
        private string pass;
        private SqlConnectionStringBuilder stringBuilder;

        public Conexion(string server, string catalog)
        {
            stringBuilder = new SqlConnectionStringBuilder();
            this.stringBuilder.DataSource = server;
            this.stringBuilder.InitialCatalog = catalog;
            this.stringBuilder.IntegratedSecurity = true;
        }

        public SqlConnectionStringBuilder StringBuilder { get => stringBuilder; }
    }
}
