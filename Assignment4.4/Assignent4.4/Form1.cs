using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignent4._4
{
    public partial class Form1 : Form
    {

        List<Beverages.Coffee> coffees;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            coffees = new List<Beverages.Coffee>();
            coffees.Add(new Beverages.Coffee() { Name = "Cafe Americano", Regular = "$3.05", Large = "$3.55" });
            coffees.Add(new Beverages.Coffee() { Name = "Decaf Americano", Regular = "$3.15", Large = "$3.65" });
            coffees.Add(new Beverages.Coffee() { Name = "Cappuccino", Regular = "$4.05", Large = "$4.55" });
            coffees.Add(new Beverages.Coffee() { Name = "Latte", Regular = "$3.55", Large = "$3.75" });
            coffees.Add(new Beverages.Coffee() { Name = "Cafe Mocha", Regular = "$3.55", Large = "$3.75" });
            coffees.Add(new Beverages.Coffee() { Name = "White Chocolate Mocha", Regular = "$4.05", Large = "$4.45" });
            coffees.Add(new Beverages.Coffee() { Name = "Caramel Machiatto", Regular = "$3.85", Large = "$4.55" });
            coffees.Add(new Beverages.Coffee() { Name = "Pumpkin Spice Latte", Regular = "4.35", Large = "$5.01" });
            coffees.Add(new Beverages.Coffee() { Name = "White Hot Chocolate", Regular = "4.25", Large = "4.55" });
            coffees.Add(new Beverages.Coffee() { Name = "Hot Chocolate", Regular = "3.75", Large = "4.05" });
            coffees.Add(new Beverages.Coffee() { Name = "Flat White", Regular = "3.85", Large = "---" });
            coffees.Add(new Beverages.Coffee() { Name = "London Fog Tea Latte", Regular = "4.25", Large = "4.75" });
            coffees.Add(new Beverages.Coffee() { Name = "Chai Tea Latte", Regular = "3.75", Large = "4.35" });
            BeverageGrid.DataSource = coffees;





        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (TextBevName.Text != String.Empty && TextPrice1.Text != String.Empty && TextPrice2.Text != String.Empty)
            {
                Beverages.Coffee newCoffee = new Beverages.Coffee();
                newCoffee.Name = TextBevName.Text;
                newCoffee.Regular = TextPrice1.Text;
                newCoffee.Large = TextPrice2.Text;
                coffees.Add(newCoffee);
                MessageBox.Show("Beverage added!");
            }
            RefreshData();

        }
        private void RefreshData()
        {
            TextBevName.Clear();
            TextPrice1.Clear();
            TextPrice2.Clear();
            BeverageGrid.DataSource = null;
            BeverageGrid.DataSource = coffees;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            coffees.RemoveAt(BeverageGrid.CurrentRow.Index);
            RefreshData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBevName_Validating(object sender, CancelEventArgs e)
        {
            if (TextBevName.Text.Length == 0 || TextBevName.Text.Length > 100)
            {
                MessageBox.Show("Please enter a correct input");
                e.Cancel = true;
                TextBevName.Clear();
            }
        }

        private void TextPrice1_Validating(object sender, CancelEventArgs e)
        {
            if (TextPrice1.Text.Length == 0 || TextPrice1.Text.Length > 100)
            {
                MessageBox.Show("Please enter a correct input");
                e.Cancel = true;
                TextPrice1.Clear();
            }
        }

        private void TextPrice2_Validating(object sender, CancelEventArgs e)
        {
            if (TextPrice2.Text.Length == 0 || TextPrice2.Text.Length > 100)
            {
                MessageBox.Show("Please enter a correct input");
                e.Cancel = true;
                TextPrice2.Clear();
            }
        }
    }
}
