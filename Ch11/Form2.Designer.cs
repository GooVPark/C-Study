namespace Ch11
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnHobby = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHobby = new System.Windows.Forms.ComboBox();
            this.lbResultPosition = new System.Windows.Forms.Label();
            this.lbResultHobby = new System.Windows.Forms.Label();
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbResultCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해주는 컨트롤";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(57, 57);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 23);
            this.cbPosition.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ComboBox 컨트롤 연습";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "직급";
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(184, 56);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(75, 23);
            this.btnPosition.TabIndex = 4;
            this.btnPosition.Text = "확인";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnHobby
            // 
            this.btnHobby.Location = new System.Drawing.Point(184, 85);
            this.btnHobby.Name = "btnHobby";
            this.btnHobby.Size = new System.Drawing.Size(75, 23);
            this.btnHobby.TabIndex = 7;
            this.btnHobby.Text = "확인";
            this.btnHobby.UseVisualStyleBackColor = true;
            this.btnHobby.Click += new System.EventHandler(this.btnHobby_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "취미";
            // 
            // cbHobby
            // 
            this.cbHobby.FormattingEnabled = true;
            this.cbHobby.Location = new System.Drawing.Point(57, 86);
            this.cbHobby.Name = "cbHobby";
            this.cbHobby.Size = new System.Drawing.Size(121, 23);
            this.cbHobby.TabIndex = 5;
            // 
            // lbResultPosition
            // 
            this.lbResultPosition.AutoSize = true;
            this.lbResultPosition.Location = new System.Drawing.Point(265, 60);
            this.lbResultPosition.Name = "lbResultPosition";
            this.lbResultPosition.Size = new System.Drawing.Size(0, 15);
            this.lbResultPosition.TabIndex = 8;
            // 
            // lbResultHobby
            // 
            this.lbResultHobby.AutoSize = true;
            this.lbResultHobby.Location = new System.Drawing.Point(265, 89);
            this.lbResultHobby.Name = "lbResultHobby";
            this.lbResultHobby.Size = new System.Drawing.Size(0, 15);
            this.lbResultHobby.TabIndex = 9;
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 15;
            this.lstCountry.Location = new System.Drawing.Point(20, 174);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(120, 94);
            this.lstCountry.TabIndex = 10;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "ListBox 컨트롤 연습";
            // 
            // lbResultCountry
            // 
            this.lbResultCountry.AutoSize = true;
            this.lbResultCountry.Location = new System.Drawing.Point(156, 253);
            this.lbResultCountry.Name = "lbResultCountry";
            this.lbResultCountry.Size = new System.Drawing.Size(31, 15);
            this.lbResultCountry.TabIndex = 12;
            this.lbResultCountry.Text = "결과";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "DataGrdiView 컨트롤 연습";
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(20, 329);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 25;
            this.dgvMember.Size = new System.Drawing.Size(722, 243);
            this.dgvMember.TabIndex = 14;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbResultCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCountry);
            this.Controls.Add(this.lbResultHobby);
            this.Controls.Add(this.lbResultPosition);
            this.Controls.Add(this.btnHobby);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHobby);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbPosition;
        private Label label2;
        private Label label3;
        private Button btnPosition;
        private Button btnHobby;
        private Label label4;
        private ComboBox cbHobby;
        private Label lbResultPosition;
        private Label lbResultHobby;
        private ListBox lstCountry;
        private Label label5;
        private Label lbResultCountry;
        private Label label6;
        private DataGridView dgvMember;
    }
}