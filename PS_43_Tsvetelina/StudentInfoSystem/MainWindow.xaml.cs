using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            if (logButton.Content.ToString().Equals("Login"))
            {
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).IsEnabled = true;
                    }
                }
                Student student = StudentData.TestStudents.OrderBy(st => st.FacultyNumber).FirstOrDefault();
                firstNameText.Text = student.FirstName;
                secondNameText.Text = student.SecondName;
                lastNameText.Text = student.LastName;
                facultyText.Text = student.Faculty;
                majorText.Text = student.Major;
                degreeText.Text = student.Degree;
                statusText.Text = student.Status;
                facultyNumberText.Text = student.FacultyNumber.ToString();
                courseText.Text = student.Course.ToString();
                streamText.Text = student.Stream.ToString();
                groupText.Text = student.Group.ToString();
                logButton.Content = "Logout";
            }
            else if (logButton.Content.ToString().Equals("Logout"))
            {
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                        ((TextBox)item).IsEnabled = false;
                    }
                }
                logButton.Content = "Login";
            }
        }
    }
}
