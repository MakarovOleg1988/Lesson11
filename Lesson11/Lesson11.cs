using System;


namespace Lesson11
{
    class Program
    {

        static void Main(string[] args)
        {
            _whileMethod();
            _doMethod();
            _foreachMethod();
        }

        public static void _arrayMethod()
        {
            int[] _array = new int[5]; //массив   

            var _size_array = _array.Length; //длина массива

            _array[1] = 5;

            var _oldArray = _array;
            _array = new int[20]; //обновление ссылки на массив

            long[] _checkArray = null;

            //_array = null; обнуление массива
            //_array = default; обнуление массива через default

            //Array _t = _oldArray;

            //foreach (var r in _array) Console.WriteLine(r);
            //[0][1][2][3][4] индексация ячеек массива

            _newClass[] _check = new _newClass[5];

            for (int i = 0; i < 5; i++)//Запуск цикла
            {
                _check[i] = new _newClass();
            }

            int j = 0;
            for (; ; )//Запуск цикла
            {
                j++;
                if (j == 90000) break;
            }

            for (int i1 = 0, j1 = 10, k1 = 11; i1 < 100 || j1 == 100 || k1 <1; i1++, j1++, k1--)//Запуск цикла с несколькими условиями
            {
                //Console.WriteLine(k1);
            }

            for (int i2 = 0, k2 = -100; i2 != 1000; k2++)//Запуск цикла с несколькими условиями
            {
                i2++;
                if (i2 < 5) { continue; }
                break;
            }

        }

        public static void _whileMethod()
        {
            int i3 = 0;
            while (i3 < 10) //Цикл while выполняется только если условие True
            {
                i3++;
                Console.WriteLine("One" + i3);
            }
        }

        public static void _doMethod()
        {
            int i4 = 0;
            do //Цикл do, выполняется гарантированно один раз
            {
                Console.WriteLine("Two" + i4);
                i4++;
            }
            while (i4 < 5); //Цикл while
        }

        public static void _foreachMethod()
        {
            int[] _newArray = new int[6];
            _newArray[2] = 4;
            foreach (var i5 in _newArray) //Цикл foreach, цикл с перебором
            {
                Console.WriteLine("Three" + i5);
            }
        }

        public class _newClass { }
    }
}
