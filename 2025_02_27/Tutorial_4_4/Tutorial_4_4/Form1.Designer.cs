namespace Tutorial_4_4
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
            label1 = new Label();
            label2 = new Label();
            averagelabel3 = new Label();
            distancetextBox1 = new TextBox();
            gastextBox2 = new TextBox();
            averagelabel = new Label();
            button1 = new Button();
            button2 = new Button();
            historylistBox1 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 99);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 156);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "消耗油量公升數";
            // 
            // averagelabel3
            // 
            averagelabel3.AutoSize = true;
            averagelabel3.Location = new Point(67, 225);
            averagelabel3.Name = "averagelabel3";
            averagelabel3.Size = new Size(79, 15);
            averagelabel3.TabIndex = 3;
            averagelabel3.Text = "您的平均油耗";
            // 
            // distancetextBox1
            // 
            distancetextBox1.Location = new Point(316, 99);
            distancetextBox1.Name = "distancetextBox1";
            distancetextBox1.Size = new Size(100, 23);
            distancetextBox1.TabIndex = 4;
            // 
            // gastextBox2
            // 
            gastextBox2.Location = new Point(316, 156);
            gastextBox2.Name = "gastextBox2";
            gastextBox2.Size = new Size(100, 23);
            gastextBox2.TabIndex = 5;
            // 
            // averagelabel
            // 
            averagelabel.BorderStyle = BorderStyle.Fixed3D;
            averagelabel.Location = new Point(316, 225);
            averagelabel.Name = "averagelabel";
            averagelabel.Size = new Size(114, 23);
            averagelabel.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(58, 349);
            button1.Name = "button1";
            button1.Size = new Size(109, 56);
            button1.TabIndex = 7;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(295, 349);
            button2.Name = "button2";
            button2.Size = new Size(105, 56);
            button2.TabIndex = 8;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // historylistBox1
            // 
            historylistBox1.FormattingEnabled = true;
            historylistBox1.ItemHeight = 15;
            historylistBox1.Location = new Point(562, 100);
            historylistBox1.Name = "historylistBox1";
            historylistBox1.Size = new Size(165, 214);
            historylistBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(583, 349);
            button3.Name = "button3";
            button3.Size = new Size(109, 56);
            button3.TabIndex = 10;
            button3.Text = "總平均油耗";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(historylistBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(averagelabel);
            Controls.Add(gastextBox2);
            Controls.Add(distancetextBox1);
            Controls.Add(averagelabel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label averagelabel3;
        private TextBox distancetextBox1;
        private TextBox gastextBox2;
        private Label averagelabel;
        private Button button1;
        private Button button2;
        private ListBox historylistBox1;
        private Button button3;
    }
}
