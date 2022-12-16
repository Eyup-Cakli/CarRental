﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        [Key]
        public int CarId { get; set; }
        
        public int BrandId { get; set; }
        
        public int ColorId { get; set; }
        
        public int CarModelYear { get; set; }
        
        public decimal CarDailyPrice { get; set; }
        
        public string CarDescription { get; set; }
    }
}
