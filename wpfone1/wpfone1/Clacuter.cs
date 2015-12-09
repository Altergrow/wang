using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wpfone1
{
  public  class Clacuter
    {
        private operater1 oper1;

        public Clacuter(string aSS)
        {

            switch (aSS)
            {

                case "+":

                    oper1 = new Add();

                    break;

                case "-":

                    oper1 = new Sub();

                    break;

                case "*":

                    oper1 = new Mul();

                    break;

                case "/":

                    oper1 = new Div();

                    break;

            }

        }

        public int Calculation(int a, int b)
        {

            return oper1.calculate(a, b);

        }
    }
}
