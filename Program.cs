using System;
using System.Collections.Generic;

namespace Spies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            solve(n);
        }

        static void solve(int n)
        {
            bool[,] grid = new bool[n, n];
            List<Spy> spies = new List<Spy>();
            spies.ForEach(c => new Spy(ref grid));
        }
    }

    class Spy
    {
        int x { get; set; }
        int y { get; set; }
        int[] diagNb = new int[8];
        
        public Spy(ref bool[,] grid)
        {
            place(this, ref grid);
        }

        public void place(Spy spy, ref bool[,] grid)
        {

        }
    }
}
