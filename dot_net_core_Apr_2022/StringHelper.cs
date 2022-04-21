using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_core_Apr_2022
{
    internal static class StringHelper
    {
        public static string FlipFirsLetterCase(this string input)
        {
            if (input.Length > 0)
            {
                char[] arr = input.ToCharArray();

                arr[0] = char.IsUpper(arr[0]) ? char.ToLower(arr[0]) : char.ToUpper(arr[0]);

                return new string(arr);
            }

            return input;
        }
    }
}
