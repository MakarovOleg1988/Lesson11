using System;


namespace Lesson11
{
    class Program
    {

        static void Main(string[] args)
        {
            _arrayMethod();
        }

        public static void _arrayMethod()
        {
            int[] _array = new int[5]; //массив   

            var _size_array = _array.Length; //длина массива

            _array[1] = 5;

            var _oldArray = _array;
            _array = new int[20]; //обновление ссылки на массив

            //_array = null; обнуление массива
            //_array = default; обнуление массива через default

            long[] _checkArray = null;

            Array _t = _oldArray;

            foreach (var r in _array) Console.WriteLine(r);
            //[0][1][2][3][4] индексация ячеек массива
        }
    }
}
