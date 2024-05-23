using System;
using System.Windows.Forms;

namespace The_function_calculates_the_sum_of_the_geometric_progression
{
    public partial class GeometricProgressionForm : Form
    {
        public GeometricProgressionForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double firstTerm = double.Parse(txtFirstTerm.Text);
            double commonRatio = double.Parse(txtCommonRatio.Text);
            int numberOfTerms = int.Parse(txtNumberOfTerms.Text);

            double sum = CalculateGeometricProgression(firstTerm, commonRatio, numberOfTerms);
            lblResult.Text = sum.ToString();
        }

        private double CalculateGeometricProgression(double firstTerm, double commonRatio, int numberOfTerms)
        {
            return firstTerm * (1 - Math.Pow(commonRatio, numberOfTerms)) / (1 - commonRatio);
        }
    }
}
