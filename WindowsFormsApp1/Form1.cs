using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendMessage(this.twDropDown.Handle, CB_SETCUEBANNER, 0, "Prosze wybrać twierdzenie...");
        }



        private void twDropDown_IndexChanged(object sender, EventArgs e)
        {

            string[] Twierdzenia =
            {
                "|O₁O₂| > r₁ + r₂",
                "|O₁O₂| = r₁ + r₂",
                "|r₁ - r₂| < |O₁O₂| < r₁ + r₂",
                "|O₁O₂| = |r₁ - r₂| ≠ 0",
                "|O₁O₂| < |r₁ - r₂|"
            };

            twTextBox.Text = Twierdzenia[twDropDown.SelectedIndex];
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

           // int pos = path.IndexOf("\\bin");
           // if (pos >= 0) 
            //{ 
               // path = path.Remove(pos);
                //path += $"\\img\\{twDropDown.SelectedIndex + 1}.png";

               // twZdj.Image = Image.FromFile(path);
           // }
        }

        int checkValues(float p1, float p2, float o)
        {
            if (p1 == 0) return 1;
            if (p2 == 0) return 2;
            if (o == 0) return 3;
            return 0;

        }


        private void drawBtn_Click(object sender, EventArgs e)
        {
            float promien1 = (float)promien1num.Value;
            float promien2 = (float)promien2num.Value;
            float odleglosc = (float)distanceNum.Value;


            int errorVal = checkValues(promien1, promien2, odleglosc);
            switch(errorVal)
            {
                case 1:
                    MessageBox.Show("Nie podano pierwszego promienia");
                    return;
                case 2:
                    MessageBox.Show("Nie podano drugiego promienia");
                    return;
                case 3:
                    MessageBox.Show("Nie podano odległosci");
                    return;
            }


            MessageBox.Show($"promien1: {promien1} promien2: {promien2} odleglosc: {odleglosc}");




        }

    }
}
