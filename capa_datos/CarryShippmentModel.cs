using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class CarryShippmentModel : DataBaseControl
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public int IDDestination { get; set; }
        public string ShippingStatus { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO transporta(id_camion, id_lote, id_des, estatus) VALUES(" +
               $"{this.IDTruck}, " +
               $"{this.IDBatch}, " +
               $"{this.IDDestination}," +
               $"'{this.ShippingStatus}')";
            this.Command.ExecuteNonQuery();
        }

        public List<CarryShippmentModel> GetAllDestinations()
        {
            this.Command.CommandText = "SELECT * FROM transporta";
            this.Reader = this.Command.ExecuteReader();

            List<CarryShippmentModel> result = new List<CarryShippmentModel>();
            while (this.Reader.Read())
            {
                CarryShippmentModel destinations = new CarryShippmentModel();
                destinations.IDTruck = Int32.Parse(this.Reader["id_camion"].ToString());
                destinations.IDBatch = Int32.Parse(this.Reader["id_lote"].ToString());
                destinations.IDDestination = Int32.Parse(this.Reader["fech_sal"].ToString());
                destinations.ShippingStatus = this.Reader["estatus"].ToString();
                result.Add(destinations);
            }
            this.Reader.Close();
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM transporta WHERE id_camion = {this.IDTruck}";
            this.Command.ExecuteNonQuery();
        }
    }
}
