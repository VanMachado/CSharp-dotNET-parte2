namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int number)
        {
            if(thisObj.Length <= number)
            {
                return thisObj;
            }

            return thisObj.Substring(0, number) + "...";
        }
    }
}
