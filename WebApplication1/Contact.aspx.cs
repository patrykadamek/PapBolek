using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        static string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-WebApplication1-20170402081813.mdf;Initial Catalog=aspnet-WebApplication1-20170402081813;Integrated Security=True";
        string userName = HttpContext.Current.User.Identity.Name;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string login = GridView3.SelectedRow.Cells[0].Text;   //wybieram z każdej kolumny pierwszy rzad jako parametr login
            string query = "Insert into [AspNetUserRoles] (UserId, RoleId) values (@Login, @Rola)";
            using (SqlConnection polacz = new SqlConnection(connectionString))
            using (SqlCommand komenda = new SqlCommand(query, polacz))
            {
                komenda.Parameters.Add("@Login", SqlDbType.VarChar, 50).Value = login;
                komenda.Parameters.Add("@Rola", SqlDbType.VarChar, 1).Value = "2";  //Wprowadzam 2 do bazy, co przypisuje konkretną rolę
                polacz.Open();
                komenda.ExecuteNonQuery();
                polacz.Close();
            }
            // Page_Load(sender, e);
            GridView2.DataBind();
            GridView3.DataBind();



        }



        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string login = GridView2.SelectedRow.Cells[0].Text;
            string query = "Insert into [AspNetUserRoles] (UserId, RoleId) values (@Login, @Rola)";
            using (SqlConnection polacz = new SqlConnection(connectionString))
            using (SqlCommand komenda = new SqlCommand(query, polacz))
            {
                komenda.Parameters.Add("@Login", SqlDbType.VarChar, 50).Value = login;
                komenda.Parameters.Add("@Rola", SqlDbType.VarChar, 1).Value = "3";
                polacz.Open();
                komenda.ExecuteNonQuery();
                polacz.Close();
            }
            //  Page_Load(sender, e);

            GridView3.DataBind();
            GridView2.DataBind();


        }
    }
}