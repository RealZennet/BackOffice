using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class AssignTypeOfUserTruckerController
    {

        public static void Crear(int id)
        {
            AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
            user.IDTrucker = id;
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
                row["Nombre de usuario"] = user.IDTrucker;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(int id)
        {
            AssignTypeOfUserTruckerModel user = new AssignTypeOfUserTruckerModel();
            user.IDTrucker = id;
            user.DeleteUser();
        }

    }
}
