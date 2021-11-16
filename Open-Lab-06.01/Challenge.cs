using System;

namespace Open_Lab_06._01
{
    public class Challenge
    {
         public string MysteryFunc(string str)
         {
               string temp_string = "";
               for (int i = 0; i < str.Length; i++)
               {
                    if ("0123456789".Contains(str[i]))
                    {
                        for (int x = 0; x < int.Parse(str[i].ToString()); x++){temp_string += str[(i - 1)];}
                    }
               }
               return temp_string;
         }
    }
}
