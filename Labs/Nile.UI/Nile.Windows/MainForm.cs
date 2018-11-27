/*Marissa Greise
 * ITSE 1430
 * 11/20/2018
 */
using System;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            //var connString = ConfigurationManager
            //                   .ConnectionStrings["Database"]
            //                   .ConnectionString;
            //_database = new SqlMovieDatabase(connString);

            UpdateList();
        }

        #region Event Handlers
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            //Save product
            try
            {
                _database.Add(child.Product);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateList();
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Handle errors
            //Delete product
            try
            {
                _database.Remove(product.Id);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            UpdateList();
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            //Save product
            try
            {
                _database.Update(child.Product);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

            UpdateList();
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            //TODO: Handle errors
            try
            {
                _bsProducts.DataSource = _database.GetAll();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private readonly IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();
        #endregion

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Marissa Greise\nFall 2018\nITSE 1430", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
