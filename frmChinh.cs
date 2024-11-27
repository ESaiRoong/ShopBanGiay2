using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopBanGiay
{
    public partial class frmChinh : Form
    {
        public List<Shoes> shoesList = new List<Shoes>();
        
        public frmChinh()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }
       
        

        

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            
            
        }

       

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmTimKiemNangCao frmnc = new frmTimKiemNangCao())
            {
               
                frmnc.StartPosition = FormStartPosition.CenterParent;

           
                frmnc.ShowDialog(this);
            }
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            using (frmThemSl frmsl = new frmThemSl())
            {
              
                frmsl.StartPosition = FormStartPosition.CenterParent;

             
                frmsl.ShowDialog(this);
            }
        }

        

        
       

        private void btnListReset_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
