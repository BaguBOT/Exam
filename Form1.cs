using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indinok
{
    public partial class Form1 : Form
    {
        public dataotdel _otdelata;
        public Form1()
        {
            InitializeComponent();
            _otdelata = new dataotdel();
            _otdelata.Initialize();
            Data.DataSource = _otdelata.Otdel.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Data> _Find = _otdelata.Otdel.Where(x => x.OtdelName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            Data.DataSource = _Find;

        }
    }
}
