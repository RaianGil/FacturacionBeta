using System.Collections.Generic;
using Xamarin.Forms;
//Using Microcharts
using Microcharts;
//Especificar que los entrys son los del nuget
using Entry = Microcharts.ChartEntry;
//Using a SkiaSharp para los colores de los gráficos
using SkiaSharp;

namespace FacaiboBETA.Views
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entryList;
        public MainPage()
        {
            InitializeComponent();
            entryList = new List<Entry>();
            //Cargar nuesta lista de entries;
            LoadEntries();
            //Asignar los datos dentro de los entrys a los gráficos dentro de la vista XAML
            barChart.Chart = new BarChart()
            {
                Entries = entryList
            };
            pieChart.Chart = new RadialGaugeChart()
            {
                Entries = entryList
            };
            donutChart.Chart = new DonutChart()
            {
                Entries = entryList
            };
            linesChart.Chart = new LineChart()
            {
                Entries = entryList
            };
        }
        private void LoadEntries()
        {
            Entry e1 = new Entry(70)
            {
                Label = "A",
                ValueLabel = "70",
                Color = SKColor.Parse("#00bcd4")
            };
            Entry e2 = new Entry(300)
            {
                Label = "B",
                ValueLabel = "300",
                Color = SKColor.Parse("#F44336")
            };
            Entry e3 = new Entry(50)
            {
                Label = "C",
                ValueLabel = "50",
                Color = SKColor.Parse("#43A047")
            };
            Entry e4 = new Entry(500)
            {
                Label = "D",
                ValueLabel = "500",
                Color = SKColor.Parse("#F9A825")
            };
            entryList.Add(e1);
            entryList.Add(e2);
            entryList.Add(e3);
            entryList.Add(e4);
        }
    }
}