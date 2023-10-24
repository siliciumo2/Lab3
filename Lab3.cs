Console.WriteLine("Введите a,b,c,d,e");
int chet = 0;
for (int i = 1; i <= 5; i++) {
    int n = Convert.ToInt32(Console.ReadLine());
    if (n % 2 == 0) {
        chet++;
    }
}
Console.WriteLine($"Четные числа - {chet}");