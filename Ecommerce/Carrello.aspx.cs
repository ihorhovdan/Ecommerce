using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCartItems();
            }
        }

        private void LoadCartItems()
        {
            List<int> product = (List<int>)Session["ProductID"];
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Prezzo", typeof(double));

            if (product != null)
            {
                foreach (int id in product)
                {
                    try
                    {
                        Dbconn.conn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT * FROM Prodotti WHERE ID='{id}'", Dbconn.conn);
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            dt.Rows.Add(dataReader["ID"], dataReader["Nome"], dataReader["Prezzo"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                    finally
                    {
                        if (Dbconn.conn.State == ConnectionState.Open)
                        {
                            Dbconn.conn.Close();
                        }
                    }
                }
            }

            rptCartItems.DataSource = dt;
            rptCartItems.DataBind();

            double totCart = GetTotalCartAmount(product);
            contentTot.InnerHtml = $"<h2>Totale: {totCart}€</h2>";
        }

        private double GetTotalCartAmount(List<int> productIds)
        {
            double totalAmount = 0;

            if (productIds != null)
            {
                foreach (int id in productIds)
                {
                    try
                    {
                        Dbconn.conn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT Prezzo FROM Prodotti WHERE ID='{id}'", Dbconn.conn);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            totalAmount += Convert.ToDouble(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                    }
                    finally
                    {
                        if (Dbconn.conn.State == ConnectionState.Open)
                        {
                            Dbconn.conn.Close();
                        }
                    }
                }
            }

            return totalAmount;
        }

        protected void rptCartItems_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                List<int> product = (List<int>)Session["ProductID"];

                if (product != null)
                {
                    product.Remove(productId);
                    Session["ProductID"] = product;
                    LoadCartItems(); // Ricarica gli elementi del carrello dopo l'eliminazione
                }
            }
        }
    }
}