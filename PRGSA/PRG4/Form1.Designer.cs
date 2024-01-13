namespace PRG4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDestination = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxTicketPrice = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTicketIdToDelete = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxTicketIdToEdit = new System.Windows.Forms.TextBox();
            this.textBoxUpdatedPassengerName = new System.Windows.Forms.TextBox();
            this.textBoxUpdatedTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxUpdatedDestination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ticket Price";
            // 
            // dateTimePickerDestination
            // 
            this.dateTimePickerDestination.Location = new System.Drawing.Point(40, 136);
            this.dateTimePickerDestination.Name = "dateTimePickerDestination";
            this.dateTimePickerDestination.Size = new System.Drawing.Size(347, 22);
            this.dateTimePickerDestination.TabIndex = 3;
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.Location = new System.Drawing.Point(216, 6);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(171, 22);
            this.textBoxPassengerName.TabIndex = 4;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(216, 46);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(171, 22);
            this.textBoxDestination.TabIndex = 5;
            // 
            // textBoxTicketPrice
            // 
            this.textBoxTicketPrice.Location = new System.Drawing.Point(216, 79);
            this.textBoxTicketPrice.Name = "textBoxTicketPrice";
            this.textBoxTicketPrice.Size = new System.Drawing.Size(171, 22);
            this.textBoxTicketPrice.TabIndex = 6;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(414, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(815, 384);
            this.dataGrid.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTicketIdToDelete
            // 
            this.textBoxTicketIdToDelete.Location = new System.Drawing.Point(216, 240);
            this.textBoxTicketIdToDelete.Name = "textBoxTicketIdToDelete";
            this.textBoxTicketIdToDelete.Size = new System.Drawing.Size(171, 22);
            this.textBoxTicketIdToDelete.TabIndex = 11;
            this.textBoxTicketIdToDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(347, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Edit ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxTicketIdToEdit
            // 
            this.textBoxTicketIdToEdit.Location = new System.Drawing.Point(40, 324);
            this.textBoxTicketIdToEdit.Name = "textBoxTicketIdToEdit";
            this.textBoxTicketIdToEdit.Size = new System.Drawing.Size(149, 22);
            this.textBoxTicketIdToEdit.TabIndex = 13;
            // 
            // textBoxUpdatedPassengerName
            // 
            this.textBoxUpdatedPassengerName.Location = new System.Drawing.Point(216, 323);
            this.textBoxUpdatedPassengerName.Name = "textBoxUpdatedPassengerName";
            this.textBoxUpdatedPassengerName.Size = new System.Drawing.Size(171, 22);
            this.textBoxUpdatedPassengerName.TabIndex = 14;
            // 
            // textBoxUpdatedTicketPrice
            // 
            this.textBoxUpdatedTicketPrice.Location = new System.Drawing.Point(216, 368);
            this.textBoxUpdatedTicketPrice.Name = "textBoxUpdatedTicketPrice";
            this.textBoxUpdatedTicketPrice.Size = new System.Drawing.Size(171, 22);
            this.textBoxUpdatedTicketPrice.TabIndex = 15;
            // 
            // textBoxUpdatedDestination
            // 
            this.textBoxUpdatedDestination.Location = new System.Drawing.Point(40, 368);
            this.textBoxUpdatedDestination.Name = "textBoxUpdatedDestination";
            this.textBoxUpdatedDestination.Size = new System.Drawing.Size(149, 22);
            this.textBoxUpdatedDestination.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 423);
            this.Controls.Add(this.textBoxUpdatedDestination);
            this.Controls.Add(this.textBoxUpdatedTicketPrice);
            this.Controls.Add(this.textBoxUpdatedPassengerName);
            this.Controls.Add(this.textBoxTicketIdToEdit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxTicketIdToDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBoxTicketPrice);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.dateTimePickerDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestination;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxTicketPrice;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxTicketIdToDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxTicketIdToEdit;
        private System.Windows.Forms.TextBox textBoxUpdatedPassengerName;
        private System.Windows.Forms.TextBox textBoxUpdatedTicketPrice;
        private System.Windows.Forms.TextBox textBoxUpdatedDestination;
    }
}

