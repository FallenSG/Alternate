using System.Windows.Forms;
using System;
using System.Security.Cryptography.X509Certificates;
using Alternate.UI.Unit;
using Alternate.UI;

namespace Alternate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*for (int i = 1; i <= 128; i++)
            {
                dataGridView1.Rows.Add(i, "", "", "", "", "");
            }*/
        }

        private void New_Click(object sender, EventArgs e)
        {
            /*Form2 newMDIChild = new Form2();*/
            Add newMDIChild = new Add();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void Unit_Click(object sender, EventArgs e)
        {
            UnitUI newMDIChild = new UnitUI();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        /* private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
         {
             // Check if the column is one of the integer columns
             if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
             {
                 int parsedValue;
                 if (!int.TryParse(e.FormattedValue.ToString(), out parsedValue))
                 {
                     //e.Cancel = true;
                     dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                 }
             }

             //dataGridView1_KeyDown(sender, KeyEventArgs);

         }

         private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {

                 int currentRow = dataGridView1.CurrentCell.RowIndex;
                 int currentCol = dataGridView1.CurrentCell.ColumnIndex;

                 // Check if it's not the last column
                 if (currentCol < dataGridView1.ColumnCount - 1)
                 {
                     // Move to the next cell in the same row
                     dataGridView1.CurrentCell = dataGridView1[currentCol + 1, currentRow];
                 }
                 else
                 {
                     // If it's the last column, move to the first column of the next row
                     if (currentRow < dataGridView1.RowCount - 1 && !string.IsNullOrEmpty(dataGridView1[currentCol, currentRow].Value?.ToString()))
                     {
                         dataGridView1.CurrentCell = dataGridView1[0, currentRow + 1];
                     }
                 }

                 // Consume the Enter key press
                 e.SuppressKeyPress = true;
             }
         }

         private void label1_Click(object sender, EventArgs e)
         {
         }

         private void label1_Click_1(object sender, EventArgs e)
         {

         }

         private void label4_Click(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void listView1_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void dataGridView1_CellValidating(object sender, DataGridViewCellEventArgs e)
         {

         }

         private void dataGridView1_CellBeginEdit(object sender, EventArgs e)
         {


         }*/
    }
}