using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capa_datos
{
    public abstract class DataBaseControl
    {
        //Conexion DB - > Para mas seguridad pasar a json y deserializar ese json en esta clase para despues conectar la db
        public string dbip;
        public string dbUser;
        public string dbPassword;
        public string dbDatabaseName;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader Reader;

        public DataBaseControl()
        {
            this.dbip = "localhost";
            this.dbUser = "root";
            this.dbPassword = "zackquack";
            this.dbDatabaseName = "quickcarryapitesting";

            this.Connection = new MySqlConnection(
                $"server={this.dbip};" +
                $"user={this.dbUser};" +
                $"password={this.dbPassword};" +
                $"database={this.dbDatabaseName};");

            this.Connection.Open();
            this.Command = new MySqlCommand();
            this.Command.Connection = this.Connection;
        }

    }
}
