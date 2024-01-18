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


		// Funckja do wyliczania wartości funkcji w punkcie punkcie x1, x2, x3, x4 ......

									// (tablica ze współczynnikami wielomianu, współrzedna X punktu dla którego będziemy wyznaczać wartość funkcji)
		public decimal CalculateFunctionValueAtX(decimal[] functionParameters, decimal pointX) // Wyliczamy po kolei wartości funkcji f(x) w punkcie x1, x2, x3, x4 ......  i dodajemy je do siebie
		{
			decimal result = 0.0m;
			for (int i = 0; i < functionParameters.Length; i++)
			{
				//		x1,x2,x3,x4....		*						x0 do potęgi takiej, ile jest wpółczynników wielomianu, iteracyjnie o 1 mniej
				result += functionParameters[i] * (decimal)Math.Pow((double)pointX, functionParameters.Length - 1 - i);
				
			}
			return result; // wartość funkcji w zadanym punkcie - współrzedna Y
		}





		//Funkcja do wyznaczania wartości pochodnej funkcji w punktach x1, x2, x3, x4, ......

												// tablica ze współczynnikami wielomianu
		public decimal[] CalculateDerivative(decimal[] functionParameters) // Wyznaczenie tablicy z wartościami pochodnych funkcji w punktach x1, x2, x3, x4, ......
		{
			decimal[] result = new decimal[functionParameters.Length - 1];

			for (int i = 0; i < functionParameters.Length - 1; i++)
			{
				result[i] = functionParameters[i] * (functionParameters.Length - 1 - i);
			}
			return result; // wyliczona wartość pochodnej funkcji
		}






		//Funkcja do wyznaczania wartości punktów opisujących styczną

									//(tablica z wartościami pochodnych,    współrzędna X pochodnej, wsp. Y pochodnej)
		public decimal[] CalculateTangent(decimal[] derivativeFunctionParameters, decimal pointX, decimal pointY)
		{
			decimal[] result = new decimal[2];

			decimal derivativeValue = CalculateFunctionValueAtX(derivativeFunctionParameters, pointX);
			result[0] = derivativeValue;

			result[1] = pointY - derivativeValue * pointX; // przekształcone równanie stycznej

			return result; // wartość opisująca styczną
		}



		// przycisk OBLICZ
		private void calculateButton_Click(object sender, EventArgs e) 
		{
			try //obsługa błędów wprowadzanych danych parserami
			{
				wykres.ResetChart();
				decimal epsilon = Decimal.Parse(epsilonTextBox.Text);       // parametr epsilon
				decimal delta = Decimal.Parse(deltaTextBox.Text);			// parametr delta
				int iterations = Int32.Parse(iterationsTextBox.Text);		// liczba iteracji
				decimal pointX = Decimal.Parse(pointXTextBox.Text);			// punkt startowy X0



				//wykres.PunktPocz(pointX); // zaznaczenie punktu startowego nie dziala


				decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse); // wpisanie współczynników wielomianów do tablicy współczynników wielomianu

				decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations); // funkcja obliczająca miejsce zerowe

				zeroPlaceTextBox.Text = zeroPlace.ToString();

				Series functionChartSeries = PrepareChartSeries(functionParameters, pointX, "Funkcja f(x)");

				wykres.DrawFunctionChart(functionChartSeries);
				wykres.Show();
			}
			catch
			{
				Blad uwaga = new Blad();
				uwaga.Show();
			}
		}






		// Funkcja wyliczająca miejsce zerowe
									
										// tablica z współczynnikami wielomianu, punkt startowy, epislon, delta, max. liczba iteracji

		public decimal CalculateZeroPlace(decimal[] functionParameters, decimal x0, decimal epsilon, decimal delta, int iterations) 
		{
			
			// porobic AppendText zamiast +=

			
			logRichTextBox.Text += "Wzór funkcji w postaci wielomianu: " + parametersTextBox.Text + "\n"; //String.Join(";", functionParameters
			logRichTextBox.Text += "Punkt startowy X0: " + pointXTextBox.Text + "\n"; //x0


			decimal x1 = x0 - 1; 

			// wyliczona wartość funkcji w punkcie x0
			decimal fX0 = CalculateFunctionValueAtX(functionParameters, x0);


		

			logRichTextBox.Text += "Wartość funkcji w punkcie startowym wynosi: " + fX0 + "\n";
			logRichTextBox.Text += "Dokładność porównania z zerem - epsilon: " + epsilon + "\n";
			logRichTextBox.Text += "Dokładność wyznaczania pierwiastka - delta: " + delta + "\n";
			logRichTextBox.Text += "Maksymalna liczba iteracji: " + iterations + "\n";

			int numberOfIteration = 0;

			while (iterations > 0 && Math.Abs(x1 - x0) > epsilon && Math.Abs(fX0) > delta) //wykonuj dopóki liczba iteracji jest większa od 0 i wartość bezwzględna z x1 - x0 jest większa od epsilon i wartość bezwzględna z funkcji w punkcie x0 jest większa od delta
			{
				

				logRichTextBox.Text += "\n";
				numberOfIteration += 1;
				logRichTextBox.Font = new Font(logRichTextBox.Font, FontStyle.Bold);

				logRichTextBox.AppendText("Numer iteracji: " + numberOfIteration + "\n");
				//logRichTextBox.Rtf = @"{\rtf1\ansi This is in \b bold\b0.}";



				// Tutaj są wartości pochodnej
				decimal[] derivativeParamters = CalculateDerivative(functionParameters);



				// Obliczona pochodna funkcji w potencjalnym miejscu zerowym
				decimal fX1 = CalculateFunctionValueAtX(derivativeParamters, x0);

				
				logRichTextBox.Font = new Font(logRichTextBox.Font, FontStyle.Regular);
				logRichTextBox.Text += "Pochodna funkcji w potencjalnym miejscu zerowym wynosi: " + fX1 + "\n";


				// Obliczone wartości opisujące styczną
				decimal[] tangentParameters = CalculateTangent(derivativeParamters, x0, fX0);


				if (functionParameters.Length > 1) // nie wyliczymy stycznej dla stałej tak żeby przecięła oś X
				{
					Series series = PrepareTangentSeries(tangentParameters, x0, "Styczna nr " + numberOfIteration);
					wykres.DrawFunctionChart(series);
				}




				if (Math.Abs(fX1) < delta) //sprawdzenie czy wartość funkcji od bieżącego przybliżenia miejsca zerowego jest mniejsza od przyjętej wartości delty - KRYTERIUM STOPU
				{
					MessageBox.Show("Zły punkt startowy");
					logRichTextBox.Text += "Wartość funkcji f(x), która uruchomiła kryterium stopu: "+fX1.ToString()+"\n";
					logRichTextBox.Text += "Zły punkt startowy\n";
					logRichTextBox.Text += "Koniec obliczeń" + "\n";

					return x0;
				}



				x1 = x0;
				x0 = x0 - fX0 / fX1;		// tutaj wyliczanie równanie stycznej --> x1 = x0 - fX0 / f'X0	i tak dalej (iteracyjnie)		fX1 to pochodna w potencjalnym miejscu zerowym obliczona powyżej



				logRichTextBox.Text += "Potencjalne miejsce zerowe wynosi: " + x0 + "\n";

				// Wyliczamy wartość funkcji w potencjalnym miejscu zerowym
				fX0 = CalculateFunctionValueAtX(functionParameters, x0);


				logRichTextBox.Text += "Wartość funkcji w potencjalnym miejscu zerowym wynosi: " + fX0 + "\n";
				wykres.DrawPoint(x0, fX0);

				iterations = iterations - 1;


			}

			if (iterations == 0) // Czy osiągnięto maksymalną liczbę iteracji?
			{
				MessageBox.Show("Przekroczono maksymalną liczbę iteracji","Osiągnięto maksymalną liczbę iteracji", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				logRichTextBox.Text += "Przekroczono maksymalną liczbę iteracji\n";
			}

			logRichTextBox.Text += "\n";
			logRichTextBox.Text += "\n";

			logRichTextBox.Text += "UZYSKANE WYNIKI" + "\n";
			logRichTextBox.Text += "-------------------------------------------------------------------------------------------------------\n";

			logRichTextBox.Font = new Font(logRichTextBox.Font, FontStyle.Bold);

			logRichTextBox.AppendText("Miejsce zerowe wynosi: " + x0 + "\n"); 
			logRichTextBox.AppendText("Wartość funkcji w tym miejscu zerowym wynosi: " + fX0.ToString() + "\n");
			logRichTextBox.Font = new Font(logRichTextBox.Font, FontStyle.Regular);

			logRichTextBox.AppendText("Numer iteracji, w której znaleziono miejsce zerowe: " + numberOfIteration.ToString() + "\n");

			wykres.DrawZeroPlace(x0, fX0); // Zaznaczane jest miejsce zerowe na wykresie
			

			return x0; // wartość miejsca zerowego, współrzędna X
		}






		// Funkcja sprawdzająca, czy miejsce zerowe jest zgodne z wartością epsilon (dokładność porównania z zerem)

		//					(tablica z współczynnikami wielom, wyliczone miejsce zerowe, epsilon)
		public bool IsResultCorrect(decimal[] functionParameters, decimal zeroPlace, decimal epsilon) // Sprawdź wynik - funkcja
		{
			decimal result = CalculateFunctionValueAtX(functionParameters, zeroPlace);  // czy bezwzględna wartość funkcji w miejscu zerowym jest mniejsza od wartości epsilon??

			if (Math.Abs(result) < epsilon)												// wtedy - jeśli tutaj jest wartość bliska 0, to znaczy że program działa ok
			{
				return true;
			}
			else
			{
				return false;
			}
		}





		// Wykonuje się funkcja powyższa i sprawdza wynik

		private void IsCorrectButton_Click(object sender, EventArgs e) // Sprawdź wynik - przycisk
		{
			// try catch

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





				/**
				 * Metoda
				 * @param functionParameters tablica zawierająca parametry wielomianu
				 * @param startingPointX punkt startowy
				 * @param seriesName nazwa serii
				 * @return seria danych do narysowania funkcji
				 */
		public Series PrepareChartSeries(decimal[] functionParameters, decimal startingPointX, string seriesName)
		{
			// try catch

			Series series = new Series(seriesName);
			for (decimal i = startingPointX - 5.0m; i < startingPointX + 5.0m; i = i + 0.5m)
			{
				series.Points.Add(new DataPoint((double)i, (double)CalculateFunctionValueAtX(functionParameters, i))); // punkty X Y funkcji
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

		public Series PrepareTangentSeries(decimal[] functionParameters, decimal startingPointX, string seriesName) // rysowanie stycznych
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

		private void resetButton_Click(object sender, EventArgs e) // resetowanie danych w textboxach
		{
			try
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
			catch
			{
				Blad blad = new Blad();
				blad.Show();
			}
		}

		private void saveButton_Click(object sender, EventArgs e) // Zapisz dane z richTextBox do pliku .txt
		{
			try
			{
				MemoryStream ms = new MemoryStream();

				ms.Position = 0;

				logRichTextBox.SaveFile(ms, RichTextBoxStreamType.PlainText);
				ms.WriteByte(13);

				SaveFileDialog svd = new SaveFileDialog();

				svd.CreatePrompt = true;
				svd.OverwritePrompt = true;

				svd.FileName = "Proces-wyznaczenia-miejsca-zerowego";
				svd.DefaultExt = "txt";
				svd.Filter =
					"Text files (*.txt)|*.txt|All files (*.*)|*.*";
				svd.InitialDirectory =
					Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				DialogResult result = svd.ShowDialog();

				Stream fileStream;

				if (result == DialogResult.OK)
				{
					fileStream = svd.OpenFile();
					ms.Position = 0;
					ms.WriteTo(fileStream);
					fileStream.Close();
				}
			}
			catch
			{
				Blad blad = new Blad();
				blad.Show();
			}
		}

		// Wyświetl okno pomocy
		private void schematWprowadzaniaDanychToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Pomoc schematObslugiBledow = new Pomoc();
			schematObslugiBledow.Show();
		}

		// Wyświetl okno o programie
		private void oProgramieToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OProgramie O_Programie = new OProgramie();
			O_Programie.Show();
		}

		private void button1_Click(object sender, EventArgs e) // zamknij program
		{
			wykres.Close();
			this.Close();
		}
	}
}
