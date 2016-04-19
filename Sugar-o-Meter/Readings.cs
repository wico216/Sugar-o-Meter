using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugar_o_Meter
{
    class Readings
    {
        public Readings()
        {
            readings = new List<float>();
        }

        public void AddReading(float sugar)
        {
            readings.Add(sugar);
        }

        List<float> readings; 
    }
}
