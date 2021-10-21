using System;
using System.Linq;
using System.Collections.Generic;

namespace _21._10
{
    public class MySystem : List<InfoUser>, IDisposable
    {
        public MySystem(){
            //base = new List();
        }

        public void ADD(InfoUser user){
            base.Add(user);
        }
        public void REmove(InfoUser user){
           base.Remove(user);

        }
        public bool FIndAll(InfoUser user){
           
            
            for (var i = 0; i < this.Count(); i++)
            {
                if(base[i]?.Pasword != user.Pasword){
                    return false;
                }
                if( base[i]?.Login != user.Login){
                    return false;
                }
                if( base[i]?.Age != user.Age){
                    return false;
                }
                if( base[i]?.Email != user.Email){
                    return false;
                }
                if( base[i]?.FirstName != user.FirstName){
                    return false;
                }
                if( base[i]?.LastName != user.LastName){
                    return false;
                }
                if( base[i]?.MiddleName != user.MiddleName){
                    return false;
                }
            
            }
            return true;
        }
        public void CLear(InfoUser user){
            
             for (var i = 0; i < 5; i++)
            {
                if(base[i]?.Pasword != user.Pasword){
                    break;
                }
                if( base[i]?.Login != user.Login){
                    break;
                }
                if( base[i]?.Age != user.Age){
                    break;
                }
                if( base[i]?.Email != user.Email){
                    break;
                }
                if( base[i]?.FirstName != user.FirstName){
                    break;
                }
                if( base[i]?.LastName != user.LastName){
                    break;
                }
                if( base[i]?.MiddleName != user.MiddleName){
                    break;
                }
                 this.REmove(user);
            }
           
        }

        public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }

    }
}
