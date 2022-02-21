using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Colour :IEntity
    {
        public int ColourId { get; set; }
        public string ColourName { get; set; }
    }
}
