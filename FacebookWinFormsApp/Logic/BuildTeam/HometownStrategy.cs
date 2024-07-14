using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    class HometownStrategy : ITeamBuildingStrategy
    {
        public bool IsValidTeamMember(User i_PotentialTeamMember, TeamSettings i_TeamSettings)
        {
            return i_TeamSettings.TeamManager.Hometown == i_PotentialTeamMember.Hometown;
        }
    }
}
