using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyPointsIsThat.Entities
{
    public class ConsumedFood
    {
        [Key]
        public int ConsumedFoodId { get; set; }
        public DateTime DateTimeConsumed { get; set; }
        [ForeignKey("FkFoodItemId")]
        public FoodItem FoodItem { get; set; }
        public int FkFoodItemId { get; set; }
        public int ServingQty { get; set; }
    }
}
