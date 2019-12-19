using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konzisztencia
{
    public partial class Form1 : Form
    {
        Matrix result;

        private int questionIndex = -1;
        String[] Termekek = new String[] { "alma", "körte", "szilva", "cseresznye", "eper", "fekete ribizli" };
        int n = 6; //A termekek szama
        Tuple<int, int>[] randomPairs;
        public Form1()
        {

            InitializeComponent();
            result = new Matrix(6);


            Tuple<int, int>[] pairs = new Tuple<int, int>[n * (n - 1) / 2];

            Random rnd = new Random();

            int index = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                {
                    pairs[index] = new Tuple<int, int>(i, j);
                    index++;
                }

            for (int i = 0; i < n; i++)
                result.m[i, i] = 1;

            randomPairs = pairs.OrderBy(i => rnd.Next()).ToArray();

            nextQuestion();
        }

        private void nextQuestion()
        {
            questionIndex++;

            if (questionIndex == n * (n - 1) / 2)
            {
                startButton.Enabled = false;
                var d = decimal.Parse(result.consistency().ToString());
                consLabel.Text = decimal.Round(d,2).ToString();
                return;
            }

            termekLabel1.Text = Termekek[randomPairs[questionIndex].Item1];
            termekLabel2.Text = Termekek[randomPairs[questionIndex].Item2];
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (questionIndex == n * (n - 1) / 2)
            {
                startButton.Enabled = false;
                consLabel.Text = this.result.consistency().ToString();
            }

            result.m[randomPairs[questionIndex].Item1, randomPairs[questionIndex].Item2] = (double)numericUpDown.Value;
            result.m[randomPairs[questionIndex].Item2, randomPairs[questionIndex].Item1] = 1.0 / (double)numericUpDown.Value;

            nextQuestion();
        }
    }

    public class Matrix
    {
        public int n;
        public double[,] m;

        public Matrix(int n)
        {
            this.n = n;
            m = new double[n, n];
        }

        public static Matrix operator *(Matrix lhv, Matrix rhv)
        {
            if (rhv.n != lhv.n)
                throw new IndexOutOfRangeException();

            Matrix ret = new Matrix(lhv.n);

            for (int i = 0; i < lhv.n; i++)
                for (int j = 0; j < lhv.n; j++)
                    for (int k = 0; k < lhv.n; k++)
                        ret.m[i, j] += lhv.m[i, k] * rhv.m[k, j];

            return ret;
        }

        public double consistency()
        {
            double ret = 0.0;
            int numberOfTrans = fact(this.n) / (fact(this.n - 3) * fact(3));
            for (int i = 0; i < this.n; i++)
                for (int j = i + 1; j < this.n; j++)
                    for (int k = j + 1; k < this.n; k++)
                    {
                        ret += this.m[i, i] * this.m[j, j] * this.m[k, k] +
                                this.m[i, j] * this.m[j, k] * this.m[k, i] +
                                this.m[j, i] * this.m[k, j] * this.m[i, k] -
                                this.m[i, k] * this.m[j, j] * this.m[k, i] -
                                this.m[i, j] * this.m[j, i] * this.m[k, k] -
                                this.m[i, i] * this.m[j, k] * this.m[k, j];
                    }

            double retValue = ret / (double)numberOfTrans;
            if (retValue >= 0.001 && retValue <= 0.001)
                retValue = 0.0;
            return retValue;
        }

        private int fact(int n)
        {
            if (n == 0)
                return 1;
            int ret = 1;
            for (int i = 1; i <= n; i++)
                ret *= i;

            return ret;
        }
    }
}
