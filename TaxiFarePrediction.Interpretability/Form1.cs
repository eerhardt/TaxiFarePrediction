﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.IO;


namespace TaxiFareRegression.Interpretability
{
    public partial class Form1 : Form
    {
        int _predictionIndex = 0;
        
        static List<DataStructures.TaxiFarePrediction> predictions = GetTaxiFare.Predictions();
        int _resultCount= predictions.Count();

        public Form1()
        {
            this.InitializeComponent();
            PaintChart();
        }

        void PaintChart()
        {
            this.plot1.Model = Chart.GetPlotModel(predictions[_predictionIndex]);
            this.lblTripID.Text = (_predictionIndex + 1).ToString();
            this.lblFare.Text = string.Format("{0:C}", Convert.ToDecimal(predictions[_predictionIndex].FareAmount));
            this.distance.Text = string.Format("{0}", Convert.ToDecimal(predictions[_predictionIndex].Input.TripDistance));
            this.tripTime.Text = string.Format("{0}", new TimeSpan(0, 0, (int)predictions[_predictionIndex].Input.TripTime));
            this.passengerCount.Text = ((int)predictions[_predictionIndex].Input.PassengerCount).ToString();
        }

        internal static class Chart
        {
            public static PlotModel GetPlotModel(DataStructures.TaxiFarePrediction prediction)
            {
                var model = new PlotModel { Title = "Taxi Fare Prediction Impact per Feature" };

                var barSeries = new BarSeries
                {
                    ItemsSource = new List<BarItem>(new[]
                        {
                        new BarItem{ Value = (prediction.Features[0].Value)},
                        new BarItem{ Value = (prediction.Features[1].Value)},
                        new BarItem{ Value = (prediction.Features[2].Value)}
                    }),
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0:.00}"
                };

                model.Series.Add(barSeries);

                model.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "FeatureAxis",
                    ItemsSource = new[]
                    {
                        prediction.Features[0].Name,
                        prediction.Features[1].Name,
                        prediction.Features[2].Name
                }
                });

                return model;
            }

            
        }
        internal static class GetTaxiFare
        {
            private static string BaseRelativePath = @"../../../TaxiFarePrediction";
            private static string BaseDataPath = Path.Combine(Path.GetFullPath(BaseRelativePath), "inputs");
            private static string TestDataPath = Path.Combine(BaseDataPath, "taxi-fare-test.csv");
            private static string ModelPath = Path.Combine(BaseRelativePath, "outputs", "TaxiFareModel.zip");

            public static List<DataStructures.TaxiFarePrediction> Predictions()
            {
                var modelPredictor = new Predictor(ModelPath, TestDataPath);
                List<DataStructures.TaxiFarePrediction> predictions = modelPredictor.RunMultiplePredictions(numberOfPredictions: 20);
                return predictions;
                //Console.WriteLine(JsonConvert.SerializeObject(predictions, Formatting.Indented));

            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Plot1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_predictionIndex < _resultCount - 1)
            {
                _predictionIndex++;
                PaintChart();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (_predictionIndex > 0)
            {
                _predictionIndex--;
                PaintChart();
            }
        }
    }
}
