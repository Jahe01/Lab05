using System.Collections;
using System.Globalization;

namespace Lab05_List;
class Program
{
    static void Main2(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(5);
        arrayList.AddRange(new int[] { 6, -7, 8 });
        arrayList.AddRange(new object[] { "Marcin", "Mary" });
        arrayList.Insert(5, 7.8);
        arrayList.Remove(4);

        foreach (object element in arrayList)
        {
            Console.WriteLine(element);
        }
    }
}
