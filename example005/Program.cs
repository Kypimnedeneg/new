Console.WriteLine("Ведите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура эТО Же МАША");
}
else
{
    Console.WriteLine("Привет," + username );
}

   