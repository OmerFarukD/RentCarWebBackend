using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto_s
{
    public class CarDetailDto :IDto
    {
        public int CarId { get; set; }
        public string ColourName { get; set; }
        public string BrandName { get; set; }

        public double DailyPrice { get; set; }
    }
}
