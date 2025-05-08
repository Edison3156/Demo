namespace Demo
{
    partial class Demo
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            lblHelloWorld = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            gbxDateTime = new GroupBox();
            lblDateTime = new Label();
            gbxCountTo10 = new GroupBox();
            lblCount = new Label();
            btnCount = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxDateTime.SuspendLayout();
            gbxCountTo10.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(70, 32);
            button1.TabIndex = 0;
            button1.Text = "Say Hello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblHelloWorld);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 70);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hello World";
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblHelloWorld.Location = new Point(139, 26);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(26, 23);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "l1";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(gbxDateTime);
            groupBox2.Controls.Add(gbxCountTo10);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(3, -5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(795, 457);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // gbxDateTime
            // 
            gbxDateTime.Controls.Add(lblDateTime);
            gbxDateTime.Dock = DockStyle.Fill;
            gbxDateTime.Location = new Point(3, 189);
            gbxDateTime.Name = "gbxDateTime";
            gbxDateTime.Size = new Size(789, 265);
            gbxDateTime.TabIndex = 2;
            gbxDateTime.TabStop = false;
            gbxDateTime.Text = "Date Time";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(17, 45);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(42, 15);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "label1";
            // 
            // gbxCountTo10
            // 
            gbxCountTo10.Controls.Add(lblCount);
            gbxCountTo10.Controls.Add(btnCount);
            gbxCountTo10.Dock = DockStyle.Top;
            gbxCountTo10.Location = new Point(3, 89);
            gbxCountTo10.Name = "gbxCountTo10";
            gbxCountTo10.Size = new Size(789, 100);
            gbxCountTo10.TabIndex = 0;
            gbxCountTo10.TabStop = false;
            gbxCountTo10.Text = "CountTo10";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.Location = new Point(139, 40);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(21, 23);
            lblCount.TabIndex = 1;
            lblCount.Text = "0";
            // 
            // btnCount
            // 
            btnCount.Location = new Point(12, 36);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(70, 32);
            btnCount.TabIndex = 1;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // Demo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(groupBox2);
            Name = "Demo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Utility";
            Load += Demo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            gbxDateTime.ResumeLayout(false);
            gbxDateTime.PerformLayout();
            gbxCountTo10.ResumeLayout(false);
            gbxCountTo10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Label lblHelloWorld;
        private GroupBox gbxDateTime;
        private GroupBox gbxCountTo10;
        private Button btnCount;
        private Label lblCount;
        private Label lblDateTime;
    }
}