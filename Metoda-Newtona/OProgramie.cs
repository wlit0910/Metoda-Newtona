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
			
			//this.Text = String.Format("Informacje o {0}", AssemblyTitle);
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Hide();

		}
	}
}
