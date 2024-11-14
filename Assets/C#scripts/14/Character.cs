using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ass14{
public class Charecter
{
   string _name = "";
   int _health = 0;

   public string name
   {
      get{return _name;}
      set{_name = value;}
   }
   public int health
   {
      get{return _health;}
      set{_health = value;}
   }

   public Charecter(string name, int health)
   {
        this.name = name;
        this.health = health;
   }


}
}