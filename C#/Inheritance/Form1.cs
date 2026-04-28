using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string skill;
            switch (comboBox1.Text)
            {
                
                case "다리우스":
                    Dyrius dyrius = new Dyrius(comboBox1.Text, 400);
                    skill = dyrius.QWER(); // 상속을 받으면 부모의 메서드, 필드 사용 가능
                    MessageBox.Show(skill);
                    break;

                case "카타리나":
                    Katarina katarina = new Katarina(comboBox1.Text, 300);
                    skill = katarina.QWER(); // 상속을 받으면 부모의 메서드, 필드 사용 가능
                    MessageBox.Show(skill);
                    break;
            }
        }
    }
}
