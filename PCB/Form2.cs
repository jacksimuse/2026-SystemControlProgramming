using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNMCMotionSDK;

namespace SystemControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        NMCSDKLib.MC_STATUS ms;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool a = false;
            // 보드ID, EtherCat주소, Output 집 주소,
            // BufferInOut Input 0, Output 1, Input 방 주소, On이면 True, Off면 False
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 0, ref a);
            checkBox1.Checked = a;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 1, ref a);
            checkBox2.Checked = a;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 2, ref a);
            checkBox3.Checked = a;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 3, ref a);
            checkBox4.Checked = a;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
