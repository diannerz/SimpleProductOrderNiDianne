using System.Windows;

namespace SimpleProductOrderNiDianne
{
    public partial class SummaryWindow : Window
    {
        public SummaryWindow(string productName, string quantity, string customerName, string customerAddress)
        {
            InitializeComponent();

            ProductNameTextBlock.Text = $"Product: {productName}";
            QuantityTextBlock.Text = $"Quantity: {quantity}";
            CustomerNameTextBlock.Text = $"Customer Name: {customerName}";
            CustomerAddressTextBlock.Text = $"Address: {customerAddress}";
        }
    }
}
