using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=NGUYENHIEP\SQLEXPRESS;Initial Catalog=QuanLiHS-GV;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void Login_GV()
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
    }
}
