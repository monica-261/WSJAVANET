using Cliente.wsMate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Mult_Click(object sender, EventArgs e)
        {
            int x = int.Parse(ParX.Text);
            int y = int.Parse(ParY.Text);

            wsMate.multiplicarRequest multiReq = new multiplicarRequest(x, y);
            wsMate.wsPublico ws = new wsMate.wsPublicoClient();
            wsMate.multiplicarResponse mresp = ws.multiplicar(multiReq);

            Resultado.Text = mresp.@return.ToString();
        }
    }
}