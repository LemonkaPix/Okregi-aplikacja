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
                "Okręgi o(O₁,r) i o(O₂,r) są rozłączone zewnętrznie wtedy i tylko w tedy, gdy",
                "Okręgi o(O₁,r) i o(O₂,r) są styczne zewnętrznie wtedy i tylko w tedy, gdy",
                "Okręgi o(O₁,r) i o(O₂,r) przecinają się wtedy i tylko w tedy, gdy",
                "Okręgi o(O₁,r) i o(O₂,r) są styczne wewnętrznie wtedy i tylko w tedy, gdy",
                "Okręgi o(O₁,r) i o(O₂,r) są rozłączone wewnętrznie wtedy i tylko w tedy, gdy"
            };

            string[] Wzory =
            {
                "|O₁O₂| > r₁ + r₂",
                "|O₁O₂| = r₁ + r₂",
                "|r₁ - r₂| < |O₁O₂| < r₁ + r₂",
                "|O₁O₂| = |r₁ - r₂| ≠ 0",
                "|O₁O₂| < |r₁ - r₂|"
            };

            twTextBox.Text = Twierdzenia[twDropDown.SelectedIndex];
            twWzor.Text = Wzory[twDropDown.SelectedIndex];
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // int pos = path.IndexOf("\\bin");
            // if (pos >= 0) 
            //{ 
            // path = path.Remove(pos);
            //path += $"\\img\\{twDropDown.SelectedIndex + 1}.png";

            // twZdj.Image = Image.FromFile(path);
            // }
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            float promien1 = (float)promien1num.Value;
            float promien2 = (float)promien2num.Value;
            float odleglosc = (float)distanceNum.Value;


        }
    }
}
