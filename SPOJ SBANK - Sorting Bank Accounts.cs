using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string[]> accounts = new List<string[]>();

        for (int i = 0; i < n; i++)
        {
            string m = Console.ReadLine();
            int count = int.Parse(m);
            string[] account = new string[count];
            for (int j = 0; j < count + 1; j++)

            {
                string accountnum = Console.ReadLine();
                if (accountnum != "")

                {
                    account[j] = accountnum;
                }
            }

            accounts.Add(account);
        }

        foreach (var x in accounts)
        {
            foreach (var y in Duplicate(x.ToList()))
            {
                Console.WriteLine(y);
            }
            Console.WriteLine();
        }
    }

    public static IEnumerable<string> Duplicate(List<string> results)
    {
        return results.GroupBy(x => x)
                      .Select(y => y.Key + " " + y.Count())
                      .OrderBy(z => z)
                      .ToList();
    }
}