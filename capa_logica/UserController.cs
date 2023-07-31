using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public static class UserController
    {
        public static void Crear(int ci, string firstname, string secondname, string firstlastname, string secondlastname, int phonenumber)
        {
            UsersModel user = new UsersModel();
            user.CI = ci;
            user.FirstName = firstname;
            user.SecondName = secondname;
            user.FirstLastName = firstlastname;
            user.SecondLastName = secondlastname;
            user.PhoneNumber = phonenumber;
            user.Save();
        }

        public static DataTable Obtener()
        {
            UsersModel UserTableModel = new UsersModel();
            List<UsersModel> users = UserTableModel.GetAllUsers();

            DataTable table = new DataTable();
            table.Columns.Add("CI", typeof(int));
            table.Columns.Add("Primer nombre", typeof(string));
            table.Columns.Add("Segundo nombre", typeof(string));
            table.Columns.Add("Primer apellido", typeof(string));
            table.Columns.Add("Segundo apellido", typeof(string));
            table.Columns.Add("Numero de telefono", typeof(int));

            foreach (UsersModel user in users)
            {
                DataRow row = table.NewRow();
                row["CI"] = user.CI;
                row["Primer nombre"] = user.FirstName;
                row["Segundo nombre"] = user.SecondName;
                row["Primer apellido"] = user.FirstLastName;
                row["Segundo apellido"] = user.SecondLastName;
                row["Numero de telefono"] = user.PhoneNumber;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(int ci)
        {
            UsersModel user = new UsersModel();
            user.CI = ci;
            user.DeleteUser();
        }
    }
}
