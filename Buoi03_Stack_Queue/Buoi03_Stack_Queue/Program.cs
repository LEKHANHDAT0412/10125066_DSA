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
        Console.WriteLine("=== Bài 6 ==="); Bai6.Chay();
        Console.WriteLine("=== Bài 7 ==="); Bai7.Chay();
        Console.WriteLine("=== Bài 8 ==="); Bai8.Chay();
    } 
    }

class Bai1
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    static long S(int n) { return n == 1 ? 1 : S(n - 1) + n; }
    public static void Chay()
    {
        
        int n = Nhap("n (1.1000): ", 1, 1000);
        Console.WriteLine("S(n) = " + S(n));
    }
}



class Bai2
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    static long S(int n) { return n == 1 ? 1 : S(n - 1) + (long)n * n; }
    public static void Chay()
    {
        
        int n = Nhap("n (1.1000): ", 1, 1000);
        Console.WriteLine("S(n) = " + S(n));
    }
}



class Bai3
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    static double S(int n) { return n == 1 ? 1 : S(n - 1) + 1.0 / n; }
    public static void Chay()
    {
        
        int n = Nhap("n (1.1000): ", 1, 1000);
        Console.WriteLine("S(n) = " + S(n));
    }
}



class Bai4
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    static double LuyThua(double x, int n) { return n == 0 ? 1 : x * LuyThua(x, n - 1); }
    public static void Chay()
    {
        Console.Write("x (dấu thập phân theo máy): ");
        if (!double.TryParse(Console.ReadLine(), out double x)
            || double.IsNaN(x) || double.IsInfinity(x)) { Console.WriteLine("x không hợp lệ."); return; }
        int n = Nhap("n (-1000.1000): ", -1000, 1000);
        if (x == 0 && n <= 0) { Console.WriteLine("Không xác định với x=0, n<=0."); return; }
        
        double result = n < 0 ? LuyThua(1.0 / x, -n) : LuyThua(x, n);
        Console.WriteLine("x^n = " + result);
        if (double.IsInfinity(result)) Console.WriteLine("Kết quả vượt phạm vi double.");
    }
}



class Bai5
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    
    static int UocLe(int n) { return n % 2 == 1 ? n : UocLe(n / 2); }
    public static void Chay()
    {
        int n = Nhap("n > 0: ", 1, int.MaxValue);
        Console.WriteLine("Ước lẻ lớn nhất: " + UocLe(n));
    }
}



class Bai6
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    
    static int UCLN(int a, int b) { return b == 0 ? a : UCLN(b, a % b); }
    public static void Chay()
    {
        int a = Nhap("a > 0: ", 1, int.MaxValue);
        int b = Nhap("b > 0: ", 1, int.MaxValue);
        Console.WriteLine("Ước chung lớn nhất: " + UCLN(a, b));
    }
}



class Bai7
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    
    static int Dem(int n) { return n == 0 ? 0 : 1 + Dem(n / 10); }
    public static void Chay()
    {
        int n = Nhap("n > 0: ", 1, int.MaxValue);
        Console.WriteLine("Số chữ số: " + Dem(n));
    }
}



class Bai8
{
    static int Nhap(string label, int min, int max)
    {
        while (true)
        {
            Console.Write(label);
            string s = Console.ReadLine();
            if (s == null) throw new Exception("Đã hết dữ liệu nhập.");
            if (int.TryParse(s, out int n) && n >= min && n <= max) return n;
            Console.WriteLine("Nhập số nguyên trong [" + min + ", " + max + "].");
        }
    }
    
    
    static double Can(int i, int n)
    {
        return i == n ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));
    }
    public static void Chay()
    {
        int n = Nhap("n (1.1000): ", 1, 1000);
        Console.WriteLine("S(n) = " + Can(1, n));
    }
}




