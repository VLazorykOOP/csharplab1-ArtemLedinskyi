
 static void Main()
{
    Console.WriteLine("Choose Task");
    int task = int.Parse(Console.ReadLine());
    switch (task)
    {
        case 1:
            Console.WriteLine("Enter x1");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x3");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y3");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Task1(x1, y1, x2, y2, x3, y3));
            break;
        case 2:
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Task2(num));
            break;
        case 3:
            Console.WriteLine("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y : ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Task3(x, y));
            break;
        case 4:
            Console.WriteLine("Enter day : ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mounth : ");
            int mounth = int.Parse(Console.ReadLine());
            Console.WriteLine(Task4(day, mounth));
            break;
        case 5:
            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());
            Task5(firstnumber, secondnumber);
            break;
        case 6:
            Console.WriteLine("Enter x : ");
            double _x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y : ");
            double _y = double.Parse(Console.ReadLine());
            Console.WriteLine(Task6(_x, _y));
            break;
    }

}

static double Task1(int x1, int y1, int x2, int y2, int x3, int y3)
{
    double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
    double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
    return AB + AC + BC;
}

static string Task2(int num)
{
    string result = IsTwoDigitNumberForTask2(num) ? (IsSumDivByThreeForTask2(num)
       ? $"Сума цифр числа {num} кратна 3."
       : $"Сума цифр числа {num} не кратна 3.")
       : "Введено не двозначне число";
    return result;



}

static string Task3(int x, int y)
{
    return (x > -50 && x < 50 && y > -25 && y < 25) ? "Так"
                  : (x == -50 & x == 50 & y == -25 & y == 25) ? "На межі" : "Ні";
}

static string Task4(int n, int m)
{
    DateTime start = new DateTime(1990, 1, 1);
    DateTime current = start.AddDays(n).AddMonths(m);
    return current.ToString("MMMM");
}

static void Task5(int num1, int num2)
{
    Console.WriteLine(SquareOfProduct(num1, num2));
    
}



/* static int SquareOfProduct(int num1, int num2)
 {
     int product = num1*num2;
     return product*product;
 }*/ //повний опис методу

static double Task6(double x, double y)
{
    return ((x * Math.Pow(y, 2) + Math.Pow(x, 2)) / (x * y + 1)) * (x - y);
}

static int SquareOfProduct(int num1, int num2) => (num1 * num2) * (num1 * num2);// лямбда-вираз. 

static bool IsTwoDigitNumberForTask2(int num)
{
    return num >= 10 && num <= 99;
}
// static bool IsTwoDigitNumberForTask2(int num) => num >= 10 && num <= 99; лямбда-вираз.

static bool IsSumDivByThreeForTask2(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum % 3 == 0;
}
Main();
