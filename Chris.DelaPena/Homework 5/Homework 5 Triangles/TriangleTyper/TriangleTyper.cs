using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyper
{
    public class TriangleTyper
    {
        public void GetType(int[] side)
        {

            for (int i=0, i < side.Length; i++)
            {
                //sort side lengths from smallest to largest
                if (side.Length > 0)
                {
                    if (side[0] > side[1])
                    {
                        int swapper = side[0];
                        side[0] = side[1];
                        side[1] = swapper;
                    }
                }
            
            }
        }
    }
}
