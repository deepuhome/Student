using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IISController
{
    public partial class IISManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = GetIISStatus();
        }

        private string GetIISStatus()
        {
            ServiceController controller = new ServiceController("W3SVC");
            return controller.Status.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceController controller = new ServiceController("W3SVC");
            if (controller.Status == ServiceControllerStatus.Running)
                controller.Stop();
            else if (controller.Status == ServiceControllerStatus.Stopped)
                controller.Start();
            else
                controller.Stop();
        }
    }
}