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

        public Form1()
        {
            InitializeComponent();
            textBoxInput.Enabled = false;
        }

        private void button_Start(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Моля, въведете име.");
                textBoxPlayer.Focus();
                return;
            }

            targetText = texts[random.Next(texts.Length)];
            richTextBoxTarget.Text = targetText;

            textBoxInput.Clear();
            textBoxInput.MaxLength = targetText.Length;
            textBoxInput.ReadOnly = false;
            textBoxInput.Enabled = true;

            ColorText();
            textBoxInput.Focus();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            ColorText();

            if (targetText.Length > 0 && textBoxInput.Text.Length == targetText.Length)
            {
                textBoxInput.ReadOnly = true;
                MessageBox.Show("Готово!");
            }
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
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
    }
}
