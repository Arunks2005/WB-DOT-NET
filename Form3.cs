using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        private double totalAmount = 0;
        private const double DiscountRate = 0.10;

        // Default constructor
        public Form3()
        {
            InitializeComponent();

            // Assign event handlers
            button1.Click += (s, e) => AddToCart("Parachute Experience", 100);
            button2.Click += (s, e) => AddToCart("Trekking Adventure", 200);
            button3.Click += (s, e) => AddToCart("Camping Experience", 150);
            button4.Click += (s, e) => AddToCart("Rafting Adventure", 250);
            buttonDiscard.Click += (s, e) => DiscardCart();
            buttonCalculate.Click += (s, e) => CalculateFinalAmount();
            buttonProceed.Click += (s, e) => ProceedToCheckout();
        }

        // Overloaded constructor
        public Form3(string someParam)
        {
            InitializeComponent();
            // You can do something with 'someParam' if needed.
        }

        private void AddToCart(string item, double price)
        {
            listBoxCart.Items.Add($"{item} - ${price}");
            totalAmount += price;
            UpdateTotal();
        }

        private void DiscardCart()
        {
            listBoxCart.Items.Clear();
            totalAmount = 0;
            UpdateTotal();
            ClearCalculations();
        }

        private void CalculateFinalAmount()
        {
            double discount = totalAmount * DiscountRate;
            double finalAmount = totalAmount - discount;

            textBoxTotal.Text = totalAmount.ToString("C");
            textBoxDiscount.Text = discount.ToString("C");
            textBoxFinalAmount.Text = finalAmount.ToString("C");
        }

        private void ProceedToCheckout()
        {
            if (listBoxCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to proceed.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thank you for your purchase! Proceeding to payment.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DiscardCart();
        }

        private void UpdateTotal()
        {
            labelTotal.Text = $"Total: ${totalAmount}";
        }

        private void ClearCalculations()
        {
            textBoxTotal.Text = string.Empty;
            textBoxDiscount.Text = string.Empty;
            textBoxFinalAmount.Text = string.Empty;
        }
    }
}
