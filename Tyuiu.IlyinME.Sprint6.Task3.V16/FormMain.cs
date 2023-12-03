using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.IlyinME.Sprint6.Task3.V16.Lib; 

namespace Tyuiu.IlyinME.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 14, 1, -3, 1, 10 },
                                      { 7, -3, 5, -4, 0 },
                                      { -10, -19, -18, -9, 19 },
                                      { -2, -2, -16, 2, -17 },
                                      { -16, 9, 5, -10, 16 } };
        private void buttonDone_IME_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.GetUpperBound(1) + 1;

            dataGridViewResult_IME.ColumnCount = columns;
            dataGridViewResult_IME.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_IME.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_IME.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_IME.ColumnCount = columns;
            dataGridViewMatrix_IME.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_IME.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_IME.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_IME_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Ильин Максим Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
