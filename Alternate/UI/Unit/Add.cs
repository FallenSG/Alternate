using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Alternate.Models;

namespace Alternate.UI.Unit
{
    public partial class Add : Form
    {
        private Product_Context? dbContext;
        public Add()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new Product_Context();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Units.Load();

            this.dataGridView1.DataSource = dbContext.Units.Local.ToBindingList();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
