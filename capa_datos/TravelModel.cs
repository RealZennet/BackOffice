using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class TravelModel : DataBaseControl
    {
        public int IDStoreHouse { get; set; }
        public int IDDestination { get; set; }
        public string TypeTravel { get; set; }
        public DateTime ShippmentDate { get; set; }


        public void Save()
        {
            if (!DoesDestinationExists(IDDestination) || !DoesStoreHouseExists(IDStoreHouse))
            {
                throw new Exception("Datos incorrectos.");
            }
            this.Command.CommandText = $"INSERT INTO recorrido(id_alma, id_des, tipo_trayecto, fech_trayecto) VALUES(" +
                $"{this.IDStoreHouse}, " +
                $"{this.IDDestination}, " +
                $"'{this.TypeTravel}' " +
                $"'{this.ShippmentDate.ToString("yyyy-MM-dd")}')";

            this.Command.ExecuteNonQuery();
        }

        private bool DoesStoreHouseExists(int idStoreHouse)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM almacen WHERE id_alma = {idStoreHouse}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }

        private bool DoesDestinationExists(int idDestination)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM destino WHERE id_des = {idDestination}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }

            return false;
        }

        public List<TravelModel> GetTravelsByStoreHouse(int storeHouseId)
        {
            List<TravelModel> travels = new List<TravelModel>();

            try
            {
                this.Command.CommandText = $"SELECT * FROM recorrido WHERE id_alma = {storeHouseId}";
                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TravelModel travel = new TravelModel
                    {
                        IDStoreHouse = Convert.ToInt32(this.Reader["id_alma"]),
                        IDDestination = Convert.ToInt32(this.Reader["id_des"]),
                        TypeTravel = this.Reader["tipo_trayecto"].ToString(),
                        ShippmentDate = DateTime.Parse(this.Reader["fech_trayecto"].ToString())
                    };

                    travels.Add(travel);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return travels;
        }

        public List<TravelModel> GetTravelsByDestination(int destinationId)
        {
            List<TravelModel> travels = new List<TravelModel>();

            try
            {
                this.Command.CommandText = $"SELECT * FROM recorrido WHERE id_des = {destinationId}";
                this.Reader = this.Command.ExecuteReader();

                while (this.Reader.Read())
                {
                    TravelModel travel = new TravelModel
                    {
                        IDStoreHouse = Convert.ToInt32(this.Reader["id_alma"]),
                        IDDestination = Convert.ToInt32(this.Reader["id_des"]),
                        TypeTravel = this.Reader["tipo_trayecto"].ToString(),
                        ShippmentDate = DateTime.Parse(this.Reader["fech_trayecto"].ToString())
                    };

                    travels.Add(travel);
                }

                this.Reader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return travels;
        }
    }
}