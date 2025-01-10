
using System;
using PrimitiveMath;

namespace NonPrimitiveType_Class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            var res = cal.Sum(20, 20);
            Console.WriteLine(res);

            Player player = new Player();

            player.playerName = "FI Pranto";
            player.hp = 100;
            player.Show();
        }
    }
}
