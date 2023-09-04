using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignTypeOfUserTruckerModel : DataBaseControl
    {
        public string UserName { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO camionero (username) VALUES (" +
                $"'{this.UserName}')";
            this.Command.ExecuteNonQuery();
        }

        public List<AssignTypeOfUserTruckerModel> GetAllTruckersUsers()
        {
            this.Command.CommandText = $"SELECT * FROM camionero";
            this.Reader = this.Command.ExecuteReader();

            List<AssignTypeOfUserTruckerModel> result = new List<AssignTypeOfUserTruckerModel>();
            while (this.Reader.Read())
            {
                AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
                user.UserName = this.Reader["username"].ToString();
                result.Add(user);
            }
            return result;
        }


        public void DeleteUser()
        {
            this.Command.CommandText = $"DELETE FROM camionero where username = {this.UserName}";
            this.Command.ExecuteNonQuery();
        }
    }
}
