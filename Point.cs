using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }


        //говнокод здесь
        public static void Main()
        {
            int x = 1;
            Func1(x);
        }

        public static void Func1(int value);
        {

        }

        public static void Main()
        {
            int x = 1;
            Func2(x);
        }

        public static void Func2(int value);
        {
            value = Value + 1;
        }

    public static void Main()
    {
        int x = 1;
        Func3(x);
    }

    public static void Func3(int value);
        {
            x = x + 1;
        }
    }
}
