namespace TodoNotes
{
    partial class DeckMenu
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
            cardListLabel = new Label();
            newCardButton = new Button();
            deleteCardButton = new Button();
            cardList = new DataGridView();
            deckName = new DataGridViewTextBoxColumn();
            deckCount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)cardList).BeginInit();
            SuspendLayout();
            // 
            // cardListLabel
            // 
            cardListLabel.AutoSize = true;
            cardListLabel.Location = new Point(12, 9);
            cardListLabel.Name = "cardListLabel";
            cardListLabel.Size = new Size(93, 41);
            cardListLabel.TabIndex = 1;
            cardListLabel.Text = "Cards";
            // 
            // newCardButton
            // 
            newCardButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newCardButton.Location = new Point(239, 53);
            newCardButton.Name = "newCardButton";
            newCardButton.Size = new Size(144, 48);
            newCardButton.TabIndex = 4;
            newCardButton.Text = "New Card";
            newCardButton.UseVisualStyleBackColor = true;
            newCardButton.Click += NewCardButton_Click;
            // 
            // deleteCardButton
            // 
            deleteCardButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteCardButton.Location = new Point(239, 107);
            deleteCardButton.Name = "deleteCardButton";
            deleteCardButton.Size = new Size(144, 48);
            deleteCardButton.TabIndex = 4;
            deleteCardButton.Text = "Delete Card";
            deleteCardButton.UseVisualStyleBackColor = true;
            deleteCardButton.Click += DeleteCardButton_Click;
            // 
            // cardList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cardList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardList.Columns.AddRange(new DataGridViewColumn[] { deckName, deckCount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cardList.DefaultCellStyle = dataGridViewCellStyle2;
            cardList.Location = new Point(12, 53);
            cardList.MultiSelect = false;
            cardList.Name = "cardList";
            cardList.ReadOnly = true;
            cardList.RowHeadersVisible = false;
            cardList.RowHeadersWidth = 20;
            cardList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cardList.Size = new Size(221, 363);
            cardList.TabIndex = 5;
            // 
            // deckName
            // 
            deckName.DataPropertyName = "todo";
            deckName.HeaderText = "Todo";
            deckName.MinimumWidth = 6;
            deckName.Name = "deckName";
            deckName.ReadOnly = true;
            deckName.Resizable = DataGridViewTriState.True;
            deckName.Width = 125;
            // 
            // deckCount
            // 
            deckCount.DataPropertyName = "score";
            deckCount.HeaderText = "Priority";
            deckCount.MinimumWidth = 6;
            deckCount.Name = "deckCount";
            deckCount.ReadOnly = true;
            deckCount.Width = 125;
            // 
            // DeckMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 459);
            Controls.Add(cardList);
            Controls.Add(deleteCardButton);
            Controls.Add(newCardButton);
            Controls.Add(cardListLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "DeckMenu";
            Text = "Deck Menu";
            ((System.ComponentModel.ISupportInitialize)cardList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label cardListLabel;
        private Button newCardButton;
        private Button deleteCardButton;
        private DataGridView cardList;
        private DataGridViewTextBoxColumn deckName;
        private DataGridViewTextBoxColumn deckCount;
    }
}
