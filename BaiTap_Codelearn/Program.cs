// 1
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

//2
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Codelearn.io!");
        }
    }
}

//3
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Codelearn");
            Console.WriteLine("Date of birth: 2019");
        }
    }
}

//4
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(313 + 122);
        }
    }
}

//5
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(37 * 56);
        }
    }
}

//6
/*
A simple C# program to display "Hello, World!" on the screen
using Console.WriteLine() statement
*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display Hello World on the screen
            Console.WriteLine("Hello, World!");
        }
    }
}

//7
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("125 + 206 = " + (125 + 206));
        }
    }
}

//8
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2468 + 1234 = " + (2468 + 1234));
            Console.WriteLine("2468 - 1234 = " + (2468 - 1234));
            Console.WriteLine("2468 * 1234 = " + (2468 * 1234));
            Console.WriteLine("2468 / 1234 = " + (2468 / 1234));
        }
    }
}

//9

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 254;
            int b = 343;
            Console.WriteLine("a + b = " + (a + b));
        }
    }
}

// 10
using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8343;
            int b = 6453;
            Console.WriteLine(" a - b = " + (a - b));
        }
    }
}

// 11
using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
        }
    }
}

// 12
using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Codelearn";
            Console.WriteLine("Hello " + name);
        }
    }
}

// 13

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Codelearn";
            int dob = 2019;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date of birth: " + dob);
        }
    }
}

// 14

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.5;
            int b = 7;
            Console.WriteLine("a / b = " + (a / b));
        }
    }
}

// 15

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 7.5;
            double w = 3.8;
            Console.WriteLine("Area = " + l * w);
        }
    }
}

// 16

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'x';
            Console.WriteLine(c);
        }
    }
}

// 17

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            char d = (char)('a' + 3);
            Console.WriteLine(d);
        }
    }
}

// 18

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 384847522;
            long b = 988347273;
            Console.WriteLine(a * b);
        }
    }
}

// 19

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Console.WriteLine(b);
        }
    }
}

// 20

Quiz: short;


// 21

using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}

// 22

using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            string address = Console.ReadLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
}

// 23

using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}

// 24

using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + (l * w));
        }
    }
}

// 25

using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a % b = " + a % b);
        }
    }
}

// 26

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
        }
    }
}
// 27
using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 15 years, age of " + name + " will be " + (age + 15));
        }
    }
}
// 28
using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("after swapping, a = " + a + ", b = " + b);
        }
    }
}
// 29
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine("Circumference = " + (2 * pi * r));
        }
    }
}
// 30
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = (char)(char.Parse(Console.ReadLine()) + 1);
            Console.WriteLine(c);
        }
    }
}
// 31
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b);
        }
    }
}
// 32

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("n is an even number");
            }
            else
            {
                Console.WriteLine("n is an odd number");
            }
        }
    }
}
// 33
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("n is a positive number");
            }
            if (n < 0)
            {
                Console.WriteLine("n is a negative number");
            }
            if (n == 0)
            {
                Console.WriteLine("n is equal to 0");
            }
        }
    }
}
// 34
namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("a is greater than or equal to b");
            }
            else
            {
                Console.WriteLine("a is smaller than b");
            }
        }
    }
}
// 35
namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            if (name1 == name2)
            {
                Console.WriteLine("two people have the same name");
            }
            else
            {
                Console.WriteLine("two people don't have the same name");
            }
        }
    }
}
// 36

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                Console.WriteLine("a is not equal to 0 and b is not equal to 0");
            }
            else
            {
                Console.WriteLine("a is equal to 0 or b is equal to 0");
            }
        }
    }
}
// 37
namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            if (c >= a && c >= b)
            {
                Console.WriteLine(c);
            }

        }
    }
}
// 38
namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 10 && a <= 100)
            {
                Console.WriteLine(a + " is in the range [10, 100]");
            }
            else
            {
                Console.WriteLine(a + " is not in the range [10, 100]");
            }
        }
    }
}
// 39
namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 10)
            {
                Console.WriteLine("The score is valid");
            }
            else
            {
                Console.WriteLine("The score is not valid");
            }
        }
    }
}
// 40

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c)
            {
                Console.WriteLine("increasing");
            }
            else if (a >= b && b >= c)
            {
                Console.WriteLine("decreasing");
            }
            else
            {
                Console.WriteLine("neither increasing nor decreasing order");
            }
        }
    }
}
// 41

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
// 42
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
// 43
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= -n; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}
// 44
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                c += i;
            }
            Console.WriteLine(c);
        }
    }
}
// 45
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    a += i;
                }
            }
            Console.WriteLine(a);

        }
    }
}
// 46
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
// 47
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                tmp *= i;
            }
            Console.WriteLine(tmp);
        }
    }
}
// 48
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
// 49
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i * 5 + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
// 50
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n <= 100)
            {
                if (n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
                n++;
            }
        }
    }
}
// 51
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int answer = 0;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    answer++;
                }
                i++;
            }
            Console.Write(answer);
        }
    }
}
// 52
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int answer = 1;
            while (b > 0)
            {
                answer *= a;
                b--;
            }
            Console.Write(answer);
        }
    }
}
// 53
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {
                if (a % 3 == 0 && a % 5 == 0)
                    Console.Write(a + " ");
                a++;
            }


        }
    }
}
// 54
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 51)
                {
                    break;
                }
                Console.Write(i + " ");
            }
        }
    }
}
// 55
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
        }
    }
}
// 56
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {

                Console.Write(i + " ");
                i++;
            } while (i <= 5);
        }
    }
}
// 57
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                if (i % 10 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            } while (i <= 1000);
        }
    }
}
// 58
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
// 59
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
// 60
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(a[0] + (a[n - 1]));
        }
    }
}
// 61
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }

            }
        }
    }
}
// 62
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == k)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
// 63
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 && a[i] % 2 != 0)
                {
                    b += a[i];
                }
            }
            Console.WriteLine(b);
        }
    }
}
// 64
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0 && a[i] <= 10)
                {
                    Console.Write(a[i] + " ");
                }
            }

        }
    }
}
// 65
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
// 66
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
// 67
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 5 == 0)
                    {
                        b += a[i, j];
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}
// 68
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(s[k - 1]);
        }
    }
}
// 69
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
// 70
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int a = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    a = i;
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
// 71
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            Console.WriteLine(s1.IndexOf(s2));
        }
    }
}
// 72
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (char c = '0'; c <= '9'; c++)
            {
                s = s.Replace(c + "", "");
            }
            Console.WriteLine(s);
        }
    }
}
// 73
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    a++;
                }
            }
            Console.WriteLine(a);
        }
    }
}
// 74
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
// 75
namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfArray(arr));
        }

        public static int sumOfArray(int[] arr)
        {
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += arr[i];
            }
            return a;
        }
    }
}
// 76
namespace Method
{
    class Program
    {
        public static void Show(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 5 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Show(arr);
        }
    }
}
// 77
namespace Method
{
    class Program
    {
        public static void Show(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 3)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Show(arr);
        }
    }
}
// 78
namespace Method
{
    class Program
    {
        public static int Max3(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            if (b >= c)
            {
                return b;
            }
            return c;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write(Max3(a, b, c));
        }
    }
}
// 79
namespace Method
{
    class Program
    {
        public static double Circumference(double r)
        {
            return 2 * r * 3.14;
        }

        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Circumference(r));
        }
    }
}
// 80
namespace Method
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}
// 81
namespace Method
{
    class Program
    {
        public static int Sum(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0)
            {
                return Sum(n - 1);
            }
            else
            {
                return n + Sum(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }
    }
}
// 82
namespace Method
{
    class Program
    {
        public static int SumOfArray(int[] arr, int n)
        {
            if (n == 1) return arr[0];
            return arr[n - 1] + SumOfArray(arr, n - 1);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(SumOfArray(arr, n));
        }
    }
}