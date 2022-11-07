Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());// программа по выводу названия дня недели.
if (day < 1 || day > 7)
{
    Console.WriteLine("ОШИБКА!");
}// Ошибка в случее не верного числа
switch (day)
{
    case 1:
        Console.WriteLine(week.ПОНЕДЕЛЬНИК);
        break;
    case 2:
        Console.WriteLine(week.ВТОРНИК);
        break;
    case 3:
        Console.WriteLine(week.СРЕДА);
        break;
    case 4:
        Console.WriteLine(week.ЧЕТВЕРГ);
        break;
    case 5:
        Console.WriteLine(week.ПЯТНИЦА);
        break;
    case 6:
        Console.WriteLine(week.СУББОТА);
        break;
    case 7:
        Console.WriteLine(week.ВОСКРЕСЕНЬЕ);
        break;

}// Дни недели в зависимости с числом.

enum week
{
    ПОНЕДЕЛЬНИК,
    ВТОРНИК,
    СРЕДА,
    ЧЕТВЕРГ,
    ПЯТНИЦА,
    СУББОТА,
    ВОСКРЕСЕНЬЕ
}// Ответ