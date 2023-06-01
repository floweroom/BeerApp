namespace Beer
{
    partial class ViewSupliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSupliers));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            иННToolStripMenuItem = new ToolStripMenuItem();
            названиеКомпанииToolStripMenuItem = new ToolStripMenuItem();
            договорыToolStripMenuItem = new ToolStripMenuItem();
            добавитьПоставщикаToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            заводыToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            просмотрДоговоровToolStripMenuItem = new ToolStripMenuItem();
            добавитьДоговорToolStripMenuItem = new ToolStripMenuItem();
            товарныеНакладныеToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton4 = new ToolStripDropDownButton();
            добавлениеКонтрагентаToolStripMenuItem = new ToolStripMenuItem();
            договорыToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripDropDownButton3, toolStripDropDownButton4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { иННToolStripMenuItem, названиеКомпанииToolStripMenuItem, договорыToolStripMenuItem, добавитьПоставщикаToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(109, 24);
            toolStripDropDownButton1.Text = "Поставщики";
            // 
            // иННToolStripMenuItem
            // 
            иННToolStripMenuItem.Name = "иННToolStripMenuItem";
            иННToolStripMenuItem.Size = new Size(246, 26);
            иННToolStripMenuItem.Text = "ИНН";
            // 
            // названиеКомпанииToolStripMenuItem
            // 
            названиеКомпанииToolStripMenuItem.Name = "названиеКомпанииToolStripMenuItem";
            названиеКомпанииToolStripMenuItem.Size = new Size(246, 26);
            названиеКомпанииToolStripMenuItem.Text = "Название компании";
            // 
            // договорыToolStripMenuItem
            // 
            договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            договорыToolStripMenuItem.Size = new Size(246, 26);
            договорыToolStripMenuItem.Text = "Договоры";
            договорыToolStripMenuItem.Click += договорыToolStripMenuItem_Click;
            // 
            // добавитьПоставщикаToolStripMenuItem
            // 
            добавитьПоставщикаToolStripMenuItem.Name = "добавитьПоставщикаToolStripMenuItem";
            добавитьПоставщикаToolStripMenuItem.Size = new Size(246, 26);
            добавитьПоставщикаToolStripMenuItem.Text = "Добавить поставщика";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { заводыToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(75, 24);
            toolStripDropDownButton2.Text = "Заводы";
            // 
            // заводыToolStripMenuItem
            // 
            заводыToolStripMenuItem.Name = "заводыToolStripMenuItem";
            заводыToolStripMenuItem.Size = new Size(203, 26);
            заводыToolStripMenuItem.Text = "Добавить завод";
            заводыToolStripMenuItem.Click += заводыToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { просмотрДоговоровToolStripMenuItem, добавитьДоговорToolStripMenuItem, товарныеНакладныеToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(101, 24);
            toolStripDropDownButton3.Text = "Документы";
            // 
            // просмотрДоговоровToolStripMenuItem
            // 
            просмотрДоговоровToolStripMenuItem.Name = "просмотрДоговоровToolStripMenuItem";
            просмотрДоговоровToolStripMenuItem.Size = new Size(242, 26);
            просмотрДоговоровToolStripMenuItem.Text = "Просмотр договоров";
            // 
            // добавитьДоговорToolStripMenuItem
            // 
            добавитьДоговорToolStripMenuItem.Name = "добавитьДоговорToolStripMenuItem";
            добавитьДоговорToolStripMenuItem.Size = new Size(242, 26);
            добавитьДоговорToolStripMenuItem.Text = "Акты";
            // 
            // товарныеНакладныеToolStripMenuItem
            // 
            товарныеНакладныеToolStripMenuItem.Name = "товарныеНакладныеToolStripMenuItem";
            товарныеНакладныеToolStripMenuItem.Size = new Size(242, 26);
            товарныеНакладныеToolStripMenuItem.Text = "Товарные накладные";
            // 
            // toolStripDropDownButton4
            // 
            toolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton4.DropDownItems.AddRange(new ToolStripItem[] { добавлениеКонтрагентаToolStripMenuItem, договорыToolStripMenuItem1 });
            toolStripDropDownButton4.Image = (Image)resources.GetObject("toolStripDropDownButton4.Image");
            toolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            toolStripDropDownButton4.Size = new Size(113, 24);
            toolStripDropDownButton4.Text = "Контрагенты";
            // 
            // добавлениеКонтрагентаToolStripMenuItem
            // 
            добавлениеКонтрагентаToolStripMenuItem.Name = "добавлениеКонтрагентаToolStripMenuItem";
            добавлениеКонтрагентаToolStripMenuItem.Size = new Size(267, 26);
            добавлениеКонтрагентаToolStripMenuItem.Text = "Добавление контрагента";
            // 
            // договорыToolStripMenuItem1
            // 
            договорыToolStripMenuItem1.Name = "договорыToolStripMenuItem1";
            договорыToolStripMenuItem1.Size = new Size(267, 26);
            договорыToolStripMenuItem1.Text = "Договоры";
            // 
            // ViewSupliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "ViewSupliers";
            Text = "ViewSupliers";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem иННToolStripMenuItem;
        private ToolStripMenuItem названиеКомпанииToolStripMenuItem;
        private ToolStripMenuItem договорыToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem заводыToolStripMenuItem;
        private ToolStripMenuItem добавитьПоставщикаToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem просмотрДоговоровToolStripMenuItem;
        private ToolStripMenuItem добавитьДоговорToolStripMenuItem;
        private ToolStripMenuItem товарныеНакладныеToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton4;
        private ToolStripMenuItem добавлениеКонтрагентаToolStripMenuItem;
        private ToolStripMenuItem договорыToolStripMenuItem1;
    }
}