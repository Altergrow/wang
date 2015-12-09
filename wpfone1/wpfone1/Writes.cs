using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace wpfone1
{
    class Writes
    {
        public void inscribe(string a, string b)
        {

            StreamWriter aaa = new StreamWriter(a, true);
            aaa.WriteLine(b);
            aaa.Close();

        }
        public void cleanup(string c, string d, string e)
        {
            StreamWriter ddd = new StreamWriter(c);
            ddd.WriteLine(" ");
            ddd.Close();
            StreamWriter aaa = new StreamWriter(d);
            aaa.WriteLine("");
            aaa.Close();
            StreamWriter fff = new StreamWriter(e);
            fff.WriteLine("");
            fff.Close();
        }
    }
}
