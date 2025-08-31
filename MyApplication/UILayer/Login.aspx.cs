using MyApplication.ServicerLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           var res= AutiticateServiceLayer.Login(LoginPage.UserName,LoginPage.Password);
            if(res==false)
            {
              
                
            }
            else
            {
                Response.Redirect("CRUD.aspx");
            }
        }
    }
}