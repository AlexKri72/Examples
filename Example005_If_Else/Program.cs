Console.Write("Введите Ваше имя: ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    
    Console.Write("Ура, это же ");
    Console.Write(userName);
    Console.WriteLine(" !");
}
    else
    {
        Console.Write("Привет, ");
        Console.Write(userName);
        Console.Write(" !");
    }

