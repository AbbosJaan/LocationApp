namespace winform
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
            this.GetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetByIdButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.PutButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(88, 112);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(161, 64);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(455, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country/Region";
            // 
            // GetByIdButton
            // 
            this.GetByIdButton.Location = new System.Drawing.Point(275, 112);
            this.GetByIdButton.Name = "GetByIdButton";
            this.GetByIdButton.Size = new System.Drawing.Size(161, 64);
            this.GetByIdButton.TabIndex = 4;
            this.GetByIdButton.Text = "GET BY ID";
            this.GetByIdButton.UseVisualStyleBackColor = true;
            this.GetByIdButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(466, 112);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(161, 64);
            this.PostButton.TabIndex = 5;
            this.PostButton.Text = "POST";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // PutButton
            // 
            this.PutButton.Location = new System.Drawing.Point(653, 112);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(161, 64);
            this.PutButton.TabIndex = 6;
            this.PutButton.Text = "PUT";
            this.PutButton.UseVisualStyleBackColor = true;
            this.PutButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1858, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 64);
            this.button5.TabIndex = 7;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "GET";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(553, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 97);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GET BY ID";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(547, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 262);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post";
            this.groupBox2.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(40, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Country Id";
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(40, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Code";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Short title";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(244, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "Post";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Location = new System.Drawing.Point(547, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 262);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Put";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter_1);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(40, 35);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(125, 27);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "Id";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(40, 189);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "Country Id";
            this.textBox7.Visible = false;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(40, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 27);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(40, 105);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Short title";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(244, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 35);
            this.button8.TabIndex = 10;
            this.button8.Text = "Put";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(40, 68);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 27);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "Title";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Location = new System.Drawing.Point(547, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 274);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            this.groupBox4.Visible = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(221, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 1;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(40, 31);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(125, 27);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 732);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.PutButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GetByIdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetButton;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button GetByIdButton;
        private Button PostButton;
        private Button PutButton;
        private Button button5;
        private TextBox textBox2;
        private Label label2;
        private Button button6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button7;
        private TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox6;
        private GroupBox groupBox3;
        private TextBox textBox11;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox9;
        private Button button8;
        private TextBox textBox10;
        private GroupBox groupBox4;
        private Button button9;
        private TextBox textBox12;
    }
}