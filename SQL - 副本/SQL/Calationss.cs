using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL
{
    interface Ifact//建一个工厂接口
    {
        operater1 CreatrOper();
    }
    class Addfactory : Ifact//加法工厂
    {
        public operater1 CreatrOper()
        {
            return new Add();
        }
    }
    class Subfactory : Ifact//减法工厂
    {
        public operater1 CreatrOper()
        {
            return new Sub();
        }
    }
    class Mulfactory : Ifact//乘法工厂
    {
        public operater1 CreatrOper()
        {
            return new Mul();
        }
 
    }
    class Divfactory : Ifact//除法工厂
    {
        public operater1 CreatrOper()
        {
            return new Div();
        }
    }
}

