using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_OOP
{
    public partial class Form1 : Form
    {
        //CRUD crud =new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //create data

            //using Parametered Constructors
            string input1 = Name.Text;
            string input2 = Mobile.Text;
            string input3 = Address.Text;
            CRUD crud = new CRUD(input1, input2, input3);
            crud.CreateData();

            //crud.Name = Name.Text;
            //crud.Mobile = Mobile.Text;
            //crud.Address = Address.Text;
            //crud.CreateData();
        }

        //private void update_Click(object sender, EventArgs e)
        //{
        //    //update data
        //    crud.Name = Name.Text;
        //    crud.Mobile = Mobile.Text;
        //    crud.Address = Address.Text;
        //    crud.UpdateData();
        //}

        //private void delete_Click(object sender, EventArgs e)
        //{
        //    //delete data
        //    crud.Name = Name.Text;
        //    crud.DeleteData();

        //}
    }
}
