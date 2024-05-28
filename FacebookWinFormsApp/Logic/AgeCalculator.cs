using System;

namespace BasicFacebookFeatures.Logic
{
    public static class AgeCalculator
    {
        public static int CalculateAgeFromDateTime(DateTime i_Birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - i_Birthday.Year;

            if (i_Birthday > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public static int CalculateAgeFromString(string i_Birthday)
        {
            int indexer = 0;
            string[] usersBirthDatesStr = i_Birthday.Split('/');
            int length = usersBirthDatesStr.Length;
            int[] usersBirthDates = new int[length];

            if (length == 3)
            {
                foreach (string userBirthDateElement in usersBirthDatesStr)
                {
                    if (!int.TryParse(usersBirthDatesStr[indexer], out usersBirthDates[indexer]))
                    {
                        throw new ArgumentException("User's birthday format is incorrect.");
                    }

                    indexer++;
                }
            }
            else
            {
                throw new ArgumentException("User's birthday format is incorrect.");
            }

            int month = usersBirthDates[0];
            int day = usersBirthDates[1];
            int year = usersBirthDates[2];

            DateTime userBirthDay = new DateTime(year, month, day);

            return CalculateAgeFromDateTime(userBirthDay);
        }

        public static bool IsInRange(int i_Lower, int i_Upper, int i_ToCompare)
        {
            return i_ToCompare >= i_Lower && i_ToCompare <= i_Upper;
        }
    }
}
