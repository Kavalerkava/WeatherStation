using Database;

User user1 = new User("rikovens", 999);
User user2 = new User("Danill", 999);
Sensor sensor1 = new Sensor();

Console.WriteLine($"Utworzono użytkownika 1: {user1.Name} (ID: {user1.Id})");
Console.WriteLine($"Utworzono użytkownika 2: {user2.Name} (ID: {user2.Id})");
Console.WriteLine("Utworzono sensor 1");
bool i = user1.Equals( user2 );
Console.WriteLine(i);