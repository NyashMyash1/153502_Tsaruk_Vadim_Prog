bool IsTrue = true;

while(IsTrue)
{
    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());    
    if(m % n == 0)
    {
        Console.WriteLine($"Частное: {m / n}");
    }
    else
    {
        Console.WriteLine("M на N нацело не делится");
    }

    string? s = null;
    while (s != "1" && s != "2")
    {
        Console.WriteLine("Выберите пункт:");
        Console.WriteLine("1) Продолжить;");
        Console.WriteLine("2) Закончить;");
        s = Console.ReadLine();
    }
    switch(s)
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
