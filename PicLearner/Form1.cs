namespace PicLearner
{
    public partial class Form1 : Form
    {
        private List<string> files = new();
        private int listIndex = 0;
        private bool nextQuestion = false;
        private bool isTypingMode = true;
        private int correctAnswers = 0;
        private List<Button> answearButtons = new();
        private int correctlyButtonIndex = -1;

        public Form1()
        {
            InitializeComponent();
            answearButtons.Add(answ1button);
            answearButtons.Add(answ2button);
            answearButtons.Add(answ3button);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                NextGuessingAction();
            }
        }

        private void NextGuessingAction()
        {
            if (nextQuestion)
            {
                GetNextQuestion();
                textBox1.Text = string.Empty;
            }
            else
            {
                CheckAnswear();
            }

            nextQuestion = !nextQuestion;
        }

        private void CheckAnswear()
        {
            if (IsAnswearCorrect())
            {
                label2.ForeColor = Color.Green;
                label2.Text = textBox1.Text;
                correctAnswers++;
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = FirstCharToUpper(Path.GetFileNameWithoutExtension(files[listIndex]));
            }

            button2.Text = "Dalej";
        }

        private void GetNextQuestion()
        {
            listIndex++;
            if (listIndex > files.Count - 1)
            {
                EndGuessing();
                return;
            }
            pictureBox1.Image.Dispose();
            pictureBox1.Image = Image.FromFile(files[listIndex]);
            button2.Text = "Sprawdz";
            resultLabel.Text = $"{listIndex + 1}/{files.Count}";
        }

        private void EndGuessing()
        {
            listIndex = 0;
            MessageBox.Show($"Koniec. Poprawnych odpowiedzi: {correctAnswers} na {files.Count} pytan.");
            startButton.Text = "Jeszcze raz";
            label2.Text = string.Empty;
            pictureBox1.Image.Dispose();
            button2.Enabled = false;
            correctAnswers = 0;
            return;
        }

        private bool IsAnswearCorrect()
        {
            return textBox1.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                files = Directory.GetFiles(fbd.SelectedPath).ToList();
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ShuffleList();
            pictureBox1.Image = Image.FromFile(files[listIndex]);
            resultLabel.Text = $"{listIndex + 1}/{files.Count}";
            button2.Enabled = true;
            if (!isTypingMode)
            {
                SetAnswearsToButtons();
            }
        }

        private void SetAnswearsToButtons()
        {
            ShuffleButtons();
            answearButtons[0].Text = Path.GetFileNameWithoutExtension(files[listIndex]);
            int newRandomIndex = GetRandomIndexWithout(listIndex, -2);
            answearButtons[1].Text = Path.GetFileNameWithoutExtension(files[newRandomIndex]);
            answearButtons[2].Text = Path.GetFileNameWithoutExtension(files[GetRandomIndexWithout(listIndex, newRandomIndex)]);
        }

        private int GetRandomIndexWithout(int firstIndex, int secondIndex)
        {
            Random random = new();
            int randomed;
            do
            {
                randomed = random.Next(0, files.Count);
            } while (randomed == firstIndex || randomed == secondIndex);

            return randomed;
        }

        private void ShuffleButtons()
        {
            answearButtons = answearButtons.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void ShuffleList()
        {
            files = files.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextGuessingAction();
        }

        public string FirstCharToUpper(string input)
        {
            return string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isTypingMode = true;
            answ1button.Visible = false;
            answ2button.Visible = false;
            answ3button.Visible = false;
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isTypingMode = false;
            answ1button.Visible = true;
            answ2button.Visible = true;
            answ3button.Visible = true;
            textBox1.Visible = false;
            button2.Visible = false;
        }

        private void answ1button_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            answ1button.Enabled = false;
            answ2button.Enabled = false;
            answ3button.Enabled = false;
            if (answ1button.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower()))
            {
                correctAnswers++;
                answ1button.BackColor = Color.Green;
            }
            else
            {
                answ1button.BackColor = Color.Red;
                answearButtons.First(a => a.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower())).BackColor = Color.Green;
            }
        }

        private void answ2button_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            answ1button.Enabled = false;
            answ2button.Enabled = false;
            answ3button.Enabled = false;
            if (answ2button.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower()))
            {
                correctAnswers++;
                answ2button.BackColor = Color.Green;
            }
            else
            {
                answ2button.BackColor = Color.Red;
                answearButtons.First(a => a.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower())).BackColor = Color.Green;

            }
        }

        private void answ3button_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            answ1button.Enabled = false;
            answ2button.Enabled = false;
            answ3button.Enabled = false;
            if (answ3button.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower()))
            {
                correctAnswers++;
                answ3button.BackColor = Color.Green;
            }
            else
            {
                answ3button.BackColor = Color.Red;
                answearButtons.First(a => a.Text.ToLower().Equals(Path.GetFileNameWithoutExtension(files[listIndex]).ToLower())).BackColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            answ1button.Enabled = true;
            answ2button.Enabled = true;
            answ3button.Enabled = true;
            answ1button.BackColor = SystemColors.Control;
            answ2button.BackColor = SystemColors.Control;
            answ3button.BackColor = SystemColors.Control;
            listIndex++;
            if (listIndex > files.Count - 1)
            {
                EndGuessing();
                return;
            }

            SetAnswearsToButtons();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = Image.FromFile(files[listIndex]);
            button2.Text = "Sprawdz";
            resultLabel.Text = $"{listIndex + 1}/{files.Count}";
        }
    }
}