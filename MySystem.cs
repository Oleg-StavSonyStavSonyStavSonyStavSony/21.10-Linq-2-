using System;
using System.Linq;
using System.Collections.Generic;

namespace _21._10
{
    public class MySystem : List<InfoUser>, IDisposable
    {
        public MySystem(){
          // = new List<InfoUser>();
        }

        public new void Add(InfoUser user){
            base.Add(user);
        }
        public new bool Remove( InfoUser user)
        {
            InfoUser infoUser = new InfoUser();
            for (var i = 0; i < this.Count(); i++)
            {
                if (this[i].Pasword == user.Pasword && this[i].Login == user.Login)
                {
                    infoUser = this[i];
                    base.Remove(infoUser);
                    return true;
                }
            }
            return true;
        }
        
     public new bool Clear()
        {
            int t = this.Count();
                    
            for (var i = t - 1; i >= 0 ; i--)
            {base.Remove(this[i]);
            }

            if (base.Count == 0)
                return true;

            return false;
        }
        

        public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }

    }
}
