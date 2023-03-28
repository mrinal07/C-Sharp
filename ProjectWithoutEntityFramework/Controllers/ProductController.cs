using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectWithoutEntityFramework.Models;
using System.Data;
using System.Data.SqlClient;


namespace ProjectWithoutEntityFramework.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MvcCrudDB; Integrated Security=True";

        // GET: ProductController
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Product", sqlCon);
                dataAdapter.Fill(dataTable);

            }
            return View(dataTable);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel productModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Insert into product values(@ProductName,@Price,@Count)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

                sqlCommand.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlCommand.Parameters.AddWithValue("@Price", productModel.Price);
                sqlCommand.Parameters.AddWithValue("@Count", productModel.Count);

                sqlCommand.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel productModel = new ProductModel();
            DataTable dblProduct = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open(); 
                string query = "Select * from Product where ProductId = @ProductId";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                sqlDa.Fill(dblProduct);
            }

            if (dblProduct.Rows.Count == 1)
            {
                productModel.ProductId = Convert.ToInt32(dblProduct.Rows[0][0].ToString());
                productModel.ProductName = dblProduct.Rows[0][1].ToString();
                productModel.Price = Convert.ToDecimal(dblProduct.Rows[0][2].ToString());
                productModel.Count = Convert.ToInt32(dblProduct.Rows[0][3].ToString());
                return View(productModel);
            }
            else
            {
                return RedirectToAction("Index");

            }
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductModel productModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Update Product SET ProductName = @ProductName, Price = @Price, Count = @Count Where ProductId = @ProductId ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

                sqlCommand.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                sqlCommand.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlCommand.Parameters.AddWithValue("@Price", productModel.Price);
                sqlCommand.Parameters.AddWithValue("@Count", productModel.Count);

                sqlCommand.ExecuteNonQuery();
            }

            return RedirectToAction("Index");
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Delete from Product where ProductId = @ProductId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);

                sqlCommand.Parameters.AddWithValue("@ProductId", id);
                

                sqlCommand.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
