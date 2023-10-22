using Alternate.Models;

namespace Alternate.UI
{
    public partial class UnitUI : Form
    {
        public UnitUI()
        {
            InitializeComponent();

            using (Product_Context dbContext = new Product_Context())
            {
                //dbContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s); // Optional for debugging

                // Assuming you have a DbSet in YourDbContext named "Unit"
                var names = dbContext.Units.Select(u => u.Name).ToList();

                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                autoCompleteCollection.AddRange(names.ToArray());

                textBox1.AutoCompleteCustomSource = autoCompleteCollection;
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void Alternate_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_textChange(object sender, EventArgs e)
        {

        }
    }
}
