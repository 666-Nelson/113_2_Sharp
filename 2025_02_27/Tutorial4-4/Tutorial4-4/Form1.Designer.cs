namespace Tutorial4_4
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
            gas = new Label();
            label3 = new Label();
            distextBox = new TextBox();
            gastextBox = new TextBox();
            averagelabel = new Label();
            calculatebutton = new Button();
            exitbutton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(127, 92);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // gas
            // 
            gas.AutoSize = true;
            gas.Font = new Font("Microsoft JhengHei UI", 18F);
            gas.Location = new Point(127, 162);
            gas.Name = "gas";
            gas.Size = new Size(181, 30);
            gas.TabIndex = 1;
            gas.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(127, 231);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // distextBox
            // 
            distextBox.Font = new Font("Microsoft JhengHei UI", 12F);
            distextBox.Location = new Point(336, 92);
            distextBox.Name = "distextBox";
            distextBox.Size = new Size(163, 28);
            distextBox.TabIndex = 3;
            // 
            // gastextBox
            // 
            gastextBox.Font = new Font("Microsoft JhengHei UI", 12F);
            gastextBox.Location = new Point(336, 162);
            gastextBox.Name = "gastextBox";
            gastextBox.Size = new Size(163, 28);
            gastextBox.TabIndex = 4;
            // 
            // averagelabel
            // 
            averagelabel.BorderStyle = BorderStyle.Fixed3D;
            averagelabel.Location = new Point(336, 237);
            averagelabel.Name = "averagelabel";
            averagelabel.Size = new Size(163, 24);
            averagelabel.TabIndex = 5;
            // 
            // calculatebutton
            // 
            calculatebutton.Font = new Font("Modern No. 20", 9F);
            calculatebutton.Location = new Point(127, 306);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(131, 70);
            calculatebutton.TabIndex = 6;
            calculatebutton.Text = "計算";
            calculatebutton.UseVisualStyleBackColor = true;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Modern No. 20", 9F);
            exitbutton.Location = new Point(336, 306);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(131, 70);
            exitbutton.TabIndex = 7;
            exitbutton.Text = "離開";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(560, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(176, 244);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(exitbutton);
            Controls.Add(calculatebutton);
            Controls.Add(averagelabel);
            Controls.Add(gastextBox);
            Controls.Add(distextBox);
            Controls.Add(label3);
            Controls.Add(gas);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label gas;
        private Label label3;
        private TextBox distextBox;
        private TextBox gastextBox;
        private Label averagelabel;
        private Button calculatebutton;
        private Button exitbutton;
        private ListBox listBox1;
    }
}
