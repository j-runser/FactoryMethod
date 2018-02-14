using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        private DesktopFactory factory_desktop;
        private LaptopFactory factory_laptop;
        private Product product;

        public Form1()
        {
            InitializeComponent();

            factory_desktop = new DesktopFactory();
            factory_laptop = new LaptopFactory();
        }

        private void btn_laptop_Click(object sender, EventArgs e)
        {
            product = factory_laptop.CreateComputer();
            PopulateTextBox();
        }

        private void lbl_desktop_Click(object sender, EventArgs e)
        {
            product = factory_desktop.CreateComputer();
            PopulateTextBox();
        }

        private void PopulateTextBox()
        {
            string str_tmp = "" +
                product.GetType + "\n" +
                product.GetCPU + "\n" +
                product.GetRAM + "\n" +
                product.GetGPU;

            rTxtBox_display.Text = str_tmp;
        }
    }
}
