using System.Data;
using System.Data.SqlClient;
using Winform.Fullstack2.DTO;
//using Winform.Fullstack2.Form;
using Winform.Fullstack2.Forms;

namespace Winform.Fullstack2
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var response = GetUser(txtUsername.Text, txtPassword.Text);

                if(response!=null)
                {

                    NavigationForm form = new NavigationForm(response);
                    //ProductsForm form = new ProductsForm(userFullName);


                    form.Show();
                    this.Hide();

                }
                else 
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
               
            }
            else 
            {
                MessageBox.Show("Alanları doldurunuz");
            }


        }

        /// <summary>
        /// Parametre olarak girilen username ve passworda karşılık, user ın full name ini döner.
        /// </summary>

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private UserLoginResponseDto GetUser(string username, string password)
        {

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress01; database=TutorialDb; integrated security = true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where Username=@username and Password=@password";

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);


            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();

            var id = 0;
            string fullname = "";
            UserLoginResponseDto responseDto = null;
            while (reader.Read())
            {
                responseDto = new UserLoginResponseDto();
                responseDto.Id = Convert.ToInt32(reader[0]);
                responseDto.Fullname = Convert.ToString(reader[3]);
            }
            reader.Close();
            connection.Close();

            
            return responseDto;
        }
    }

}





