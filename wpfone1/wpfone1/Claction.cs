using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wpfone1
{
    
        interface operater1
        {

            int calculate(int a, int b);

        }

        class Add : operater1
        {
            public int calculate(int a, int b)
            {
                return a + b;

            }
        }

        class Sub : operater1
        {
            public int calculate(int a, int b)
            {
                return a - b;
            }
        }

        class Mul : operater1
        {
            public int calculate(int a, int b)
            {
                return a * b;
            }
        }

        class Div : operater1
        {

            public int calculate(int a, int b)
            {

                if (b == 0)
                {

                    throw new Exception("除数不能为零！");

                }

                else
                {

                    return a / b;

                }

            }

        }
    }

