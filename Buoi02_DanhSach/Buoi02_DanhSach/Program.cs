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
    
    
    static void Hanoi(int n, char nguon, char phu, char dich)
    {
        if (n == 0) return;
        Hanoi(n - 1, nguon, dich, phu);
        Console.WriteLine("Đĩa " + n + ": " + nguon + " -> " + dich);
        Hanoi(n - 1, phu, nguon, dich);
    }
    public static void Chay()
    {
        int n = Nhap("Số đĩa (1.20, giới hạn để tránh in quá nhiều): ", 1, 20);
        Hanoi(n, 'A', 'B', 'C');
        Console.WriteLine("Tổng bước: " + (Math.Pow(2, n) - 1));
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
    
    
    
    static int Tim(int[] a, int x, int l, int r)
    {
        if (l > r) return -1;
        int m = l + (r - l) / 2;
        if (a[m] == x) return m;
        return x < a[m] ? Tim(a, x, l, m - 1) : Tim(a, x, m + 1, r);
    }
    public static void Chay()
    {
        int n = Nhap("Số phần tử: ", 0, 100000);
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = Nhap("a[" + i + "] = ", int.MinValue, int.MaxValue);
        for (int i = 1; i < n; i++)
            if (a[i] < a[i-1]) { Console.WriteLine("Mảng chưa tăng dần."); return; }
        int x = Nhap("Giá trị cần tìm: ", int.MinValue, int.MaxValue);
        Console.WriteLine("Chỉ số: " + Tim(a, x, 0, n - 1));
    }
}



class Bai3
{
    
    
    static double Do(int n, int cach, int soLan)
    {
        bool ketQua = default(bool);
        DateTime batDau = DateTime.Now;
        for (int lan = 0; lan < soLan; lan++) { if (cach == 1) ketQua = CoBan(n); else ketQua = CaiTien(n); }
        double ms = (DateTime.Now - batDau).TotalMilliseconds / soLan;
        Console.Write(" "); 
        return ms;
    }
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
    
    static bool CoBan(int n)
    {
        if (n < 2) return false;
        for (int d = 2; d < n; d++) if (n % d == 0) return false;
        return true;
    }
    
    
    static bool CaiTien(int n)
    {
        if (n < 2) return false;
        for (int d = 2; d <= n / d; d++) if (n % d == 0) return false;
        return true;
    }
    public static void Chay()
    {
        int n = Nhap("n (1.10000000): ", 1, 10000000);
        Console.WriteLine("Cơ bản: " + (CoBan(n) ? "Là số nguyên tố" : "Không phải số nguyên tố") + "; Cải tiến: " + (CaiTien(n) ? "Là số nguyên tố" : "Không phải số nguyên tố"));
        Console.WriteLine("n\tCơ bản (ms)\tCải tiến (ms)");
        foreach (int k in new[] {1009, 10007, 100003, 1000003})
            Console.WriteLine(k + "\t" + Do(k, 1, 10).ToString("F6") + "\t" + Do(k, 2, 100).ToString("F6"));
    }
}



class Bai4
{
    
    
    static double Do(int n, int cach, int soLan)
    {
        bool ketQua = default(bool);
        DateTime batDau = DateTime.Now;
        for (int lan = 0; lan < soLan; lan++) { for (int j = 1; j < n; j++) { if (cach == 1) ketQua = CoBan(j); else ketQua = CaiTien(j); } }
        double ms = (DateTime.Now - batDau).TotalMilliseconds / soLan;
        Console.Write(" "); 
        return ms;
    }
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
    static bool CoBan(int n)
    {
        long sum = 0;
        for (int d = 1; d < n; d++) if (n % d == 0) sum += d;
        return n > 1 && sum == n;
    }
    static bool CaiTien(int n)
    {
        if (n < 2) return false;
        long sum = 1;
        for (int d = 2; d <= n / d; d++)
            if (n % d == 0)
            {
                sum += d;
                if (d != n / d) sum += n / d; 
            }
        return sum == n;
    }
    
    
    static void LietKe(int n, int cach)
    {
        
        for (int i = 1; i < n; i++) { bool dung; if (cach == 1) dung = CoBan(i); else dung = CaiTien(i); if (dung) Console.Write(i + " "); }
        Console.WriteLine();
    }
    public static void Chay()
    {
        int n = Nhap("N (1.20000): ", 1, 20000);
        Console.Write("Cơ bản: "); LietKe(n, 1);
        Console.Write("Cải tiến: "); LietKe(n, 2);
        Console.WriteLine("N\tCơ bản (ms)\tCải tiến (ms)");
        foreach (int k in new[] {500, 1000, 2000, 5000})
            Console.WriteLine(k + "\t" + Do(k, 1, 3).ToString("F6") + "\t" + Do(k, 2, 3).ToString("F6"));
    }
}



class Bai5
{
    
    
    static double Do(int n, int cach, int soLan)
    {
        long ketQua = default(long);
        DateTime batDau = DateTime.Now;
        for (int lan = 0; lan < soLan; lan++) { if (cach == 1) ketQua = DeQuy(n); else ketQua = Lap(n); }
        double ms = (DateTime.Now - batDau).TotalMilliseconds / soLan;
        Console.Write(" "); 
        return ms;
    }
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
    
    
    static long DeQuy(int n) { return n < 2 ? n : DeQuy(n-1) + DeQuy(n-2); }
    
    static long Lap(int n)
    {
        if (n < 2) return n;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++) { long c = a + b; a = b; b = c; }
        return b;
    }
    public static void Chay()
    {
        int n = Nhap("n (0.92): ", 0, 92);
        Console.WriteLine("Lặp: " + Lap(n));
        if (n <= 35) Console.WriteLine("Đệ quy: " + DeQuy(n));
        else Console.WriteLine("Bỏ qua đệ quy trực tiếp với n > 35 vì rất chậm.");
        Console.WriteLine("n\tĐệ quy (ms)\tLặp (ms)");
        foreach (int k in new[] {10, 20, 25, 30, 35})
            Console.WriteLine(k + "\t" + Do(k, 1, 3).ToString("F6") + "\t" + Do(k, 2, 10000).ToString("F6"));
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
    
    static void Bubble(double[] a)
    {
        for (int end = a.Length - 1; end > 0; end--)
        {
            bool changed = false;
            for (int j = 0; j < end; j++)
                if (a[j] > a[j+1])
                { double t = a[j]; a[j] = a[j+1]; a[j+1] = t; changed = true; }
            if (!changed) break;
        }
    }
    
    static void Selection(double[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int min = i;
            for (int j = i+1; j < a.Length; j++) if (a[j] < a[min]) min = j;
            double t = a[i]; a[i] = a[min]; a[min] = t;
        }
    }
    static double Do(double[] source, int cach)
    {
        
        double ms = 0;
        for (int r = 0; r < 3; r++)
        {
            double[] a = new double[source.Length]; for (int i = 0; i < source.Length; i++) a[i] = source[i]; 
            DateTime batDau = DateTime.Now; if (cach == 1) Bubble(a); else Selection(a);
            ms += (DateTime.Now - batDau).TotalMilliseconds;
            
        }
        return ms / 3;
    }
    public static void Chay()
    {
        int n = Nhap("Số phần tử (0.10000): ", 0, 10000);
        double[] a = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] (dấu thập phân theo máy): ");
            string s = Console.ReadLine();
            if (s == null) return;
            if (!double.TryParse(s, out a[i])
                || double.IsNaN(a[i]) || double.IsInfinity(a[i]))
            { Console.WriteLine("Số không hợp lệ."); i--; }
        }
        double[] b = new double[n]; for (int i = 0; i < n; i++) b[i] = a[i];
        Bubble(a); Selection(b);
        Console.Write("Sắp xếp nổi bọt: "); for (int i = 0; i < n; i++) Console.Write(a[i] + " "); Console.WriteLine();
        Console.Write("Sắp xếp chọn: "); for (int i = 0; i < n; i++) Console.Write(b[i] + " "); Console.WriteLine();
        Console.WriteLine("n\tNổi bọt (ms)\tChọn (ms)");
        Random random = new Random(42);
        foreach (int k in new[] {500, 1000, 2000, 5000})
        {
            double[] source = new double[k];
            for (int i = 0; i < k; i++) source[i] = random.NextDouble();
            Console.WriteLine(k + "\t" + Do(source, 1).ToString("F6") + "\t" + Do(source, 2).ToString("F6"));
        }
    }
}




