namespace BmiCalculatorApp
{
    partial class FormMain
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
            panel1 = new Panel();
            labelHeader = new Label();
            textBoxHeight = new TextBox();
            textBoxMass = new TextBox();
            labelMass = new Label();
            labelHeight = new Label();
            labelResult = new Label();
            labelITM = new Label();
            buttonCalculate = new Button();
            labelStat = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 133);
            panel1.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(31, 48);
            labelHeader.Margin = new Padding(4, 0, 4, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(299, 41);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "ITM KALKULATOR";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(31, 237);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(135, 28);
            textBoxHeight.TabIndex = 2;
            // 
            // textBoxMass
            // 
            textBoxMass.Location = new Point(31, 177);
            textBoxMass.Name = "textBoxMass";
            textBoxMass.Size = new Size(135, 28);
            textBoxMass.TabIndex = 1;
            // 
            // labelMass
            // 
            labelMass.AutoSize = true;
            labelMass.Location = new Point(31, 154);
            labelMass.Name = "labelMass";
            labelMass.Size = new Size(82, 20);
            labelMass.TabIndex = 3;
            labelMass.Text = "Masa (kg)";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(31, 214);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(91, 20);
            labelHeight.TabIndex = 4;
            labelHeight.Text = "Visina (cm)";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.ForeColor = Color.Red;
            labelResult.Location = new Point(201, 154);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 20);
            labelResult.TabIndex = 5;
            labelResult.Text = "ITM";
            // 
            // labelITM
            // 
            labelITM.AutoSize = true;
            labelITM.ForeColor = Color.Red;
            labelITM.Location = new Point(245, 154);
            labelITM.Name = "labelITM";
            labelITM.Size = new Size(49, 20);
            labelITM.TabIndex = 6;
            labelITM.Text = "          ";
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.Green;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.ForeColor = Color.White;
            buttonCalculate.Location = new Point(31, 286);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(135, 31);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Izračunaj";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelStat
            // 
            labelStat.AutoSize = true;
            labelStat.Location = new Point(201, 237);
            labelStat.Name = "labelStat";
            labelStat.Size = new Size(49, 20);
            labelStat.TabIndex = 8;
            labelStat.Text = "          ";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 341);
            Controls.Add(labelStat);
            Controls.Add(buttonCalculate);
            Controls.Add(labelITM);
            Controls.Add(labelResult);
            Controls.Add(labelHeight);
            Controls.Add(labelMass);
            Controls.Add(textBoxMass);
            Controls.Add(textBoxHeight);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "BMI Calculator";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelHeader;
        private TextBox textBoxHeight;
        private TextBox textBoxMass;
        private Label labelMass;
        private Label labelHeight;
        private Label labelResult;
        private Label labelITM;
        private Button buttonCalculate;
        private Label labelStat;
    }
}
