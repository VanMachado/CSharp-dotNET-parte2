//Quando se faz um "extension method", por boa pratica, coloque-o no mesmo namespace da classe
//que sera extendida

namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan durantion = DateTime.Now.Subtract(thisObj);

            if(durantion.TotalHours < 24)
            {
                return durantion.TotalHours.
                    ToString("F1") + " Hours";
            }

            return durantion.TotalDays.
                ToString("F1") + " Days";
        }
    }
}
