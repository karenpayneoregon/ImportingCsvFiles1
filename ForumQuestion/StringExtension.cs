using System;
using System.Linq;

namespace ForumQuestion
{
    public static class StringExtension
    {
        public static string ProcessSpacings(this string line)
        {
            try
            {
                return string.Join(",", Array.ConvertAll(line.Split(','),
                    field => field.Trim()).Select(items => $"{items}"));
            }
            catch (Exception)
            {
                return line;
            }
        }
    }
}