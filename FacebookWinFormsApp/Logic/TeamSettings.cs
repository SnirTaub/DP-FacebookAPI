using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.Logic
{
    public class TeamSettings
    {
        public User TeamManager { get; set; }
        public string TeamName { get; set; }
        public string TeamPurpose { get; set; }
        public int TeamSize { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public bool FromHometown { get; set; }
        public Genders Gender { get; set; }

        public TeamSettings(User i_TeamManager, string i_TeamName, string i_TeamPurpose, int i_TeamSize, int i_AgeFrom, int i_AgeTo, Genders i_Gender, bool i_FromHometown)
        {
            TeamManager = i_TeamManager;
            TeamName = i_TeamName;
            TeamPurpose = i_TeamPurpose;
            TeamSize = i_TeamSize;
            AgeFrom = i_AgeFrom;
            AgeTo = i_AgeTo;
            Gender = i_Gender;
            FromHometown = i_FromHometown;
        }
    }
}
