using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_9
{
    public partial class Form1 : Form
    {
        double[] p = new double[5]; 
        public Form1()
        {
            InitializeComponent();
            chart1.Legends.Clear();
            Prob5.Enabled = false;
            labAverage.Text = labVariance.Text = labChi.Text = labChiBool.Text = "";
        }

        private void startB_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            p[0] = (double)Prob1.Value;
            p[1] = (double)Prob2.Value;
            p[2] = (double)Prob3.Value;
            p[3] = (double)Prob4.Value;
            p[4] = 1 - p[0] - p[1] - p[2] - p[3];

            if (p[4] <= 0 || p[4] > 1) return;

            Prob5.Value = (decimal)p[4];            
            Random random = new Random();

            double[] n = new double[5];
            int N = (int)NExp.Value;

            for (int i = 0; i < N; i++)
            {
                double k = (double)random.NextDouble();
                for (int j = 0; j < 5; j++)
                {
                    k -= p[j];
                    if (k <= 0)
                    {
                        n[j]++;
                        break;
                    }                    
                }
            }
            for (int i = 0; i < 5; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, (float)n[i] / N);
            }

            double Ex = 0, Dx = 0, emEx = 0, emDx = 0, Chi = 0;
            for (int i = 0; i < 5; i++)
            {
                Ex += p[i] * (i + 1);
                emEx += (n[i] / N) * (i + 1);
                Dx += p[i] * (i + 1) * (i + 1);
                emDx += (n[i] / N) * (i + 1) * (i + 1);
                Chi += (n[i] * n[i]) / (N * p[i]);
            }
            Dx -= Ex * Ex;
            emDx -= emEx * emEx;
            Chi -= N;
            double eError = Math.Abs(emEx - Ex) / Math.Abs(Ex);
            double dError = Math.Abs(emDx - Dx) / Math.Abs(Dx);

            labAverage.Text = "Average: "+Math.Round(emEx,3)+" (error = "+Math.Round(eError*100)+"%)";
            labVariance.Text = "Variance: " + Math.Round(emDx, 3) + " (error = " + Math.Round(dError * 100) + "%)";
            labChi.Text = "Chi-squared: "+ Math.Round(Chi,3)+" > 9.488 ";
            if (Chi >= 9.488)
            {
                labChiBool.Text = "True";
                labChiBool.ForeColor = Color.Green;
            }
            else
            {
                labChiBool.Text = "False";
                labChiBool.ForeColor = Color.Red;
            }

        }
    }
}
