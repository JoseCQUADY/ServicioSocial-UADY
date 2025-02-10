using ScottPlot;

namespace Dashboards
{
    public partial class Form1 : Form
    {
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
