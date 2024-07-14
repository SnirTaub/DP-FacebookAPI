using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic.BuildTeam
{
    class AgeStrategy : ITeamBuildingStrategy
    {
        public bool IsValidTeamMember(ProxyUser i_PotentialTeamMember, TeamSettings i_TeamSettings)
        {
            int ageFrom = i_TeamSettings.AgeFrom <= i_TeamSettings.AgeTo ? i_TeamSettings.AgeFrom : i_TeamSettings.AgeTo;
            int ageTo = i_TeamSettings.AgeTo > i_TeamSettings.AgeFrom ? i_TeamSettings.AgeTo : i_TeamSettings.AgeFrom;

            int potentialTeamMemberAge = AgeCalculator.CalculateAgeFromString(i_PotentialTeamMember.Birthday);

            return AgeCalculator.IsInRange(ageFrom, ageTo, potentialTeamMemberAge);
        }
    }
}
