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
        private readonly FacebookObjectCollection<ProxyUser> r_TeamMembers;
        private readonly List<ITeamBuildingStrategy> r_Strategies;
        private TeamSettings m_TeamSettings;

        private Team(TeamSettings i_TeamSettings, List<ITeamBuildingStrategy> i_Strategies)
        {
            r_TeamMembers = new FacebookObjectCollection<ProxyUser>();
            m_TeamSettings = i_TeamSettings;
            r_Strategies = i_Strategies;
        }

        public FacebookObjectCollection<ProxyUser> TeamMembers
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

        internal ProxyUser TeamManager
        {
            get
            {
                return m_TeamSettings.TeamManager;
            }
        }

        internal static Team BuildTeam(TeamSettings i_TeamSettings, List<ITeamBuildingStrategy> i_Strategies)
        {
            Team team = new Team(i_TeamSettings, i_Strategies);

            FacebookObjectCollection<ProxyUser> potentialTeamMembers = team.fetchAllFriends();
            team.filterTeamMembers(potentialTeamMembers, i_TeamSettings);

            return team;
        }

        public void RemoveTeamMember(ProxyUser i_TeamMember)
        {
            r_TeamMembers.Remove(i_TeamMember);
        }

        private FacebookObjectCollection<ProxyUser> fetchAllFriends()
        {
            FacebookObjectCollection<ProxyUser> friends = m_TeamSettings.TeamManager.Friends;

            return friends;
        }

        private void filterTeamMembers(FacebookObjectCollection<ProxyUser> i_PotentialTeamMembers, TeamSettings i_TeamSettings)
        {
            int size = 0;

            foreach (ProxyUser potentialTeamMember in i_PotentialTeamMembers)
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

        private bool isValidTeamMember(ProxyUser i_PotentialTeamMember)
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
    }
}
