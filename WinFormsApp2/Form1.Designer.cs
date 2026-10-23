namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControlMain = new TabControl();
            tabPageExercise = new TabPage();
            richTextBoxTarget = new RichTextBox();
            textBoxInput = new TextBox();
            panelTop = new Panel();
            buttonStop = new Button();
            buttonStart = new Button();
            textBoxPlayer = new TextBox();
            labelAccuracy = new Label();
            labelSpeed = new Label();
            labelTime = new Label();
            labelPlayer = new Label();
            tabPageResults = new TabPage();
            tabPageSettings = new TabPage();
            timerGame = new System.Windows.Forms.Timer(components);
            tabControlMain.SuspendLayout();
            tabPageExercise.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageExercise);
            tabControlMain.Controls.Add(tabPageResults);
            tabControlMain.Controls.Add(tabPageSettings);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(884, 561);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageExercise
            // 
            tabPageExercise.Controls.Add(richTextBoxTarget);
            tabPageExercise.Controls.Add(textBoxInput);
            tabPageExercise.Controls.Add(panelTop);
            tabPageExercise.Location = new Point(4, 24);
            tabPageExercise.Name = "tabPageExercise";
            tabPageExercise.Padding = new Padding(3);
            tabPageExercise.Size = new Size(876, 533);
            tabPageExercise.TabIndex = 0;
            tabPageExercise.Text = "Упражнение";
            tabPageExercise.UseVisualStyleBackColor = true;
            // 
            // richTextBoxTarget
            // 
            richTextBoxTarget.BackColor = SystemColors.Window;
            richTextBoxTarget.DetectUrls = false;
            richTextBoxTarget.Dock = DockStyle.Fill;
            richTextBoxTarget.Font = new Font("Segoe UI", 16F);
            richTextBoxTarget.ImeMode = ImeMode.AlphaFull;
            richTextBoxTarget.Location = new Point(3, 63);
            richTextBoxTarget.Name = "richTextBoxTarget";
            richTextBoxTarget.ReadOnly = true;
            richTextBoxTarget.Size = new Size(870, 367);
            richTextBoxTarget.TabIndex = 7;
            richTextBoxTarget.TabStop = false;
            richTextBoxTarget.Text = "";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Bottom;
            textBoxInput.Font = new Font("Segoe UI", 14F);
            textBoxInput.Location = new Point(3, 430);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(870, 100);
            textBoxInput.TabIndex = 6;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.KeyPress += textBoxInput_KeyPress;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonStop);
            panelTop.Controls.Add(buttonStart);
            panelTop.Controls.Add(textBoxPlayer);
            panelTop.Controls.Add(labelAccuracy);
            panelTop.Controls.Add(labelSpeed);
            panelTop.Controls.Add(labelTime);
            panelTop.Controls.Add(labelPlayer);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(3, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(870, 60);
            panelTop.TabIndex = 0;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(322, 16);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Стоп";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(220, 15);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button_StartClick;
            // 
            // textBoxPlayer
            // 
            textBoxPlayer.Location = new Point(55, 17);
            textBoxPlayer.Name = "textBoxPlayer";
            textBoxPlayer.Size = new Size(150, 23);
            textBoxPlayer.TabIndex = 4;
            // 
            // labelAccuracy
            // 
            labelAccuracy.AutoSize = true;
            labelAccuracy.Location = new Point(743, 23);
            labelAccuracy.Name = "labelAccuracy";
            labelAccuracy.Size = new Size(78, 15);
            labelAccuracy.TabIndex = 3;
            labelAccuracy.Text = "Точност: 0 %";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(573, 23);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(124, 15);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорост: 0 думи/мин";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(443, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(75, 15);
            labelTime.TabIndex = 1;
            labelTime.Text = "Време: 0 сек";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Location = new Point(10, 20);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(31, 15);
            labelPlayer.TabIndex = 0;
            labelPlayer.Text = "Име";
            // 
            // tabPageResults
            // 
            tabPageResults.Location = new Point(4, 24);
            tabPageResults.Name = "tabPageResults";
            tabPageResults.Padding = new Padding(3);
            tabPageResults.Size = new Size(876, 533);
            tabPageResults.TabIndex = 1;
            tabPageResults.Text = "Резултати";
            tabPageResults.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Size = new Size(876, 533);
            tabPageSettings.TabIndex = 2;
            tabPageSettings.Text = "Настройки";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            timerGame.Tick += timerGame_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControlMain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тренежор за бързо писане";
            tabControlMain.ResumeLayout(false);
            tabPageExercise.ResumeLayout(false);
            tabPageExercise.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageExercise;
        private TabPage tabPageResults;
        private TabPage tabPageSettings;
        private Panel panelTop;
        private Button buttonStart;
        private TextBox textBoxPlayer;
        private Label labelAccuracy;
        private Label labelSpeed;
        private Label labelTime;
        private Label labelPlayer;
        private RichTextBox richTextBoxTarget;
        private TextBox textBoxInput;
        private System.Windows.Forms.Timer timerGame;
        private Button buttonStop;
    }
}
