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
            buttonFormat = new Button();
            checkBoxUpdate = new CheckBox();
            comboBoxSheetName = new ComboBox();
            textBoxFirstRow = new TextBox();
            textBoxLastRow = new TextBox();
            buttonConfig = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
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
            // textBoxFirstRow
            // 
            textBoxFirstRow.Anchor = AnchorStyles.Bottom;
            textBoxFirstRow.Location = new Point(160, 308);
            textBoxFirstRow.MaximumSize = new Size(63, 23);
            textBoxFirstRow.MinimumSize = new Size(63, 23);
            textBoxFirstRow.Name = "textBoxFirstRow";
            textBoxFirstRow.Size = new Size(63, 23);
            textBoxFirstRow.TabIndex = 4;
            textBoxFirstRow.TextChanged += textBoxFirstRow_TextChanged;
            // 
            // textBoxLastRow
            // 
            textBoxLastRow.Anchor = AnchorStyles.Bottom;
            textBoxLastRow.Location = new Point(240, 308);
            textBoxLastRow.MaximumSize = new Size(63, 23);
            textBoxLastRow.MinimumSize = new Size(63, 23);
            textBoxLastRow.Name = "textBoxLastRow";
            textBoxLastRow.Size = new Size(63, 23);
            textBoxLastRow.TabIndex = 5;
            textBoxLastRow.TextChanged += textBoxLastRow_TextChanged;
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
            pictureBox1.Location = new Point(0, 0);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(65, 311);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 10;
            label2.Text = "Első, utolsó sor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(315, 405);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonConfig);
            Controls.Add(textBoxLastRow);
            Controls.Add(textBoxFirstRow);
            Controls.Add(comboBoxSheetName);
            Controls.Add(checkBoxUpdate);
            Controls.Add(buttonFormat);
            MinimumSize = new Size(331, 444);
            Name = "Form1";
            Text = "Formatter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFormat;
        private CheckBox checkBoxUpdate;
        private ComboBox comboBoxSheetName;
        private TextBox textBoxFirstRow;
        private TextBox textBoxLastRow;
        private Button buttonConfig;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
