Console.Write("Введите имя пользовотеля: ");
string useranme = Console.ReadLine();

if(useranme.ToLower() == "маша")
{
     Console.WriteLine("УРА, это же МАША!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(useranme);
}