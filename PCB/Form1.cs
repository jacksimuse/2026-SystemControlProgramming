using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemControl;
using VNMCMotionSDK;

namespace sysControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ms = NMCSDKLib.MC_MasterInit(0);
            ms = NMCSDKLib.MC_MasterRUN(0);
        }

        NMCSDKLib.MC_STATUS ms;

        private void button3_Click(object sender, EventArgs e)
        {
            // 공급 후진에 신호가 있으면 공급 전진한다. 
            bool a = false;
            // 보드ID, EtherCat주소, Output 집 주소,
            // BufferInOut Input 0, Output 1, Input 방 주소, On이면 True, Off면 False
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, 4, 0, ref a);

            MessageBox.Show(a.ToString());

            if (a)
            {
                // 보드ID, EtherCat주소, Output 집 주소, Output 방 주소, On이면 True, Off면 False
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 0, true);
                ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 1, false);
            }
            
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = false;
            ms = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, 4, 0, ref a);
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 0, false);
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 1, true);
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 2, true);
             
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ms = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, 0, 2, false);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}
