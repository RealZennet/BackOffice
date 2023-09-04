using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class AssignTypeOfUserOperatorController
    {

        public static void Crear(string username)
        {
            AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
            user.UserName = username;
            user.Save();
        }

        public static DataTable Obtener()
        {
            AssignTypeOfUserOperatorModel UserTableModel = new AssignTypeOfUserOperatorModel();
            List<AssignTypeOfUserOperatorModel> users = UserTableModel.GetAllOperatorsUsers();

            DataTable table = new DataTable();
            table.Columns.Add("Nombre de usuario", typeof(string));


            foreach (AssignTypeOfUserOperatorModel user in users)
            {
                DataRow row = table.NewRow();
                row["Nombre de usuario"] = user.UserName;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(string username)
        {
            AssignTypeOfUserOperatorModel user = new AssignTypeOfUserOperatorModel();
            user.UserName = username;
            user.DeleteUser();
        }
    }
}
