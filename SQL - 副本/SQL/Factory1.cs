using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL
{
    class Factory1
    {
        private Ifact fact;
        private operater1 oper1;
        public Factory1(string operation)
        {
            switch (operation)
            {
                case "+":
                    fact = new Addfactory();
                    oper1 = fact.CreatrOper();
                    break;
                case "-":
                    fact = new Subfactory();
                    oper1 = fact.CreatrOper();
                    break;
                case "*":
                    fact = new Mulfactory();
                    oper1 = fact.CreatrOper();
                    break;
                case "/":
                    fact = new Divfactory();
                    oper1 = fact.CreatrOper();
                    break;

            }
            
        }
        public int claations(int a, int b)
        {
            return oper1.calculate(a, b);
        }
    }
}
