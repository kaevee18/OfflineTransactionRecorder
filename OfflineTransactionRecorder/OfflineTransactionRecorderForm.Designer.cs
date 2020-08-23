namespace WindowsFormsApplication1
{
    partial class OfflineTransactionRecorderForm
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
            this.components = new System.ComponentModel.Container();
            this.input_msg_label = new System.Windows.Forms.Label();
            this.add_sms_button = new System.Windows.Forms.Button();
            this.show_transaction_button = new System.Windows.Forms.Button();
            this.input_sms_textbox = new System.Windows.Forms.RichTextBox();
            this.notifyModelClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaction_grid = new System.Windows.Forms.DataGridView();
            this.accNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDebitStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avlBalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notifyModelClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showdata_notification_label = new System.Windows.Forms.RichTextBox();
            this.add_notification_label = new System.Windows.Forms.RichTextBox();
            this.delete_transaction_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notifyModelClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyModelClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // input_msg_label
            // 
            this.input_msg_label.AutoSize = true;
            this.input_msg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_msg_label.Location = new System.Drawing.Point(33, 86);
            this.input_msg_label.Name = "input_msg_label";
            this.input_msg_label.Size = new System.Drawing.Size(249, 15);
            this.input_msg_label.TabIndex = 1;
            this.input_msg_label.Text = "Add SMS transaction recieved in you mobile.";
            // 
            // add_sms_button
            // 
            this.add_sms_button.Location = new System.Drawing.Point(391, 158);
            this.add_sms_button.Name = "add_sms_button";
            this.add_sms_button.Size = new System.Drawing.Size(75, 23);
            this.add_sms_button.TabIndex = 2;
            this.add_sms_button.Text = "Add";
            this.add_sms_button.UseVisualStyleBackColor = true;
            this.add_sms_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_transaction_button
            // 
            this.show_transaction_button.Location = new System.Drawing.Point(13, 223);
            this.show_transaction_button.Name = "show_transaction_button";
            this.show_transaction_button.Size = new System.Drawing.Size(104, 23);
            this.show_transaction_button.TabIndex = 3;
            this.show_transaction_button.Text = "Show Transactions";
            this.show_transaction_button.UseVisualStyleBackColor = true;
            this.show_transaction_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_sms_textbox
            // 
            this.input_sms_textbox.Location = new System.Drawing.Point(297, 45);
            this.input_sms_textbox.Name = "input_sms_textbox";
            this.input_sms_textbox.Size = new System.Drawing.Size(290, 107);
            this.input_sms_textbox.TabIndex = 4;
            this.input_sms_textbox.Text = "";
            // 
            // transaction_grid
            // 
            this.transaction_grid.AutoGenerateColumns = false;
            this.transaction_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accNoDataGridViewTextBoxColumn,
            this.creditDebitStatusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.avlBalDataGridViewTextBoxColumn});
            this.transaction_grid.DataSource = this.notifyModelClassBindingSource1;
            this.transaction_grid.Location = new System.Drawing.Point(13, 265);
            this.transaction_grid.Name = "transaction_grid";
            this.transaction_grid.ReadOnly = true;
            this.transaction_grid.Size = new System.Drawing.Size(676, 150);
            this.transaction_grid.TabIndex = 5;
            this.transaction_grid.Visible = false;
            // 
            // accNoDataGridViewTextBoxColumn
            // 
            this.accNoDataGridViewTextBoxColumn.DataPropertyName = "AccNo";
            this.accNoDataGridViewTextBoxColumn.HeaderText = "AccNo";
            this.accNoDataGridViewTextBoxColumn.Name = "accNoDataGridViewTextBoxColumn";
            this.accNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditDebitStatusDataGridViewTextBoxColumn
            // 
            this.creditDebitStatusDataGridViewTextBoxColumn.DataPropertyName = "CreditDebitStatus";
            this.creditDebitStatusDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            this.creditDebitStatusDataGridViewTextBoxColumn.Name = "creditDebitStatusDataGridViewTextBoxColumn";
            this.creditDebitStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avlBalDataGridViewTextBoxColumn
            // 
            this.avlBalDataGridViewTextBoxColumn.DataPropertyName = "AvlBal";
            this.avlBalDataGridViewTextBoxColumn.HeaderText = "AvlBal";
            this.avlBalDataGridViewTextBoxColumn.Name = "avlBalDataGridViewTextBoxColumn";
            this.avlBalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notifyModelClassBindingSource1
            // 
            this.notifyModelClassBindingSource1.DataSource = typeof(WindowsFormsApplication1.NotifyModelClass);
            // 
            // showdata_notification_label
            // 
            this.showdata_notification_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showdata_notification_label.Location = new System.Drawing.Point(13, 464);
            this.showdata_notification_label.Name = "showdata_notification_label";
            this.showdata_notification_label.ReadOnly = true;
            this.showdata_notification_label.Size = new System.Drawing.Size(373, 13);
            this.showdata_notification_label.TabIndex = 6;
            this.showdata_notification_label.Text = "";
            this.showdata_notification_label.Visible = false;
            // 
            // add_notification_label
            // 
            this.add_notification_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_notification_label.Location = new System.Drawing.Point(297, 196);
            this.add_notification_label.Name = "add_notification_label";
            this.add_notification_label.ReadOnly = true;
            this.add_notification_label.Size = new System.Drawing.Size(276, 13);
            this.add_notification_label.TabIndex = 7;
            this.add_notification_label.Text = "";
            this.add_notification_label.Visible = false;
            // 
            // delete_transaction_button
            // 
            this.delete_transaction_button.Location = new System.Drawing.Point(159, 223);
            this.delete_transaction_button.Name = "delete_transaction_button";
            this.delete_transaction_button.Size = new System.Drawing.Size(123, 23);
            this.delete_transaction_button.TabIndex = 8;
            this.delete_transaction_button.Text = "Delete Transactions";
            this.delete_transaction_button.UseVisualStyleBackColor = true;
            this.delete_transaction_button.Click += new System.EventHandler(this.delete_transaction_button_Click);
            // 
            // OfflineTransactionRecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 634);
            this.Controls.Add(this.delete_transaction_button);
            this.Controls.Add(this.add_notification_label);
            this.Controls.Add(this.showdata_notification_label);
            this.Controls.Add(this.transaction_grid);
            this.Controls.Add(this.input_sms_textbox);
            this.Controls.Add(this.show_transaction_button);
            this.Controls.Add(this.add_sms_button);
            this.Controls.Add(this.input_msg_label);
            this.Name = "OfflineTransactionRecorderForm";
            this.Text = "Offline Transaction Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.notifyModelClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifyModelClassBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_msg_label;
        private System.Windows.Forms.Button add_sms_button;
        private System.Windows.Forms.Button show_transaction_button;
        private System.Windows.Forms.RichTextBox input_sms_textbox;
        private System.Windows.Forms.BindingSource notifyModelClassBindingSource;
        private System.Windows.Forms.DataGridView transaction_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDebitStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avlBalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource notifyModelClassBindingSource1;
        private System.Windows.Forms.RichTextBox showdata_notification_label;
        private System.Windows.Forms.RichTextBox add_notification_label;
        private System.Windows.Forms.Button delete_transaction_button;
    }
}

