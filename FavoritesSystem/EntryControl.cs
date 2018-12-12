using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritesSystem
{
   public static class EntryControl
   {
      private static Entry[] entries = new Entry[5];
      public static Entry[] rankedEntries = new Entry[5];
      public static int numEntries = 5;
      //    public static int doneEntries = 0;
      public static Entry EntryOne;
      public static Entry EntryTwo;
      public static bool done = false;
      private static int numMatches = 0;
      public static int maxNumMatches = ((Factorial(numEntries) / 2) / Factorial(numEntries - 2));
      private static Match[] matches = new Match[maxNumMatches];

      public static int Factorial(int number)
      {
         if (number == 1 || number == 0)
            return 1;
         else
            return number * Factorial(number - 1);
      }

      public static void MakeNewSet(string first, string second, string third, string fourth, string fifth)
      {
         entries[0] = new Entry(first, 1);
         entries[1] = new Entry(second, 2);
         entries[2] = new Entry(third, 3);
         entries[3] = new Entry(fourth, 4);
         entries[4] = new Entry(fifth, 5);

         EntryOne = entries[0];
         EntryTwo = entries[1];
      }

      public static void ChooseEntries()
      {
         bool isItDone = CheckForDone();
         if (isItDone)
         {
            MakeFinalSet();
            return;
         }
         for (int i = 0; i < numEntries - 1; i++)
         {
            for (int j = i + 1; j < numEntries; j++)
            {
               if (entries[i].ranking == entries[j].ranking)
               {
                  EntryOne = entries[i];
                  EntryTwo = entries[j];
                  RandomCheck();
               }
            }
         }
      }

      private static void RandomCheck()
      {
         if (EntryOne.ranking % 2 == 0)
         {
            Entry temp = EntryOne;
            EntryOne = EntryTwo;
            EntryTwo = temp;
         }
      }

      private static void MakeFinalSet()
      {
         bubbleSort(entries);
         for (int i = 0; i < numEntries; i++)
            rankedEntries[i] = entries[i];
      }

      static void bubbleSort(Entry[] arr)
      {
         int n = arr.Length;
         for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
               if (arr[j].ranking < arr[j + 1].ranking)
               {
                  // swap temp and arr[i]
                  Entry temp = arr[j];
                  arr[j] = arr[j + 1];
                  arr[j + 1] = temp;
               }
      }

      private static bool CheckForDone()
      {
         done = true;
         for (int i = 0; i < numEntries - 1; i++)
         {
            for (int j = i + 1; j < numEntries; j++)
            {
               if (entries[i].ranking == entries[j].ranking)
                  done = false;
            }
         }
         if (numMatches != maxNumMatches)
            done = false;

         return done;
         /*      int count = 0;
               while (EntryOne.ranking != EntryTwo.ranking)
               {
                  if (EntryTwo.number < 5)
                     EntryTwo = entries[EntryTwo.number];
                  else
                     EntryTwo = entries[0];
                  count++;
                  if (count >= 4)
                  {
                     EntryOne.done = true;
                     notDoneEntries--;
                     //      doneEntries++;
                     if (EntryOne.number < notDoneEntries + 1)
                     {
                        int index = EntryOne.number - 1;
                        Entry temp = entries[index];
                        entries[index] = entries[notDoneEntries];
                        rankedEntries[doneEntries++] = temp;

                        //     entries[notDoneEntries] = temp;
                        //            entries[EntryOne.number - 1].number = 5;
                     }
                     else
                        rankedEntries[doneEntries++] = entries[notDoneEntries + 1];
                  }
               }*/
      }
   }
}
