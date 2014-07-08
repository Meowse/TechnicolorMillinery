using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2ExtraCredit
{
    public class Integer
    {
        public static Int16 num;
        public Int16 aNum;

        public Integer()
        {
            addInteger();
            aNum = num;                
        }

        private void addInteger(){
            num++;
        }

        public void setInteger()
        {
            num = 0;
            aNum = num;
        }
    }
}
