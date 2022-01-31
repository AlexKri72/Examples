Console.Clear();
int point1_x = 50, point1_y = 1,
    point2_x = 1, point2_y = 20,
    point3_x = 100, point3_y = 20;
Console.SetCursorPosition(point1_x, point1_y);
Console.Write("+");
Console.SetCursorPosition(point2_x, point2_y);
Console.Write("+");
Console.SetCursorPosition(point3_x, point3_y);
Console.Write("+");
int x = point1_x, y = point1_y;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3); // интервал 0  1  2 это трииточки
    if (what == 0)
    {
        x = (x + point1_x) / 2;
        y = (y + point1_y) / 2;
    }
    if (what == 1)
    {
        x = (x + point2_x) / 2;
        y = (y + point2_y) / 2;
    }
    if (what == 2)
    {
        x = (x + point3_x) / 2;
        y = (y + point3_y) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count++;
    Console.SetCursorPosition(0,25);
}