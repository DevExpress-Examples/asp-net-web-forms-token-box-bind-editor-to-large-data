using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public Product()
    { }

    public Product(int id, string name)
    {
        ProductID = id;
        ProductName = name;
    }
}

public partial class _Default : System.Web.UI.Page
{
    [WebMethod()]
    public static IEnumerable<Product> GetData()
    {
        var returnList = new List<Product>
            {
                new Product(10010, "Toys"),
                new Product(10020, "Books"),
                new Product(10030, "Cars"),
                new Product(10040, "Cars2"),
                new Product(10050, "Cars3"),
                new Product(10060, "Trucks"),
                new Product(10070, "Bikes"),
                new Product(20000, "Pets"),
                new Product(20002, "Dogs"),
                new Product(20004, "Cats"),
                new Product(20006, "Fish")
            };
        for (int i = 0; i < 10000; i++)
        {
            returnList.Add(new Product(i, "John Doe" + i++));
            returnList.Add(new Product(i, "Jane Doe" + i++));
            returnList.Add(new Product(i, "Michael Doe" + i++));
            returnList.Add(new Product(i, "Lana Doe" + i));
        }
        return returnList;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    [WebMethod()]
    public static List<Product> GetFilteredData(string str)
    {
        if (!string.IsNullOrEmpty(str))
            return GetData().Where(p => p.ProductName.ToLower().Contains(str.ToLower())).Take(10).ToList();
        else
            return null;
    }
}