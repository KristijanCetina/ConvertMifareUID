using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMifareUID
{
    static class tmcUID
    {
        public static string ConvertToDec(string UID)
        {
            uint dec = Convert.ToUInt32(UID, 16);
            return dec.ToString().PadLeft(10, '0');
        }

        public static string reversUID(string UID)
        {
            string s = UID;
            string reversedUID = "";
            var splitted = Enumerable.Range(0, s.Length)
                                     .GroupBy(x => x / 2)
                                     .Select(x => new string(x.Select(y => s[y]).ToArray()))
                                     .ToList();
            splitted.Reverse();

            foreach (string t in splitted)
            {
                reversedUID += t;
            }
            return reversedUID;
        }
    }
}