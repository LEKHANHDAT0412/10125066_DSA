using System;
    class Program { 
    static void Main() { 
    Console.InputEncoding = System.Text.Encoding.UTF8; 
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.WriteLine("=== Bài 1 ==="); Bai1.Chay();
    Console.WriteLine("=== Bài 2 ==="); Bai2.Chay();
    Console.WriteLine("=== Bài 3 ==="); Bai3.Chay();
    Console.WriteLine("=== Bài 4 ==="); Bai4.Chay();
    Console.WriteLine("=== Bài 5 ==="); Bai5.Chay();
    } 
    }


    class Bai1
    {
        public static void Chay()
        {
            
            int[] a = new int[1000];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = random.Next(0, 10000);

            
            int min = a[0], max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
            }
            Console.WriteLine("Số lớn nhất: " + max);
            Console.WriteLine("Số nhỏ nhất: " + min);
            
        }
    }



    class Bai2
    {
        public static void Chay()
        {
            for (int i = 1; i <= 100; i++)
            {
                
                
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }



    class Bai3
    {
        public static void Chay()
        {
            Console.Write("Nhập chuỗi: ");
            string s = Console.ReadLine() ?? "";
            char[] a = s.ToCharArray();

            
            int left = 0, right = a.Length - 1;
            while (left < right)
            {
                char temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine("Chuỗi đảo ngược: " + new string(a));
            
            
        }
    }



    class Bai4
    {
        public static void Chay()
        {
            int[] a = new int[1000];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = random.Next(0, 10000);

            Console.WriteLine("Mảng ban đầu:");
            InMang(a);
            SapXepChon(a);
            Console.WriteLine("Mảng tăng dần:");
            InMang(a);
        }

        static void SapXepChon(int[] a)
        {
            
            
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] < a[minIndex]) minIndex = j;

                int temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }

        static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
                if ((i + 1) % 10 == 0) Console.WriteLine();
            }
            if (a.Length % 10 != 0) Console.WriteLine();
        }
    }



    class Bai5
    {
        public static void Chay()
        {
            Console.Write("Nhập n (1.93): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 93)
            {
                Console.Write("Không hợp lệ. Nhập lại n trong 1.93: ");
            }

            
            
            long previous = 0;
            long current = 1;
            for (int i = 1; i < n; i++)
            {
                long next = 0; if (i < n - 1) next = previous + current;
                previous = current;
                if (i < n - 1) current = next;
            }
            Console.WriteLine("Số Fibonacci thứ " + n + ": " + previous);
            
        }
    }


