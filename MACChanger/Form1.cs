using System;
using pUnknownC;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MACChanger
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            aMAC.Text = _sysIn.GetMACAddress().ToString();
            getNetworkAdapter();
        }
        
        private Point _mouseMoving;
        _mBoxes m = new _mBoxes();
        RegistryKey r;
        string key = String.Empty;
        string[] result = new String[20];
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cMAC_Click(object sender, EventArgs e)
        {
            string select = listBox1.SelectedItem.ToString();
            
            if(select == result[0])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if(select == result[1])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0002", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if(select == result[2])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0003", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if(select == result[3])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0004", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[4])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0005", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[5])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0006", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[6])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0007", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[7])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0008", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[8])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0009", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[9])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0010", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[10])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0011", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[11])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[12])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\00013", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[13])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0014", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[14])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0015", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[15])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0016", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[16])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0017", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[17])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0018", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[18])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0019", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            if (select == result[19])
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0020", true);
                r.SetValue("NetworkAddress", nMAC.Text);
                State.Visible = true;
                State.Text = "MAC Adresse wurde geändert!";
                r.Close();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseMoving = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.Location.X - _mouseMoving.X;
                int y = e.Location.Y - _mouseMoving.Y;
                this.Location = new Point(this.Location.X + x, this.Location.Y + y);
            }
        }

        private void getNetworkAdapter()
        {
            try
            {
                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001", true);
                result[0] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[0]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0002", true);
                result[1] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[1]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0003", true);
                result[2] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[2]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0004", true);
                result[3] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[3]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0005", true);
                result[4] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[4]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0006", true);
                result[5] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[5]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0007", true);
                result[6] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[6]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0008", true);
                result[7] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[7]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0009", true);
                result[8] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[8]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0010", true);
                result[9] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[9]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0011", true);
                result[10] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[10]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012", true);
                result[11] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[11]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0013", true);
                result[12] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[12]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0014", true);
                result[13] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[13]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0015", true);
                result[14] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[14]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0016", true);
                result[15] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[15]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0017", true);
                result[16] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[16]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0018", true);
                result[17] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[17]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0019", true);
                result[18] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[18]).ToString();

                r = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0020", true);
                result[19] = r.GetValue("DriverDesc").ToString();
                listBox1.Items.Add(result[19]).ToString();


            }
            catch
            {

            }
        }

       
    }
}
