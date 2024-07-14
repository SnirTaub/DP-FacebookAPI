using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    internal class Team
    {
        private readonly FacebookObjectCollection<User> r_TeamMembers;
        private readonly List<ITeamBuildingStrategy> r_Strategies; // changed
        private TeamSettings m_TeamSettings;

        private Team(TeamSettings i_TeamSettings, List<ITeamBuildingStrategy> i_Strategies) // changed
        {
            r_TeamMembers = new FacebookObjectCollection<User>();
            m_TeamSettings = i_TeamSettings;
            r_Strategies = i_Strategies;
        }

        public FacebookObjectCollection<User> TeamMembers
        {
            get
            {
                return r_TeamMembers;
            }
        }

        internal int AgeFrom
        {
            get
            {
                return m_TeamSettings.AgeFrom;
            }
        }

        internal int AgeTo
        {
            get
            {
                return m_TeamSettings.AgeTo;
            }
        }

        internal int TeamSize
        {
            get
            {
                return m_TeamSettings.TeamSize;
            }
        }

        internal string TeamName
        {
            get
            {
                return m_TeamSettings.TeamName;
            }
        }

        internal bool FromHometown
        {
            get
            {
                return m_TeamSettings.FromHometown;
            }
        }

        internal string TeamPurpose
        {
            get
            {
                return m_TeamSettings.TeamPurpose;
            }
        }

        internal Genders Gender
        {
            get
            {
                return m_TeamSettings.Gender;
            }
        }

        internal User TeamManager
        {
            get
            {
                return m_TeamSettings.TeamManager;
            }
        }

        internal static Team BuildTeam(TeamSettings i_TeamSettings, List<ITeamBuildingStrategy> i_Strategies) // changed
        {
            Team team = new Team(i_TeamSettings, i_Strategies);

            FacebookObjectCollection<User> potentialTeamMembers = team.fetchAllFriends();
            team.filterTeamMembers(potentialTeamMembers, i_TeamSettings);

            return team;
        }

        public void RemoveTeamMember(User i_TeamMember)
        {
            r_TeamMembers.Remove(i_TeamMember);
        }

        private FacebookObjectCollection<User> fetchAllFriends()
        {
            FacebookObjectCollection<User> friends = m_TeamSettings.TeamManager.Friends;

            return friends;
        }

        private void filterTeamMembers(FacebookObjectCollection<User> i_PotentialTeamMembers, TeamSettings i_TeamSettings) // changed
        {
            int size = 0;

            foreach (User potentialTeamMember in i_PotentialTeamMembers)
            {
                if (size < i_TeamSettings.TeamSize &&
                    isValidTeamMember(potentialTeamMember))
                {
                    r_TeamMembers.Add(potentialTeamMember);
                    size++;
                }
                else if (size == i_TeamSettings.TeamSize)
                {
                    break;
                }
            }
        }

        private bool isValidTeamMember(User i_PotentialTeamMember) // changed
        {
            bool isValidTeamMember = true;

            foreach (ITeamBuildingStrategy strategy in r_Strategies)
            {
                if (!strategy.IsValidTeamMember(i_PotentialTeamMember, m_TeamSettings))
                {
                    isValidTeamMember = false;
                    break;
                }
            }

            return isValidTeamMember;
        }

        /*private bool isValidTeamMember(User i_PotentialTeamMember, int i_AgeFrom, int i_AgeTo, Genders i_Gender, bool i_FromHometown)
        {
            bool isValidLocation = true;

            if (i_FromHometown)
            {
                isValidLocation = isFromHometown(i_PotentialTeamMember);
            }

            return isRequiredGender(i_PotentialTeamMember, i_Gender) &&
                isRequiredAge(i_PotentialTeamMember, i_AgeFrom, i_AgeTo) &&
                isValidLocation;
        }

        private bool isRequiredGender(User i_PotentialTeamMember, Genders i_Gender)
        {
            return i_Gender == null ||
                !i_Gender.Gender.HasValue ||
                i_PotentialTeamMember.Gender.HasValue && i_PotentialTeamMember.Gender.Value == i_Gender.Gender.Value;
        }

        private bool isRequiredAge(User i_PotentialTeamMember, int i_AgeFrom, int i_AgeTo)
        {
            int ageFrom = i_AgeFrom <= i_AgeTo ? i_AgeFrom : i_AgeTo;
            int ageTo = i_AgeTo > i_AgeFrom ? i_AgeTo : i_AgeFrom;

            int potentialTeamMemberAge = AgeCalculator.CalculateAgeFromString(i_PotentialTeamMember.Birthday);

            return AgeCalculator.IsInRange(ageFrom, ageTo, potentialTeamMemberAge);
        }

        private bool isFromHometown(User i_PotentialTeamMember)
        {
            return m_TeamSettings.TeamManager.Hometown == i_PotentialTeamMember.Hometown;
        }*/
    }
}
