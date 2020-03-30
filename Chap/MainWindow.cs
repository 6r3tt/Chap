using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Chap
{
    public partial class MainWindow : Form
    {
        int iMessageCount;
        string strTextPath = "..\\writeread.txt";
        
        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            var line = rtbMessageLog.Lines;

            if(rtbMessageLog.Text == "")
            {
                rtbMessageLog.AppendText(DateTime.Now + ": " + txtEnterMessage.Text);
            } else { 
            rtbMessageLog.AppendText(Environment.NewLine + DateTime.Now + ": " + txtEnterMessage.Text);
            }

            using (StreamWriter sw = new StreamWriter(strTextPath))
            {
                foreach (string strLine in line)
                {
                    sw.WriteLine(strLine);
                }
            }
        }
    }
}
