using Zhuravlev_34.Forms.ClientForm;
using Zhuravlev_34.Forms.ProductForm;
using Zhuravlev_34.Forms.SellForm;

namespace Zhuravlev_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void ProductLinkListener(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.ShowDialog();
            Update();
        }

        public void ClientLinkListener(object sender, EventArgs e)
        {
            ClientForm pf = new ClientForm();
            pf.ShowDialog();
            Update();
        }
        public void SellLinkListener(object sender, EventArgs e)
        {
            SellForm pf = new SellForm();
            pf.ShowDialog();
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void operationLink_Click(object sender, EventArgs e)
        {

        }
    }
}
