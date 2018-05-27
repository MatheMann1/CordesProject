using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordesProject
{
    class DialogOpener
    {
        public DialogOpener()
        {
        }

        public String ShowOpenFileDialog(String filter, String title, String pfad)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = pfad;
            ofd.Filter = filter;
            ofd.Title = title;
            ofd.Multiselect = false;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            return "";
        }
    }
}
