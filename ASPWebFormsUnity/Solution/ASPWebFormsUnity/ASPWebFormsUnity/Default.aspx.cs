using ASPWebFormsUnity.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebFormsUnity
{
    public partial class _Default : Page
    {
        [Dependency]
        public ISayHello SayHello { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var foo = SayHello.Hi("Vulcan");
        }
    }
}