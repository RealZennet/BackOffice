using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class DestinationModel : DataBaseControl
    {
        public int IDDestination { get; set; }
        public string StreetDestination { get; set; }
        public int DoorNumber { get; set; }
        public string CornerDestination { get; set; }
        public bool ActivedDestination { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO destino(calle, num, esq, bajalogica) VALUES(" +
                $"'{this.StreetDestination}'," +
                $"{this.DoorNumber}," +
                $"'{this.CornerDestination}'," +
                $"{this.ActivedDestination})";

            this.Command.ExecuteNonQuery();
        }

        public List<DestinationModel> getAllDestinations()
        {
            this.Command.CommandText = $"SELECT * FROM destino";
            this.Reader = this.Command.ExecuteReader();
            List<DestinationModel> result = new List<DestinationModel>();
            while (this.Reader.Read())
            {
                DestinationModel destination = new DestinationModel();
                destination.IDDestination = Int32.Parse(this.Reader["id_des"].ToString());
                destination.StreetDestination = this.Reader["calle"].ToString();
                destination.DoorNumber = Int32.Parse(this.Reader["num"].ToString());
                destination.CornerDestination = this.Reader["esq"].ToString();
                destination.ActivedDestination = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
                result.Add(destination);
            }
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM destino WHERE id_des = {this.IDDestination}";
            this.Command.ExecuteNonQuery();
        }

        public bool CheckIfDestinationExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM destino WHERE id_des = {id}";
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

        public void Edit()
        {

            bool destinationExists = CheckIfDestinationExists(this.IDDestination);

            if (destinationExists == true)
            {
                this.Command.CommandText = $"UPDATE destino SET " +
                    $"calle = '{this.StreetDestination}', " +
                    $"num = {this.DoorNumber}, " +
                    $"esquina = '{this.CornerDestination}', " +
                    $"bajalogica = {this.ActivedDestination}" +
                    $"WHERE id_des = {this.IDDestination}";
                this.Command.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("Error");
            }
        }

    }
}