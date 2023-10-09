using System.Diagnostics.Tracing;
using System.Net.Mail;

namespace Task_9oktyabr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task-1          
            //Student student = new Student("Xeyal", "Huseynov", "AB104", 81, false);

            //student.Getİnfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();

            //Task-2 Methodlar ile yazdim
            //int[] Reshad = new int[3];
            //int[] Aydan = new int[3];

            //int ReshadCount = 0;
            //int AydanCount = 0;

            //for (int i = 0; i < Reshad.Length; i++)
            //{
            //    Console.WriteLine("Reshadin neticeleri:");
            //    Reshad[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < Aydan.Length; i++)
            //{
            //    Console.WriteLine("Aydanin neticeleri:");
            //    Aydan[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i<3 ; i++)
            //{
            //    if (Reshad[i] > Aydan[i])
            //    {
            //        ReshadCount++;
            //    }
            //    else if (Reshad[i] > Aydan[i])
            //    {
            //        AydanCount++;
            //    }
            //}
            //Console.WriteLine($"Reshadin neticesi {ReshadCount}");
            //Console.WriteLine($"Aydanin neticesi {AydanCount}");

            //Task-3 OPTIONAL
            //Console.WriteLine("Enter sentence: ");
            //string sentence=Console.ReadLine();

            //Task-4 YAZAMMADIM
        }
        //Task-5
        //static void EnterMatris(int[,] matris)
        //{
        //    int setirSayi = matris.GetLength(0);
        //    int sutunSayi = matris.GetLength(1);

        //    for (int i = 0; i < setirSayi; i++)
        //    {
        //        for (int j = 0; j < sutunSayi; j++)
        //        {
        //            Console.Write($"[{i}, {j}]: ");
        //            matris[i, j] = Convert.ToInt32(Console.ReadLine());
        //        }
        //    }
        //}
        //static int[,] SumMatris(int[,] matris1, int[,] matris2)
        //{
        //    int setirSayi = matris1.GetLength(0);
        //    int sutunSayi = matris1.GetLength(1);

        //    int[,] cemMatrisi = new int[setirSayi, sutunSayi];

        //    for (int i = 0; i < setirSayi; i++)
        //    {
        //        for (int j = 0; j < sutunSayi; j++)
        //        {
        //            cemMatrisi[i, j] = matris1[i, j] + matris2[i, j];
        //        }
        //    }

        //    return cemMatrisi;
        //}
        //static void ShowMatris(int[,] matris)
        //{
        //    int setirSayi = matris.GetLength(0);
        //    int sutunSayi = matris.GetLength(1);

        //    for (int i = 0; i < setirSayi; i++)
        //    {
        //        for (int j = 0; j < sutunSayi; j++)
        //        {
        //            Console.Write(matris[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //Task-3
        //static void CustomSplit(string sentence)
        //{
        //    int count = 1;
        //    if (sentence.Length==0)
        //    {
        //        Console.WriteLine("Heç nə daxil edilməyib");
        //        return;
        //    }
        //    else
        //    {
        //        CountWords(sentence, ref count);

        //        string[] words = new string[count];

        //        SplitString(sentence, words);
        //    }
        //}

        //static void CountWords(string sentence, ref int count)
        //{
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence[i] == ' ') ;
        //        count++;
        //    }
        //}

        //static void SplitString(string sentence, string[] array)
        //{
        //    string word = "";

        //    int index = 0;

        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence[i] == ' ')
        //        {
        //            array[index] = word;
        //            index++;
        //            word = "";
        //        }
        //        else
        //        {
        //            word += sentence[i];
        //        }
        //    }
        //}
    }

    //Task-1
    //class Student
    //{
    //    //Field
    //    public string Name;

    //    public string Surname;

    //    public string Group;

    //    public int Point;

    //    public bool isGraduated;


    //    //Constructor

    //    public Student(string name, string surname, string group, int point)
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Group = group;
    //        Point = point;
    //    }

    //    public Student(string name, string surname, string group, int point, bool isGraduated) : this(name, surname, group, point)
    //    {
    //        isGraduated = true;

    //        if (Point < 65)
    //        {
    //            Console.WriteLine("Kesilib");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ugurla kecib");
    //        }
    //    }

    //    public Student(string name, string surname, string group, int point, string graduated) : this(name, surname, group, point)
    //    {
    //    }

    //    //Method
    //    public void Getİnfo()
    //    {
    //        Console.WriteLine($"{Name},{Surname},{Group},{Point},{isGraduated}");
    //    }

    //    public void CheckGraduation()
    //    {
    //        if (isGraduated == false)
    //        {
    //            Console.WriteLine("Mezun Olub");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Mezun ola bilmedi");
    //        }
    //    }

    //    public void GetDiplomDegree()
    //    {
    //        if (Point < 65)
    //        {
    //            Console.WriteLine("Yoxdur");
    //        }
    //        else if (65 < Point && Point < 80)
    //        {
    //            Console.WriteLine("Adi");
    //        }
    //        else if (80 < Point && Point < 90)
    //        {
    //            Console.WriteLine("Sheref");
    //        }
    //        else if (Point > 90)
    //        {
    //            Console.WriteLine("Yuksek sheref");
    //        }
    //    }
    //}
}