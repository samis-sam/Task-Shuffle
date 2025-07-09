namespace TodoNotes
{
    partial class MainMenu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            deckListLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            newDeckButton = new Button();
            deleteDeckButton = new Button();
            viewDeckButton = new Button();
            drawHandButton = new Button();
            deckList = new DataGridView();
            deckName = new DataGridViewTextBoxColumn();
            deckCount = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deckList).BeginInit();
            SuspendLayout();
            // 
            // deckListLabel
            // 
            deckListLabel.AutoSize = true;
            deckListLabel.Location = new Point(12, 40);
            deckListLabel.Name = "deckListLabel";
            deckListLabel.Size = new Size(97, 41);
            deckListLabel.TabIndex = 1;
            deckListLabel.Text = "Decks";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(125, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(125, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // newDeckButton
            // 
            newDeckButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newDeckButton.Location = new Point(239, 84);
            newDeckButton.Name = "newDeckButton";
            newDeckButton.Size = new Size(144, 48);
            newDeckButton.TabIndex = 4;
            newDeckButton.Text = "New Deck";
            newDeckButton.UseVisualStyleBackColor = true;
            newDeckButton.Click += NewDeckButton_Click;
            // 
            // deleteDeckButton
            // 
            deleteDeckButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteDeckButton.Location = new Point(239, 138);
            deleteDeckButton.Name = "deleteDeckButton";
            deleteDeckButton.Size = new Size(144, 48);
            deleteDeckButton.TabIndex = 4;
            deleteDeckButton.Text = "Delete Deck";
            deleteDeckButton.UseVisualStyleBackColor = true;
            deleteDeckButton.Click += DeleteDeckButton_Click;
            // 
            // viewDeckButton
            // 
            viewDeckButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewDeckButton.Location = new Point(239, 192);
            viewDeckButton.Name = "viewDeckButton";
            viewDeckButton.Size = new Size(144, 48);
            viewDeckButton.TabIndex = 4;
            viewDeckButton.Text = "Deck Editor";
            viewDeckButton.UseVisualStyleBackColor = true;
            viewDeckButton.Click += ViewDeckButton_Click;
            // 
            // drawHandButton
            // 
            drawHandButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drawHandButton.Location = new Point(239, 246);
            drawHandButton.Name = "drawHandButton";
            drawHandButton.Size = new Size(144, 48);
            drawHandButton.TabIndex = 4;
            drawHandButton.Text = "Draw Hand";
            drawHandButton.UseVisualStyleBackColor = true;
            drawHandButton.Click += DrawHandButton_Click;
            // 
            // deckList
            // 
            deckList.AllowUserToResizeColumns = false;
            deckList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            deckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            deckList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deckList.Columns.AddRange(new DataGridViewColumn[] { deckName, deckCount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            deckList.DefaultCellStyle = dataGridViewCellStyle2;
            deckList.Location = new Point(12, 84);
            deckList.MultiSelect = false;
            deckList.Name = "deckList";
            deckList.ReadOnly = true;
            deckList.RowHeadersVisible = false;
            deckList.RowHeadersWidth = 20;
            deckList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            deckList.Size = new Size(221, 363);
            deckList.TabIndex = 5;
            // 
            // deckName
            // 
            deckName.DataPropertyName = "name";
            deckName.HeaderText = "Deck Name";
            deckName.MinimumWidth = 6;
            deckName.Name = "deckName";
            deckName.ReadOnly = true;
            deckName.Resizable = DataGridViewTriState.True;
            deckName.Width = 125;
            // 
            // deckCount
            // 
            deckCount.DataPropertyName = "Count";
            deckCount.HeaderText = "Cards";
            deckCount.MinimumWidth = 6;
            deckCount.Name = "deckCount";
            deckCount.ReadOnly = true;
            deckCount.Width = 125;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 459);
            Controls.Add(deckList);
            Controls.Add(drawHandButton);
            Controls.Add(viewDeckButton);
            Controls.Add(deleteDeckButton);
            Controls.Add(newDeckButton);
            Controls.Add(deckListLabel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "MainMenu";
            Text = "Todo Decks";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deckList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label deckListLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button newDeckButton;
        private Button deleteDeckButton;
        private Button viewDeckButton;
        private Button drawHandButton;
        private DataGridView deckList;
        private DataGridViewTextBoxColumn deckName;
        private DataGridViewTextBoxColumn deckCount;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
