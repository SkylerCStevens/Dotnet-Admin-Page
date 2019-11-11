using System;
namespace project4.Models
{
    public class Product //Create model for how to save data in table of database
    {
            public int Id { get; set; }
            public string product_name { get; set; }
            public string product_desc { get; set; }
            public string product_category { get; set; }
            public string image { get; set; }
     }
}
