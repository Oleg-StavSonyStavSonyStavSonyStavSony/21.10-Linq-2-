using System;

namespace _21._10
{
    public abstract class BaseUser{
        public string Pasword { get; set; }     
        public string  Login { get; set; }
        public string Email { get; set; }
        public BaseUser (string pas, string log, string emel){
            Pasword = pas;
            Login = log;
            Email = emel;
        }
         public override string ToString() =>  $"Pasword - {Pasword ?? "is no data "} \nLogin - {Login ?? "is no data "} \nEmail - {Email ?? "is no data "} ";
    }

}