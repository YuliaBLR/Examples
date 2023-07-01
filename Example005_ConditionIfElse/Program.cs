Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "юлия")
{
    Console.WriteLine("Ура, это же Юля!");
}
else
{
   Console.Write("Привет, "); 
   Console.WriteLine(username); 
}