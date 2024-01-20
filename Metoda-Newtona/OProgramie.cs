using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoda_Newtona
{
	public partial class OProgramie : Form
	{
		public OProgramie()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // link do literatury, z której braliśmy wzory
		{
			System.Diagnostics.Process.Start("https://eduinf.waw.pl/inf/alg/005_root/0013.php");
		}
	}
}
