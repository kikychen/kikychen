﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace facility_booking7a
{
    public partial class _2_Add_Member : Form
    {
        public _2_Add_Member()
        {
            InitializeComponent();
        }

        private void MemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void MIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            facility7a0Entities ctx = new facility7a0Entities();
            using (TransactionScope ts = new TransactionScope())
            {
                int PC = Convert.ToInt32(PCTextBox.Text);
                double PN= Convert.ToDouble(ConTextBox.Text);
                int ID = Convert.ToInt32(MemTextBox.Text);

                Member mem = new Member();
                
                mem.FirstName = MIDTextBox.Text;
                mem.LastName = MNameTextBox.Text;
                mem.TitleOfCountery = comboBox1.Text;               
                mem.Address = AddressTextBox.Text;
                mem.PostalCode = PC;
                mem.PhoneNumber = PN ;
                mem.EmailAddress = EmialTextBox.Text;
                mem.MemberID = ID;

                ctx.Members.Add(mem);
                ctx.SaveChanges();
                ts.Complete();
            }

            this.Close();
           
            


        }

       
    }
}
