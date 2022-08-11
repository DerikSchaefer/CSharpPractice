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
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace Assignment5._4
{
    public partial class Form1 : Form
    {
        Person person;
        const string FilePath = @"C:\Files\pcad7binary.txt";
        const string filePathXML = @"C:\Files\pcad7xml.xml";
        const string jsonfilepath = @"C:\Files\pcad7json.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSerializeBinary.Enabled = false;
            btnDeserializeBinary.Enabled = false;
            btnSerializeXML.Enabled = false;
            btnDeserializeXML.Enabled = false;
            btnSerializeJSON.Enabled = false;
            btnDeserializeJSON.Enabled = false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.Mobile = (TextMobile.Text);
            person.FirstName = TextFName.Text;
            person.Address = TextAddress.Text;
            MessageBox.Show("person object created");
            btnSerializeBinary.Enabled = true;
            btnSerializeXML.Enabled = true;
            btnSerializeJSON.Enabled = true;
        }
        private void btnSerializeBinary_Click_1(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, person);
                MessageBox.Show("object is serialized!");
                btnDeserializeBinary.Enabled = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }
        private void btnDeserializeBinary_Click_1(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Person temp = (Person)formatter.Deserialize(fileStream); 
                MessageBox.Show($"Name: {temp.FirstName} mobile: {temp.Mobile} address:{temp.Address}");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }
        private void btnSerializeXML_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(filePathXML, FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter soapFormatter = new SoapFormatter(); 
            soapFormatter.Serialize(fileStream, person); 
            MessageBox.Show("Serialization done");
            fileStream.Close();
            btnDeserializeXML.Enabled = true;
        }
        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(filePathXML, FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter = new SoapFormatter();
            Person temp = (Person)soapFormatter.Deserialize(fileStream);
            MessageBox.Show($"Name: {temp.FirstName} mobile: {temp.Mobile} address:{temp.Address}");
            fileStream.Close();
        }
        private void btnSerializeJSON_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(jsonfilepath, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();

            serializer.WriteObject(fileStream, person);
            MessageBox.Show("JSON data serialized");
            fileStream.Close();
            btnDeserializeJSON.Enabled = true;
        }
        private void btnDeserializeJSON_Click(object sender, EventArgs e)
        {

            FileStream fileStream = new FileStream(jsonfilepath, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));
            Person temp = jsonSerializer.ReadObject(fileStream) as Person;
            fileStream.Close();
            MessageBox.Show($"Name: {temp.FirstName} mobile: {temp.Mobile} address:{temp.Address}");
        }
    }
}