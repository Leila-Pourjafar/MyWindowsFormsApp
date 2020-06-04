
namespace MyWindowsFormsApp
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            Models.DataBaseContext databaseContext = null;
            try
            {
                databaseContext =
                    new Models.DataBaseContext();

                Models.User user = new Models.User()
                {
                    IsActive = true,

                    Password = "123456",
                    UserName = "leila.122",
                    FullName = "Leila Jafari",
                    EmailAddress = "leila.122@gmail.com",
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
