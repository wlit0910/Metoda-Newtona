using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Controls;


namespace Metoda_Newtona
{
	public partial class Wykres : Form
	{
		private Series potencjalneMZ;


		public Wykres()
		{
			InitializeComponent(); // poniżej wstępne parametry wykresu - tytuł, opis osi współrzędnych itd.
			try	{
				ResetChart();

				chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
				chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
				chart1.MouseWheel += Chart1_MouseWheel;

				Title tytul = chart1.Titles.Add("Wyznaczanie miejsca zerowego metodą stycznych (Newtona)");
				tytul.Font = new Font("Arial", 15, FontStyle.Bold);

				chart1.ChartAreas[0].AxisX.Title = "Oś X";
				chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 15, FontStyle.Bold);
				chart1.ChartAreas[0].AxisY.Title = "Oś Y";
				chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 15, FontStyle.Bold);
			}
			catch {
				Blad blad = new Blad();
				blad.Show();
			}		
		}




		// Rysowanie wykresu wielomianu na wykresie metodą funkcji sklejanych
		public void RysujWielomian(Series series) // dane z Interpolatora - seria danych do narysowania
		{
			try {
				series.ChartType = SeriesChartType.Spline;
				chart1.Series.Add(series);
			}
			catch {
				Blad blad = new Blad();
				blad.Show();
			}
		}




	

								// (wsp.X, wsp.Y potencjalnego miejsca zerowego)
		public void RysujPunkt(decimal wspX, decimal wspY)
		{
			potencjalneMZ.Points.AddXY(wspX, wspY);
			//			potentialZeroPlaces.LegendText = "Punkt X0";
			//potentialZeroPlaces.ChartType = SeriesChartType.Point;
		}

		public void RysujStart(decimal wspX, decimal wspY)
		{

			try
			{
				Series series = new Series("Punkt startowy X0");
				series.Points.AddXY(wspX, wspY);
				series.ChartType = SeriesChartType.Point;

				series.Color = Color.Magenta;
				series.MarkerSize = 10;
				chart1.Series.Add(series);
			}
			catch
			{
				Blad blad = new Blad();
				blad.Show();
			}

			//potencjalneMZ.Points.AddXY(pointX, pointY);
			//			potentialZeroPlaces.LegendText = "Punkt X0";
			//potentialZeroPlaces.ChartType = SeriesChartType.Point;
		}

		//public void PunktPocz(decimal pointX)
		//{
		//	potentialZeroPlaces.Points.AddXY(pointX, 0);
		//				potentialZeroPlaces.LegendText = "Punkt X0";
		//	//potentialZeroPlaces.ChartType = SeriesChartType.Point;
		//	potentialZeroPlaces.ChartType = SeriesChartType.Point;
		//	potentialZeroPlaces.Color = Color.Red;
		//	potentialZeroPlaces.MarkerSize = 10;
		//}



		// Zaznaczenie miejsca zerowego na wykresie

		// (wsp.X, wsp.Y miejsca zerowego)
		public void RysujMiejsceZerowe(decimal wspX, decimal wspY) 
		{
			try{
				Series series = new Series("Miejsce zerowe");
				series.Points.AddXY(wspX, wspY);
				series.ChartType = SeriesChartType.Point;

				series.Color = Color.Firebrick;
				series.MarkerSize = 12;
				chart1.Series.Add(series);
			}
			catch {
				Blad blad = new Blad();
				blad.Show();
			}
		}

				
		 // skalowanie wykresu:		 
		 // https://stackoverflow.com/questions/13584061/how-to-enable-zooming-in-microsoft-chart-control-by-using-mouse-wheel
		 

		private void Chart1_MouseWheel(object sender, MouseEventArgs e)
		{
			try	{
				var chart = (Chart)sender;
				var xAxis = chart.ChartAreas[0].AxisX;
				var yAxis = chart.ChartAreas[0].AxisY;

				if (e.Delta < 0) // Na dół
				{
					try{
						xAxis.ScaleView.ZoomReset();
						yAxis.ScaleView.ZoomReset();
					}
					catch{
						Blad blad = new Blad();
						blad.Show();
					}

				}
				else if (e.Delta > 0) // Do góry
				{
					var xMin = xAxis.ScaleView.ViewMinimum;
					var xMax = xAxis.ScaleView.ViewMaximum;
					var yMin = yAxis.ScaleView.ViewMinimum;
					var yMax = yAxis.ScaleView.ViewMaximum;

					var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
					var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
					var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
					var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

					xAxis.ScaleView.Zoom(posXStart, posXFinish);
					yAxis.ScaleView.Zoom(posYStart, posYFinish);
				}
			}
			catch(Exception ex) { 
				MessageBox.Show("Błąd. Treść błędu: \n"+ ex.Message);
			}
		}
		public void ResetChart()
		{

			try	{

				//foreach (var series in chart1.Series)    resetowanie wykresu nie dziala
				//{
				//	series.Points.Clear();
				//	//chart1.Series["Miejsce zerowe"].Points.Clear();
				//}
				//while (chart1.Series.Count > 0) { chart1.Series.RemoveAt(0); }

				chart1.Series.Clear();
				//potencjalneMZ = new Series();

				potencjalneMZ = new Series("Potencjalne miejsca zerowe");
				potencjalneMZ.ChartType = SeriesChartType.Point;
				potencjalneMZ.Color = Color.Green;
				potencjalneMZ.MarkerSize = 8;
				chart1.Series.Add(potencjalneMZ);
				

			}
			catch {
				Blad blad = new Blad();
				blad.Show();
			}

		}

		private void Wykres_Load(object sender, EventArgs e)
		{

		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}



		private void zapiszWykresPNGToolStripMenuItem_Click(object sender, EventArgs e) // zapisywanie wykresu
		{
			MemoryStream ms = new MemoryStream();
			ms.Position = 0;

			this.chart1.SaveImage(ms, ChartImageFormat.Png);
			//ms.WriteByte(13);

			SaveFileDialog svd = new SaveFileDialog();

			svd.CreatePrompt = true;
			svd.OverwritePrompt = true;

			svd.FileName = "Wykres-z-wyznaczonym-MZ";
			svd.DefaultExt = "png";
			svd.Filter =
				"PNG files (*.png)|*.png|All files (*.*)|*.*";
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
	}
}
