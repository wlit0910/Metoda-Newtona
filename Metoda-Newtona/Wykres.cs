using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Metoda_Newtona
{
	public partial class Wykres : Form
	{
		private Series potentialZeroPlaces;


		public Wykres()
		{
			InitializeComponent();
			try	{
				ResetChart();

				chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
				chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
				chart1.MouseWheel += Chart1_MouseWheel;

				Title title = chart1.Titles.Add("Wyznaczanie miejsca zerowego metodą stycznych (Newtona)");
				title.Font = new Font("Arial", 15, FontStyle.Bold);

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




		// Rysowanie funkcji na wykresie
		public void DrawFunctionChart(Series series) // dane z Interpolatora - seria danych do narysowania
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




		// Zaznaczanie na wykresie potencjalnych miejsc zerowych

								// (wsp.X, wsp.Y potencjalnego miejsca zerowego)
		public void DrawPoint(decimal pointX, decimal pointY)
		{
			potentialZeroPlaces.Points.AddXY(pointX, pointY);
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
		public void DrawZeroPlace(decimal pointX, decimal pointY) // Oznaczenie miejsca zerowego
		{
			try{
				Series series = new Series("Miejsce zerowe");
				series.Points.AddXY(pointX, pointY);
				series.ChartType = SeriesChartType.Point;

				series.Color = Color.Firebrick;
				series.MarkerSize = 10;
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
				potentialZeroPlaces = new Series("Potencjalne miejsca zerowe");
				potentialZeroPlaces.ChartType = SeriesChartType.Point;
				potentialZeroPlaces.Color = Color.Green;
				potentialZeroPlaces.MarkerSize = 10;
				chart1.Series.Add(potentialZeroPlaces);

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
	}
}
