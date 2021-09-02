using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Xem_Ngay.ultility
{
    public class StringUtil
    {
        private static readonly Regex regex = new Regex("[ ]{2,}", RegexOptions.None);


        public static String replaceMoreSpaceAndTrim(String input) {
            return regex.Replace(input," ").Trim();
        }
    }
}
