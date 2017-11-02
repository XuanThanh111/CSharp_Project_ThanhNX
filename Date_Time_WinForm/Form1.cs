using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            DateTime first = dateTimePickerFirst.Value;
            DateTime second = dateTimePickerSecond.Value;
            
            Compare compare = new Compare();
            int diff = compare.dateCompare(first, second);
            textBox.Text = "";
            show("firstDate == secondDate", diff == 0);
            show("firstDate != secondDate", diff != 0);
            show("firstDate < secondDate", diff < 0);
            show("firstDate <= secondDate", diff <= 0);
            show("firstDate > secondDate", diff > 0);
            show("firstDate >= secondDate", diff >= 0);
            
        }

        private void show(string v1, bool v2)
        {
            textBox.Text = v1 +"\t" + v2;
        }
    }
    }

