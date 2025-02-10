using ScottPlot;
using SpreadsheetLight;

namespace Dashboards
{
    public partial class Form1 : Form
    {
        string pathFile = AppDomain.CurrentDomain.BaseDirectory + "vacantes.xlsx";
        SLDocument document;

        // Cargar documento de Excel
       
private void loadDocument()
        {
            int index = 1;
            document = new SLDocument(pathFile);
            while (!string.IsNullOrEmpty(document.GetCellValueAsString(index, 1)))
            {
                List<string> rowValues = new List<string>();
                for (int col = 1; col <= 18; col++)
                {
                    string cellValue = document.GetCellValueAsString(index, col);
                    rowValues.Add(cellValue);
                }
                
                index++;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Load += formsPlot1_Load_1;
        }

        private void formsPlot1_Load_1(object sender, EventArgs e)
        {
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            formsPlot1.Plot.Add.Scatter(dataX, dataY);
            formsPlot1.Refresh();
        }
    }
}
