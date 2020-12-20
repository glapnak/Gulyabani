using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Gulyabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolesDataGridView.Rows.Clear();
            Roles roles = new Roles();
            //var test = roles.GameRoles;
            int value = comboBox1.SelectedIndex+6;
            List<string> selectedRoles = new List<string>();
            int i = 0;

            
            foreach (var item in roles.GameRoles)
            {
                var index = Array.IndexOf(item.Limit, value);
                var count = item.Count[index];
                for (i = 0; i < count; i++)
                {
                    selectedRoles.Add(item.Name);
                }
                if (selectedRoles.Count >= value) break;

                    
            }
            Random rnd = new Random();
            string[] randomizedRoles = selectedRoles.OrderBy(x=>rnd.Next()).ToArray();
            var users = listBox1.Items;
            
            for (i = 0; i < value; i++)
            {
                string item = randomizedRoles[i];
                string user = users[i].ToString();
                rolesDataGridView.Rows.Add(item, user);
            }

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

            
        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
                usersTotalCountLbl.Text = listBox1.Items.Count.ToString();
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                listBox1.Items.RemoveAt(secim);
                usersTotalCountLbl.Text = listBox1.Items.Count.ToString();

            }
            else
            {
                MessageBox.Show("Seçim Yapın!");
            }


        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void rolesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

       


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                MessageBox.Show("Korundu");
                MessageBox.Show("Günlerini takip et");

            }

            else
            {


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Aşık Öldürüldü");
                MessageBox.Show("Diğer Aşığı idam et");

            }

            else
            {


            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox2.Checked == true)
            {
                MessageBox.Show("Aşık Öldürüldü");
                MessageBox.Show("Diğer Aşığı idam et");
                checkBox1.Checked=(true);
            }

            else
            {


            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                MessageBox.Show("Gündelik Gulyabani dedi");
                MessageBox.Show("Hergün kontrol et");
                
            }

            else
            {


            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                MessageBox.Show("Gulyabani avladı");
                MessageBox.Show("Hak kı bitti");
                
            }

            else
            {


            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                MessageBox.Show("Korundu");
                MessageBox.Show("Günlerini takip et");
               
            }

            else
            {


            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                MessageBox.Show("Korundu");
                MessageBox.Show("Günlerini takip et");

            }

            else
            {


            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                MessageBox.Show("1.Gün Doldu");
                MessageBox.Show("Günlerini takip et");

            }

            else
            {


            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                MessageBox.Show("2.Gün Doldu");
                MessageBox.Show("Günlerini takip et");

            }

            else
            {


            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                MessageBox.Show("3.Gün Doldu");
                MessageBox.Show("Günlerini takip et");

            }

            else
            {


            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                MessageBox.Show("Kafaya takılan kişi öldü");
                MessageBox.Show("Ölenleri takip et");

            }

            else
            {


            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox11.Checked == true)
                {
                    MessageBox.Show("Kafaya takılan kişi öldü");
                    MessageBox.Show("Ölenleri takip et");

                }

                else
                {


                }
            }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                MessageBox.Show("Kafaya takılan kişi öldü");
                MessageBox.Show("Ölenleri takip et");

            }

            else
            {


            }
        }

        private void rolesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
          


        }

        private void rolesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rolesDataGridView_SelectionChanged(object sender, EventArgs e)
        {

           


        }

        private void rolesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rolesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

       

        private void rolesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            rolesDataGridView.SelectedRows[0].Cells[2].Value = "";




        }

        private void rolesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rolesDataGridView.SelectedRows[0].Cells[2].Value = "Öldü";


            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
