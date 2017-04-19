using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            Brush brush = new SolidBrush(ForeColor);
            int y = 20;
            grfx.DrawString("    Chương trình quản lý bán hàng", Font, brush, 0, y);
            grfx.DrawString("Tác giả: Phạm Đình Thọ",Font,brush,0,y+=Font.Height);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}