using System;
using System.Linq;

namespace _22._01._2023HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Verilmiş string dəyərindəki ilk sözü tapan metod(ilk söz ilk boşluğa qədərki ifadədir)
            //    Console.WriteLine(methodName("Hello World"));
            //}
            //static string methodName(string name)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (name[i]!=' ')
            //        {
            //            newStr += name[i];
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    return newStr;
            //.................................................................................................................

            // - Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)
            //    Console.WriteLine(methodNum("Baku Code Academy"));
            //}
            //static int methodNum(string str)
            //{
            //    int count = 0;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i]==' ')
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //.................................................................................................................

            //- Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
            //Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.
            //    int[] a = (new[]{ -2, 4, 8, -13, -18, -19 });
            //    Console.Write("New Array: ");
            //}
            //static int arrMethod(int[] a)
            //{
            //    int size = a.Length;
            //    int[] newArr = new int[size];
            //    int count = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] >= 0)
            //            count++;
            //        for (int j = 0; j < size; j++)
            //        {

            //        }
            //    }
            //    return count;
            //.................................................................................................................

            //- Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
            //    string[] names = { "Faiq", "Ismayilov", "Hello" };
            //    Console.WriteLine(arrayList(names));
            //}
            //static int arrayList(string[] str)
            //{
            //    int count = 0;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] == )
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //.................................................................................................................

            //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.
            //    Console.WriteLine(mainIndex(" Salam"));
            //}
            //static int mainIndex(string str)
            //{
            //    int newName = ' ';
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i]!=' ')
            //        {
            //            return i;
            //            newName = i;
            //        }
            //    }
            //    return newName;
            //.................................................................................................................

            //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
            //    Console.WriteLine(mainName("   Hello"));
            //}
            //static string mainName(string str)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i]!=' ')
            //        {
            //            newStr += str[i];
            //        }
            //    }
            //    return newStr;
            //.................................................................................................................
        }
    }
}
