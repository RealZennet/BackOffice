﻿using capa_datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public class TruckerController
    {
        public static void Create(int truckweight, int truckvolume, int activedtruck)
        {
            TruckModel truck = new TruckModel();
            truck.TruckWeight = truckweight;
            truck.TruckVolume = truckvolume;
            truck.ActivedTruck = activedtruck;
            truck.Save();
        }

        public static DataTable GetAllTrucks()
        {
            TruckModel AllTrucks = new TruckModel();
            List<TruckModel> trucks = AllTrucks.getAllTrucks();
            DataTable table = new DataTable();
            table.Columns.Add("Camion ID", typeof(int));
            table.Columns.Add("Peso camion", typeof(int));
            table.Columns.Add("Volumen camion", typeof(int));
            table.Columns.Add("Activo", typeof(int));

            foreach (TruckModel truck in trucks)
            {
                DataRow row = table.NewRow();
                row["Camion ID"] = truck.IDTruck;
                row["Peso camion"] = truck.TruckWeight;
                row["Volumen camion"] = truck.TruckVolume;
                row["Activo"] = truck.ActivedTruck;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void DeleteTruck(int id)
        {
            TruckModel truck = new TruckModel();
            truck.IDTruck = id; 
            truck.Delete();
        }
    }
}