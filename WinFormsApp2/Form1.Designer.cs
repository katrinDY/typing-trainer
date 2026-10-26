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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            listViewResults = new ListView();
            imageListLarge = new ImageList(components);
            imageListSmall = new ImageList(components);
            groupBoxView = new GroupBox();
            buttonClearResults = new Button();
            radioButtonList = new RadioButton();
            radioButtonLargeIcon = new RadioButton();
            radioButtonDetails = new RadioButton();
            tabPageSettings = new TabPage();
            labelTexts = new Label();
            listBoxTexts = new ListBox();
            labelCategories = new Label();
            checkedListBoxCategories = new CheckedListBox();
            groupBoxOptions = new GroupBox();
            checkBoxShowErrors = new RadioButton();
            checkBoxCaseSensitive = new RadioButton();
            groupBoxLevel = new GroupBox();
            radioButtonHard = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonEasy = new RadioButton();
            timerGame = new System.Windows.Forms.Timer(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            tabControlMain.SuspendLayout();
            tabPageExercise.SuspendLayout();
            panelTop.SuspendLayout();
            tabPageResults.SuspendLayout();
            groupBoxView.SuspendLayout();
            tabPageSettings.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            groupBoxLevel.SuspendLayout();
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
            textBoxInput.ShortcutsEnabled = false;
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
            buttonStart.Click += buttonStart_Click;
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
            labelAccuracy.Location = new Point(741, 19);
            labelAccuracy.Name = "labelAccuracy";
            labelAccuracy.Size = new Size(78, 15);
            labelAccuracy.TabIndex = 3;
            labelAccuracy.Text = "Точност: 0 %";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(571, 19);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(124, 15);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорост: 0 думи/мин";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(441, 19);
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
            tabPageResults.Controls.Add(listViewResults);
            tabPageResults.Controls.Add(groupBoxView);
            tabPageResults.Location = new Point(4, 24);
            tabPageResults.Name = "tabPageResults";
            tabPageResults.Padding = new Padding(3);
            tabPageResults.Size = new Size(876, 533);
            tabPageResults.TabIndex = 1;
            tabPageResults.Text = "Резултати";
            tabPageResults.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            listViewResults.Dock = DockStyle.Fill;
            listViewResults.FullRowSelect = true;
            listViewResults.GridLines = true;
            listViewResults.LargeImageList = imageListLarge;
            listViewResults.Location = new Point(3, 3);
            listViewResults.MultiSelect = false;
            listViewResults.Name = "listViewResults";
            listViewResults.Size = new Size(690, 527);
            listViewResults.SmallImageList = imageListSmall;
            listViewResults.TabIndex = 4;
            listViewResults.UseCompatibleStateImageBehavior = false;
            listViewResults.View = View.Details;
            // 
            // imageListLarge
            // 
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListLarge.ImageStream");
            imageListLarge.TransparentColor = Color.Transparent;
            imageListLarge.Images.SetKeyName(0, "0_gold_32.png");
            imageListLarge.Images.SetKeyName(1, "1_silver_32.png");
            imageListLarge.Images.SetKeyName(2, "2_bronze_32.png");
            imageListLarge.Images.SetKeyName(3, "3_plain_32.png");
            // 
            // imageListSmall
            // 
            imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imageListSmall.ImageStream");
            imageListSmall.TransparentColor = Color.Transparent;
            imageListSmall.Images.SetKeyName(0, "0_gold_16.png");
            imageListSmall.Images.SetKeyName(1, "1_silver_16.png");
            imageListSmall.Images.SetKeyName(2, "2_bronze_16.png");
            imageListSmall.Images.SetKeyName(3, "3_plain_16.png");
            // 
            // groupBoxView
            // 
            groupBoxView.Controls.Add(buttonClearResults);
            groupBoxView.Controls.Add(radioButtonList);
            groupBoxView.Controls.Add(radioButtonLargeIcon);
            groupBoxView.Controls.Add(radioButtonDetails);
            groupBoxView.Dock = DockStyle.Right;
            groupBoxView.Location = new Point(693, 3);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(180, 527);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "Изглед";
            // 
            // buttonClearResults
            // 
            buttonClearResults.Location = new Point(6, 110);
            buttonClearResults.Name = "buttonClearResults";
            buttonClearResults.Size = new Size(168, 23);
            buttonClearResults.TabIndex = 3;
            buttonClearResults.Text = "Изчисти класацията";
            buttonClearResults.UseVisualStyleBackColor = true;
            buttonClearResults.Click += buttonClearResults_Click;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(6, 72);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(66, 19);
            radioButtonList.TabIndex = 2;
            radioButtonList.Text = "Списък";
            radioButtonList.UseVisualStyleBackColor = true;
            radioButtonList.CheckedChanged += radioButtonView_CheckedChanged;
            // 
            // radioButtonLargeIcon
            // 
            radioButtonLargeIcon.AutoSize = true;
            radioButtonLargeIcon.Location = new Point(6, 47);
            radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            radioButtonLargeIcon.Size = new Size(104, 19);
            radioButtonLargeIcon.TabIndex = 1;
            radioButtonLargeIcon.Text = "Големи икони";
            radioButtonLargeIcon.UseVisualStyleBackColor = true;
            radioButtonLargeIcon.CheckedChanged += radioButtonView_CheckedChanged;
            // 
            // radioButtonDetails
            // 
            radioButtonDetails.AutoSize = true;
            radioButtonDetails.Checked = true;
            radioButtonDetails.Location = new Point(6, 22);
            radioButtonDetails.Name = "radioButtonDetails";
            radioButtonDetails.Size = new Size(72, 19);
            radioButtonDetails.TabIndex = 0;
            radioButtonDetails.TabStop = true;
            radioButtonDetails.Text = "Таблица";
            radioButtonDetails.UseVisualStyleBackColor = true;
            radioButtonDetails.CheckedChanged += radioButtonView_CheckedChanged;
            // 
            // tabPageSettings
            // 
            tabPageSettings.Controls.Add(labelTexts);
            tabPageSettings.Controls.Add(listBoxTexts);
            tabPageSettings.Controls.Add(labelCategories);
            tabPageSettings.Controls.Add(checkedListBoxCategories);
            tabPageSettings.Controls.Add(groupBoxOptions);
            tabPageSettings.Controls.Add(groupBoxLevel);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Size = new Size(876, 533);
            tabPageSettings.TabIndex = 2;
            tabPageSettings.Text = "Настройки";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // labelTexts
            // 
            labelTexts.AutoSize = true;
            labelTexts.Location = new Point(334, 197);
            labelTexts.Name = "labelTexts";
            labelTexts.Size = new Size(59, 15);
            labelTexts.TabIndex = 5;
            labelTexts.Text = "Текстове:";
            // 
            // listBoxTexts
            // 
            listBoxTexts.FormattingEnabled = true;
            listBoxTexts.HorizontalScrollbar = true;
            listBoxTexts.Location = new Point(334, 231);
            listBoxTexts.Name = "listBoxTexts";
            listBoxTexts.Size = new Size(500, 94);
            listBoxTexts.TabIndex = 7;
            // 
            // labelCategories
            // 
            labelCategories.AutoSize = true;
            labelCategories.Location = new Point(334, 24);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(67, 15);
            labelCategories.TabIndex = 4;
            labelCategories.Text = "Категории:";
            // 
            // checkedListBoxCategories
            // 
            checkedListBoxCategories.CheckOnClick = true;
            checkedListBoxCategories.FormattingEnabled = true;
            checkedListBoxCategories.Location = new Point(334, 53);
            checkedListBoxCategories.Name = "checkedListBoxCategories";
            checkedListBoxCategories.Size = new Size(279, 94);
            checkedListBoxCategories.TabIndex = 6;
            checkedListBoxCategories.ItemCheck += checkedListBoxCategories_ItemCheck;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(checkBoxShowErrors);
            groupBoxOptions.Controls.Add(checkBoxCaseSensitive);
            groupBoxOptions.Location = new Point(35, 225);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new Size(229, 100);
            groupBoxOptions.TabIndex = 3;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Опции";
            // 
            // checkBoxShowErrors
            // 
            checkBoxShowErrors.AutoSize = true;
            checkBoxShowErrors.Location = new Point(6, 57);
            checkBoxShowErrors.Name = "checkBoxShowErrors";
            checkBoxShowErrors.Size = new Size(191, 19);
            checkBoxShowErrors.TabIndex = 3;
            checkBoxShowErrors.Text = "Показвай грешките в червено";
            checkBoxShowErrors.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaseSensitive
            // 
            checkBoxCaseSensitive.AutoSize = true;
            checkBoxCaseSensitive.Checked = true;
            checkBoxCaseSensitive.Location = new Point(6, 22);
            checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
            checkBoxCaseSensitive.Size = new Size(213, 19);
            checkBoxCaseSensitive.TabIndex = 3;
            checkBoxCaseSensitive.TabStop = true;
            checkBoxCaseSensitive.Text = "Различавай главни и малки букви";
            checkBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // groupBoxLevel
            // 
            groupBoxLevel.Controls.Add(radioButtonHard);
            groupBoxLevel.Controls.Add(radioButtonMedium);
            groupBoxLevel.Controls.Add(radioButtonEasy);
            groupBoxLevel.Location = new Point(28, 53);
            groupBoxLevel.Name = "groupBoxLevel";
            groupBoxLevel.Size = new Size(200, 100);
            groupBoxLevel.TabIndex = 0;
            groupBoxLevel.TabStop = false;
            groupBoxLevel.Text = " Ниво";
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Location = new Point(7, 75);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(109, 19);
            radioButtonHard.TabIndex = 2;
            radioButtonHard.Text = "Трудно (30 сек)";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Location = new Point(6, 44);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(110, 19);
            radioButtonMedium.TabIndex = 1;
            radioButtonMedium.Text = "Средно (60 сек)";
            radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Checked = true;
            radioButtonEasy.Location = new Point(6, 19);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(163, 19);
            radioButtonEasy.TabIndex = 0;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Лесно (без ограничение)";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            timerGame.Tick += timerGame_Tick;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageSize = new Size(16, 16);
            imageList3.TransparentColor = Color.Transparent;
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
            tabPageResults.ResumeLayout(false);
            groupBoxView.ResumeLayout(false);
            groupBoxView.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxLevel.ResumeLayout(false);
            groupBoxLevel.PerformLayout();
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
        private GroupBox groupBoxLevel;
        private GroupBox groupBoxOptions;
        private RadioButton checkBoxShowErrors;
        private RadioButton checkBoxCaseSensitive;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonEasy;
        private CheckedListBox checkedListBoxCategories;
        private Label labelTexts;
        private Label labelCategories;
        private ListBox listBoxTexts;
        private ImageList imageListSmall;
        private ImageList imageList2;
        private ImageList imageList3;
        private ImageList imageListLarge;
        private ListView listViewResults;
        private GroupBox groupBoxView;
        private Button buttonClearResults;
        private RadioButton radioButtonList;
        private RadioButton radioButtonLargeIcon;
        private RadioButton radioButtonDetails;
    }
}
