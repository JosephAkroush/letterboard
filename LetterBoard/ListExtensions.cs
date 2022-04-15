using System.Collections.Generic;

namespace LetterBoard
{
    public static class ListExtensions
    {
        public static string AsString<T>(this List<T> list)
        {
            return $"[ {string.Join(",", list)} ]";
        }
        
        public static void MoveToBeginning<T>(this List<T> list, int index)
        {
            T temp = list[index];
            list.RemoveAt(index);
            list.Insert(0, temp);
        }

        public static void MoveToEnd<T>(this List<T> list, int index)
        {
            T temp = list[index];
            list.RemoveAt(index);
            list.Add(temp);
        }
    }
}
