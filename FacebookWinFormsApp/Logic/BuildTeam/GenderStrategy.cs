using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    class GenderStrategy : ITeamBuildingStrategy
    {
        public bool IsValidTeamMember(User i_PotentialTeamMember, TeamSettings i_TeamSettings)
        {
            return i_TeamSettings.Gender == null ||
                   !i_TeamSettings.Gender.Gender.HasValue ||
                   i_PotentialTeamMember.Gender.HasValue && i_PotentialTeamMember.Gender.Value == i_TeamSettings.Gender.Gender.Value;
        }
    }
}
