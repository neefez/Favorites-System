using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritesSystem
{
   public class Entry
   {
      public string name { get; }
      public int number { get; set; }
      public int ranking { get; set; }
 //     public bool done { get; set; }

      public Entry(string inName, int inNum)
      {
         name = inName;
         number = inNum;
         ranking = 0;
      }
   }
}
