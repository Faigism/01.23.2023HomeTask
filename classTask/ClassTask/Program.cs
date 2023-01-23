using System;
using System.Net.Http.Headers;

namespace ClassTask
{
    internal class Programs
    {
        static void Mains(string[] args)
        {
            //Verilmiş 3 ədəd içərisində ən böyük olanı tapan program?
            //Console.WriteLine("num1:");
            //string num1str = Console.ReadLine();
            //Console.WriteLine("num2:");
            //string num2str = Console.ReadLine();
            //Console.WriteLine("num3:");
            //string num3str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1str);
            //int num2 = Convert.ToInt32(num2str);
            //int num3 = Convert.ToInt32(num3str);
            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine("en boyuk eded: "+num1);
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    Console.WriteLine("en boyuk eded "+num2);
            //}
            //else
            //{
            //    Console.WriteLine("en boyuk eded "+num3);
            //}
            //....................................................................................................

            //Verilmiş ədədlər siyahısındakı cüt ədədlərin ədədi ortasını tapan program?
            //int[] num = { 21, 12, 31, 45, 82, 22, 90, 100, 99, 33, 47 };
            //int sum = 0;
            //double count = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i]%2==0)
            //    {
            //        sum += num[i];
            //        count++;
            //    }
            //}
            //if (count==0)
            //{
            //    Console.WriteLine("Cut eded yoxdur");
            //}
            //else
            //{
            //    Console.WriteLine(sum/count);
            //}
            //......................................................................................................

            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan program?
            //int m = 100;
            //int n = 200;
            //int sum = 0;
            //int count = 0;
            //for (int i = m; i < n; i++)
            //{
            //    if (i%21==0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //if (count==0)
            //{
            //    Console.WriteLine("21-e bolunen eded yoxdur");
            //}
            //else
            //{
            //    Console.WriteLine(sum/count);
            //}
            //.........................................................................................................

            //Verilmiş N tam ədədinin rəqəmləri cəmini tapan program?
            //Console.WriteLine("ededi daxil edin");
            //string nstr=Console.ReadLine();
            //int n = Convert.ToInt32(nstr);
            //int sum = 0;
            //while (n>0)
            //{
            //    var lastdigit = n % 10;
            //    sum += lastdigit;
            //    n/=10;
            //}
            //Console.WriteLine(sum);
            //............................................................................................................

            //verilmiş yazıda 1 rəqəminin olub olmadığını tapan program?
            //Console.WriteLine("Yazini daxil edin");
            //string word=Console.ReadLine();
            //bool check=false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i]=='1')
            //    {
            //        check= true;
            //    }
            //}
            //if (check==true)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //............................................................................................................

            //Consolda 1 olub olmadığını yoxlamaq varsa yenidən daxil etmək?
            //string username;
            //bool check = false;
            //do
            //{
            //    Console.WriteLine("Username daxil edin");
            //    username = Console.ReadLine();
            //    check = false;
            //    for (int i = 0; i < username.Length; i++)
            //    {
            //        if (username[i]=='1')
            //        {
            //            check = true;
            //            break;
            //        }
            //    }
            //} while (check==true);
            //Console.WriteLine(username);
            //................................................................................................................

            //2 yazını birləşdirib yan yana yazdırmaq boşluq qoyaraq
            //    Console.WriteLine("Name:");
            //    string name=Console.ReadLine();
            //    Console.WriteLine("Surname:");
            //    string surname=Console.ReadLine();
            //    Console.WriteLine(fullName(name,surname));
            //}
            //static string fullName(string name,string surname)
            //{
            //    var input=name+" "+surname;
            //    return input;
            //...........................................................................................................................

            //Verilmiş char-ın rəqəm olub olmadığını tapan metod
            //    Console.WriteLine(getChar('1'));

            //}
            //static bool getChar(char cr)
            //{
            //    bool check=false;
            //    if (cr>='0'&&cr<='9')
            //    {
            //        return true;
            //    }
            //    return false;
            //........................................................................................................................

            //Verilmiş yazıdakı verilmiş char-ın olub olmadığını tapan metod
            //    Console.WriteLine(getName("Faiq",'i'));

            //}
            //static bool getName(string name,char cr)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        if (name[i]==cr)
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //.............................................................................................................................

            //Verilmiş ədədi verilmiş qüvvətə yüksəldən metod
            //    Console.WriteLine(doubleNum(5,3));
            //}
            //static int doubleNum(int x, int y)
            //{
            //    int result = 1;
            //    for (int i = 0; i < y; i++)
            //    {
            //        result *= x;
            //    }
            //    return result;
            //........................................................................................................................

            //Verilmiş ədədlər siyahısındakı ən böyük ədədi tapan metod
            //    int[] number = { 4, 7, 9, 5, 23, 67, 53, 73, 3, 6 };
            //    Console.WriteLine(bigNum(number));
            //}
            //static int bigNum(int[] num)
            //{
            //    int max = 0;
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        if (num[i]>max)
            //        {
            //            max = num[i];
            //        }
            //    }
            //    return max;
            //...................................................................................................................

            //Tək index-də yerləşən charlardan ibarət string necə düzəltmək olar
            //string str = "Hello World";
            //string newStr = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (i%2==1)
            //    {
            //        newStr += str[i];
            //    }
            //}
            //Console.WriteLine(newStr);
            //..................................................................................................................

            //Verilmiş yazıdan yalnız cüt indexlərində duran charlardan yeni bir yazı düzəldən metod
            //    Console.WriteLine(indexPair("Faiq"));
            //}
            //static string indexPair(string str)
            //{
            //    string newStr = "";
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (i%2==0)
            //        {
            //            newStr+= str[i];
            //        }
            //    }
            //    return newStr;
            //..................................................................................................................
            //Verilmiş adlar siyahısında verilmiş adın olub olmadığını tapan metod
            string[] list = { "Faiq", "Tofiq", "Nermin", "Aydin" };
            Console.WriteLine(arrList(list,"Nuru"));
        }
        static bool arrList(string[] arr,string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==str)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
