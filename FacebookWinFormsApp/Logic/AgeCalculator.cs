using System;

namespace BasicFacebookFeatures.Logic
{
    public class AgeCalculator
    {
        public static int CalculateAge(DateTime i_Birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - i_Birthday.Year;

            if (i_Birthday > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
