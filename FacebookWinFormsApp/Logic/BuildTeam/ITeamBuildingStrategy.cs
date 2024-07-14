using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    public interface ITeamBuildingStrategy
    {
        bool IsValidTeamMember(User i_PotentialTeamMember, TeamSettings i_TeamSettings);
    }
}
