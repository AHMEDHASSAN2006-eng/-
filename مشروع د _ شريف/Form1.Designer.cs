namespace مشروع_دكتور_شريف
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEquations;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Panel matrixPanel;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.RichTextBox stepsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numEquations = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.matrixPanel = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.stepsTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEquations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(408, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد المعادلات:";
            // 
            // numEquations
            // 
            this.numEquations.Location = new System.Drawing.Point(292, 25);
            this.numEquations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numEquations.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEquations.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEquations.Name = "numEquations";
            this.numEquations.Size = new System.Drawing.Size(93, 24);
            this.numEquations.TabIndex = 1;
            this.numEquations.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerateMatrix.ForeColor = System.Drawing.Color.White;
            this.btnGenerateMatrix.Location = new System.Drawing.Point(134, 25);
            this.btnGenerateMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(140, 37);
            this.btnGenerateMatrix.TabIndex = 2;
            this.btnGenerateMatrix.Text = "إنشاء مصفوفة المعادلات";
            this.btnGenerateMatrix.UseVisualStyleBackColor = false;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            // 
            // matrixPanel
            // 
            this.matrixPanel.AutoScroll = true;
            this.matrixPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixPanel.Location = new System.Drawing.Point(23, 74);
            this.matrixPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(525, 246);
            this.matrixPanel.TabIndex = 3;
            this.matrixPanel.Visible = false;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(23, 332);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(525, 43);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "حل المعادلات";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Visible = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.stepsTextBox.Location = new System.Drawing.Point(23, 418);
            this.stepsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stepsTextBox.Size = new System.Drawing.Size(524, 245);
            this.stepsTextBox.TabIndex = 5;
            this.stepsTextBox.Text = "";
            this.stepsTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(210, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "خطوات الحل:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(175, -37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "مشروع دكتور شريف - Gaussian Elimination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 690);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.matrixPanel);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.numEquations);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Gaussian Elimination - دكتور شريف";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEquations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

