using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    public class TeamManager
    {
        private readonly Dictionary<string, Team> r_Teams;
        private Team m_SelectedTeam;

        public TeamManager()
        {
            r_Teams = new Dictionary<string, Team>();
            m_SelectedTeam = null;
        }

        public List<string> Teams
        {
            get
            {
                List<string> teams = new List<string>();

                foreach (KeyValuePair<string, Team> team in r_Teams)
                {
                    teams.Add(team.Key);
                }

                return teams;
            }
        }

        public string SelectedTeamName
        {
            get
            {
                string teamName;

                teamName = m_SelectedTeam == null ? null : m_SelectedTeam.TeamName;

                return teamName;
            }
            set
            {
                Team team = getTeam(value);

                m_SelectedTeam = team;
            }
        }

        public bool BuildTeam(TeamSettings i_TeamSettings)
        {
            bool isTeamBuilt = false;

            if (!r_Teams.ContainsKey(i_TeamSettings.TeamName))
            {
                m_SelectedTeam = Team.BuildTeam(i_TeamSettings);
                r_Teams.Add(i_TeamSettings.TeamName, m_SelectedTeam);
                isTeamBuilt = true;
            }

            return isTeamBuilt;
        }

        public void RemoveTeam(string i_TeamName)
        {
            if (r_Teams.ContainsKey(i_TeamName))
            {
                r_Teams.Remove(i_TeamName);
            }
        }

        public FacebookObjectCollection<User> GetTeamMembers(string i_TeamName)
        {
            Team team = getTeam(i_TeamName);

            return team.TeamMembers;
        }

        public void RemoveTeamMember(string i_TeamName, User i_TeamMember)
        {
            Team team = getTeam(i_TeamName);

            team.RemoveTeamMember(i_TeamMember);
        }

        public List<string> GetTeamNames()
        {
            List<string> teams = new List<string>();

            foreach (KeyValuePair<string, Team> team in r_Teams)
            {
                teams.Add(team.Key);
            }

            return teams;
        }

        public int GetAgeFrom(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.AgeFrom;
        }

        public int GetAgeTo(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.AgeTo;
        }

        public User GetTeamManager(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.TeamManager;
        }

        public int GetTeamSize(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.TeamSize;
        }

        public bool GetTeamFromHometown(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.FromHometown;
        }

        public string GetTeamPurpose(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.TeamPurpose;
        }

        public Genders GetGender(string i_TeamName = null)
        {
            Team team = getTeam(i_TeamName);

            return team.Gender;
        }

        private Team getTeam(string i_TeamName)
        {
            Team team;

            if (i_TeamName == null)
            {
                team = m_SelectedTeam;
            }
            else
            {
                if (r_Teams.ContainsKey(i_TeamName))
                {
                    team = r_Teams[i_TeamName];
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return team;
        }
    }
}
