using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairs
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void m_btnAddPeople_Click(object sender, EventArgs e)
    {
      frmAddPeople fAP = new frmAddPeople();
      if (fAP.ShowDialog() != DialogResult.Cancel)
      {
        // do this stuff if the form is closed -- except for cancel.
      }
    }
  }
}
