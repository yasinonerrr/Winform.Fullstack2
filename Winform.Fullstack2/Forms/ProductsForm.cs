using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using Winform.Fullstack2.Defaults;
using Winform.Fullstack2.Entities;

namespace Winform.Fullstack2.Forms
{
    public partial class ProductsForm : Form
    {
        string userFullname;

        Product selectedProduct;
        /// <summary>
        /// Bu form ancak ve ancak userFullname ile örneklenebilir.
        /// </summary>

        public ProductsForm(string userFullname)
        {
            InitializeComponent();
            this.userFullname = userFullname;
            Reload();
        }

        public void Reload()
        {
            var notes = ListProduct();
            listProducts.DataSource = null;
            listProducts.DataSource = notes;
            listProducts.DisplayMember = "Name";
            listProducts.ValueMember = "Id";
            //listNote.Items.Clear();
            //listNote.Items.AddRange(notes.ToArray());
            //listNote.DisplayMember = "Name";
            //listNote.ValueMember = "Id";
        }

        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            var item = listProducts.SelectedItem as Product;

            lblTest.Text = item.Stock.ToString();

            lblUser.Text = userFullname;
        }

        private List<Product> ListProduct()
        {
            var productList = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress01; database=TutorialDb; integrated security =true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);

                productList.Add(product);

            }

            reader.Close();

            connection.Close();

            return productList;

        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProducts.SelectedItem != null)
            {
                selectedProduct = listProducts.SelectedItem as Product;
                txtStock.Text = selectedProduct.Stock + "";
                txtProductName.Text = selectedProduct.Name;
                lblTest.Text = selectedProduct.Stock.ToString();
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(txtStock.Text) && !string.IsNullOrEmpty(txtProductName.Text))
                {
                    UpdateProduct(new Product { Name = txtProductName.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                    Reload();
                }
                else
                {
                    MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
                }
                
               
            }
        }

        private int UpdateProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLExpress01; database=TutorialDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Update Products set Name = @name, Stock=@stock where Id=@id";

            command.Parameters.AddWithValue("@name", updatedProduct.Name);
            command.Parameters.AddWithValue("@stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@id", updatedProduct.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();

            connection.Close();

            return effectedRows;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedProduct = null;
        }

        // DRY => DONT REPEAT YOURSELF

        // Bir metod bi işi yapsın

        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {

                SqlConnection connection = new SqlConnection("server=.\\SQLExpress01; database= TutorialDb; integrated security=true;");

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products values(@name, @stock)";

                var stock = int.Parse(txtStock.Text);

                command.Parameters.AddWithValue("@name", txtProductName.Text);
                command.Parameters.AddWithValue("@stock", stock);

                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (effectedRows > 0)
                {
                    MessageBox.Show("Kayıt başarılı bir şekilde eklendi");
                    Reload();
                    ClearText();
                }
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                SqlConnection conneciton = new SqlConnection("server=.\\SQLExpress01; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conneciton;
                command.CommandText = "delete from Products where Id = @id";

                command.Parameters.AddWithValue("@id", selectedProduct.Id);
                conneciton.Open();
                command.ExecuteNonQuery();
                conneciton.Close();
                command.Parameters.Clear();
                Reload();
                ClearText();

            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
            }
        }


        //private List<Category> ListCategory() 
        //{

        //}

        //public class Category 
        //{

        //}

        // 1-n =>  Bire çok ilişki kim tek, kim çok



        /*
         * 

        Users                               Notes
      1- Ozan                             1  Abc 1 => not null , null
      2- Hürrem                           2  Cba 2

        1 kullanıcının bir den fazla notu olur
        1 notun 1 kullanıcısı olur. /olmak zorundadır).

        */




    }
}