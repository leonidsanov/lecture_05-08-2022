Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // Параметр ToLower() переводит все символы в нижний регистр
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}