using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveType_Class_
{
    class Player//internal access modifier present
    {
        internal string playerName;
        internal int hp;

        public void Show()
        {
            Console.WriteLine(playerName+" "+hp);
        }


    }
}
