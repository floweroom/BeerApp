namespace Beer
{
    partial class Supliers
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
            dataGridView1 = new DataGridView();
            toolStripContainer1 = new ToolStripContainer();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(519, 120);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(button3);
            toolStripContainer1.ContentPanel.Controls.Add(button5);
            toolStripContainer1.ContentPanel.Controls.Add(button4);
            toolStripContainer1.ContentPanel.Controls.Add(button2);
            toolStripContainer1.ContentPanel.Controls.Add(button1);
            toolStripContainer1.ContentPanel.Controls.Add(dataGridView1);
            toolStripContainer1.ContentPanel.Size = new Size(519, 194);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(165, 94);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(519, 219);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // button3
            // 
            button3.Location = new Point(180, 0);
            button3.Name = "button3";
            button3.Size = new Size(144, 29);
            button3.TabIndex = 6;
            button3.Text = "Согласование";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 39);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Подобрать";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(320, 0);
            button4.Name = "button4";
            button4.Size = new Size(118, 29);
            button4.TabIndex = 4;
            button4.Text = "Документы";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(91, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Товары";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Главная";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(91, 37);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 2;
            button6.Text = "Записать";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(215, 37);
            button7.Name = "button7";
            button7.Size = new Size(167, 29);
            button7.TabIndex = 3;
            button7.Text = "Отправить по почте";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(407, 37);
            button8.Name = "button8";
            button8.Size = new Size(182, 29);
            button8.TabIndex = 4;
            button8.Text = "Передать контрагенту";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackColor = Color.Tomato;
            button9.Location = new Point(545, 349);
            button9.Name = "button9";
            button9.Size = new Size(139, 29);
            button9.TabIndex = 5;
            button9.Text = "Согласовать";
            button9.UseVisualStyleBackColor = false;
            // 
            // Supliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(toolStripContainer1);
            Name = "Supliers";
            Text = "Supliers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStripContainer toolStripContainer1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button3;
    }
}