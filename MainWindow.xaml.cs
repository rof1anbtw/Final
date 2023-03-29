using PRAKTIK5.prak5DataSetTableAdapters;
using System.Windows;


namespace PRAKTIK5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter users = new UsersTableAdapter();
        AdminsTableAdapter admins = new AdminsTableAdapter();
        ManagersTableAdapter managers= new ManagersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userLogins = users.GetData().Rows;
            var adminLogins = admins.GetData().Rows;
            var managerLogins = managers.GetData().Rows;
            bool chek = true, chek1=true , chek2=true;
            if (chek == true)
            {
                for (int i = 0; i < userLogins.Count; i++)
                {
                    if (userLogins[i][2].ToString() == LoginTbx.Text && userLogins[i][3].ToString() == PasswordTbx.Password)
                    {
                        int roleID = (int)userLogins[i][4];

                        switch (roleID)
                        {
                            case 3:
                                UserRoleWindow userRoleWindow = new UserRoleWindow();
                                userRoleWindow.Show();
                                chek1= false;
                                chek2 = false; 
                                break;
                        }
                    }
                }
                if(chek1 == true)
                {
                    for (int i = 0; i < adminLogins.Count; i++)
                    {
                        if (adminLogins[i][3].ToString() == LoginTbx.Text && adminLogins[i][2].ToString() == PasswordTbx.Password)
                        {
                            int roleID = (int)adminLogins[i][5];

                            switch (roleID)
                            {
                                case 1:
                                    AdminRoleWindow adminRoleWindow = new AdminRoleWindow();
                                    adminRoleWindow.Show();
                                    chek2 = false;
                                    break;
                            }
                        }
                    }
                    if (chek2 == true)
                    {
                        chek = false;
                        for (int i = 0; i < managerLogins.Count; i++)
                        {
                            if (managerLogins[i][2].ToString() == LoginTbx.Text && managerLogins[i][3].ToString() == PasswordTbx.Password)
                            {
                                int roleID = (int)managerLogins[i][4];

                                switch (roleID)
                                {
                                    case 2:
                                        UserRoleWindow userRoleWindow = new UserRoleWindow();
                                        userRoleWindow.Show();
                                        chek = true;
                                        break;
                                }
                            }
                        }
                    }
                }

            }
            else if (chek == false)
            {
                MessageBox.Show("Вы ввели неправильный пароль или логин!");
            }
        }
    }
}
