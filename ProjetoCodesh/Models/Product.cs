using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ProjetoCodesh.Models.Enums;
using System;

namespace ProjetoCodesh.Models
{
    public class Product
    {
        public ObjectId Id { get; private set; }
        public long Code { get; private set; }
        public StatusEnum Status { get; private set; }
        [BsonElement("Imported_t")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)] // Especifica o tipo de DateTime
        public DateTime? Imported_t { get; private set; } = DateTime.Now;
        public string Url { get; private set; }
        public string Creator { get; private set; }
        public long Last_modified_t { get; private set; }
        public string Product_name { get; private set; }
        public string Quantity { get; private set; }
        public string Brands { get; private set; }
        public string Categories { get; private set; }
        public string Labels { get; private set; }
        public string Citites { get; private set; }
        public string PurchasePlaces { get; set; }
        public string Stores { get; private set; }
        public string Ingredients_text { get; private set; }
        public string Traces { get; private set; }
        public string Serving_size { get; private set; }
        public double Serving_quantity { get; private set; }
        public double NutriScore_score { get; private set; }
        public string NitriScore_grade { get; private set; }
        public string Main_Category { get; private set; }
        public string Image { get; private set; }

        public Product(long code, string prodcutName)
        {
            Code = code;
            Product_name = prodcutName;
            //Imported_t = imported_t;
        }
        public Product(long code, string productName, StatusEnum status, string ingredients_text)
        {
            Code = code;
            Product_name = productName;
            Status = status;
            Imported_t = DateTime.Now;
            Ingredients_text = ingredients_text;
        }

        public void UpdateProduct(string productName, StatusEnum status, string ingredients_text)
        {
            Product_name = productName;
            Status = status;
            Ingredients_text = ingredients_text;
            Imported_t = DateTime.Now;
        }
    }
}
