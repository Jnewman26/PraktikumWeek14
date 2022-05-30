namespace PraktikumWeek14
{
    partial class Form1
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
            this.buttonLastPrev = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLastNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelDicipline = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLastPrev
            // 
            this.buttonLastPrev.Location = new System.Drawing.Point(53, 38);
            this.buttonLastPrev.Name = "buttonLastPrev";
            this.buttonLastPrev.Size = new System.Drawing.Size(88, 80);
            this.buttonLastPrev.TabIndex = 0;
            this.buttonLastPrev.Text = "<<";
            this.buttonLastPrev.UseVisualStyleBackColor = true;
            this.buttonLastPrev.Click += new System.EventHandler(this.buttonLastPrev_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(169, 38);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(88, 80);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(285, 38);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(88, 80);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLastNext
            // 
            this.buttonLastNext.Location = new System.Drawing.Point(401, 38);
            this.buttonLastNext.Name = "buttonLastNext";
            this.buttonLastNext.Size = new System.Drawing.Size(88, 80);
            this.buttonLastNext.TabIndex = 0;
            this.buttonLastNext.Text = ">>";
            this.buttonLastNext.UseVisualStyleBackColor = true;
            this.buttonLastNext.Click += new System.EventHandler(this.buttonLastNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stadium :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Top Scorer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Worst Discipline :";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(276, 199);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(19, 25);
            this.labelTeamName.TabIndex = 2;
            this.labelTeamName.Text = "-";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(276, 247);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(19, 25);
            this.labelManager.TabIndex = 2;
            this.labelManager.Text = "-";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(276, 296);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(19, 25);
            this.labelStadium.TabIndex = 2;
            this.labelStadium.Text = "-";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(276, 348);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(19, 25);
            this.labelTopScorer.TabIndex = 2;
            this.labelTopScorer.Text = "-";
            // 
            // labelDicipline
            // 
            this.labelDicipline.AutoSize = true;
            this.labelDicipline.Location = new System.Drawing.Point(276, 397);
            this.labelDicipline.Name = "labelDicipline";
            this.labelDicipline.Size = new System.Drawing.Size(19, 25);
            this.labelDicipline.TabIndex = 2;
            this.labelDicipline.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 457);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(715, 411);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 918);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDicipline);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLastNext);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLastPrev);
            this.Name = "Form1";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLastPrev;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLastNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelDicipline;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

