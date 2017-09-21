using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Dto
{
    public class VegetableDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Height { get; set; } // in ft

        public int GroundSpace { get; set; } // in sq ft
    }
}
