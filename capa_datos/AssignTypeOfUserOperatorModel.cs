using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignTypeOfUserOperatorModel : DataBaseControl
    {

        public string UserName { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO operario (username) VALUES (" +
                $"'{this.UserName}')";
            this.Command.ExecuteNonQuery();
        }

        public List<AssignTypeOfUserOperatorModel> GetAllOperatorsUsers()
        {
            this.Command.CommandText = $"SELECT * FROM operario";
            this.Reader = this.Command.ExecuteReader();

            List<AssignTypeOfUserOperatorModel> result = new List<AssignTypeOfUserOperatorModel>();
            while (this.Reader.Read())
            {
                AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
                user.UserName = this.Reader["username"].ToString();
                result.Add(user);
            }
            return result;
        }


        public void DeleteUser()
        {
            this.Command.CommandText = $"DELETE FROM operario where username = '{this.UserName}'";
            this.Command.ExecuteNonQuery();
        }
    }
}
