using BootcampWPF.BussinessLogic;
using BootcampWPF.BussinessLogic.Services.Master;
using BootcampWPF.DataAccess.Model;
using BootcampWPF.DataAccess.Param;
//using BootcampWPF.Model;
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

namespace BootcampWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ISupplierService _supplierService = new SupplierService();
        MyContext _context = new MyContext();
        SupplierParam supplierParam = new SupplierParam();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var name = NameTextBox1.Text;
            ResultTextBox.Text = name;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox == null)
            {
                MessageBox.Show("Please Insert Supplier Name");
            }
            else
            {
                Supplier supplier = new Supplier();
                supplier.Name = NameTextBox.Text;
                supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
                supplier.UpdateDate = DateTimeOffset.Now.LocalDateTime;
                _context.Suppliers.Add(supplier);
                var result = _context.SaveChanges();
                if ( result > 0)
                {
                    MessageBox.Show("Insert Success");
                    NameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
            }
        }

        private void NameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z .]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountTextBox.Text = NameTextBox.Text.Length.ToString();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SupplierDataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            SupplierComboBox.ItemsSource = _supplierService.Get();
        }

        private void SupplierDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = SupplierDataGrid.SelectedItem;
            NameTextBox.Text = (SupplierDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            //SupplierComboBox.Text = (SupplierDataGrid.SelectedCells[1].Column.GetCellContent(item) as ComboBox).Text;
        }

        private void SupplierComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var getSupplier = Convert.ToInt16(SupplierComboBox.SelectedValue);
            //SupplierComboBox.ItemsSource = _supplier.Get(getSupplier);
        }
    }
}
