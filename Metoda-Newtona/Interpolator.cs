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
using System.Windows.Forms.DataVisualization.Charting; // dodana przestrzeń nazw niezbędna do tworzenia wykresów

namespace Metoda_Newtona
{
	// 3x^3 - 2x^2 dla x0 = -4 lub 2 == 0,67
	public partial class Interpolator : Form
	{
		private Wykres wykres;

		public Interpolator()
		{
			InitializeComponent();
			wykres = new Wykres();
		}


		// Funckja do wyliczania wartości funkcji w punkcie punkcie x1, x2, x3, x4 ......

									//		(tablica ze współczynnikami wielomianu, współrzedna X punktu dla którego będziemy wyznaczać wartość funkcji)
		public decimal ObliczWartoscFunkcji_WPunkcieX(decimal[] wspolczynnikiWielom, decimal wspX) // Wyliczamy po kolei wartości funkcji f(x) w punkcie x1, x2, x3, x4 ......  i dodajemy je do siebie
		{
			decimal wartoscFunkcji = 0.0m;
			for (int i = 0; i < wspolczynnikiWielom.Length; i++)
			{
				//		x1,x2,x3,x4....		*						x0 do potęgi takiej, ile jest wpółczynników wielomianu, iteracyjnie o 1 mniej
				wartoscFunkcji += wspolczynnikiWielom[i] * (decimal)Math.Pow((double)wspX, wspolczynnikiWielom.Length - 1 - i);

				// wzór funkcji dla wielomianu o współczynnikach np. 5 6 7  i dla punktu startowego = 3
				// wynosiłby f(x) = 5*3^3 + 6*3^2 + 7*3^1
				
			}
			return wartoscFunkcji; // wartość funkcji w zadanym punkcie - współrzedna Y
		}





		//Funkcja do wyznaczania wartości pochodnej funkcji w punktach x1, x2, x3, x4, ......

												// tablica ze współczynnikami wielomianu
		public decimal[] ObliczPochodna(decimal[] wspolczynnikiWielom) // Wyznaczenie tablicy z wartościami pochodnych funkcji w punktach x1, x2, x3, x4, ......
		{
			decimal[] ParamPochodnej = new decimal[wspolczynnikiWielom.Length - 1];

			for (int i = 0; i < wspolczynnikiWielom.Length - 1; i++)
			{
				ParamPochodnej[i] = wspolczynnikiWielom[i] * (wspolczynnikiWielom.Length - 1 - i);
			}
			return ParamPochodnej; // wyliczona wartość pochodnej funkcji
		}






		//Funkcja do wyznaczania wartości punktów opisujących styczną

									//(tablica z wartościami pochodnych,    współrzędna X pochodnej, wsp. Y pochodnej)
		public decimal[] ObliczStyczna(decimal[] parametryPochodnej, decimal wspX, decimal wspY)
		{
			decimal[] wspolrzedneStycznej = new decimal[2];

			decimal wartoscPochodnej = ObliczWartoscFunkcji_WPunkcieX(parametryPochodnej, wspX);
			wspolrzedneStycznej[0] = wartoscPochodnej;

			wspolrzedneStycznej[1] = wspY - wartoscPochodnej * wspX; // przekształcone równanie stycznej

			return wspolrzedneStycznej; // tablica z wartościami opisującymi styczną
		}



		public Series PunktStartowy(decimal punktStartowy, decimal wspY,string nazwaSerii)
		{
			Series series = new Series(nazwaSerii);

			return series; // seria danych do wykresu
		}



		// przycisk OBLICZ
		private void Oblicz_button_Click(object sender, EventArgs e) 
		{
			try //obsługa błędów wprowadzanych danych parserami
			{
				wykres.ResetChart();
				decimal punktStartowy = Decimal.Parse(punktStartowy_TextBox.Text);			// punkt startowy X0
				decimal epsilon = Decimal.Parse(epsilon_TextBox.Text);       // parametr epsilon
				decimal delta = Decimal.Parse(delta_TextBox.Text);			// parametr delta
				int liczbaIteracji = Int32.Parse(iteracje_TextBox.Text);        // liczba iteracji


				

				decimal[] wspolczynnikiWielom = Array.ConvertAll(wspolczynniki_textbox1.Text.Split(' '), Decimal.Parse); // wpisanie współczynników wielomianów do tablicy współczynników wielomianu


				decimal wspY = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom,punktStartowy);
				
				
				wykres.RysujStart(punktStartowy,wspY); // zaznaczenie punktu startowego na wykresie



				decimal miejsceZerowe = ObliczMiejsceZerowe(wspolczynnikiWielom, punktStartowy, epsilon, delta, liczbaIteracji); // funkcja obliczająca miejsce zerowe

				miejsceZerowe_TextBox.Text = miejsceZerowe.ToString();

				Series WykresFunkcjiWielomianu = StworzSerieDanych(wspolczynnikiWielom, punktStartowy, "Wykres wielomianu");

				wykres.RysujWielomian(WykresFunkcjiWielomianu);
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

		public decimal ObliczMiejsceZerowe(decimal[] wspolczynnikiWielom, decimal x0, decimal epsilon, decimal delta, int liczbaIteracji) 
		{

			// porobic AppendText zamiast +=

			richTextBox1.AppendText("\n");
			richTextBox1.AppendText("\n");
			richTextBox1.AppendText("Wzór funkcji w postaci wielomianu: " + wspolczynniki_textbox1.Text + "\n"); 
			richTextBox1.AppendText("Punkt startowy X0: " + punktStartowy_TextBox.Text + "\n"); 


			decimal x1 = x0 - 1; 

			// wyliczona wartość funkcji w punkcie x0
			decimal fX0 = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, x0);


		

			richTextBox1.AppendText("Wartość funkcji w punkcie startowym wynosi: " + fX0 + "\n");
			richTextBox1.AppendText("Dokładność porównania z zerem - epsilon: " + epsilon + "\n");
			richTextBox1.AppendText("Dokładność wyznaczania pierwiastka - delta: " + delta + "\n");
			richTextBox1.AppendText("Maksymalna liczba iteracji: " + liczbaIteracji + "\n");

			int numerIteracji = 0;

			while (liczbaIteracji > 0 && Math.Abs(x1 - x0) > epsilon && Math.Abs(fX0) > delta) //wykonuj dopóki liczba iteracji jest większa od 0 i wartość bezwzględna z x1 - x0 jest większa od epsilon i wartość bezwzględna z funkcji w punkcie x0 jest większa od delta
			{
				

				//richTextBox1.AppendText( "\n");
				numerIteracji += 1;
				richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);

				//richTextBox1.AppendText("Numer iteracji: " + numerIteracji + "\n");



				// Tutaj są wartości pochodnej
				decimal[] wartosciPochodnej = ObliczPochodna(wspolczynnikiWielom);



				// Obliczona pochodna funkcji w potencjalnym miejscu zerowym
				decimal fX1 = ObliczWartoscFunkcji_WPunkcieX(wartosciPochodnej, x0);

				
				richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
				//richTextBox1.AppendText("Pochodna funkcji w potencjalnym miejscu zerowym wynosi: " + fX1 + "\n");


				// Obliczone wartości opisujące styczną
				decimal[] wartosciStycznej = ObliczStyczna(wartosciPochodnej, x0, fX0);


				if (wspolczynnikiWielom.Length > 1) // nie wyliczymy stycznej dla stałej tak żeby przecięła oś X
				{
					Series series = StworzSerie_dlaStycznej(wartosciStycznej, x0, "Styczna nr " + numerIteracji);
					wykres.RysujWielomian(series);
				}




				if (Math.Abs(fX1) < delta) //sprawdzenie czy wartość funkcji od bieżącego przybliżenia miejsca zerowego jest mniejsza od przyjętej wartości delty - KRYTERIUM STOPU
				{
					MessageBox.Show("Zły punkt startowy");
					richTextBox1.AppendText("Wartość funkcji f(x), która uruchomiła kryterium stopu: " + fX1.ToString() + "\n");
					richTextBox1.AppendText("Zły punkt startowy\n");
					richTextBox1.AppendText("Koniec obliczeń" + "\n");

					return x0;
				}



				x1 = x0;
				x0 = x0 - fX0 / fX1;		// tutaj wyliczanie równanie stycznej --> x1 = x0 - fX0 / f'X0	i tak dalej (iteracyjnie)		fX1 to pochodna w potencjalnym miejscu zerowym obliczona powyżej



				//richTextBox1.AppendText("Potencjalne miejsce zerowe wynosi: " + x0 + "\n");

				// Wyliczamy wartość funkcji w potencjalnym miejscu zerowym
				fX0 = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, x0);


				//richTextBox1.AppendText("Wartość funkcji w potencjalnym miejscu zerowym wynosi: " + fX0 + "\n");
				wykres.RysujPunkt(x0, fX0);

				liczbaIteracji = liczbaIteracji - 1;


			}

			if (liczbaIteracji == 0) // Czy osiągnięto maksymalną liczbę iteracji?
			{
				MessageBox.Show("Przekroczono maksymalną liczbę iteracji","Osiągnięto maksymalną liczbę iteracji", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				richTextBox1.AppendText("Przekroczono maksymalną liczbę iteracji\n");
			}

			richTextBox1.AppendText("\n");
			richTextBox1.AppendText("\n");

			richTextBox1.AppendText("UZYSKANE WYNIKI" + "\n");
			richTextBox1.AppendText("-------------------------------------------------------------------------------------------------------\n");

			richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);

			richTextBox1.AppendText("Miejsce zerowe wynosi: " + x0 + "\n"); 
			richTextBox1.AppendText("Wartość funkcji w tym miejscu zerowym wynosi: " + fX0.ToString() + "\n");
			richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);

			richTextBox1.AppendText("Numer iteracji, w której znaleziono miejsce zerowe: " + numerIteracji.ToString() + "\n");

			wykres.RysujMiejsceZerowe(x0, fX0); // Zaznaczane jest miejsce zerowe na wykresie
			

			return x0; // wartość miejsca zerowego, współrzędna X
		}






		// Funkcja sprawdzająca, czy miejsce zerowe jest zgodne z wartością epsilon (dokładność porównania z zerem)

		//					(tablica z współczynnikami wielom, wyliczone miejsce zerowe, epsilon)
		public bool SprawdzWynik(decimal[] wspolczynnikiWielom, decimal miejsceZerowe, decimal epsilon) // Sprawdź wynik - funkcja
		{
			decimal wartosc_w_MZ = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, miejsceZerowe);  // czy bezwzględna wartość funkcji w miejscu zerowym jest mniejsza od wartości epsilon??

			if (Math.Abs(wartosc_w_MZ) < epsilon)												// wtedy - jeśli tutaj jest wartość bliska 0, to znaczy że program działa ok
			{
				return true;
			}
			else
			{
				return false;
			}
		}





		// Wykonuje się funkcja powyższa i sprawdza wynik

		private void sprawdzWynik_button_Click(object sender, EventArgs e) // Sprawdź wynik - przycisk
		{
			try
			{
				decimal[] wspolczynnikiWielom = Array.ConvertAll(wspolczynniki_textbox1.Text.Split(' '), Decimal.Parse);
				decimal miejsceZerowe = Decimal.Parse(miejsceZerowe_TextBox.Text);
				decimal epsilon = Decimal.Parse(epsilon_TextBox.Text);
				bool czyPoprawny = SprawdzWynik(wspolczynnikiWielom, miejsceZerowe, epsilon);

				if (czyPoprawny)
				{
					MessageBox.Show("Miejsce zerowe jest poprawne", "| f(x) | < ε  ==  ?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					MessageBox.Show("Miejsce zerowe nie spełnia kryterium poprawności");
				}
			}
			catch 
			{
				Blad blad = new Blad();
				blad.Show();
			}		
		}






		// Tworzenie serii danych do wykresu

									// (tablica z współczynnikami wielom., punkt startowy, nazwa serii do wykresu)
		public Series StworzSerieDanych(decimal[] wspolczynnikiWielom, decimal punktStartowy, string nazwaSerii)
		{
			// try catch

			Series series = new Series(nazwaSerii);
			for (decimal i = punktStartowy - 5.0m; i < punktStartowy + 5.0m; i = i + 0.5m)
			{
				series.Points.Add(new DataPoint((double)i, (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, i))); // punkty X Y funkcji - albo styczna, miejsce zerowe itd
			}
			return series; // seria danych do wykresu
		}







		// Tworzenie serii danych do wykresu - dla stycznej w punkcie

		//									(tablica współczynników wielom., punkt startowy, nazwa serii)
		public Series StworzSerie_dlaStycznej(decimal[] wspolczynnikiWielom, decimal punktStartowy, string nazwaSerii) // rysowanie stycznych
		{

			// Tworzenie nowej serii danych o podanej nazwie
			Series seria = new Series(nazwaSerii);

			// Ustawienie koloru serii na czerwony
			seria.Color = Color.Red;

			// Obliczenie wartości funkcji wielomianowej w punkcie startowym
			decimal wartoscFunkcjiwX0 = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy);

			// Inicjalizacja wartości pomocniczej pomoc_wartoscwX   
			decimal pomoc_wartoscwX = wartoscFunkcjiwX0;



			// Sprawdzenie warunków dla różnych przypadków - jeśli współczynników wielomianu jest więcej niż 0 i gdy wartość funkcji w punkcie jest mniejsza od 0 (lub  przeciwny warunek)
			if ((wspolczynnikiWielom[0] > 0 && wartoscFunkcjiwX0 < 0) || (wspolczynnikiWielom[0] < 0 && wartoscFunkcjiwX0 > 0))
			{
				// Dodanie punktu do serii dla punktu leżącego 0.5 jednostki przed punktem startowym
				seria.Points.Add(new DataPoint((double)(punktStartowy - 0.5m), (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy - 0.5m)));

				// Pętla dodająca punkty do serii do momentu, gdy wartość funkcji zmienia znak
				while (wartoscFunkcjiwX0 * pomoc_wartoscwX > 0)
				{
					// Obliczenie wartości funkcji dla aktualnego punktu
					pomoc_wartoscwX = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy);
					// Dodanie punktu do serii
					seria.Points.Add(new DataPoint((double)punktStartowy, (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy)));
					// Zwiększenie wartości x o 0.5 jednostki
					punktStartowy += 0.5m;
				}
			}
			else if ((wspolczynnikiWielom[0] > 0 && wartoscFunkcjiwX0 > 0) || (wspolczynnikiWielom[0] < 0 && wartoscFunkcjiwX0 < 0))
			{
				// Dodanie punktu do serii dla punktu leżącego 0.5 jednostki po punkcie startowym
				seria.Points.Add(new DataPoint((double)(punktStartowy + 0.5m), (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy + 0.5m)));
				// Pętla dodająca punkty do serii do momentu, gdy wartość funkcji zmienia znak
				while (wartoscFunkcjiwX0 * pomoc_wartoscwX > 0)
				{
					// Obliczenie wartości funkcji dla aktualnego punktu
					pomoc_wartoscwX = ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy);
					// Dodanie punktu do serii
					seria.Points.Add(new DataPoint((double)punktStartowy, (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy)));
					// Zmniejszenie wartości x o 0.5 jednostki
					punktStartowy -= 0.5m;
				}
			}
			else
			{
				// Dodanie punktów do serii dla punktów leżących 0.5 jednostki przed, w, i po punkcie startowym
				seria.Points.Add(new DataPoint((double)(punktStartowy + 0.5m), (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy + 0.5m)));
				seria.Points.Add(new DataPoint((double)(punktStartowy), (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy)));
				seria.Points.Add(new DataPoint((double)(punktStartowy - 0.5m), (double)ObliczWartoscFunkcji_WPunkcieX(wspolczynnikiWielom, punktStartowy - 0.5m)));
				
			}
			return seria; // seria danych do wykresu, dotycząca stycznej
		}




		private void resetuj_button_Click(object sender, EventArgs e) // resetowanie danych w textboxach
		{
			try
			{
				wykres.Close();
				wspolczynniki_textbox1.Clear();
				punktStartowy_TextBox.Clear();
				epsilon_TextBox.Text = "0,000001";
				delta_TextBox.Text = "0,000001";
				iteracje_TextBox.Text = "100";
				miejsceZerowe_TextBox.Clear();
				richTextBox1.Clear();
				this.Refresh();
				wykres.Refresh();

				//wykres.ResetChart();  problem z resetowaniem wykresu
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

				richTextBox1.SaveFile(ms, RichTextBoxStreamType.PlainText);
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

		// Wyświetl okno pomocy
		private void PomocToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Pomoc pomoc = new Pomoc();
			pomoc.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
