using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
    /// 倒星形三角形
    /// *****
    /// ****
    /// ***
    /// **
    /// *
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                int countempty = 5 - i;
                int countstar = i;

                string row = new string('*', countempty) + new string(' ', countstar);
                Console.WriteLine(row);

            }

        }
    }
}

