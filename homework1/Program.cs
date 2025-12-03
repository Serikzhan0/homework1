using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("VAQT O'LCHOV BIRLIKLARI");
            //
            // Console.WriteLine("1. 2 Soat necha Minut ga teng => " + (2 * 60));
            // Console.WriteLine("2. 5 Hafta necha Soat ga teng => " + (5 * 7 * 24));
            // Console.WriteLine("3. 4 Minut necha Sekund ga teng => " + (4 * 60));
            // Console.WriteLine("4. 45 Soat necha Sekund ga teng => " + (45 * 3600));
            // Console.WriteLine("5. 10 Hafta necha minut ga teng => " + (10 * 7 * 24 * 60));
            // Console.WriteLine("6. 4 kun necha Minut ga teng => " + (4 * 24 * 60));
            // Console.WriteLine("7. 3 Soat necha Sekund ga teng => " + (3 * 3600));
            // Console.WriteLine("8. 34 Soat necha Kun ga teng => " + (34 / 24.0));
            // Console.WriteLine("9. 24 Kun necha Hafta ga teng => " + (24 / 7.0));
            // Console.WriteLine("10. 2000 Sekund necha Soat ga teng => " + (2000.0 / 3600));
            // Console.WriteLine("11. 2400 Sekund necha Minut ga teng => " + (2400 / 60));
            // Console.WriteLine("12. 2419200 Sekund necha Haftaga ga teng => " + (2419200.0 / 604800));
            // Console.WriteLine();
            //
            // Console.WriteLine("AXBOROT O'LCHOV BIRLIKLARI");
            //
            // Console.WriteLine("1. 5 GB necha MB ga teng => " + (5 * 1024));
            // Console.WriteLine("2. 3 MB necha KB ga teng => " + (3 * 1024));
            // Console.WriteLine("3. 3 TB necha MB ga teng => " + (3 * 1024 * 1024));
            // Console.WriteLine("4. 7 GB necha MB ga teng => " + (7 * 1024));
            // Console.WriteLine("5. 8 KB necha Bayt ga teng => " + (8 * 1024));
            // Console.WriteLine("6. 4 MB necha Bit ga teng => " + (4L * 1024 * 1024 * 8));
            // Console.WriteLine("7. 9 Bayt necha bit ga teng => " + (9 * 8));
            // Console.WriteLine("8. 16 MB necha KB ga teng => " + (16 * 1024));
            // Console.WriteLine("9. 5 TB necha GB ga teng => " + (5 * 1024));
            // Console.WriteLine("10. 5000 GB necha TB ga teng => " + (5000.0 / 1024));
            // Console.WriteLine("11. 8000 MB necha GB ga teng => " + (8000.0 / 1024));
            // Console.WriteLine("12. 12000 Bit necha KB ga teng => " + (12000.0 / 8 / 1024));
            // Console.WriteLine("13. 146 KB necha MB ga teng => " + (146.0 / 1024));
            // Console.WriteLine("14. 20000 Bit necha KB ga teng => " + (20000.0 / 8 / 1024));
            // Console.WriteLine("15. 4000 Bayt necha KB ga teng => " + (4000 / 1024.0));
            // Console.WriteLine("16. 80000 Bayt necha MB ga teng => " + (80000.0 / 1024 / 1024));
            // Console.WriteLine("17. 12000 MB necha TB ga teng => " + (12000.0 / 1024));
            // Console.WriteLine();
            //
            // Console.WriteLine("MASALA");
            //
            // Console.WriteLine("21. 3 MB va 8 KB jami necha KB => " + (3 * 1024 + 8));
            // Console.WriteLine("22. 7 GB va 11 MB jami necha KB => " + (7 * 1024 * 1024 + 11 * 1024));
            // Console.WriteLine("23. 12 Bayt va 8 KB jami necha Bit => " + (12 * 8 + 8 * 1024 * 8));
            // Console.WriteLine("24. 4 MB va 10 KB jami necha Bit => " + (4L * 1024 * 1024 * 8 + 10 * 1024 * 8));
            // Console.WriteLine();
            //
            // Console.WriteLine("ASCII FIGURES");
            //
            //
            // // 1
            // for (int i = 5; i >= 1; i--)
            // {
            //     for (int j = 1; j <= i; j++)
            //         Console.Write(j);
            //     Console.WriteLine();
            // }
            //
            //
            // // 2
            // for (int i = 1; i <= 5; i++)
            // {
            //     for (int j = 1; j <= i; j++)
            //         Console.Write(j);
            //     Console.WriteLine();
            // }
            //
            //
            // // 3
            // for (int i = 1; i <= 1; i++)
            // {
            //     for (int j = 1; j <= 5; j++)
            //         Console.Write(j);
            //     Console.WriteLine();
            // }
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // for (int j = 2; j <= 4; j++) Console.Write(j);
            // Console.WriteLine();
            //
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine(3);
            //
            //
            // // 4
            // for (int s = 0; s < 4; s++) Console.Write(" ");
            // Console.WriteLine(1);
            //
            // for (int s = 0; s < 3; s++) Console.Write(" ");
            // Console.WriteLine("212");
            //
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine("32123");
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // Console.WriteLine("4321234");
            //
            // Console.WriteLine("543212345");
            //
            //
            // // 5
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine(3);
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // Console.WriteLine("232");
            //
            // Console.WriteLine("12321");
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // Console.WriteLine("232");
            //
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine(3);
            //
            //
            // // 6
            // Console.WriteLine("1234321");
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // Console.WriteLine("23432");
            //
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine("343");
            //
            // for (int s = 0; s < 3; s++) Console.Write(" ");
            // Console.WriteLine("4");
            //
            // for (int s = 0; s < 3; s++) Console.Write(" ");
            // Console.WriteLine("5");
            //
            // for (int s = 0; s < 2; s++) Console.Write(" ");
            // Console.WriteLine("656");
            //
            // for (int s = 0; s < 1; s++) Console.Write(" ");
            // Console.WriteLine("76567");
            //
            // Console.WriteLine("8765678");
            //
            //
            // // 7
            // int h = 5, w = 6;
            //
            // for (int i = 0; i < h; i++)
            // {
            //     for (int j = 0; j < w; j++)
            //     {
            //         if (i == 0 || i == h - 1 || j == 0 || j == w - 1)
            //             Console.Write("1");
            //         else
            //             Console.Write(" ");
            //     }
            //
            //     Console.WriteLine();
            // }
            //
            //
            // // 8
            // int size = 8;
            //
            // for (int i = 0; i < size; i++)
            // {
            //     for (int j = 0; j < size; j++)
            //     {
            //
            //         if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
            //             Console.Write("0");
            //
            //         else if (j == i)
            //             Console.Write("0");
            //         else
            //             Console.Write(" ");
            //     }
            //
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("OSON");
            //
            //
            // // 1
            // {
            //     int inputNumber = int.Parse(Console.ReadLine());
            //     int resultNumber = inputNumber + 10;
            //     Console.WriteLine(resultNumber);
            // }
            //
            //
            // // 2
            // {
            //     int inputNumber = int.Parse(Console.ReadLine());
            //     int resultNumber = inputNumber - 10;
            //     Console.WriteLine(resultNumber);
            // }
            //
            //
            // // 3
            // {
            //     int firstNumber = int.Parse(Console.ReadLine());
            //     int secondNumber = int.Parse(Console.ReadLine());
            //
            //     int sum = firstNumber + secondNumber;
            //     Console.WriteLine(sum);
            // }
            //
            //
            // // 4
            // {
            //     int firstNumber = int.Parse(Console.ReadLine());
            //     int secondNumber = int.Parse(Console.ReadLine());
            //
            //     int difference = firstNumber - secondNumber;
            //     Console.WriteLine(difference);
            // }
            //
            //
            // // 5
            // {
            //     int firstNumber = int.Parse(Console.ReadLine());
            //     int secondNumber = int.Parse(Console.ReadLine());
            //
            //     int product = firstNumber * secondNumber;
            //     Console.WriteLine(product);
            // }
            //
            //
            // // 6
            // {
            //     int dividend = int.Parse(Console.ReadLine());
            //     int divisor = int.Parse(Console.ReadLine());
            //
            //     int quotient = dividend / divisor;
            //     Console.WriteLine(quotient);
            // }
            //
            //
            // // 7
            // {
            //     {
            //         int radius = int.Parse(Console.ReadLine());
            //
            //         int circleLength = 2 * 3 * radius;
            //         Console.WriteLine(circleLength);
            //     }
            // }
            //
            //
            // // 8
            // {
            //
            //     int radius = int.Parse(Console.ReadLine());
            //
            //     int circleArea = 3 * radius * radius;
            //     Console.WriteLine(circleArea);
            //
            // }
            //
            //
            // Console.WriteLine("QIYIN");
            //
            // // 1
            // int a =
            //     int.Parse(Console.ReadLine());
            // int b =
            //     int.Parse(Console.ReadLine());
            // int c =
            //     int.Parse(Console.ReadLine());
            // int d =
            //     int.Parse(Console.ReadLine());
            //
            // int sums = a + b + c + d;
            // Console.WriteLine(sums);
            //
            //
            // // 2
            // float e =
            //     float.Parse(Console.ReadLine());
            // float f =
            //     float.Parse(Console.ReadLine());
            // float g =
            //     float.Parse(Console.ReadLine());
            //
            // float average = (e + f + g) / 3;
            // Console.WriteLine(average);
            //
            //
            // float k =
            //     float.Parse(Console.ReadLine());
            // float l =
            //     float.Parse(Console.ReadLine());
            // float m =
            //     float.Parse(Console.ReadLine());
            // float n =
            //     float.Parse(Console.ReadLine());
            // float p =
            //     float.Parse(Console.ReadLine());
            //
            // float averagee = (k + l + m + n + p) / 5;
            // Console.WriteLine(averagee);
            //
            //
            // // 3
            // float o =
            //     float.Parse(Console.ReadLine());
            // float q =
            //     float.Parse(Console.ReadLine());
            // float r =
            //     float.Parse(Console.ReadLine());
            // float t =
            //     float.Parse(Console.ReadLine());
            // float u =
            //     float.Parse(Console.ReadLine());
            // float v =
            //     float.Parse(Console.ReadLine());
            // float x =
            //     float.Parse(Console.ReadLine());
            // float y =
            //     float.Parse(Console.ReadLine());
            //
            // float averag = (o + q + r + t + u + v + x + y) / 8;
            // Console.WriteLine(averag);
            //
            //
            // // 4 
            // int firstnumber = int.Parse(Console.ReadLine());
            // int secondnumber = int.Parse(Console.ReadLine());
            //
            // int temp = firstnumber;
            // firstnumber = secondnumber;
            // secondnumber = temp;
            //
            // Console.WriteLine(firstnumber);
            // Console.WriteLine(secondnumber);
            //
            //
            // // 5 
            // int minutes =
            //     int.Parse(Console.ReadLine());
            // int seconds = minutes * 60;
            // Console.WriteLine(seconds);
            //
            //
            // // 6 
            // int hours = int.Parse(Console.ReadLine());
            // int secondss = hours * 3600;
            // Console.WriteLine(secondss);
            //
            // // 7
            // int days = int.Parse(Console.ReadLine());
            // int minutess = days * 24 * 60;
            // Console.WriteLine(minutess);
            //
            // // 8 
            // int minute = int.Parse(Console.ReadLine());
            // int hour = minute / 60;
            // Console.WriteLine(hour);
            //
            //
            // // 9
            // int minut = int.Parse(Console.ReadLine());
            // int day = minut / (24 * 60);
            // Console.WriteLine(day);
            //
            // Console.WriteLine("JUDA QIYIN MASALALAR");
            //
            //
            //
            // // 1
            // {
            //     int age = int.Parse(Console.ReadLine());
            //     int birthYear = 2024 - age;
            //     Console.WriteLine(birthYear);
            // }
            //
            //
            // // 2
            // {
            //     int number = int.Parse(Console.ReadLine());
            //     int bigger = number + 1;
            //     int smaller = number - 1;
            //     Console.WriteLine(bigger);
            //     Console.WriteLine(smaller);
            // }
            //
            //
            // // 3
            // {
            //     int number = int.Parse(Console.ReadLine());
            //     int bigger10 = number + 10;
            //     int smaller15 = number - 15;
            //     Console.WriteLine(bigger10);
            //     Console.WriteLine(smaller15);
            // }
            //
            // // 4
            // {
            //     int aa = int.Parse(Console.ReadLine());
            //     int bb = int.Parse(Console.ReadLine());
            //
            //     int sum = aa + bb;
            //     int diff = aa - bb;
            //     int product = aa * bb;
            //     double division = (double)aa / bb;
            //
            //     Console.WriteLine(sum);
            //     Console.WriteLine(diff);
            //     Console.WriteLine(product);
            //     Console.WriteLine(division);
            // }
            //
            // // 5
            // {
            //     int number = int.Parse(Console.ReadLine());
            //
            //     int x3 = number * 3;
            //     int x4 = number * 4;
            //     int x5 = number * 5;
            //
            //     Console.WriteLine(x3);
            //     Console.WriteLine(x4);
            //     Console.WriteLine(x5);
            // }
            
           
            // 1
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 % 10);

            // 2
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine((n2 / 10) % 10);

            // 3
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(n3 / 100);

            // 4
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine((n4 / 1000) % 10);

            // 5
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine((n5 / 100) % 10);

            // 6
            int n6 = int.Parse(Console.ReadLine());
            int sum6 = n6 / 100 + (n6 / 10) % 10 + n6 % 10;
            Console.WriteLine(sum6);

            // 7
            int n7 = int.Parse(Console.ReadLine());
            int prod7 = (n7 / 100) * ((n7 / 10) % 10) * (n7 % 10);
            Console.WriteLine(prod7);

            // 8
            int n8 = int.Parse(Console.ReadLine());
            Console.WriteLine((n8 / 10) * (n8 % 10));

            // 9
            int n9 = int.Parse(Console.ReadLine());
            int sum9 = n9 / 10000 + (n9 / 1000) % 10 + (n9 / 100) % 10 + (n9 / 10) % 10 + n9 % 10;
            Console.WriteLine(sum9);

            // 10
            int n10 = int.Parse(Console.ReadLine());
            int rev10 = (n10 % 10) * 100 + ((n10 / 10) % 10) * 10 + (n10 / 100);
            Console.WriteLine(rev10);

            // 11
            int n11 = int.Parse(Console.ReadLine());
            int a11 = n11 / 100;
            int b11 = (n11 / 10) % 10;
            int c11 = n11 % 10;
            Console.WriteLine(a11 * 100 + c11 * 10 + b11);

            // 12
            int n12 = int.Parse(Console.ReadLine());
            int a12 = n12 / 100;
            int b12 = (n12 / 10) % 10;
            int c12 = n12 % 10;
            Console.WriteLine(b12 * 100 + a12 * 10 + c12);

            // 13
            int n13 = int.Parse(Console.ReadLine());
            int a13 = n13 / 1000;
            int b13 = (n13 / 10) % 10;
            int c13 = (n13 / 100) % 10;
            int d13 = n13 % 10;
            Console.WriteLine(b13 * 1000 + c13 * 100 + a13 * 10 + d13);

            // 14
            int gb14 = int.Parse(Console.ReadLine());
            Console.WriteLine(gb14 * 1024);

            // 15
            int gb15 = int.Parse(Console.ReadLine());
            Console.WriteLine(gb15 * 1024L * 1024 * 1024 * 8);

            // 16
            int gb16 = int.Parse(Console.ReadLine());
            Console.WriteLine((double)gb16 / 1024);

            // 17
            int gb17 = int.Parse(Console.ReadLine());
            Console.WriteLine(gb17 / 2);

            // 18
            int gb18 = int.Parse(Console.ReadLine());
            Console.WriteLine(gb18 / 5);

            // 19
            int n19 = int.Parse(Console.ReadLine());
            int a19 = n19 / 100;
            int rest19 = n19 % 100;
            Console.WriteLine(rest19 * 10 + a19);

           // 20
           int n20 = int.Parse(Console.ReadLine());
           int a20 = n20 % 10;
           int rest20 = n20 / 10;
          Console.WriteLine(a20 * 100 + rest20);
        }
    }
}






        
    
