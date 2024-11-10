namespace CalculatorApplication
{
    partial class frmCalculator
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
            cbOperator = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            linkLabel1 = new LinkLabel();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(230, 42);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(65, 28);
            cbOperator.TabIndex = 0;
            cbOperator.SelectedIndexChanged += cbOperator_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 16);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 80);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 120);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Answer:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Location = new Point(178, 9);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(189, 27);
            txtBoxInput1.TabIndex = 4;
            txtBoxInput1.TextChanged += txtBoxInput1_TextChanged;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Location = new Point(178, 80);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(189, 27);
            txtBoxInput2.TabIndex = 5;
            txtBoxInput2.TextChanged += txtBoxInput2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(268, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 6;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(178, 120);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(93, 20);
            lblDisplayTotal.TabIndex = 7;
            lblDisplayTotal.Text = "______________";
            lblDisplayTotal.Click += lblDisplayTotal_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(209, 159);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(118, 29);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 209);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(linkLabel1);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Name = "frmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOperator;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private LinkLabel linkLabel1;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
