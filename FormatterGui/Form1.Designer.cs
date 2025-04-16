namespace FormatterGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonFormat = new Button();
            checkBoxUpdate = new CheckBox();
            comboBoxSheetName = new ComboBox();
            buttonConfig = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar = new ProgressBar();
            label4 = new Label();
            textBoxPage = new TextBox();
            Test = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonFormat
            // 
            buttonFormat.Anchor = AnchorStyles.Bottom;
            buttonFormat.BackColor = SystemColors.Control;
            buttonFormat.ForeColor = SystemColors.ControlText;
            buttonFormat.Location = new Point(160, 342);
            buttonFormat.Name = "buttonFormat";
            buttonFormat.Size = new Size(143, 51);
            buttonFormat.TabIndex = 0;
            buttonFormat.Text = "Format";
            buttonFormat.UseVisualStyleBackColor = true;
            buttonFormat.Click += buttonFormat_Click;
            // 
            // checkBoxUpdate
            // 
            checkBoxUpdate.Anchor = AnchorStyles.Bottom;
            checkBoxUpdate.AutoSize = true;
            checkBoxUpdate.Location = new Point(160, 254);
            checkBoxUpdate.Name = "checkBoxUpdate";
            checkBoxUpdate.Size = new Size(117, 19);
            checkBoxUpdate.TabIndex = 2;
            checkBoxUpdate.Text = "Táblázat frissítése";
            checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxSheetName
            // 
            comboBoxSheetName.Anchor = AnchorStyles.Bottom;
            comboBoxSheetName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSheetName.FormattingEnabled = true;
            comboBoxSheetName.Items.AddRange(new object[] { "ital, kávé, tea", "címoldal", "ajándéközön", "Szezon", "imp+édesség", "élelmiszer", "tisztítószer", "higiénia", "háztartási", "hazai édesség", "állateledel" });
            comboBoxSheetName.Location = new Point(160, 279);
            comboBoxSheetName.Name = "comboBoxSheetName";
            comboBoxSheetName.Size = new Size(143, 23);
            comboBoxSheetName.TabIndex = 3;
            comboBoxSheetName.SelectedIndexChanged += comboBoxSheetName_SelectedIndexChanged;
            // 
            // buttonConfig
            // 
            buttonConfig.Anchor = AnchorStyles.Bottom;
            buttonConfig.Location = new Point(11, 342);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(143, 51);
            buttonConfig.TabIndex = 7;
            buttonConfig.Text = "Config";
            buttonConfig.UseVisualStyleBackColor = true;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.NOK;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(17, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(91, 282);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "Munkalap:";
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(11, 209);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(292, 23);
            progressBar.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(116, 311);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "Oldal:";
            // 
            // textBoxPage
            // 
            textBoxPage.Anchor = AnchorStyles.Bottom;
            textBoxPage.Location = new Point(160, 308);
            textBoxPage.MaximumSize = new Size(63, 23);
            textBoxPage.MinimumSize = new Size(63, 23);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(63, 23);
            textBoxPage.TabIndex = 14;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            // 
            // Test
            // 
            Test.Anchor = AnchorStyles.Bottom;
            Test.Location = new Point(229, 308);
            Test.Name = "Test";
            Test.Size = new Size(38, 23);
            Test.TabIndex = 15;
            Test.Text = "Test";
            Test.UseVisualStyleBackColor = true;
            Test.Click += Test_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(273, 305);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 16;
            label5.Text = "els";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(273, 320);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 17;
            label6.Text = "ut";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(315, 405);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Test);
            Controls.Add(textBoxPage);
            Controls.Add(label4);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonConfig);
            Controls.Add(comboBoxSheetName);
            Controls.Add(checkBoxUpdate);
            Controls.Add(buttonFormat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(331, 444);
            Name = "Form1";
            Text = "Formatter: Fat Rat Edition";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFormat;
        private CheckBox checkBoxUpdate;
        public ComboBox comboBoxSheetName;
        private Button buttonConfig;
        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar progressBar;
        private Label label4;
        public TextBox textBoxPage;
        private Button Test;
        public Label label5;
        public Label label6;
    }
}
