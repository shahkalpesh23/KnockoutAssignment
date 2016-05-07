using System;
using System.Web.Services;
using InformationSystem.Models;
using InformationSystem.BusinessContext;
using InformationSystem.Constants;

namespace InformationSystem.WebService
{
    /// <summary>
    /// Summary description for LoadInformationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]    
    [System.Web.Script.Services.ScriptService]
    public class LoadInformationService : System.Web.Services.WebService
    {
        readonly ReturnModel Data = new ReturnModel();
        readonly Operations operation = new Operations();

        [WebMethod(EnableSession = true)]
        public ReturnModel LoadCompletePageData()
        {
            if (Session[AppConstants.SessionVariable] != null)
            {
                Data.IsSessionValid = true;
            }
            else
            {
                Data.IsSessionValid = false;
            }

            Data.DataList = operation.LoadNewsData();
            return Data;
        }

        [WebMethod(EnableSession = true)]
        public string AuthenticateUser(string userName, string password)
        {
            var role = operation.CheckAuthentication(userName, password);
            if (string.IsNullOrEmpty(role))
            {
                return String.Empty;
            }
            Session[AppConstants.SessionVariable] = userName;
            return role;
        }

        [WebMethod(EnableSession = true)]
        public void ChangeNewsVisibility(int id, bool showFlag)
        {
            if (Session[AppConstants.SessionVariable] != null)
            {
                operation.ShowHideNews(id, showFlag);
            }
        }

        [WebMethod(EnableSession = true)]
        public void Logout()
        {
            Session.Abandon();
        }
    }
}
