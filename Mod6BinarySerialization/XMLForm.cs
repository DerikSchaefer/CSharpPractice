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
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
namespace Mod6BinarySerialization
{
    public partial class XMLForm : Form
    {
        Employee employee;
        const string filePath = @"C:\Files\pcad7xml.xml";
        const string jsonfilepath = @"C:\Files\pcad7json.txt";
        public XMLForm()
        {
            InitializeComponent();
        }

        private void XMLForm_Load(object sender, EventArgs e)
        {
           // btnXMLSerialize.Enabled = false;
           // btnXMLDS.Enabled = false;
        }

        private void btbCreate_Click(object sender, EventArgs e)
        {
             employee=new Employee();
             employee.Eid=Int32.Parse(txtEid.Text);
             employee.EName=txtEname.Text;
            employee.Salary=double.Parse(txtSalary.Text);
            MessageBox.Show("Object is created!");
            btnXMLSerialize.Enabled=true;
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            //FullEmp fullEmp = new FullEmp();
            //fullEmp.Eid = Int32.Parse(txtEid.Text);

            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter soapFormatter = new SoapFormatter(); // how
            soapFormatter.Serialize(fileStream, employee);// where, what
            MessageBox.Show("Serialization done");
            fileStream.Close();
            btnXMLDS.Enabled = true;
        }

        private void btnXMLDS_Click(object sender, EventArgs e)
        {
            FileStream fileStream=new FileStream(filePath, FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter=new SoapFormatter();
            Employee temp=(Employee)soapFormatter.Deserialize(fileStream);
            MessageBox.Show($"{temp.Eid}: {temp.EName} : {temp.Salary}");
            fileStream.Close();
        }

        private void btnJSONSer_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(jsonfilepath, FileMode.Create, FileAccess.Write);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Employee));
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            
            serializer.WriteObject(fileStream, employee);
            MessageBox.Show("JSON data serialized");
            fileStream.Close();

        }

        private void btnJSONDS_Click(object sender, EventArgs e)
        {
            FileStream fileStream=new FileStream(jsonfilepath,FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Employee));
            Employee temp=jsonSerializer.ReadObject(fileStream) as Employee;
            fileStream.Close();
            MessageBox.Show($"{temp.Eid} , {temp.EName} , {temp.Salary}");

        }
    }
}
