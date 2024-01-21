using Compete.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Compete.Problems;

public static class A
{
    public static void Solve(ConsoleInput cin)
    {
        throw new NotImplementedException();
    }

    public static void Exe()
    {
        //https://qiita.com/Camypaper/items/de6d576fe5513743a50e
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);
        A.Solve(new ConsoleInput(Console.In, ' '));
        Console.Out.Flush();
    }
}
