using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT03_Listview
{
    public partial class frm_listview : Form
    {
        public frm_listview()
        {
            InitializeComponent();
        }

        private void frm_listview_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string lastName = item.SubItems[0].Text;
                string firstName = item.SubItems[1].Text;
                string phone = item.SubItems[2].Text;
                MessageBox.Show("Last Name: " + lastName + "\nFirst Name: " + firstName + "\nPhone: " + phone, "Selected Item");
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];

                    txtlastnamee.Text = selectedItem.SubItems[0].Text;

                    txtfirstnamee.Text = selectedItem.SubItems[1].Text;

                    txtphonee.Text = selectedItem.SubItems[2].Text;
                }
                else
                {
                    txtlastnamee.Clear();
                    txtfirstnamee.Clear();
                    txtphonee.Clear();
                }
            }
        }

        private void btnaddname_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlastnamee.Text) ||
                string.IsNullOrEmpty(txtfirstnamee.Text) ||
                string.IsNullOrEmpty(txtphonee.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            ListViewItem item = new ListViewItem(txtlastnamee.Text);

            item.SubItems.Add(txtfirstnamee.Text);
            item.SubItems.Add(txtphonee.Text);  
            listView1.Items.Add(item);

            txtlastnamee.Clear();
            txtfirstnamee.Clear();
            txtphonee.Clear();
            txtLastName.Focus();
        }
    }
}
