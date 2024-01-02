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
	public partial class Blad : Form
	{
		public Blad()
		{
			InitializeComponent();
		}

		private void ObslugaBledow_Load(object sender, EventArgs e)
		{			
		}

		private void SchemeButton_Click(object sender, EventArgs e)
		{
			Pomoc Schemat = new Pomoc();
			Schemat.Show();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
