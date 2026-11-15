# Chương 2 – CTDL&GT 211131

Lê Khánh Đạt · MSV 10125066 · Lớp 10125O.1

## Cách chạy

Cần .NET SDK 10. Từ thư mục gốc:

```sh
dotnet run --project Chuong02_DoPhucTap
```

## Dữ liệu nhập mẫu

Mỗi giá trị một dòng. Dấu thập phân theo thiết lập máy.

```text
3
5
1
3
5
7
9
7
97
500
10
5
3
-1
2
2
0
```

## Kết quả chạy

```text
=== Bài 1 ===
Số đĩa (1.20, giới hạn để tránh in quá nhiều): Đĩa 1: A -> C
Đĩa 2: A -> B
Đĩa 1: C -> B
Đĩa 3: A -> C
Đĩa 1: B -> A
Đĩa 2: B -> C
Đĩa 1: A -> C
Tổng bước: 7
=== Bài 2 ===
Số phần tử: a[0] = a[1] = a[2] = a[3] = a[4] = Giá trị cần tìm: Chỉ số: 3
=== Bài 3 ===
n (1.10000000): Cơ bản: Là số nguyên tố; Cải tiến: Là số nguyên tố
n	Cơ bản (ms)	Cải tiến (ms)
  1009	0,108540	0,000093
  10007	0,012810	0,000267
  100003	0,128860	0,000820
  1000003	1,302950	0,002604
=== Bài 4 ===
N (1.20000): Cơ bản: 6 28 496 
Cải tiến: 6 28 496 
N	Cơ bản (ms)	Cải tiến (ms)
  500	0,195967	0,031367
  1000	0,699567	0,078600
  2000	2,893267	0,219500
  5000	16,691733	0,827367
=== Bài 5 ===
n (0.92): Lặp: 55
Đệ quy: 55
n	Đệ quy (ms)	Lặp (ms)
  10	0,000933	0,000032
  20	0,040533	0,000037
  25	0,462267	0,000066
  30	4,789767	0,000058
  35	52,854700	0,000071
=== Bài 6 ===
Số phần tử (0.10000): a[0] (dấu thập phân theo máy): a[1] (dấu thập phân theo máy): a[2] (dấu thập phân theo máy): a[3] (dấu thập phân theo máy): a[4] (dấu thập phân theo máy): Sắp xếp nổi bọt: -1 0 2 2 3 
Sắp xếp chọn: -1 0 2 2 3 
n	Nổi bọt (ms)	Chọn (ms)
500	0,320333	0,174700
1000	1,288067	0,634100
2000	5,278867	2,733367
5000	38,565767	14,997233
```
