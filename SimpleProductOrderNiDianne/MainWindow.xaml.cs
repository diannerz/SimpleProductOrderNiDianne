using System.Windows;

namespace SimpleProductOrderNiDianne
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            string productName = ProductNameTextBox.Text.Trim();
            string quantity = QuantityTextBox.Text.Trim();
            string customerName = CustomerNameTextBox.Text.Trim();
            string customerAddress = CustomerAddressTextBox.Text.Trim();

            if (string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantity) ||
                string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(customerAddress))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SummaryWindow summaryWindow = new SummaryWindow(productName, quantity, customerName, customerAddress);
            summaryWindow.Show();
            this.Close();
        }
    }
}
