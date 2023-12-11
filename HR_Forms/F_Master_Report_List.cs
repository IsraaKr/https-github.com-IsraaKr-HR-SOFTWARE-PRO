using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms
{
    public partial class F_Master_Report_List : Form
    {
        public F_Master_Report_List()
        {
            InitializeComponent();
        }

        public virtual void Title(string s_title)
        {
            lbl_tiltle.Text = s_title;
        }
        public virtual void Get_Data()
        {

        }

        public virtual void gc_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
