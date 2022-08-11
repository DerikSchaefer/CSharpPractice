using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Mod6BinarySerialization
{
    public partial class Form1 : Form
    {
        Employee employee;
        const string filePath = @"C:\Files\pcad7binary.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            employee.Eid =Int32.Parse(txtEid.Text);
            employee.EName=txtName.Text;
            employee.Salary=double.Parse(txtSalary.Text);
            MessageBox.Show("Employee object created");
            btnSerialize.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSerialize.Enabled = false;
            btnDeserialize.Enabled = false;
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            FileStream fileStream =null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter(); // how
                formatter.Serialize(fileStream, employee); // where , what
                MessageBox.Show("object is serialized!");
                btnDeserialize.Enabled = true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            FileStream fileStream=null;
            try
            {
                fileStream=new FileStream(filePath, FileMode.Open,FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Employee temp=(Employee)formatter.Deserialize(fileStream); // reading the stream of bytes and putting it back into emp object
                MessageBox.Show($"Employee id: {temp.Eid} name: {temp.EName} salary:{temp.Salary}");


            }
            catch(Exception ex)
            {

            }
            finally {
                fileStream.Close();
            
            }

        }
    }
}
