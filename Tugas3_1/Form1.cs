﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3_1
{
    public partial class frmTugas32 : Form
    {
        public frmTugas32()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Hall {0}", nama);
            txtPesan2.Text = string.Format("Pendidkan anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0} hebat", pekerjaan);
        }
    }
}
