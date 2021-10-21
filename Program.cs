using System;

namespace _21._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MySystem listUser = new MySystem();
            listUser.ADD(new InfoUser ( "paword1", "login1", "emmel1", "Vasya",  "Pupkin",  "Vasilevich",  18 ));
            listUser.ADD(new InfoUser ( "paword2", "login2", "emmel2", "Vasya2",  "Pupkin2",  "Vasilevich2",  19 ));
            listUser.ADD(new InfoUser ( "paword3", "login3", "emmel3", "Vasya3",  "Pupkin3",  "Vasilevich3",  20 ));
            listUser.ADD(new InfoUser ( "paword3", "login3", "emmel3", "Vasya3",  "Pupkin3",  "Vasilevich3",  21 ));

            foreach (var item in listUser)
            {
                Console.WriteLine(item);
            }
            InfoUser user = new InfoUser ( "paword3", "login3", "emmel3", "Vasya3",  "Pupkin3",  "Vasilevich3",  21 );
            listUser.REmove(user);
            foreach (var item in listUser)
            {
                Console.WriteLine(item);
            }
             listUser.CLear(user);
              foreach (var item in listUser)
            {
                Console.WriteLine(item);
            }




           



             Console.Read();


        }
    }
}
