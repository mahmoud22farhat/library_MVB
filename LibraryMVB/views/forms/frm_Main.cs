﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace LibraryMVB.views.forms
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }  private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
 frm_category frm = new frm_category();
            frm.ShowDialog();
        }
           private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
                {
           
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
                frm_Bookplaces frm = new frm_Bookplaces();
            frm.ShowDialog();
        }

      
    }
}