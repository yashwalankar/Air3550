﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = FormDatabaseHelper.getAvailableFlights("ANC", "FAR", DateTime.Now);

        }

        
    }
}
