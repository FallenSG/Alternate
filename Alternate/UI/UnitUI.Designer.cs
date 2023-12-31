﻿namespace Alternate.UI
{
    partial class UnitUI
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
            components = new System.ComponentModel.Container();
            unitBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            unitIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aliasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            printNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // unitBindingSource
            // 
            unitBindingSource.DataSource = typeof(Models.Unit);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { unitIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, aliasDataGridViewTextBoxColumn, printNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = unitBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            unitIdDataGridViewTextBoxColumn.HeaderText = "UnitId";
            unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            aliasDataGridViewTextBoxColumn.DataPropertyName = "Alias";
            aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // printNameDataGridViewTextBoxColumn
            // 
            printNameDataGridViewTextBoxColumn.DataPropertyName = "PrintName";
            printNameDataGridViewTextBoxColumn.HeaderText = "PrintName";
            printNameDataGridViewTextBoxColumn.Name = "printNameDataGridViewTextBoxColumn";
            // 
            // UnitUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UnitUI";
            ShowIcon = false;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            TextChanged += Alternate_Load;
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource unitBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn unitIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn printNameDataGridViewTextBoxColumn;
    }
}