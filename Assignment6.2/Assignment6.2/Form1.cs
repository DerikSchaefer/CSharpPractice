using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6._2
{
    public partial class Form1 : Form
    {

        CarRepository carRepository;    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            carRepository = new CarRepository();
            CarGrid.DataSource = carRepository.GetAllRecords();
            BtnUpdate.Enabled = false;

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVIN.Text) && !string.IsNullOrEmpty(txtMake.Text) && !string.IsNullOrEmpty(txtModel.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtPrice.Text)) { 
                var newCar = new Car(); 
                newCar.VIN = txtVIN.Text;
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Year = Int32.Parse(txtYear.Text);
                newCar.Price = decimal.Parse(txtPrice.Text);
                carRepository.AddRecord(newCar);
                MessageBox.Show("New Car Added!");
                Clear();
            }
    
        }
        private void Clear()
        {
            txtVIN.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CarGrid.DataSource = null;
            CarGrid.DataSource = carRepository.GetAllRecords();
       
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var VIN = CarGrid.CurrentRow.Cells[0].Value;
            var carDelete = carRepository.FindCar((string)VIN);
            carRepository.DeleteRecord(carDelete);
            MessageBox.Show("Car deleted");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var VIN = CarGrid.CurrentRow.Cells[0].Value;
            var carToUpdate = carRepository.FindCar((string)VIN);
   
          txtVIN.Text = carToUpdate.VIN;
          
            txtMake.Text = carToUpdate.Make;
            txtModel.Text = carToUpdate.Model;
            txtYear.Text = carToUpdate.Year.ToString();
            txtPrice.Text = carToUpdate.Price.ToString();
            BtnUpdate.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var VIN = txtVIN.Text;
            var carToUpdate = carRepository.FindCar((string)VIN);
            carToUpdate.Make = txtMake.Text;
            carToUpdate.Model = txtModel.Text;
            carToUpdate.Price = decimal.Parse(txtPrice.Text);
            carToUpdate.Year = Int32.Parse(txtYear.Text);
            MessageBox.Show("Car record updated");
            BtnUpdate.Enabled = true;
            Clear();
        }

        private void txtVIN_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
