using System;

namespace _21._10
{
    public class InfoUser : BaseUser{ 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public InfoUser (string pas, string log, string emel,string first, string last, string middle, int age) : base(pas, log,emel){
            FirstName = first;
            LastName = last;
            MiddleName = middle;
            Age = age;
            
        }
        public override string ToString() => base.ToString() +$"\nFirstName - {FirstName}-\nLastName - {LastName}-\nMiddleName - {MiddleName}-\nAge - {Age}";
       
    }

}