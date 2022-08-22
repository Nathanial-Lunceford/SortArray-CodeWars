// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

internal class Program
{
    public static int[] SortArray(int[] array)
    {
        List<int> oddPos= new List<int>();
        List<int> odds = new List<int>();
        int[] ints = new int[array.Length];

        for(int i=0; i<array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                oddPos.Add(i);
                odds.Add(array[i]);
            }
        }

        odds.Sort();
        int goThrough = 0;

        for (int o = 0; o < ints.Length; o++)
        {
            if(oddPos.Contains(o))
            {
                ints[o] = odds[goThrough];
                goThrough++;
            }
            else
            {
                ints[o] = array[o];
            }
        }
        return ints;
    }

    static void Main(string[] args)
    {
        int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        List<int> nums = SortArray(arr).ToList();
        nums.ForEach(Console.WriteLine);
    }

}