using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_OOP
{
    class CRUD
    {
        Connection sqlConn = new Connection();

        //Using Constructors to initiate variables
        //private string _name;
        //private string _mobile;
        //private string _address;
        //public CRUD(string input1, string input2, string input3)
        //{
        //    _name = input1;
        //    _mobile = input2;
        //    _address = input3;
        //}

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _mobile;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public void CreateData()
        {
            //Create Data

            //inputting values initiated in the constructor into the datatbase
            //SqlCommand sqlcmd = new SqlCommand("SaveRecords", sqlConn.ActivateConn());
            //sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            //sqlcmd.Parameters.AddWithValue("@Name", _name.Trim());
            //sqlcmd.Parameters.AddWithValue("@Mobile", _mobile.Trim());
            //sqlcmd.Parameters.AddWithValue("@Address", _address.Trim());
            //sqlcmd.ExecuteNonQuery();

            //MessageBox.Show("Records Saved Successfully", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //sqlConn.ActivateConn().Close();



            SqlCommand sqlcmd = new SqlCommand("SaveRecords", sqlConn.ActivateConn());
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Name", Name.Trim());
            sqlcmd.Parameters.AddWithValue("@Mobile", Mobile.Trim());
            sqlcmd.Parameters.AddWithValue("@Address", Address.Trim());
            sqlcmd.ExecuteNonQuery();

            MessageBox.Show("Records Saved Successfully", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConn.ActivateConn().Close();

        }

        public void UpdateData()
        {
            //Update Data

            SqlCommand sqlcmd = new SqlCommand("UpdateData", sqlConn.ActivateConn());
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Name", Name.Trim());
            sqlcmd.Parameters.AddWithValue("@Mobile", Mobile.Trim());
            sqlcmd.Parameters.AddWithValue("@Address", Address.Trim());
            sqlcmd.ExecuteNonQuery();

            MessageBox.Show("Records Updated Successfully", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConn.ActivateConn().Close();
        }

        public void DeleteData()
        {
            //Delete Data

            SqlCommand sqlcmd = new SqlCommand("DeleteData", sqlConn.ActivateConn());
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

            sqlcmd.Parameters.AddWithValue("@Name", Name.Trim());


            sqlcmd.ExecuteNonQuery();

            sqlConn.ActivateConn().Close();

            MessageBox.Show("Records Deleted Successfully", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sqlConn.ActivateConn().Close();
        }
    }
}
