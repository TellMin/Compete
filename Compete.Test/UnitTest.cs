using Compete;
using Compete.Library;

namespace Compete.Test;

[TestClass]
public class UnitTest
{
    private string RunTest(string input, Action<ConsoleInput> testExecuter)
    {
        using var sr = new StringReader(input);
        Console.SetIn(sr);

        using var ms = new MemoryStream();
        using var sw = new StreamWriter(ms);
        Console.SetOut(sw);

        testExecuter(new ConsoleInput(Console.In, ' '));

        sw.Flush();
        ms.Seek(0, SeekOrigin.Begin);
        return new StreamReader(ms).ReadToEnd().Replace("\r","").Replace("\n","");
    }


    [TestMethod]
    [DataRow(@"", @"")]
    public void A(string input, string expected)
    {
        if (String.IsNullOrEmpty(input))
        {
            return;
        }
        var result = RunTest(input, Compete.Problems.A.Solve);
        Assert.AreEqual(expected.Replace("\r", "").Replace("\n", ""), result);
    }

    [TestMethod]
    [DataRow(@"", @"")]
    public void B(string input, string expected)
    {
        if (String.IsNullOrEmpty(input))
        {
            return;
        }
        var result = RunTest(input, Compete.Problems.B.Solve);
        Assert.AreEqual(expected.Replace("\r", "").Replace("\n", ""), result);
    }

    [TestMethod]
    [DataRow(@"", @"")]
    public void C(string input, string expected)
    {
        if (String.IsNullOrEmpty(input))
        {
            return;
        }
        var result = RunTest(input, Compete.Problems.C.Solve);
        Assert.AreEqual(expected.Replace("\r", "").Replace("\n", ""), result);
    }

    [TestMethod]
    [DataRow(@"", @"")]
    public void D(string input, string expected)
    {
        if (String.IsNullOrEmpty(input))
        {
            return;
        }
        var result = RunTest(input, Compete.Problems.D.Solve);
        Assert.AreEqual(expected.Replace("\r", "").Replace("\n", ""), result);
    }

    [TestMethod]
    [DataRow(@"", @"")]
    public void E(string input, string expected)
    {
        if (String.IsNullOrEmpty(input))
        {
            return;
        }
        var result = RunTest(input, Compete.Problems.E.Solve);
        Assert.AreEqual(expected.Replace("\r", "").Replace("\n", ""), result);
    }
}