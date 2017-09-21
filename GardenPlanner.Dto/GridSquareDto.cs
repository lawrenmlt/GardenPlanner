using GardenPlanner.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner.Dto
{
    public class GridSquareDto
    {
        public int Id { get; set; }

        public int VegetableId { get; set; }

        public GridBorderType Border { get; set; }

        public int Color { get; set; }

    }
}
