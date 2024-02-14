using Npgsql;

namespace ValidWithUniquePass
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Host=localhost; Port=5432; Username=postgres; Password=1212321; Database=uniqusers";
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            if (UserExists(username))
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                return;
            }
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Пароль должен состоять из 8 символов включая буквы верхнего и нижнего регистров, а также символы '@' и '!' ");
                return;
            }
            if (RegisterUser(username, password))
            {
                MessageBox.Show("Пользователь успешно зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при регистрации пользователя!");
            }
        }
        private bool UserExists(string username)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM uniquser WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length != 8)
            {
                return false;
            }

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                return false;
            }

            if (!password.Contains('@') || !password.Contains('!'))
            {
                return false;
            }

            return true;
        }

        private bool RegisterUser(string username, string password)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO uniquser (username, password) VALUES (@username, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
