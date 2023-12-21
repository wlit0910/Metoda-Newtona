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
	public partial class ObslugaBledow : Form
	{
		public ObslugaBledow()
		{
			InitializeComponent();
		}

		private void ObslugaBledow_Load(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SchemeButton_Click(object sender, EventArgs e)
		{
			SchematObslugiBledow Schemat = new SchematObslugiBledow();
			Schemat.Show();
		}
	}
}
