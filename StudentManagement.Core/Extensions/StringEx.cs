
namespace StudentManagement.Core.Extensions
{
    public static class StringEx
    {
        public static string ConcatWith(this string str0, string str1, string contactWith)
        {
            return $"{str0}{contactWith}{str1}";
        }
    }
}
