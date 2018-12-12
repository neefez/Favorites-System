using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritesSystem
{
   class Match
   {
      private Entry first;
      private Entry second;

      public Match(Entry one, Entry two)
      {
         first = one;
         second = two;
      }
   }
}
