using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoda_Newtona
{
	public partial class Interpolator : Form
	{
		public Interpolator()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			try //obsługa błędów wprowadzanych danych
			{
				///wykres.ResetChart();
				decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
				decimal delta = Decimal.Parse(deltaTextBox.Text);
				int iterations = Int32.Parse(iterationsTextBox.Text);
				decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
				decimal pointX = Decimal.Parse(pointXTextBox.Text);
				//decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations);
				//zeroPlaceTextBox.Text = zeroPlace.ToString();

				//Series functionChartSeries = PrepareChartSeries(functionParameters, pointX, "funkcja f(x)");

			//	wykres.DrawFunctionChart(functionChartSeries);
				//wykres.Show();
			}
			catch (Exception ex)
			{
				ObslugaBledow Uwaga = new ObslugaBledow();
				Uwaga.Show();
			}
		}

		private void IsCorrectButton_Click(object sender, EventArgs e)
		{
			decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
			decimal zeroPlace = Decimal.Parse(zeroPlaceTextBox.Text);
			decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
			//bool correctResult = IsResultCorrect(functionParameters, zeroPlace, epsilon);

			/*if (correctResult)
			{
				MessageBox.Show("Miejsce zerowe jest poprawne");
			}
			else
			{
				MessageBox.Show("Miejsce zerowe nie spełnia kryterium poprawności");
			}
			*/
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			parametersTextBox.Clear();
			pointXTextBox.Clear();
			epsilonTextBox.Text = "0,000001";
			deltaTextBox.Text = "0,000001";
			iterationsTextBox.Text = "100";
			zeroPlaceTextBox.Clear();
			logRichTextBox.Clear();

			//wykres.ResetChart();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			MemoryStream userInput = new MemoryStream();

			userInput.Position = 0;

			logRichTextBox.SaveFile(userInput, RichTextBoxStreamType.PlainText);
			userInput.WriteByte(13);

			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.CreatePrompt = true;
			saveFileDialog.OverwritePrompt = true;

			saveFileDialog.FileName = "MetodaNewtona";
			saveFileDialog.DefaultExt = "txt";
			saveFileDialog.Filter =
				"Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.InitialDirectory =
				Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			DialogResult result = saveFileDialog.ShowDialog();
			Stream fileStream;

			if (result == DialogResult.OK)
			{
				fileStream = saveFileDialog.OpenFile();
				userInput.Position = 0;
				userInput.WriteTo(fileStream);
				fileStream.Close();
			}
		}

		private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OProgramie O_Programie = new OProgramie();
			O_Programie.Show();
		}

		private void schematWprowadzaniaDanychToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SchematObslugiBledow schematObslugiBledow = new SchematObslugiBledow();
			schematObslugiBledow.Show();
		}
	}
}
