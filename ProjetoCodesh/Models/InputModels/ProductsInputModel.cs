using ProjetoCodesh.Models.Enums;
using System;

namespace ProjetoCodesh.Models.InputModels
{
    public class ProductsInputModel
    {
        public long Code { get;  set; }

        public string Product_name { get;  set; }
        public StatusEnum Status { get;  set; }
        public string Ingredients_text { get; set; }
        

    }

    public class ProductInputModelPut
    {
        public string Product_name { get; set; }
        public StatusEnum Status { get; set; }
        public string Ingredients_text { get; set; }
    }
}
