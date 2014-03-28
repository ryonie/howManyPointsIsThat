using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyPointsIsThat.Entities
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }
        // [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Fiber { get; set; }
        public int Fat { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Points { get; set; }
        public int Carbohydrates { get; set; }
        public decimal ServingWeight { get; set; }
        public decimal ServingQty { get; set; }
        public string ServingUnit { get; set; }
        public decimal ServingsPerContainer { get; set; }
    }
}
