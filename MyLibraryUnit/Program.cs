using System;
using System.Linq;

namespace ArrayLibrary
{
    public static class ArrayHelper
    {
        // Метод сортировки массива
        public static int[] SortArray(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return array.OrderBy(x => x).ToArray();
        }

        // Метод фильтрации массива по предикату
        public static int[] FilterArray(int[] array, Func<int, bool> predicate)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return array.Where(predicate).ToArray();
        }

        // Метод поиска элемента в массиве (возвращает индекс)
        public static int FindElement(int[] array, int value)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return Array.IndexOf(array, value);
        }
    }
}