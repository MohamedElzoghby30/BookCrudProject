using MyApplication.ObjectDB;
using MyApplication.ServicerLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApplication
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            GridView1.DataSource= BookServiceLayer.GetAllBooks();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow; 
          
            tbBookName.Text = row.Cells[2].Text;
            tbDescreption.Text= row.Cells[4].Text;
            tbPrice.Text= row.Cells[3].Text;
            tbID.Text= row.Cells[1].Text;
            tbID.Visible = true;
            lbID.Visible = true;
            bAdd.Visible= false;
            bUpdate.Visible= true;
            bDelete.Visible= true;

        }

        protected void bCancel_Click(object sender, EventArgs e)
        {
            tbBookName.Text = tbDescreption.Text = tbPrice.Text = "";
            tbID.Visible = false;
            lbID.Visible = false;
            bUpdate.Visible = false;
            bDelete.Visible = false;
            bAdd.Visible = true;
        }

        protected void bDelete_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null&& tbID.Text!=null)
            {
                int Id =int.Parse( tbID.Text);
                var res= BookServiceLayer.DeletBook(Id);
                LResult.Text = res==false?"Cant Delete Row":"The Rpw Deleted";
                LResult.Visible = true;
                GridView1.DataSource = BookServiceLayer.GetAllBooks();
                GridView1.DataBind();
                tbBookName.Text = tbDescreption.Text = tbPrice.Text = "";

            }
                

        }

        protected void bAdd_Click(object sender, EventArgs e)
        {
            Book  book = new Book();
            book.BookName=tbBookName.Text;
            book.Price=decimal.Parse(tbPrice.Text);
            book.BookDescription=tbPrice.Text;
          var res=  BookServiceLayer.AddBook(book);
            LResult.Text = res == false ? "Cant Add Row" : "The Row Added";
            GridView1.DataSource = BookServiceLayer.GetAllBooks();
            GridView1.DataBind();
            tbBookName.Text = tbDescreption.Text = tbPrice.Text = "";
        }

        protected void bUpdate_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedRow != null && tbID.Text != null)
            {
                int Id = int.Parse(tbID.Text);
               
                Book book = new Book();
                book.BookId=Id;
                book.BookName = tbBookName.Text;
                book.Price = decimal.Parse(tbPrice.Text);
                book.BookDescription = tbPrice.Text;
                var res = BookServiceLayer.UpdateBook(book);
                LResult.Text = res == false ? "Cant Delete Row" : "The Rpw Deleted";
                LResult.Visible = true;
                GridView1.DataSource = BookServiceLayer.GetAllBooks();
                GridView1.DataBind();
                tbBookName.Text = tbDescreption.Text = tbPrice.Text = "";

            }
        }
    }
}