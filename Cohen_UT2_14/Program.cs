using System;

namespace StructToClass
{
    class Program
    {

        static void Main(string[] args)
        {
            Friend friend;
            Friend enemy;

            // create my friend Charlie Sheen
            friend = new Friend("Charlie Sheen", "Dear Charlie", DateTime.Parse("1967-12-25"), "123 Any Street, NY NY 12202");

            // now he has become my enemy
            enemy = friend.GetCopy();

            // set the enemy greeting and address without changing the friend variable
            enemy.Greeting = "Sorry Charlie";
            enemy.Address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.Greeting} => {enemy.Greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.Address} => {enemy.Address}");
        }

        public class Friend
        {
            public string Name;
            public string Greeting;
            public DateTime Birthdate;
            public string Address;

            public Friend(string name, string greeting, DateTime birthdate, string address)
            {
                Name = name;
                Greeting = greeting;
                Birthdate = birthdate;
                Address = address;
            }

            public Friend GetCopy()
            {
                return (Friend)this.MemberwiseClone();
            }

        }
    }
}
