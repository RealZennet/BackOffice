﻿using capa_datos;
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
        public static void Crear(string firstname , string firstlastname, string phonenumber, string username, string password)
        {
            UsersModel user = new UsersModel();
            user.FirstName = firstname;
            user.FirstLastName = firstlastname;
            user.PhoneNumber = phonenumber;
            user.UserName = username;
            user.Password = password;
            user.Save();
        }


        public static DataTable Obtener()
        {
            UsersModel UserTableModel = new UsersModel();
            List<UsersModel> users = UserTableModel.GetAllUsers();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Primer nombre", typeof(string));
            table.Columns.Add("Primer apellido", typeof(string));
            table.Columns.Add("Numero de telefono", typeof(int));
            table.Columns.Add("Nombre de usuario", typeof(string));


            foreach (UsersModel user in users)
            {
                DataRow row = table.NewRow();
                row["ID"] = user.UserID;
                row["Primer nombre"] = user.FirstName;
                row["Primer apellido"] = user.FirstLastName;
                row["Numero de telefono"] = user.PhoneNumber;
                row["Nombre de usuario"] = user.UserName;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteUser(int id)
        {
            UsersModel user = new UsersModel();
            user.UserID = id;
            user.DeleteUser();
        }
    }
}
