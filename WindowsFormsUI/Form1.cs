using ApplicationModel;
using Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class MainForm : Form
    {
        private const int posX = 3;
        private const int offsetY = 15;
        private int posY = 0;
        private Model model;
        private List<AmountNeuronsInHidenLayersModel> layersModels;

        public MainForm()
        {
            InitializeComponent();
            activatorBindingSource.DataSource = ActivatorsList.GetActivators();
            SetRowCount(trainingDataDGW, trainingsAmount);
            SetRowCount(trainingDataDGW, trainingsAmount);
            model = new Model();
            layersModels = new List<AmountNeuronsInHidenLayersModel>();
            showStatBtn.Enabled = false;
            saveToFileBtn.Enabled = false;
            loadToCheckBtn.Enabled = false;
        }

        private void hidenLayersAmount_ValueChanged(object sender, EventArgs e)
        {
            neuronAmountPanel.Controls.Clear();
            layersModels.Clear();
            posY = 0;
            for(int i = 0; i < (int)hidenLayersAmount.Value; i++)
            {
                AmountNeuronsInHidenLayersModel model = new AmountNeuronsInHidenLayersModel();
                layersModels.Add(model);
                InputAmountUserControl control = new InputAmountUserControl(i, model);
                control.Location = new Point(posX, posY);
                neuronAmountPanel.Controls.Add(control);
                posY += control.Height + offsetY;
            }
        }

        private void outputsAmount_ValueChanged(object sender, EventArgs e)
        {
            RefreshDGW(trainingDataDGW, false);
        }

        private void RefreshDGW(DataGridView dataGridView, bool readOnly)
        {
            dataGridView.Columns.Clear();
            for (int i = 0; i < inputsAmount.Value; i++)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = string.Format("inp{0}", i + 1),
                    HeaderText = string.Format("Вход {0}", i + 1),
                    Width = 100
                });
            }
            for (int i = 0; i < outputsAmount.Value; i++)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = string.Format("out{0}", i + 1),
                    HeaderText = string.Format("Выход {0}", i + 1),
                    Width = 100,
                    ReadOnly = readOnly
                });
            }

            SetRowCount(trainingDataDGW, trainingsAmount);
        }

        private void inputsAmount_ValueChanged(object sender, EventArgs e)
        {
            RefreshDGW(trainingDataDGW, false);
        }

        private void trainingsAmount_ValueChanged(object sender, EventArgs e)
        {
            SetRowCount(trainingDataDGW, trainingsAmount);
        }

        private void SetRowCount(DataGridView dataGridView, NumericUpDown numericUpDown)
        {
            dataGridView.RowCount = (int)numericUpDown.Value;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            if (IsCorrectEps(out double eps) && IsCorrectMutation(out double mutationPropability))
            {
                List<double[]> trainingInputs = GetTrainingInputs();
                List<double[]> trainingOutputs = GetTrainingOutputs();
                if(trainingInputs == null || trainingOutputs == null)
                {
                    MessageBox.Show("Тестовое множество введено неверно");
                    return;
                }

                int[] layersDescriptor = GetNeuronsInLayers();
                model.CreateNeuralNetwork((Manager.Activator)activatorCB.SelectedItem, (int)inputsAmount.Value, layersDescriptor);
                model.TrainNeuralNetwork(trainingInputs, trainingOutputs, eps, (int)populationSizeNUD.Value, (int)iterationsAmountNUD.Value, mutationPropability);
                showStatBtn.Enabled = true;
                saveToFileBtn.Enabled = true;
                loadToCheckBtn.Enabled = true;

                RefreshDGW(workDGW, true);
                MessageBox.Show("Нейросеть обучена");
            }
        }

        private int[] GetNeuronsInLayers()
        {
            List<int> amounts = new List<int>();
            if(layersModels.Count > 0)
            {
                amounts.AddRange(layersModels.Select(x => x.Amount));
            }

            amounts.Add((int)outputsAmount.Value);
            return amounts.ToArray();
        }

        private bool IsCorrectEps(out double eps)
        {
            eps = 0;
            if (string.IsNullOrEmpty(epsTB.Text))
            {
                MessageBox.Show("Максимальная ошибка не установлена");
                return false;
            }

            if(!double.TryParse(epsTB.Text, out eps))
            {
                MessageBox.Show("Значение максимальной ошибки некорректно");
                return false;
            }

            if(eps > 0.1 || eps < 0.0001)
            {
                MessageBox.Show("Значение максимальной ошибки должно находиться в диапазоне от 0,0001 до 0,1");
                return false;
            }

            return true;
        }
        private bool IsCorrectMutation(out double mutationPropability)
        {
            mutationPropability = 0;

            if (string.IsNullOrEmpty(mutationTB.Text))
            {
                MessageBox.Show("Вероятность мутаций не установлена");
                return false;
            }

            if (!double.TryParse(mutationTB.Text, out mutationPropability))
            {
                MessageBox.Show("Значение вероятности мутации некорректно");
                return false;
            }

            if (mutationPropability > 0.3 || mutationPropability < 0.001)
            {
                MessageBox.Show("Значение максимальной ошибки должно находиться в диапазоне от 0,001 до 0,3");
                return false;
            }

            return true;
        }

        private List<double[]> GetTrainingInputs()
        {
            List<double[]> result = new List<double[]>();
            for(int i = 0; i < (int)trainingsAmount.Value; i++)
            {
                double[] vector = new double[(int)inputsAmount.Value];
                for (int j = 0; j < (int)inputsAmount.Value; j++)
                {
                    string value = trainingDataDGW.Rows[i].Cells[j].Value.ToString();
                    if(value == null || !double.TryParse(value, out double number))
                    {
                        return null;
                    }

                    vector[j] = number;
                }

                result.Add(vector);
            }

            return result;
        }

        private List<double[]> GetTrainingOutputs()
        {
            List<double[]> result = new List<double[]>();
            for (int i = 0; i < (int)trainingsAmount.Value; i++)
            {
                double[] vector = new double[(int)outputsAmount.Value];
                for (int j = (int)inputsAmount.Value; j < (int)outputsAmount.Value + (int)inputsAmount.Value; j++)
                {
                    string value = trainingDataDGW.Rows[i].Cells[j].Value.ToString();
                    if (value == null || !double.TryParse(value, out double number))
                    {
                        return null;
                    }

                    vector[j - (int)inputsAmount.Value] = number;
                }

                result.Add(vector);
            }

            return result;
        }

        private void showStatBtn_Click(object sender, EventArgs e)
        {
            if (model.IsLearned)
            {
                var statForm = new StatisticForm(model.Statistic, model.MillisecondsElapsed, model.IterationsAmount);
                statForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Идет обучение");
            }
        }

        private void loadFromfileBtn_Click(object sender, EventArgs e)
        {
            LoadNeuralNetwork();
            showStatBtn.Enabled = false;
            SetRowCount(workDGW, amountTasksNUD);
        }

        private void LoadNeuralNetwork()
        {
            LoadNetwork();
            loadToCheckBtn.Enabled = true;
        }

        private void LoadNetwork()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "all files(*.ntw)| *.ntw";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                model.LoadNeuralNetworkFromFile(openFileDialog.FileName);
                inputsAmount.Value = model.Inputs;
                outputsAmount.Value = model.Outputs;
                amountTasksNUD.Value = 1;
                RefreshDGW(workDGW, true);
            }
        }

        private void saveToFileBtn_Click(object sender, EventArgs e)
        {
            SaveNeuralNetwork();
        }

        private void SaveNeuralNetwork()
        {
            if (model.IsNeuralNetworkExists)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "all files(*.ntw)| *.ntw";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    model.SaveNeuralNetwork(saveFileDialog.FileName);
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            List<double[]> data;
            int inputs;
            int outputs;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "all files(*.trdt)| *.trdt";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                data = model.LoadTrainData(openFileDialog.FileName, out inputs, out outputs);
                inputsAmount.Value = inputs;
                outputsAmount.Value = outputs;
                trainingsAmount.Value = data.Count;
                for (int i = 0; i < trainingDataDGW.Rows.Count; i++)
                {
                    for (int j = 0; j < trainingDataDGW.Columns.Count; j++)
                    {
                        trainingDataDGW.Rows[i].Cells[j].Value = data[i][j];
                    }
                }
            }
        }

        private void saveTrainingDataBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1}\n", inputsAmount.Value, outputsAmount.Value));
            for(int i = 0; i < trainingDataDGW.Rows.Count; i++)
            {
                for(int j = 0; j < trainingDataDGW.Columns.Count; j++)
                {
                    string value = trainingDataDGW.Rows[i].Cells[j].Value.ToString().Replace(".", ",");
                    sb.Append(string.Format("{0} ", Convert.ToDouble(value)));
                }

                sb.Append("\n");
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "all files(*.trdt)| *.trdt";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                model.SaveTrainData(saveFileDialog.FileName, sb.ToString());
            }        
        }

        private void amountTasksNUD_ValueChanged(object sender, EventArgs e)
        {
            SetRowCount(workDGW, amountTasksNUD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateSolutionBtn_Click(object sender, EventArgs e)
        {
            resultTB.Text = string.Empty;
            for(int i = 0; i < workDGW.RowCount; i++)
            {
                double[] vector = new double[model.Inputs];
                for (int j = 0; j < vector.Length; j++)
                {
                    string value = workDGW.Rows[i].Cells[j].Value.ToString();
                    if (value == null || !double.TryParse(value, out double number))
                    {
                        return;
                    }
                    vector[j] = number;
                }
               
                model.NeuralNetwork.Traverse(vector);
                double[] solution = model.NeuralNetwork.Solution;

                for(int j = model.Inputs; j <model.Inputs + model.Outputs; j++)
                {
                    workDGW.Rows[i].Cells[j].Value = solution[j-model.Inputs];
                }

                var arr = solution.Select(x => x < 0.8 ? 0 : 1).ToArray();
                int result = ProcessResults(arr);
                string text = result == 0 ? string.Format("Отношение {0} находится в 3-ей нормальной форме\n", i + 1) : 
                    string.Format("Отношение {0} нарушает правила {1} нормальной формы\n", i + 1, result);
                if (text.Contains("нарушает"))
                {
                    resultTB.SelectionColor = Color.Red;
                }
                else
                {
                    resultTB.SelectionColor = Color.Green;
                }
                resultTB.AppendText(text);
            }
        }

        private int ProcessResults(int[] solution)
        {
            int form = 0;
            for(int i = 0; i < solution.Length; i++)
            {
                if(solution[i] == 0)
                {
                    form = i + 1;
                    break;
                }
            }

            return form;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNeuralNetwork();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNeuralNetwork();
            showStatBtn.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetRowCount(workDGW, amountTasksNUD);
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = trainingDataDGW.CurrentRow.Index;
            trainingDataDGW.Rows.RemoveAt(index);
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            LoadDataToCheck();
        }

        private void LoadDataToCheck()
        {
            if (inputsAmount.Value == 5)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "text files(*.txt)| *.txt";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    workDGW.RowCount = 0;
                    foreach (string file in openFileDialog.FileNames)
                    {
                        double[] inputs = model.ProcessFile(file);
                        workDGW.Rows.Add();
                        for (int i = 0; i < inputs.Length; i++)
                        {
                            workDGW.Rows[workDGW.RowCount - 1].Cells[i].Value = inputs[i];
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Данная нейронная сеть не расчитана на проверку отношений на принадлежность к нормальным формам");
            }
        }

        private void loadDatatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataToCheck();
        }
    }
}
