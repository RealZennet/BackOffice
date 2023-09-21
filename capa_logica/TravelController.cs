using capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_logica
{
    public abstract class TravelController
    {
        public static void Create(int idstorehouse, int iddestination, string typetravel, DateTime shipmmentdate)
        {
            TravelModel travel = new TravelModel();
            travel.IDStoreHouse = idstorehouse;
            travel.IDDestination = iddestination;
            travel.TypeTravel = typetravel;
            travel.ShippmentDate = shipmmentdate;
            travel.Save();
        }


    }
}
