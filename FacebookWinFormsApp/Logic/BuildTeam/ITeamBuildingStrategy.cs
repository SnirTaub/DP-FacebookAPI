using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    public interface ITeamBuildingStrategy
    {
        bool IsValidTeamMember(ProxyUser i_PotentialTeamMember, TeamSettings i_TeamSettings);
    }
}
