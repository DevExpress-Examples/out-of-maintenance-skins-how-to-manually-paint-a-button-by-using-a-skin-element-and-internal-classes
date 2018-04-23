using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DXApplication191.Properties;

namespace DXApplication191 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        SkinButtonPaintHelper helper;
        public Form1() {
            InitializeComponent();
            helper = new SkinButtonPaintHelper() {
                ButtonImage = Resources.open_32x32,
                ButtonRectangle = new Rectangle(5, 5, 200, 80),
                ButtonText = "Manually painted"
            };
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            helper.DrawButton(e, ObjectState.Normal);
        }
    }

}
