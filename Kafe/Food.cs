using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    public class Food
    {
        public Food()
        {
            this.FoodId = Guid.NewGuid(); //otomatik olarak yeni id üretsin diye
        }
        public Guid FoodId { get; set; }

        [MaxLength(50)]
        [Required]
        public string FoodName { get; set; }

        [MaxLength(100)]
        [Required]
        public string FoodMetarials { get; set; }

        [MaxLength(30)]
        [Required]
        public string FoodCategory { get; set; }

        [MaxLength(30)]
        [Required]
        public string FoodPrice { get; set; }

        [MaxLength(500)]
        public string FoodSpecification { get; set; }

        public EntityState State { get; internal set; }
    }
}
