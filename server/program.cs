class Program

{
    static void Main()
{
Console.WriteLine("Здравсвуйте!");
Console.WriteLine("Корначев Кирилл Александрович");
Console.WriteLine("Группа: ИСП-243");
Console.WriteLine("Дата: 22.09.2026");
Console.WriteLine("1 - Показать ФИО");
Console.WriteLine("2 - Показать группу");
Console.WriteLine("3 - Показать дату");
Console.WriteLine("4 - Выход");
Console.Write("Выберите пункт: ");

string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Корначев Кирилл Александрович");
        }
        else if (choice == "2")
        {
            Console.WriteLine("ИСП-243");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Дата: 22.09.2026");
        }
        else if (choice == "4")
        {
            Console.WriteLine("Пока");
        }
        else
        {
            Console.WriteLine("Неверный пункт");
        }

        Console.ReadLine();
    }
}

