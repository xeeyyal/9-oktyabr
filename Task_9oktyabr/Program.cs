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

            //Task-3
            //string sentence = "Xeyal Huseynov Group AB104 Back-End Developer";
            //string[] word = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(string.Join("\n", word));


            //Task-4
            //TrimStart()
            //string sentence = "****000Xeyal000****";
            //char[] charsToTrim = { '*', '0' };

            //Console.WriteLine("After: ");
            //Console.WriteLine(sentence.TrimStart(charsToTrim));

            ////Trim()
            //string sentence2 = "****000Xeyal000****";
            //char[] charsToTrim2 = { '*', '0' };

            //Console.WriteLine("After: ");
            //Console.WriteLine(sentence.Trim(charsToTrim2));

            ////TrimEnd()
            //string sentence3 = "****000Xeyal000****";
            //char[] charsToTrim3 = { '*', '0' };

            //Console.WriteLine("After: ");
            //Console.WriteLine(sentence.TrimEnd(charsToTrim3));

            //Task-5 Optional
            //Console.Write("Matrisin sətir sayını daxil edin: ");
            //int setirSayi = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Matrisin sütun sayını daxil edin: ");
            //int sutunSayi = Convert.ToInt32(Console.ReadLine());

            //int[,] matris1 = new int[setirSayi, sutunSayi];
            //int[,] matris2 = new int[setirSayi, sutunSayi];

            //Console.WriteLine("Birinci matrisi daxil edin:");
            //EnterMatris(matris1);

            //Console.WriteLine("İkinci matrisi daxil edin:");
            //EnterMatris(matris2);

            //int[,] cemMatrisi = SumMatris(matris1, matris2);

            //Console.WriteLine("Cemi");
            //ShowMatris(cemMatrisi);
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