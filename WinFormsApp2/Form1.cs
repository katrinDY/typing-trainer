namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string[] texts =
        {
            "Който рано рани, две сърца носи.",
            "Капка по капка вир става.",
            "Бързата работа срам за майстора.",
            "Каквото посееш, това ще пожънеш.",
            "Не казвай хоп, преди да си прескочил."
        };

        private string targetText = "";
        private Random random = new Random();

        private int seconds = 0;
        private bool started = false;
        private int timeLimit = 0;

        public Form1()
        {
            InitializeComponent();
            textBoxInput.Enabled = false;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            ColorText();
            UpdateStats();

            if (started && textBoxInput.Text.Length == targetText.Length)
            {
                MessageBox.Show("Готово!");
            }
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                return;
            }

            if (!started && !textBoxInput.ReadOnly)
            {
                started = true;
                timerGame.Start();
            }
        }

        private void ColorText()
        {
            string typed = textBoxInput.Text;

            richTextBoxTarget.SelectAll();
            richTextBoxTarget.SelectionColor = Color.Black;
            richTextBoxTarget.SelectionBackColor = Color.White;

            for (int i = 0; i < typed.Length && i < targetText.Length; i++)
            {
                richTextBoxTarget.Select(i, 1);
                if (typed[i] == targetText[i])
                {
                    richTextBoxTarget.SelectionColor = Color.Green;
                }
                else
                {
                    richTextBoxTarget.SelectionColor = Color.Red;
                    richTextBoxTarget.SelectionBackColor = Color.MistyRose;
                }
            }

            if (typed.Length < targetText.Length)
            {
                richTextBoxTarget.Select(typed.Length, 1);
                richTextBoxTarget.SelectionBackColor = Color.LightYellow;
            }

            richTextBoxTarget.Select(0, 0);
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateStats();

            if (timeLimit > 0 && seconds >= timeLimit)
            {
                EndGame("Времето изтеюе!");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (started)
            {
                EndGame("Опитът е прекъснат.");
            }
        }

        private void button_StartClick(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Моля, въведете име.");
                textBoxPlayer.Focus();
                return;
            }

            timerGame.Stop();
            seconds = 0;
            started = false;

            targetText = texts[random.Next(texts.Length)];
            richTextBoxTarget.Text = targetText;

            textBoxInput.Clear();
            textBoxInput.MaxLength = targetText.Length;
            textBoxInput.ReadOnly = false;
            textBoxInput.Enabled = true;

            ColorText();
            UpdateStats();
            textBoxInput.Focus();
        }

        private int CountCorrect()
        {
            string typed = textBoxInput.Text;
            int correct = 0;
            for (int i = 0; i < typed.Length && i < targetText.Length; i++)
            {
                if (typed[i] == targetText[i])
                {
                    correct++;
                }
            }
            return correct;
        }

        private double CalculateSpeed()
        {
            if (seconds == 0) return 0;
            return (CountCorrect() / 5.0) / (seconds / 60.0);
        }

        private double CalculateAccuracy()
        {
            int typedLength = textBoxInput.Text.Length;
            if (typedLength == 0) return 0;
            return CountCorrect() * 100.0 / typedLength;
        }

        private void UpdateStats()
        {
            labelTime.Text = "Време: " + seconds + " сек";
            labelSpeed.Text = "Скорост: " + CalculateSpeed().ToString("0") + " думи/мин";
            labelAccuracy.Text = "Точност: " + CalculateAccuracy().ToString("0") + " %";
        }

        private void EndGame(string message)
        {
            timerGame.Stop();
            started = false;
            textBoxInput.ReadOnly = true;
            UpdateStats();

            MessageBox.Show(message + Environment.NewLine +
                "Време: " + seconds + " сек" + Environment.NewLine +
                "Скорост: " + CalculateSpeed().ToString("0") + " думи/мин" + Environment.NewLine +
                "Точност: " + CalculateAccuracy().ToString("0") + " %",
                "Резултат");
        }
    }
}
