namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> availableTexts = new List<string>();
        private List<Result> results = new List<Result>();
        private string resultsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "results.txt");
        private string textsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Texts");

        private string targetText = "";
        private Random random = new Random();

        private int seconds = 0;
        private bool started = false;
        private int timeLimit = 0;
        private int matchedChars = 0;
        private int comparedChars = 0;
        private bool textCompleted = false;

        public Form1()
        {
            InitializeComponent();
            textBoxInput.Enabled = false;
            listViewResults.SmallImageList = imageListSmall;
            listViewResults.LargeImageList = imageListLarge;
            LoadCategories();
            CreateResultHeaders();
            LoadResults();
            PaintResults();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxPlayer.Text.Trim().Length == 0)
            {
                MessageBox.Show("Моля, въведете име.");
                textBoxPlayer.Focus();
                return;
            }

            if (availableTexts.Count == 0)
            {
                MessageBox.Show("Изберете поне една категория от таб 'Настройки'.");
                return;
            }

            timerGame.Stop();
            seconds = 0;
            matchedChars = 0;
            comparedChars = 0;
            textCompleted = false;
            started = false;

            if (listBoxTexts.SelectedIndex > 0)
            {
                targetText = listBoxTexts.SelectedItem?.ToString() ?? "";
            }
            else
            {
                targetText = availableTexts[random.Next(availableTexts.Count)];
            }

            timeLimit = GetTimeLimit();
            richTextBoxTarget.Text = targetText;

            textBoxInput.Clear();
            textBoxInput.MaxLength = 32767;
            textBoxInput.ReadOnly = false;
            textBoxInput.Enabled = true;

            ColorText();
            UpdateStats();
            textBoxInput.Focus();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (started)
            {
                EndGame("Опитът е прекъснат.", false);
            }
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxInput.ReadOnly)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                if (started) EndGame("Готово!");
                return;
            }

            if (!started && e.KeyChar != 8)
            {
                started = true;
                timerGame.Start();
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            ColorText();
            UpdateStats();

            if (started && IsFinished())
            {
                EndGame("Готово!");
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateStats();

            if (timeLimit > 0 && seconds >= timeLimit)
            {
                EndGame("Времето изтече!");
            }
        }

        private bool IsFinished()
        {
            return textCompleted;
        }

        private void ColorText()
        {
            if (targetText.Length == 0) return;

            string[] targetWords = targetText.Split(' ');
            string typed = textBoxInput.Text;
            string[] typedWords = typed.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int finishedWords = (typed.Length == 0 || typed.EndsWith(" ")) ? typedWords.Length : typedWords.Length - 1;

            int[] map = AlignWords(typedWords, targetWords);
            bool[] usedTyped = new bool[typedWords.Length];

            int lastTypedTarget = -1;
            for (int j = 0; j < map.Length; j++)
            {
                if (map[j] >= 0)
                {
                    lastTypedTarget = j;
                    usedTyped[map[j]] = true;
                }
            }

            matchedChars = 0;
            comparedChars = 0;

            richTextBoxTarget.SelectAll();
            richTextBoxTarget.SelectionColor = Color.Black;
            richTextBoxTarget.SelectionBackColor = Color.White;

            int start = 0;
            for (int w = 0; w < targetWords.Length; w++)
            {
                string expected = targetWords[w];

                if (map[w] >= 0)
                {
                    string written = typedWords[map[w]];
                    bool finished = map[w] < finishedWords;
                    bool[] matched = MatchLetters(written, expected);
                    int lastMatched = Array.LastIndexOf(matched, true);

                    for (int j = 0; j < expected.Length; j++)
                    {
                        richTextBoxTarget.Select(start + j, 1);

                        if (matched[j])
                        {
                            richTextBoxTarget.SelectionColor = Color.Green;
                            matchedChars++;
                        }
                        else if (finished || j < written.Length || j < lastMatched)
                        {
                            MarkError();
                        }
                        else
                        {
                            richTextBoxTarget.SelectionBackColor = Color.LightYellow;
                        }
                    }

                    comparedChars += finished ? Math.Max(written.Length, expected.Length) : written.Length;
                }
                else if (w < lastTypedTarget)
                {
                    richTextBoxTarget.Select(start, expected.Length);
                    MarkError();
                    comparedChars += expected.Length;
                }
                else if (w == lastTypedTarget + 1 && finishedWords == typedWords.Length)
                {
                    richTextBoxTarget.Select(start, expected.Length);
                    richTextBoxTarget.SelectionBackColor = Color.LightYellow;
                }

                start += expected.Length + 1;
            }

            for (int i = 0; i < typedWords.Length; i++)
            {
                if (!usedTyped[i])
                {
                    comparedChars += typedWords[i].Length;
                }
            }

            int last = targetWords.Length - 1;
            textCompleted = map[last] >= 0 &&
                (map[last] < finishedWords || typedWords[map[last]].Length >= targetWords[last].Length);

            richTextBoxTarget.Select(0, 0);
        }

        private void MarkError()
        {
            richTextBoxTarget.SelectionColor = Color.Red;
            if (checkBoxShowErrors.Checked)
            {
                richTextBoxTarget.SelectionBackColor = Color.MistyRose;
            }
        }

        private int[] AlignWords(string[] typed, string[] target)
        {
            int n = typed.Length;
            int m = target.Length;

            int[,] sim = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sim[i, j] = MatchLetters(typed[i], target[j]).Count(x => x);

            int[,] score = new int[n + 1, m + 1];
            for (int i = n - 1; i >= 0; i--)
                score[i, m] = score[i + 1, m] - 1;

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    int match = score[i + 1, j + 1] + sim[i, j];
                    int extraWord = score[i + 1, j] - 1;
                    int skippedWord = score[i, j + 1] - 1;
                    score[i, j] = Math.Max(match, Math.Max(extraWord, skippedWord));
                }
            }

            int[] map = new int[m];
            Array.Fill(map, -1);

            int a = 0, b = 0;
            while (a < n && b < m)
            {
                if (score[a, b] == score[a + 1, b + 1] + sim[a, b])
                {
                    map[b] = a;
                    a++;
                    b++;
                }
                else if (score[a, b] == score[a, b + 1] - 1)
                {
                    b++;
                }
                else
                {
                    a++;
                }
            }
            return map;
        }

        private bool[] MatchLetters(string typed, string expected)
        {
            int n = typed.Length;
            int m = expected.Length;

            int[,] dp = new int[n + 1, m + 1];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    if (IsMatch(typed[i], expected[j]))
                        dp[i, j] = dp[i + 1, j + 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }

            bool[] matched = new bool[m];
            int a = 0, b = 0;
            while (a < n && b < m)
            {
                if (IsMatch(typed[a], expected[b]))
                {
                    matched[b] = true;
                    a++;
                    b++;
                }
                else if (dp[a + 1, b] >= dp[a, b + 1])
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            return matched;
        }

        private bool IsMatch(char typed, char expected)
        {
            if (checkBoxCaseSensitive.Checked)
            {
                return typed == expected;
            }
            return char.ToLower(typed) == char.ToLower(expected);
        }

        private double CalculateSpeed()
        {
            if (seconds == 0) return 0;
            return (matchedChars / 5.0) / (seconds / 60.0);
        }

        private double CalculateAccuracy()
        {
            if (comparedChars == 0) return 0;
            return matchedChars * 100.0 / comparedChars;
        }

        private void UpdateStats()
        {
            labelTime.Text = "Време: " + seconds + " сек";
            labelSpeed.Text = "Скорост: " + CalculateSpeed().ToString("0") + " думи/мин";
            labelAccuracy.Text = "Точност: " + CalculateAccuracy().ToString("0") + " %";
        }

        private void EndGame(string message, bool saveResult = true)
        {
            timerGame.Stop();
            started = false;
            textBoxInput.ReadOnly = true;
            UpdateStats();

            if (saveResult && textBoxInput.Text.Length > 0)
            {
                AddResult();
            }

            MessageBox.Show(message + Environment.NewLine +
                "Време: " + seconds + " сек" + Environment.NewLine +
                "Скорост: " + CalculateSpeed().ToString("0") + " думи/мин" + Environment.NewLine +
                "Точност: " + CalculateAccuracy().ToString("0") + " %",
                "Резултат");
        }

        private void LoadCategories()
        {
            checkedListBoxCategories.Items.Clear();

            if (!Directory.Exists(textsFolder))
            {
                MessageBox.Show("Не е намерена папката Texts.");
                return;
            }

            foreach (string file in Directory.GetFiles(textsFolder, "*.txt"))
            {
                checkedListBoxCategories.Items.Add(Path.GetFileNameWithoutExtension(file), true);
            }

            FillTexts(null, CheckState.Unchecked);
        }

        private void FillTexts(int? changedIndex, CheckState newValue)
        {
            availableTexts.Clear();
            listBoxTexts.Items.Clear();
            listBoxTexts.Items.Add("(случаен текст)");

            for (int i = 0; i < checkedListBoxCategories.Items.Count; i++)
            {
                bool isChecked = (i == changedIndex)
                    ? newValue == CheckState.Checked
                    : checkedListBoxCategories.GetItemChecked(i);

                if (!isChecked) continue;

                string file = Path.Combine(textsFolder, checkedListBoxCategories.Items[i] + ".txt");
                foreach (string line in File.ReadAllLines(file))
                {
                    if (line.Trim().Length > 0)
                    {
                        availableTexts.Add(line.Trim());
                        listBoxTexts.Items.Add(line.Trim());
                    }
                }
            }

            listBoxTexts.SelectedIndex = 0;
        }

        private void checkedListBoxCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            FillTexts(e.Index, e.NewValue);
        }

        private int GetTimeLimit()
        {
            if (radioButtonMedium.Checked) return 60;
            if (radioButtonHard.Checked) return 30;
            return 0;
        }

        private string GetLevelName()
        {
            if (radioButtonMedium.Checked) return "Средно";
            if (radioButtonHard.Checked) return "Трудно";
            return "Лесно";
        }

        private void CreateResultHeaders()
        {
            listViewResults.Columns.Add("Играч", 150);
            listViewResults.Columns.Add("Скорост", 130);
            listViewResults.Columns.Add("Точност", 90);
            listViewResults.Columns.Add("Ниво", 110);
            listViewResults.Columns.Add("Дата", 140);
        }

        private void LoadResults()
        {
            results.Clear();
            if (!File.Exists(resultsFile)) return;

            foreach (string line in File.ReadAllLines(resultsFile))
            {
                Result? r = Result.FromLine(line);
                if (r != null)
                {
                    results.Add(r);
                }
            }
        }

        private void SaveResults()
        {
            List<string> lines = new List<string>();
            foreach (Result r in results)
            {
                lines.Add(r.ToLine());
            }
            File.WriteAllLines(resultsFile, lines);
        }

        private void PaintResults()
        {
            List<Result> sorted = results.OrderByDescending(r => r.Speed).ToList();

            listViewResults.BeginUpdate();
            listViewResults.Items.Clear();

            for (int i = 0; i < sorted.Count; i++)
            {
                Result r = sorted[i];
                ListViewItem lvi = new ListViewItem(r.Player);
                lvi.ImageIndex = (i < 3) ? i : 3;
                lvi.SubItems.Add(r.Speed.ToString("0") + " думи/мин");
                lvi.SubItems.Add(r.Accuracy.ToString("0") + " %");
                lvi.SubItems.Add(r.Level);
                lvi.SubItems.Add(r.Date.ToString("dd.MM.yyyy HH:mm"));
                listViewResults.Items.Add(lvi);
            }

            listViewResults.EndUpdate();
        }

        private void AddResult()
        {
            results.Add(new Result
            {
                Player = textBoxPlayer.Text.Trim(),
                Speed = CalculateSpeed(),
                Accuracy = CalculateAccuracy(),
                Level = GetLevelName(),
                Date = DateTime.Now
            });
            SaveResults();
            PaintResults();
        }

        private void radioButtonView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDetails.Checked) listViewResults.View = View.Details;
            else if (radioButtonLargeIcon.Checked) listViewResults.View = View.LargeIcon;
            else if (radioButtonList.Checked) listViewResults.View = View.List;
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Да се изтрият ли всички резултати?", "Потвърждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                results.Clear();
                SaveResults();
                PaintResults();
            }
        }
    }
}