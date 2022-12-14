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
            SendMessage(this.twDropDown.Handle, CB_SETCUEBANNER, 0, "Proszę wybrać twierdzenie...");
        }

        float promien1;
        float promien2;
        float odleglosc;

        private void twDropDown_IndexChanged(object sender, EventArgs e)
        {

            string[] Twierdzenia =
            {
                "Okręgi o(O₁,r₁) i o(O₂,r₂) są rozłączne zewnętrznie wtedy i tylko wtedy, gdy",
                "Okręgi o(O₁,r₁) i o(O₂,r₂) są styczne zewnętrznie wtedy i tylko wtedy, gdy",
                "Okręgi o(O₁,r₁) i o(O₂,r₂) przecinają się wtedy i tylko wtedy, gdy",
                "Okręgi o(O₁,r₁) i o(O₂,r₂) są styczne wewnętrznie wtedy i tylko wtedy, gdy",
                "Okręgi o(O₁,r₁) i o(O₂,r₂) są rozłączne wewnętrznie wtedy i tylko wtedy, gdy"
            };

            string[] Wzory =
            {
                "|O₁O₂| > r₁ + r₂",
                "|O₁O₂| = r₁ + r₂",
                "|r₁ - r₂| < |O₁O₂| < r₁ + r₂",
                "|O₁O₂| = |r₁ - r₂| ≠ 0",
                "|O₁O₂| < |r₁ - r₂|"
            };
            
            Dane[] dane =
            {
                new Dane(5,3,10),
                new Dane(5,3,8),
                new Dane(5,3,6),
                new Dane(5,3,2),
                new Dane(5,3,1)
            };

            twTextBox.Text = Twierdzenia[twDropDown.SelectedIndex];
            twWzor.Text = Wzory[twDropDown.SelectedIndex];
            promien1num.Value = (decimal)dane[twDropDown.SelectedIndex].promien1;
            promien2num.Value = (decimal)dane[twDropDown.SelectedIndex].promien2;
            distanceNum.Value = (decimal)dane[twDropDown.SelectedIndex].odleglosc;
            promien1 = (float)promien1num.Value;
            promien2 = (float)promien2num.Value;
            odleglosc = (float)distanceNum.Value/2;

            this.Refresh();
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // int pos = path.IndexOf("\\bin");
            // if (pos >= 0) 
            //{ 
            // path = path.Remove(pos);
            //path += $"\\img\\{twDropDown.SelectedIndex + 1}.png";

            // twZdj.Image = Image.FromFile(path);
            // }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float multipler = 100;
            float mid1 = 350;
            float y = 300;
            float mid2 = 350 + odleglosc * multipler;
            Font drawFont = new Font("Arial", 16);

            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.LightBlue);
            Pen pen2 = new Pen(Color.Pink);
            Pen pen3 = new Pen(Color.Yellow);
            Brush brush1 = new SolidBrush(Color.LightBlue);
            Brush brush2 = new SolidBrush(Color.Pink);
            Brush brush3 = new SolidBrush(Color.Yellow);
            g.DrawEllipse(pen1,
                mid1 - promien1 * multipler / 2,
                y - promien1 * multipler / 2,
                promien1 * multipler,
                promien1 * multipler
                );
            g.DrawEllipse(pen2,
                mid2 - promien2 * multipler / 2,
                y - promien2 * multipler / 2,
                promien2 * multipler,
                promien2 * multipler
                );
            if (promien1 != 0 || promien2 != 0) g.DrawLine(pen3, mid1, y, mid1+1, y);
            if (promien1 != 0 && promien2 != 0) g.DrawLine(pen3, mid1, y, mid2, y);
            if(promien1 != 0 && (mid1 != mid2 || promien2 == 0)) g.DrawString("O₁", drawFont, brush3, mid1, y);
            if(promien2 != 0 && mid1 != mid2) g.DrawString("O₂", drawFont, brush3, mid2, y);
            if(promien1 != 0 && promien1 != 0 && mid1 == mid2) g.DrawString("O", drawFont, brush3, 350, y);

            g.DrawLine(pen1, mid1, y, mid1, y + promien1 * multipler / 2);
            if (promien1 != 0 && (mid1 != mid2 || promien2 == 0)) g.DrawString("r₁", drawFont, brush1, mid1, y + promien1 * multipler / 4);
            g.DrawLine(pen2, mid2, y, mid2, y + promien2 * multipler / 2);
            if (promien1 != 0 && (mid1 != mid2 || promien2 == 0)) g.DrawString("r₂", drawFont, brush2, mid2, y + promien2 * multipler / 4);
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            promien1 = (float)promien1num.Value;
            promien2 = (float)promien2num.Value;
            odleglosc = (float)distanceNum.Value/2;

            this.Refresh();
        }

        private void promien1Box_Enter(object sender, EventArgs e)
        {

        }
    }
}
