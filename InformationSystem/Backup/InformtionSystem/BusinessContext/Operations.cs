using System.Collections.Generic;
using System.Linq;
using InformationSystem.Models;
using InformationSystem.Constants;
using InformationSystem.BusinessContext;

namespace InformationSystem.BusinessContext
{
    public class Operations
    {
        public string CheckAuthentication(string userName, string password)
        {
            if (InitializeData.Admin.UserName.Equals(userName) && InitializeData.Admin.Password.Equals(password))
            {
                return AppConstants.Admin;
            }
            return string.Empty;
        }

        public List<Data> LoadNewsData()
        {
            return InitializeData.DataList.ToList();
        }

        public void ShowHideNews(int id, bool show)
        {
            var news = InitializeData.DataList.FirstOrDefault(x => x.LogId == id);
            if (news != null)
            {
                news.Show = show;
            }
        }
    }
}