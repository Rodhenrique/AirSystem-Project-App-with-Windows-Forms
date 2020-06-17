using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Models
{
    class util
    {
        public static bool CampoVazio(Form cadastro)
        {

            foreach (Control c in cadastro.Controls)
            {
                TextBox tbox = c as TextBox;

                if (tbox != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
