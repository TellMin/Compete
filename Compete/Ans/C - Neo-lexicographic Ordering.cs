using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Compete.Ans
{
    /// <summary>
    /// https://atcoder.jp/contests/abc219/tasks/abc219_c
    /// 
    /// 独自に定義されたアルファベット順に従って文字列を並び替える問題
    /// 右空白埋めし、空白のスコアを0とすることで異なる文字数の大小比較が可能とした
    /// 
    /// 解説では前方が一致する場合は文字数の少ない方が小さいとしている
    /// 
    /// OrderBy関数の第二引数にIComparerを渡すことで、ソートの仕方をカスタマイズできる
    /// </summary>
    internal class C___Neo_lexicographic_Ordering
    {
        public void Solve(ConsoleInput cin)
        {
            var X = cin.ReadLine;
            var N = cin.ReadInt;

            List<(string Input, int[] ScoreArray)> ans = new List<(string, int[])>();

            for (int i = 0; i < N; i++)
            {
                // 右空白埋めをすることで、文字数の少ない方が小さいとしてソートできる
                var Sn = cin.ReadLine.PadRight(10);
                var score = new int[10];

                for (int j = 0; j < Sn.Length; j++)
                {
                    score[j] = X.IndexOf(Sn[j]);
                }

                ans.Add((Sn, score));
            }

            var sortedAns = ans.OrderBy(x => x.ScoreArray, new CustomComparer());

            foreach (var item in sortedAns)
            {
                WriteLine($"{item.Input}");
            };
        }

        public class CustomComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] > y[i])
                        return 1;
                    else if (x[i] < y[i])
                        return -1;
                }

                // x と y が同じ文字列の場合は0を返してよい
                // x の方が配列が短い場合、ただしく比較できないので、文字数で比較する
                //if(x.Length < y.Length)
                //{
                //    return -1;
                //}

                return 0;
            }
        }
    }
}
