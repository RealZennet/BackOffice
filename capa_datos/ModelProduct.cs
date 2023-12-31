﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class ModelProduct:DataBaseControl
    {
        public int IDProduct { get; set; }
        public int ProductWeight { get; set; }
        public bool ActivatedProduct { get; set; }
        public int Volume { get; set; }
        public string Street { get; set; }
        public int DoorNumber { get; set; }
        public string Corner { get; set; }
        public string Customer { get; set; }

        public void Save()
        {
            try
            {
            this.Command.CommandText = $"INSERT INTO producto(peso_producto, bajalogica, volumen_producto, calle, num, esq, cliente) VALUES(" +
               $"{this.ProductWeight}, " +
               $"{this.ActivatedProduct}, " +
               $"{this.Volume}," +
               $"'{this.Street}'," +
               $"{this.DoorNumber}," +
               $"'{this.Corner}'," +
               $"'{this.Customer}')";
            this.Command.ExecuteNonQuery();

            this.Command.CommandText = "SELECT LAST_INSERT_ID()";
            this.IDProduct = Convert.ToInt32(this.Command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error.");
            }
        }

        public List<ModelProduct> GetAllProducts()
        {
            this.Command.CommandText = "SELECT * FROM producto";
            this.Reader = this.Command.ExecuteReader();

            List<ModelProduct> result = new List<ModelProduct>();
            while (this.Reader.Read())
            {
                ModelProduct product = new ModelProduct();
                product.IDProduct = Int32.Parse(this.Reader["id_prod"].ToString());
                product.ProductWeight = Int32.Parse(this.Reader["peso_producto"].ToString());
                product.ActivatedProduct = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
                product.Volume = Int32.Parse(this.Reader["volumen_producto"].ToString());
                product.Street = this.Reader["calle"].ToString();
                product.DoorNumber = Int32.Parse(this.Reader["num"].ToString());
                product.Corner = this.Reader["esq"].ToString();
                product.Customer = this.Reader["cliente"].ToString();
                result.Add(product);
            }
            this.Reader.Close();
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM producto WHERE id_prod = {this.IDProduct}";
            this.Command.ExecuteNonQuery();
        }

    }
}
