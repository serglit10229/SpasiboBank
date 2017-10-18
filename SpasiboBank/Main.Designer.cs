namespace SpasiboBank
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ARBUZbutton = new System.Windows.Forms.RadioButton();
            this.BobZEHorsebutton = new System.Windows.Forms.RadioButton();
            this.HankZEChmobutton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.Location = new System.Drawing.Point(13, 13);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(35, 13);
            this.Usernamelabel.TabIndex = 0;
            this.Usernamelabel.Text = "label1";
            this.Usernamelabel.Click += new System.EventHandler(this.Usernamelabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Tag = "";
            // 
            // ARBUZbutton
            // 
            this.ARBUZbutton.AutoSize = true;
            this.ARBUZbutton.Location = new System.Drawing.Point(13, 34);
            this.ARBUZbutton.Name = "ARBUZbutton";
            this.ARBUZbutton.Size = new System.Drawing.Size(62, 17);
            this.ARBUZbutton.TabIndex = 5;
            this.ARBUZbutton.TabStop = true;
            this.ARBUZbutton.Text = "ARBUZ";
            this.ARBUZbutton.UseVisualStyleBackColor = true;
            this.ARBUZbutton.CheckedChanged += new System.EventHandler(this.ARBUZbutton_CheckedChanged);
            // 
            // BobZEHorsebutton
            // 
            this.BobZEHorsebutton.AutoSize = true;
            this.BobZEHorsebutton.Location = new System.Drawing.Point(13, 58);
            this.BobZEHorsebutton.Name = "BobZEHorsebutton";
            this.BobZEHorsebutton.Size = new System.Drawing.Size(86, 17);
            this.BobZEHorsebutton.TabIndex = 6;
            this.BobZEHorsebutton.TabStop = true;
            this.BobZEHorsebutton.Text = "BobZEHorse";
            this.BobZEHorsebutton.UseVisualStyleBackColor = true;
            // 
            // HankZEChmobutton
            // 
            this.HankZEChmobutton.AutoSize = true;
            this.HankZEChmobutton.Location = new System.Drawing.Point(13, 82);
            this.HankZEChmobutton.Name = "HankZEChmobutton";
            this.HankZEChmobutton.Size = new System.Drawing.Size(92, 17);
            this.HankZEChmobutton.TabIndex = 7;
            this.HankZEChmobutton.TabStop = true;
            this.HankZEChmobutton.Text = "HankZEChmo";
            this.HankZEChmobutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(182, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(90, 18);
            this.dataGridView1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HankZEChmobutton);
            this.Controls.Add(this.BobZEHorsebutton);
            this.Controls.Add(this.ARBUZbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Usernamelabel);
            this.Name = "Main";
            this.Text = "Maincs";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label Usernamelabel;
        public System.Windows.Forms.RadioButton ARBUZbutton;
        public System.Windows.Forms.RadioButton BobZEHorsebutton;
        public System.Windows.Forms.RadioButton HankZEChmobutton;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}