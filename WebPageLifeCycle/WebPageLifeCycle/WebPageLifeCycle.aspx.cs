using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPageLifeCycle
{
    public partial class WebPageLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string capital = input.ToUpper();
            string small = input.ToLower();
            int count = input.Length;
            string reverse = new string(input.Reverse().ToArray());

            lblOutput.Text = $"Capital: {capital}<br />Small: {small}<br />Count: {count}<br />Reverse: {reverse}";

        }
    }
}