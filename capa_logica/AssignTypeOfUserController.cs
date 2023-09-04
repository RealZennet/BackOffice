using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class AssignTypeOfUserController
    {

        public static void Crear(string username)
        {
            AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
            user.UserName = username;
            user.Save();
        }

        public static DataTable Obtener()
        {
            AssignTypeOfUserTruckerModel UserTableModel = new AssignTypeOfUserTruckerModel();
            List<AssignTypeOfUserTruckerModel> users = UserTableModel.GetAllTruckersUsers();

            DataTable table = new DataTable();
            table.Columns.Add("Nombre de usuario", typeof(string));


            foreach (AssignTypeOfUserTruckerModel user in users)
            {
                DataRow row = table.NewRow();
                row["Nombre de usuario"] = user.UserName;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(string username)
        {
            AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
            user.UserName = username;
            user.DeleteUser();
        }

    }
}
