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
using System.Windows.Shapes;

namespace Wpf_UI
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
public partial class AddStudentWindow : Window
{
    BE.Student student;
    BL.IBL bl;


    public AddStudentWindow()
    {
        InitializeComponent();

        student = new BE.Student();
        this.DataContext = student;

        bl = BL.FactoryBL.GetBL();

        this.studentCampusComboBox.ItemsSource = Enum.GetValues(typeof(BE.Campus));
        this.studentGenderComboBox.ItemsSource = Enum.GetValues(typeof(BE.Gender));
    }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddStudent(student);
                student = new BE.Student();
                this.DataContext = student;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
