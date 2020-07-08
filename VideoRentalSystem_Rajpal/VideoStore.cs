using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem_Rajpal
{
    public partial class VideoStore : Form
    {
        public VideoStore()
        {
            InitializeComponent();
            CustomerList();
            MovieList();
            RentalList();
        }

        private void CustomerList()//customer list
        {
            gridViewCustomers.DataSource = VideoRentalSystem_Rajpal_Class.Find_All_Customers();
        }
        private void MovieList()//movies list
        {
            gridViewMovies.DataSource = VideoRentalSystem_Rajpal_Class.Find_All_Movies();
        }

        private void RentalList()//rental list
        {
            gridViewRental.DataSource = VideoRentalSystem_Rajpal_Class.Get_Pending_Rentals();
        }

        private void customerAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMobile.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                VideoRentalSystem_Rajpal_Class.Add_Customer(txtName.Text, txtMobile.Text, txtAddress.Text);
                MessageBox.Show("New Customer Added");
                CustomerList();
                //Dispose();
            }
        }

        private void customerUpdate_Click(object sender, EventArgs e)
        {
            VideoRentalSystem_Rajpal_Class.Edit_Customer(txtName.Text, txtMobile.Text, txtAddress.Text, lblCustomer.Text);
            MessageBox.Show("Customer Updated");
            CustomerList();
            //Dispose();
        }

        private void customerDelete_Click(object sender, EventArgs e)
        {
            VideoRentalSystem_Rajpal_Class.Delete_Customer(lblCustomer.Text);
            MessageBox.Show("Customer Deleted");
            //Dispose();
            CustomerList();
        }

        private void videoAdd_Click(object sender, EventArgs e)
        {
            int a, b;

            if (txtMovieName.Text == "" || textPoints.Text == "" || textYear.Text == "" || textCopies.Text == "" || textReleased.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else if (!int.TryParse(textYear.Text, out a) || !(int.TryParse(textCopies.Text, out b)))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }

                VideoRentalSystem_Rajpal_Class.Add_Movie(txtMovieName.Text, textPoints.Text, Convert.ToInt32(textYear.Text), Convert.ToInt32(textCopies.Text), textReleased.Text, rental);
                MessageBox.Show("New Movie Added");
            }
        }

        private void videoUpdate_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(textYear.Text, out a))
            {
                MessageBox.Show("Year and Copies must be a valid integer");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }
                VideoRentalSystem_Rajpal_Class.Edit_Movie(txtMovieName.Text, textPoints.Text, Convert.ToInt32(textYear.Text), Convert.ToInt32(textCopies.Text), textReleased.Text, rental, lblVideo.Text);
                MessageBox.Show("Movie Updated");
                //Dispose();
            }
            MovieList();
        }

        private void videoDelete_Click(object sender, EventArgs e)
        {
            VideoRentalSystem_Rajpal_Class.Delete_Movie(lblVideo.Text);
            MessageBox.Show("Movie Deleted");
            //Dispose();
            MovieList();
        }

        private void movieIssue_Click(object sender, EventArgs e)
        {
            VideoRentalSystem_Rajpal_Class.Add_Rental_Record(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text));
            MessageBox.Show("Movie Rented");
            RentalList();
        }

        private void movieReturn_Click(object sender, EventArgs e)
        {
            VideoRentalSystem_Rajpal_Class.Update_Return_Record(Convert.ToDateTime(DateTime.Now.ToString()), lblRentalArea.Text);
            MessageBox.Show("Movie Returned");
            RentalList();
        }

        private void gridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.gridViewCustomers.Rows[e.RowIndex];
                lblCustomer.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtMobile.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            }
        }

        private void gridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.gridViewMovies.Rows[e.RowIndex];
                var a = row.Cells[0].Value.ToString();
                txtMovieName.Text = row.Cells[1].Value.ToString();
                textPoints.Text = row.Cells[2].Value.ToString();
                textYear.Text = row.Cells[3].Value.ToString();
                textCopies.Text = row.Cells[4].Value.ToString();
                textReleased.Text = row.Cells[5].Value.ToString();
            }
        }

        private void gridViewRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gridViewRental.Rows[e.RowIndex];
            lblRentalArea.Text = row.Cells[0].Value.ToString();
            comboBox1.SelectedItem = row.Cells[1].Value.ToString();
            comboBox2.SelectedItem = row.Cells[2].Value.ToString();
        }

        private void VideoStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalSystem_RajpalDataSet1.Videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.Fill(this.videoRentalSystem_RajpalDataSet1.Videos);
            // TODO: This line of code loads data into the 'videoRentalSystem_RajpalDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.videoRentalSystem_RajpalDataSet.Customers);

        }
    }
}
