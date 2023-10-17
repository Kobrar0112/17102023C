using ConsoleApp1;
using System.Data;
using System.Globalization;

DateTime d = DateTime.Now;
DateTime D = DateTime.Now;
ConsoleKeyInfo key;
int pos = 1;

Tip t = new Tip();
t.name = " 1.Возможно";
t.date = DateTime.Parse("2023-10-17");

Tip t1 = new Tip();
t1.name = " 1.Допустим";
t1.date = DateTime.Parse("2023-10-18");

Tip t2 = new Tip();
t2.name = " 1.Открыть гараж";
t2.date = DateTime.Parse("2023-10-19");

Tip t3 = new Tip();
t3.name = " 1.Старт";
t3.date = DateTime.Parse("2023-10-20");

Tip t4 = new Tip();
t4.name = " 2.Стоп";
t4.date = DateTime.Parse("2023-10-20");

var allTips = new List<Tip>() { t, t1, t2, t3, t4 };


Console.WriteLine("Заметки на " + D.ToString("D"));


bool IsValidDateTime(DateTime fromNote)
{
    return fromNote.Date == D.Date;
}

do
{
    

    key = Console.ReadKey();

    Console.SetCursorPosition(0, pos);
    Console.WriteLine("  ");
    if (key.Key == ConsoleKey.RightArrow)
    {
        Console.Clear();
        D = D.AddDays(1);

        /////////////////////////////////// вот этот блок можно перенести в отдельный метод
        Console.WriteLine("Заметки на " + D.ToString("D"));
        for (int i = 0; i < allTips.Count; i++)
        {
            if (IsValidDateTime(allTips[i].date))
            {
                Console.WriteLine("  " + allTips[i].name);
            }

        }
        ///////////////////////////////////
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        Console.Clear();
        D = D.AddDays(-1);
        Console.WriteLine("Заметки на " + D.ToString("D"));
        for (int i = 0; i < allTips.Count; i++)
        {
            if (IsValidDateTime(allTips[i].date))
            {
                Console.WriteLine("  " + allTips[i].name);
            }

        }
    }
    else if (key.Key == ConsoleKey.UpArrow && pos != 1)
    {
        pos--;
    }
    else if (key.Key == ConsoleKey.DownArrow && pos != 2)
    {
        pos++;
    }
    Console.SetCursorPosition(0, pos);
    Console.WriteLine("->");



} while (key.Key != ConsoleKey.Enter);

Console.SetCursorPosition(0, 5);

