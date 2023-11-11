using AtCoder;
using System;
using System.Linq;
using System.Security.Cryptography;

internal class Template
{
    static void Test()
    {
        // 文字列の入力
        string s = Console.ReadLine();

        // 整数の入力
        long n = long.Parse(Console.ReadLine());

        // 文字列配列の入力
        string[] inputStrArray = Console.ReadLine().Split(' ');

        // 整数配列の入力
        long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();


        // 配列を生成する
        var array1 = new int[] { 0, 2, 4, 6 };

        // [0,1...] の配列を生成する
        var array2 = Enumerable.Range(0, 5).ToArray(); // {0, 1, 2, 3, 4}

        // 初期値が全て同じ配列を生成する
        var array3 = Enumerable.Repeat(-1, 5).ToArray(); // { -1, -1, -1, -1, -1}
    }
}