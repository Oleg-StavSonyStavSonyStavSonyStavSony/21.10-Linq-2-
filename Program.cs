using System;
using System.Collections.Generic;

namespace _21._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MySystem listUser = new MySystem();
            listUser.Add(new InfoUser ( "paword1", "login1", "emmel1", "Vasya",  "Pupkin",  "Vasilevich",  18 ));
            listUser.Add(new InfoUser ( "paword2", "login2", "emmel2", "Vasya2",  "Pupkin2",  "Vasilevich2",  19 ));
            listUser.Add(new InfoUser ( "paword3", "login3", "emmel3", "Vasya3",  "Pupkin3",  "Vasilevich3",  20 ));
            listUser.Add(new InfoUser ( "paword3", "login3", "emmel3", "Vasya3",  "Pupkin3",  "Vasilevich3",  21 ));

         //   listUser.ForEach(Console.WriteLine);

            InfoUser user = new InfoUser ( "paword3", "login3", "", "",  "",  "",  0 );


            List <InfoUser>  list = listUser.FindAll(user);
           //list.ForEach(Console.WriteLine);

            //listUser.Remove(user);
             listUser.ForEach(Console.WriteLine);
            listUser.Clear();
            listUser.ForEach(Console.WriteLine);

            Console.Read();
        }
    }
}
