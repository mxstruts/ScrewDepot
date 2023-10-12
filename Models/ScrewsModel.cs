using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;

namespace ScrewDepot.Models
{
    public class ScrewsModel
    {
        public int Id { get; set; }  
        public string Name { get; set; }  
        public string Description { get; set; } 
        public string Material { get; set; }  
        public double LengthInMillimeters { get; set; }  
        public double DiameterInMillimeters { get; set; }  
        public decimal Price { get; set; }  
        public int StockQuantity { get; set; } 
        public string Manufacturer { get; set; }
        public string Rating { get; set; } // 1 to 5


        internal static Task<decimal> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
