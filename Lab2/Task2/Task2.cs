bool IsTrue = true;

while(IsTrue)
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    if(x < 15 && y < 15)
    {
        if (Math.Abs(x) == y || Math.Pow(x, 2) + Math.Pow(y, 2) == 225 )
        {
            Console.WriteLine("На границе");
        }
        else if(Math.Abs(x) < y)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }
    string? s = null;
    while (s != "1" && s != "2")
    {
        Console.WriteLine("Выберите пункт:");
        Console.WriteLine("1) Продолжить;");
        Console.WriteLine("2) Закончить;");
        s = Console.ReadLine();
    }
    switch (s)
    {
        case "1":
            continue;
        case "2":
            IsTrue = false;
            break;
        default:
            break;
    }
}