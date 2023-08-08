namespace PicLearner
{
    public partial class Form1 : Form
    {
        private List<string> files = new();
        private int listIndex = 0;
        private bool nextQuestion = false;
        private int correctAnswers = 0;

        public Form1()
        {
            InitializeComponent();
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
                label2.Text = Path.GetFileNameWithoutExtension(files[listIndex]);
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
        }

        private void ShuffleList()
        {
            files = files.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextGuessingAction();
        }
    }
}