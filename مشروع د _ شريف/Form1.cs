using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Reflection.Emit;
using System.Windows.Forms;

namespace مشروع_دكتور_شريف
{
    public partial class Form1 : Form
    {
        private List<List<TextBox>> matrixInputs = new List<List<TextBox>>();
        private int equationCount = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "مشروع دكتور شريف - Gaussian Elimination";
        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            equationCount = (int)numEquations.Value;
            GenerateMatrixInputs(equationCount);
            matrixPanel.Visible = true;
            btnSolve.Visible = true;
            stepsTextBox.Visible = false;
            label2.Visible = false;
        }

        private void GenerateMatrixInputs(int n)
        {
            matrixPanel.Controls.Clear();
            matrixInputs.Clear();

            int cellWidth = 60;
            int cellHeight = 25;
            int startX = 20;
            int startY = 20;

            for (int col = 0; col < n; col++)
            {
                Label header = new Label();
                header.Text = $"x{col + 1}";
                header.Size = new Size(cellWidth, cellHeight);
                header.Location = new Point(startX + col * cellWidth, startY);
                header.TextAlign = ContentAlignment.MiddleCenter;
                header.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                matrixPanel.Controls.Add(header);
            }

            Label resultHeader = new Label();
            resultHeader.Text = "النتيجة";
            resultHeader.Size = new Size(cellWidth, cellHeight);
            resultHeader.Location = new Point(startX + n * cellWidth, startY);
            resultHeader.TextAlign = ContentAlignment.MiddleCenter;
            resultHeader.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            matrixPanel.Controls.Add(resultHeader);

            for (int row = 0; row < n; row++)
            {
                List<TextBox> rowInputs = new List<TextBox>();

                for (int col = 0; col <= n; col++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(cellWidth, cellHeight);
                    textBox.Location = new Point(startX + col * cellWidth, startY + (row + 1) * cellHeight + 5);
                    textBox.Text = "0";
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Tag = new Point(row, col);

                    matrixPanel.Controls.Add(textBox);
                    rowInputs.Add(textBox);
                }
                matrixInputs.Add(rowInputs);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] matrix = GetMatrixFromInputs();
                List<string> steps = new List<string>();

                steps.Add("المصفوفة الأصلية:");
                steps.Add(MatrixToString(matrix));

                double[] solution = GaussianElimination(matrix, steps);

                steps.Add("\nالحل النهائي:");
                for (int i = 0; i < solution.Length; i++)
                {
                    steps.Add($"x{i + 1} = {solution[i]:F4}");
                }

                DisplaySteps(steps);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[,] GetMatrixFromInputs()
        {
            double[,] matrix = new double[equationCount, equationCount + 1];

            for (int i = 0; i < equationCount; i++)
            {
                for (int j = 0; j <= equationCount; j++)
                {
                    if (!double.TryParse(matrixInputs[i][j].Text, out matrix[i, j]))
                    {
                        throw new Exception($"قيمة غير صحيحة في الصف {i + 1}, العمود {j + 1}");
                    }
                }
            }

            return matrix;
        }

        private double[] GaussianElimination(double[,] matrix, List<string> steps)
        {
            int n = equationCount;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] == 0)
                {
                    int swapRow = -1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (matrix[j, i] != 0)
                        {
                            swapRow = j;
                            break;
                        }
                    }

                    if (swapRow != -1)
                    {
                        steps.Add($"\nتبديل الصف {i + 1} مع الصف {swapRow + 1}:");
                        for (int k = 0; k <= n; k++)
                        {
                            double temp = matrix[i, k];
                            matrix[i, k] = matrix[swapRow, k];
                            matrix[swapRow, k] = temp;
                        }
                        steps.Add(MatrixToString(matrix));
                    }
                    else
                    {
                        throw new Exception("لا يمكن إيجاد حل فريد للنظام");
                    }
                }

                if (matrix[i, i] != 1)
                {
                    double pivot = matrix[i, i];
                    steps.Add($"\nقسمة الصف {i + 1} على {pivot:F4}:");
                    for (int j = i; j <= n; j++)
                    {
                        matrix[i, j] /= pivot;
                    }
                    steps.Add(MatrixToString(matrix));
                }

                for (int j = i + 1; j < n; j++)
                {
                    double factor = matrix[j, i];
                    if (factor != 0)
                    {
                        steps.Add($"\nطرح {factor:F4} × (الصف {i + 1}) من الصف {j + 1}:");
                        for (int k = i; k <= n; k++)
                        {
                            matrix[j, k] -= factor * matrix[i, k];
                        }
                        steps.Add(MatrixToString(matrix));
                    }
                }
            }

            double[] solution = new double[n];
            steps.Add("\nالاستبدال الخلفي:");

            for (int i = n - 1; i >= 0; i--)
            {
                solution[i] = matrix[i, n];
                for (int j = i + 1; j < n; j++)
                {
                    solution[i] -= matrix[i, j] * solution[j];
                }
                solution[i] = solution[i] / matrix[i, i];
                steps.Add($"x{i + 1} = {solution[i]:F4}");
            }

            return solution;
        }

        private string MatrixToString(double[,] matrix)
        {
            string result = "";
            int n = equationCount;

            for (int i = 0; i < n; i++)
            {
                result += "[ ";
                for (int j = 0; j <= n; j++)
                {
                    result += $"{matrix[i, j],8:F4} ";
                }
                result += "]\n";
            }

            return result;
        }

        private void DisplaySteps(List<string> steps)
        {
            stepsTextBox.Text = string.Join("\n", steps);
            stepsTextBox.Visible = true;
            label2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}