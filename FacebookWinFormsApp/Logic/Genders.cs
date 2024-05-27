using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.Logic
{
    public class Genders
    {
        private User.eGender? m_Gender;

        public Genders(User.eGender? i_Gender)
        {
            m_Gender = i_Gender;
        }

        public User.eGender? Gender
        {
            get
            {
                return m_Gender;
            }
        }

        public static Genders Parse(string i_Gender)
        {
            string genderStr = i_Gender.ToLower();
            Genders gender;

            switch (genderStr)
            {
                case "female":
                    gender = new Genders(User.eGender.female);
                    break;
                case "male":
                    gender = new Genders(User.eGender.male);
                    break;
                case "all":
                    gender = null;
                    break;
                default:
                    throw new FormatException();
            }

            return gender;
        }

        public override string ToString()
        {
            string gender;

            if (m_Gender.HasValue)
            {
                switch (m_Gender.Value)
                {
                    case User.eGender.male:
                        gender = "Male";
                        break;
                    case User.eGender.female:
                        gender = "Female";
                        break;
                    default:
                        throw new FormatException();
                        break;
                }
            }
            else
            {
                gender = "All Gender";
            }

            return gender;
        }
    }
}
