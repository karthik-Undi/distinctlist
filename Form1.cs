using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distinctlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] myBooks = {"Wings of Fire", "For Me the life is..","Ponniyin Selvan",
                                "Harry's Dairy", "Life Drums", "Ponniyin Selvan","Happy Love Story",
                                "For Me the life is..", "Harry's Dairy", "Ponniyin Selvan" };

            string[] DistinctBooks = myBooks.Distinct().ToArray<String>();

            foreach(String book in DistinctBooks)
            comboBox1.Items.Add(book);
        }
    }
}
