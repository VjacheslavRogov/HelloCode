Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "настя")
{
    Console.Write("Привет, Настя");
} else 
{
    Console.Write("Здравствуйте, " + username);
};
