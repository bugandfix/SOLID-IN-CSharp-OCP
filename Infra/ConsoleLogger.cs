using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra;

public class ConsoleLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
