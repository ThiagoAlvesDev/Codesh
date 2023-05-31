using ProjetoCodesh.Models.Enums;
using System;

namespace ProjetoCodesh.Models
{
    public class Products
    {
        public long Code { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime Imported_t { get; set; }
        public string Url { get; set; }
        public string Creator { get; set; }
        public long Last_modified_t { get; set; }
        public string Prodruct_name { get; set; }
        public string Quantity { get; set; }
        public string Brands { get; set; }
        public string Categories { get; set; }
        public string Labels { get; set; }
        public string Citites { get; set; }
        public string Purchase_places { get; set; }
        public string Stores { get; set; }
        public string Ingredients_text { get; set; }
        public string Traces { get; set; }
        public string Serving_size { get; set; }
        public double Serving_quantity { get; set; }
        public double NutriScore_score { get; set; }
        public string NitriScore_grade { get; set; }
        public string Main_Category { get; set; }
        public string Image { get; set; }



    }
}
