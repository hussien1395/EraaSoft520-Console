using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_005_Task_0001
{
    public class Overloading
    {
        public int Sum()
        {
            return (10 + 20);
        }

        public int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Sum(int num1, int num2,int num3)
        {
            return (num1 + num2 + num3);
        }
    }
}
