using System.Windows.Forms;
using BasicFacebookFeatures.Logic.ScheduledPost;

namespace BasicFacebookFeatures.UI
{
    internal static class UiUtils
    {
        internal static DataGridViewRow GetSelectedRow(DataGridView i_DataGrid)
        {
            int selectedRowIndex = i_DataGrid.SelectedCells[0].RowIndex;
            return i_DataGrid.Rows[selectedRowIndex];
        }

        internal static string getPrivacyText(ePrivacyType i_Privacy)
        {
            string privacy = Texts.Everyone;

            switch (i_Privacy)
            {
                case ePrivacyType.ALL_FRIENDS:
                    privacy = Texts.MyFriends;
                    break;
                case ePrivacyType.SELF:
                    privacy = Texts.Me;
                    break;
            }

            return privacy;
        }
    }
}