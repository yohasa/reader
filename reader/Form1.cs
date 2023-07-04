using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Linq;
using VisioForge.MediaFramework.ONVIF;
using Windows.Devices.Enumeration;
using Windows.Media.Devices;
using Color = System.Drawing.Color;
using MediaDevice = Windows.Media.Devices.MediaDevice;

namespace reader
{
    public partial class Form1 : Form
    {
        int c = 4;
            string dp = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor= Color.Gray;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string PATH = @"C:\Users\USER26\source\repos\reader\reader\source.txt";
            StreamReader stream = new StreamReader(PATH);
            string data = stream.ReadToEnd();
            list1.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            list1.Text = "";
        }

        private void edi_Click(object sender, EventArgs e)
        {
            string PATH = @"C:\Users\USER26\source\repos\reader\reader\source.txt";
            StreamReader stream = new StreamReader(PATH);
            string data = "";
        }

        private void cho_Click(object sender, EventArgs e)
        {
            string fileName = "";
            //StreamWriter stream = new StreamWriter(fileName);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.InitialDirectory = "C:\\Users\\user\\Documents";
            //dp = Path.GetFileName(ofd.FileName);
            //db = Path.GetDirectoryName(ofd.FileName);
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
               fileName = ofd.FileName;
                else return;
                using (StreamReader sr = new StreamReader(fileName)) { 
                    string line;
                    string searchText = "@";
                    StringBuilder sb = new StringBuilder();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(searchText))
                    {
                        int a = line.IndexOf('@');
                        line = line.Substring(0, a);
                        sb.Append(line);
                        sb.Append("\n");
                       
                    }
                   
                }

                // Get the path of the file
                string fileName1 = "myfile"+ c++ +".txt";
                string directoryPath = Path.GetDirectoryName(ofd.FileName);
                string filePath = Path.Combine(directoryPath, fileName1);

                // Create a new file
                StreamWriter sw = File.CreateText(filePath);

                

                // Display the lines that contain the search text in the text box
                list1.Text = sb.ToString();
                // Write the text to the file
                sw.WriteLine(list1.Text);

                // Close the file
                sw.Close();

                // Open the file explorer
                Process.Start("explorer.exe", filePath);
            }
                }

        private void newFile_Click(object sender, EventArgs e)
        {
        }

        private void mic_ca_Click(object sender, EventArgs e)
        {
            //// Get the microphone device
            //MediaDevice microphoneDevice = DeviceInformation.FindAllAsync(DeviceClass.AudioCapture).Result[0];

            //// Get the camera device
            //MediaDevice cameraDevice = DeviceInformation.FindAllAsync(DeviceClass.VideoCapture).Result[0];

            //// Enable the microphone
            //microphoneDevice.DeviceState = MediaDeviceState.Enabled;

            //// Enable the camera
            //cameraDevice.DeviceState = MediaDeviceState.Enabled;
        }
    }
}

