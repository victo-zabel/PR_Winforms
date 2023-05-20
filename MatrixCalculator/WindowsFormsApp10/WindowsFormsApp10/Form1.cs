using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// !!!! сначала нажать на обратную матрицу, потом на что - то другое, потом снова на обратную матрицу и тд
namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //строки а
        {
            dataGridViewA.RowCount = (int)numeriсStringA.Value;

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e) //столбцы а
        {
            dataGridViewA.ColumnCount = (int)numericColumnA.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) //строки б
        
        {
            dataGridViewB.RowCount = (int)numericStringB.Value;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e) //столбцы б
        {
            dataGridViewB.ColumnCount = (int)numericColumnB.Value;
        }


        private void button1_Click_1(object sender, EventArgs e) // заполнение матрицы а рандомом
        {
            dataGridViewA.RowCount = Convert.ToInt32(numeriсStringA.Value);
            dataGridViewA.ColumnCount = Convert.ToInt32(numeriсStringA.Value);
            Random r = new Random();
            for (int i = 0; i < dataGridViewA.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewA.Columns.Count; j++)
                {
                    dataGridViewA[j, i].Value = r.Next(-50, 50);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) //заполнение матрицы б рандомом
        {
            Random r = new Random();
            for (int i = 0; i < dataGridViewB.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewB.Columns.Count; j++)
                {
                    dataGridViewB[j, i].Value = r.Next(-50, 50);
                }
            }
        }

        




        private void button3_Click(object sender, EventArgs e) //сложение AB
        {
            dataGridViewRes.RowCount = dataGridViewA.RowCount;
            dataGridViewRes.ColumnCount = dataGridViewA.ColumnCount;
            
            for (int i = 0; i < dataGridViewA.ColumnCount; i++)
            {
               
                    for (int j = 0; j < dataGridViewB.ColumnCount; j++)
                {
                    dataGridViewRes[i, j].Value = Convert.ToDouble(dataGridViewA[i, j].Value) + Convert.ToDouble(dataGridViewB[i, j].Value);
                }
            }
        }   
        private void button4_Click(object sender, EventArgs e) //вычитание AB
        {
            dataGridViewRes.RowCount = dataGridViewA.RowCount;
            dataGridViewRes.ColumnCount = dataGridViewA.ColumnCount;

            for (int j = 0; j < dataGridViewRes.ColumnCount; j++)
            {
                for (int k = 0; k < dataGridViewRes.RowCount; k++)
                {
                    dataGridViewRes[j, k].Value = Convert.ToDouble(dataGridViewA[j, k].Value) - Convert.ToDouble(dataGridViewB[j, k].Value);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e) //умножение AB
        {
            dataGridViewRes.RowCount = dataGridViewA.Rows.Count;
            dataGridViewRes.ColumnCount = dataGridViewA.Columns.Count;

            for (int j = 0; j < dataGridViewRes.ColumnCount; j++)
            {
                for (int k = 0; k < dataGridViewRes.RowCount; k++)
                {
                    dataGridViewRes[j, k].Value = Convert.ToDouble(dataGridViewA[j, k].Value) * Convert.ToDouble(dataGridViewB[j, k].Value);
                }
            }
        }





        private void button6_Click(object sender, EventArgs e) //обратная матрица
        {

            double[,] array = new double[dataGridViewA.ColumnCount, dataGridViewA.RowCount];
            for (int i = 0; i < dataGridViewA.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewA.RowCount; j++)
                {
                    array[i, j] = Convert.ToDouble(dataGridViewA[i, j].Value);
                }
            }

            double d = GetDtrmnte(array);

            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[j, k] = array[k, j];
                }
            }

            double[,] u = new double[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    u[i, j] = GetDtrmnte(Matrix_Sb(array, i, j));
                }
            }

            double[,] res = new double[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    res[i, j] = (1 / d) * u[i, j];
                }
            }

            dataGridViewRes.ColumnCount = res.GetLength(0);
            dataGridViewRes.RowCount = res.GetLength(1);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridViewRes[i, j].Value = res[i, j];
                }
            }
        }
        private void button10_Click(object sender, EventArgs e) //ранг матрицы
        {
            double[,] array = new double[dataGridViewA.ColumnCount, dataGridViewA.RowCount];
            for (int i = 0; i < dataGridViewA.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewA.RowCount; j++)
                {
                    array[i, j] = Convert.ToDouble(dataGridViewA[i, j].Value);
                }
            }
            GetRnk(array);
            dataGridViewRes.ColumnCount = 1;
            dataGridViewRes.RowCount = 1;
            dataGridViewRes[0, 0].Value = GetRnk(array);
        }
        private void button8_Click(object sender, EventArgs e) //транспонирование, по факту должно работать для всех матриц,
                                                               //но мы как бы поставили ограничение на квадратность,
                                                               //поэтому не судьба :С
        {

            for (int j = 0; j < dataGridViewA.ColumnCount; j++)
            {
                for (int k = 0; k < dataGridViewA.RowCount; k++)
                {
                    dataGridViewRes[j, k].Value = dataGridViewA[k, j].Value;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e) //определитель
        {
            dataGridViewRes.RowCount = 1;
            dataGridViewRes.ColumnCount = 1;
            double[,] array = new double[dataGridViewA.ColumnCount, dataGridViewA.RowCount];

            for (int i = 0; i < dataGridViewA.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewA.RowCount; j++)
                {
                    array[i, j] = Convert.ToDouble(dataGridViewA[i, j].Value);
                }
            }
            dataGridViewRes[0, 0].Value = GetDtrmnte(array);
        }
        private void button9_Click(object sender, EventArgs e) //минор элемента
        {
            dataGridViewRes.RowCount = 1;
            dataGridViewRes.ColumnCount = 1;
            double[,] array = new double[dataGridViewA.ColumnCount, dataGridViewA.RowCount];
            for (int i = 0; i < dataGridViewA.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewA.RowCount; j++)
                {
                    array[i, j] = Convert.ToDouble(dataGridViewA[i, j].Value);
                }
            }
            dataGridViewRes[0, 0].Value = GetDtrmnte(Matrix_Sb(array, Convert.ToInt32(dataGridViewA.SelectedCells[0].ColumnIndex), Convert.ToInt32(dataGridViewA.SelectedCells[0].RowIndex)));

        }
        private void button11_Click(object sender, EventArgs e) //умножить на число
        {
            for (int j = 0; j < dataGridViewA.ColumnCount; j++)
            {
                for (int k = 0; k < dataGridViewA.RowCount; k++)
                {
                    if (MultipliNumber.Value != 0)
                    {
                        dataGridViewRes[j, k].Value = Convert.ToDouble(dataGridViewA[j, k].Value) * Convert.ToDouble(MultipliNumber.Value);
                    }
                    else dataGridViewRes[j, k].Value = 0;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) // надп матр б
        {

        }

        

        private void label9_Click(object sender, EventArgs e) // стол б
        {

        }

        

        private void label4_Click(object sender, EventArgs e) //надпись опер над матр
        {

        }
        private void label3_Click(object sender, EventArgs e) //надпись оп над матр
        {

        }

        private void label5_Click(object sender, EventArgs e) //надп рез вычисл
        {

        }

        private void label1_Click(object sender, EventArgs e) //надп матр а
        {

        }

        private void label7_Click(object sender, EventArgs e) // стр а
        {

        }

        private void label6_Click(object sender, EventArgs e) //стол а
        {

        }

        private void label8_Click(object sender, EventArgs e) //стр б
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)  //поле реза
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) // панель б
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MultiplicatorNumeric_ValueChanged(object sender, EventArgs e) //множитель на число

        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public double GetDtrmnte(double[,] array) //определитель 
        {
            if (array.GetLength(0) == 1 && array.GetLength(1) == 1)
            {
                //MessageBox.Show("Матрица должна быть квадратной", "ОЙ!");
                return array[0, 0];

            }
            double d = 0;
            for (int i = 0; i < array.GetLength(1); i++)
                d += Math.Pow(-1, i) * array[i, 0] * GetDtrmnte(Matrix_Sb(array, i, 0));
            return d;
        }
        public int GetRnk(double[,] array) //ранг матрицы
        {
            int rank = 0;
            int q = 1;

            while (q <= Math.Min(array.GetLength(0), array.GetLength(1)))
            {
                double[,] matbv = new double[q, q];
                for (int i = 0; i < (array.GetLength(0) - (q - 1)); i++)
                {
                    for (int j = 0; j < (array.GetLength(1) - (q - 1)); j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            for (int c = 0; c < q; c++)
                            {
                                matbv[k, c] = array[i + k, j + c];
                            }
                        }

                        if (GetDtrmnte(matbv) != 0)
                        {
                            rank = q;
                        }
                    }
                }
                q++;
            }
            return rank;
        } 
        public double[,] Matrix_Sb(double[,] array, int a, int b) // субматрица
        {
            double[,] sub = new double[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0; i < sub.GetLength(0); i++)
                for (int j = 0; j < sub.GetLength(1); j++)
                    sub[i, j] = array[i < a ? i : i + 1, j < b ? j : j + 1];

            return sub;
        }
    }
}
