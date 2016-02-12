using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class Garden
    { 
        private List<Plot> _plots;
        public Garden(List<Plot> plots)
        {
            _plots = plots;
        }
        public int GetFencing()
        {
            int totalfencing = 0;
            foreach(Plot plotperimeter in _plots)
            {
                totalfencing += plotperimeter.GetPerimeter();
            }
            return totalfencing;
        }
        
    }
}
