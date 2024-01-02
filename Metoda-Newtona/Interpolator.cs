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
using System.Windows.Forms.DataVisualization.Charting;

namespace Metoda_Newtona
{
	public partial class Interpolator : Form
	{
		private Wykres wykres;
		public Interpolator()
		{
			InitializeComponent();
			wykres = new Wykres();
		}

		public decimal CalculateFunctionValueAtX(decimal[] functionParameters, decimal pointX)
		{
			decimal result = 0.0m;
			for (int i = 0; i < functionParameters.Length; i++)
			{
				result += functionParameters[i] * (decimal)Math.Pow((double)pointX, functionParameters.Length - 1 - i);
			}
			return result;
		}


		public decimal[] CalculateDerivative(decimal[] functionParameters)
		{
			decimal[] result = new decimal[functionParameters.Length - 1];

			for (int i = 0; i < functionParameters.Length - 1; i++)
			{
				result[i] = functionParameters[i] * (functionParameters.Length - 1 - i);
			}
			return result;
		}


		public decimal[] CalculateTangent(decimal[] derivativeFunctionParameters, decimal pointX, decimal pointY)
		{
			decimal[] result = new decimal[2];

			decimal derivativeValue = CalculateFunctionValueAtX(derivativeFunctionParameters, pointX);
			result[0] = derivativeValue;

			result[1] = pointY - derivativeValue * pointX;

			return result;
		}
		private void calculateButton_Click(object sender, EventArgs e) // OBLICZ
		{
			try //obsługa błędów wprowadzanych danych
			{
				wykres.ResetChart();
				decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
				decimal delta = Decimal.Parse(deltaTextBox.Text);
				int iterations = Int32.Parse(iterationsTextBox.Text);
				decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
				decimal pointX = Decimal.Parse(pointXTextBox.Text);
				decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations);
				zeroPlaceTextBox.Text = zeroPlace.ToString();

				Series functionChartSeries = PrepareChartSeries(functionParameters, pointX, "funkcja f(x)");

				wykres.DrawFunctionChart(functionChartSeries);
				wykres.Show();
			}
			catch (Exception ex)
			{
				ObslugaBledow Uwaga = new ObslugaBledow();
				MessageBox.Show(ex.ToString());
				Uwaga.Show();
			}
		}


		public decimal CalculateZeroPlace(decimal[] functionParameters, decimal x0, decimal epsilon, decimal delta, int iterations)
		{
			//Font Tekst = logRichTextBox.SelectionFont;

			logRichTextBox.SelectionFont = new Font(logRichTextBox.Font, FontStyle.Bold);
			logRichTextBox.Text += "Rozpoczęto obliczenia \n";
			logRichTextBox.Text += "Funkcja wejściowa " + String.Join(";", functionParameters) + "\n";
			logRichTextBox.Text += "Punkt startowy " + x0 + "\n";

			decimal x1 = x0 - 1;
			decimal fX0 = CalculateFunctionValueAtX(functionParameters, x0);

			logRichTextBox.SelectionFont = new Font(logRichTextBox.Font, FontStyle.Regular);

			logRichTextBox.Text += "Wartość funkcji w punkcie startowym " + fX0 + "\n";

			logRichTextBox.Text += "Dokładność porównania z zerem " + epsilon + "\n";
			logRichTextBox.Text += "Dokładność wyznaczania pierwiastka " + delta + "\n";
			logRichTextBox.Text += "Maksymalna wartość iteracji " + iterations + "\n";

			int numberOfIteration = 0;

			while (iterations > 0 && Math.Abs(x1 - x0) > epsilon && Math.Abs(fX0) > delta) //wykonuj dopóki liczba iteracji jest większa od 0 i wartość bezwzględna z x1 - x0 jest większa od epsilon i wartość bezwzględna z funkcji w punkcie x0 jest większa od delta
			{
				logRichTextBox.SelectionFont = new Font(logRichTextBox.Font, FontStyle.Bold);
				logRichTextBox.Text += "\n";
				numberOfIteration += 1;
				logRichTextBox.AppendText("Numer iteracji " + numberOfIteration + "\n");
				//logRichTextBox.Rtf = @"{\rtf1\ansi This is in \b bold\b0.}";
			

				decimal[] derivativeParamters = CalculateDerivative(functionParameters);
				decimal fX1 = CalculateFunctionValueAtX(derivativeParamters, x0);
				logRichTextBox.Text += "Pochodna funkcji w potencjalnym miejscu zerowym " + fX1 + "\n";

				decimal[] tangentParameters = CalculateTangent(derivativeParamters, x0, fX0);

				if (functionParameters.Length > 1) // nie wyliczymy stycznej dla stałej tak żeby przecięła oś X
				{
					Series series = PrepareTangentSeries(tangentParameters, x0, "Styczna " + numberOfIteration);
					wykres.DrawFunctionChart(series);
				}

				if (Math.Abs(fX1) < delta) //sprawdzenie czy wartość funkcji od bieżącego przybliżenia miejsca zerowego jest mniejsza od przyjętej wartości delty
				{
					MessageBox.Show("Zły punkt startowy");
					logRichTextBox.Text += "Zły punkt startowy\n";
					logRichTextBox.Text += "Zakończono obliczenia " + "\n";

					return x0;
				}

				x1 = x0;
				x0 = x0 - fX0 / fX1;

				logRichTextBox.Text += "Potencjalne miejsce zerowe " + x0 + "\n";
				fX0 = CalculateFunctionValueAtX(functionParameters, x0);

				logRichTextBox.Text += "Wartość funkcji w potencjalnym miejscu zerowym " + fX0 + "\n";
				wykres.DrawPoint(x0, fX0);

				iterations = iterations - 1;
				logRichTextBox.Text += "Pozostało iteracji " + iterations + "\n";
			}

			if (iterations == 0) //sprawdzenie czy osiągnięto maksymalną liczbę iteracji
			{
				MessageBox.Show("Przekroczony limit obiegów");
				logRichTextBox.Text += "Przekroczony limit obiegów\n";
			}

			logRichTextBox.Text += "\n";
			logRichTextBox.Text += "Zakończono obliczenia " + "\n";
			logRichTextBox.Text += "Miejsce zerowe to " + x0 + "\n";
			wykres.DrawZeroPlace(x0, fX0);

			return x0;
		}

		public bool IsResultCorrect(decimal[] functionParameters, decimal zeroPlace, decimal epsilon)
		{
			decimal result = CalculateFunctionValueAtX(functionParameters, zeroPlace);

			if (Math.Abs(result) < epsilon)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void IsCorrectButton_Click(object sender, EventArgs e)
		{
			decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
			decimal zeroPlace = Decimal.Parse(zeroPlaceTextBox.Text);
			decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
			bool correctResult = IsResultCorrect(functionParameters, zeroPlace, epsilon);

			if (correctResult)
			{
				MessageBox.Show("Miejsce zerowe jest poprawne");
			}
			else
			{
				MessageBox.Show("Miejsce zerowe nie spełnia kryterium poprawności");
			}
			
		}

		public Series PrepareChartSeries(decimal[] functionParameters, decimal startingPointX, string seriesName)
		{
			Series series = new Series(seriesName);
			for (decimal i = startingPointX - 5.0m; i < startingPointX + 5.0m; i = i + 0.5m)
			{
				series.Points.Add(new DataPoint((double)i, (double)CalculateFunctionValueAtX(functionParameters, i)));
			}
			return series;
		}

		/**
         * Metoda do przygotowania serii danych do rysowania stycznej w punkcie
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param startingPointX punkt startowy
         * @param seriesName nazwa serii
         * @return seria danych dla stycznej
         */
		public Series PrepareTangentSeries(decimal[] functionParameters, decimal startingPointX, string seriesName)
		{
			Series series = new Series(seriesName);
			series.Color = Color.Red;
			decimal fStartingPointX = CalculateFunctionValueAtX(functionParameters, startingPointX);
			decimal valueAtX = fStartingPointX;
			if ((functionParameters[0] > 0 && fStartingPointX < 0) || (functionParameters[0] < 0 && fStartingPointX > 0))
			{
				series.Points.Add(new DataPoint((double)(startingPointX - 0.5m), (double)CalculateFunctionValueAtX(functionParameters, startingPointX - 0.5m)));
				while (fStartingPointX * valueAtX > 0)
				{
					valueAtX = CalculateFunctionValueAtX(functionParameters, startingPointX);
					series.Points.Add(new DataPoint((double)startingPointX, (double)CalculateFunctionValueAtX(functionParameters, startingPointX)));
					startingPointX += 0.5m;
				}
			}
			else if ((functionParameters[0] > 0 && fStartingPointX > 0) || (functionParameters[0] < 0 && fStartingPointX < 0))
			{
				series.Points.Add(new DataPoint((double)(startingPointX + 0.5m), (double)CalculateFunctionValueAtX(functionParameters, startingPointX + 0.5m)));
				while (fStartingPointX * valueAtX > 0)
				{
					valueAtX = CalculateFunctionValueAtX(functionParameters, startingPointX);
					series.Points.Add(new DataPoint((double)startingPointX, (double)CalculateFunctionValueAtX(functionParameters, startingPointX)));
					startingPointX -= 0.5m;
				}
			}
			else
			{
				series.Points.Add(new DataPoint((double)(startingPointX + 0.5m), (double)CalculateFunctionValueAtX(functionParameters, startingPointX + 0.5m)));
				series.Points.Add(new DataPoint((double)(startingPointX), (double)CalculateFunctionValueAtX(functionParameters, startingPointX)));
				series.Points.Add(new DataPoint((double)(startingPointX - 0.5m), (double)CalculateFunctionValueAtX(functionParameters, startingPointX - 0.5m)));
			}
			return series;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			wykres.Close();
			parametersTextBox.Clear();
			pointXTextBox.Clear();
			epsilonTextBox.Text = "0,000001";
			deltaTextBox.Text = "0,000001";
			iterationsTextBox.Text = "100";
			zeroPlaceTextBox.Clear();
			logRichTextBox.Clear();
			this.Refresh();
			wykres.Refresh();

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
