using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Shop.Entities;
using My_Shop.Helpers;
using My_Shop.Models;

namespace My_Shop.Services
{
    public class ProductService
	{
        private readonly MyShopContext whContext;

        public ProductService()
        {
             whContext = new MyShopContext();
        }

        public List<ProductModel> GetProductByName(string name)
        {
            List<ProductModel> products = new List<ProductModel>();
            
            if (name != string.Empty)
            {
			    var request = whContext.Products.Where(p => p.Name.ToUpper().Contains(name.ToUpper())).ToList();
                foreach (var product in request) 
                {
                    products.Add( new ProductModel() 
                    {
                        Name = product.Name,
                        Code = product.Code,
                        Quantity = product.Quantity,
                        Price = product.Price
                    } );
                }

            }
			return products;
		}

        public List<ProductModel> AddProductToPackage(List<ProductModel> order,string code, int quantity, out int returnCode)
        { 

            if (code != string.Empty && quantity > 0)
            {
                
               var product = whContext.Products.Where( p => p.Code == code).FirstOrDefault();
                if (product!= null && product.Quantity > quantity)
                {
                    ProductModel productForBuy = new ProductModel() 
                    {
                        Name = product.Name,
                        Code = product.Code,
                        Quantity = quantity,
                        Price = product.Price
                    };
                    returnCode = 0; 
                    order.Add( productForBuy ); 
                    
                }
                else
                {
                    returnCode = 1;
                }
                
            }
            else
            {               
                returnCode = 2;
            }

            return order;
        }


        public void BuyOrderFromShop(List<ProductModel> order)
        {
            if (order.Any())
            {
                try
                {
                    foreach (var item in order)
                    {
                        var product = whContext.Products.Where(p => p.Code == item.Code).FirstOrDefault();
                        if (product != null)
                        {
                            product.Quantity -= item.Quantity;
                        }
                        else continue;
                    } 

                    whContext.SaveChanges();
                    order.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        public bool AddProductToStorage( string code, string name, string price , string quantity)
        { 
            if (!string.IsNullOrWhiteSpace(code) 
                && !string.IsNullOrWhiteSpace(name)
                && !string.IsNullOrWhiteSpace(price)
                && !string.IsNullOrWhiteSpace(quantity)) 
            {
                bool priceOk = decimal.TryParse(price, out decimal priceParsed);
                bool quantityOk = int.TryParse(quantity, out int quantityParsed);
                if (priceOk && quantityOk)
                {
                    Product productForAdd = new Product()
                    {
                        Code = code,
                        Name = name,
                        Price = priceParsed,
                        Quantity = quantityParsed,
                    };
                   
                    whContext.Products.Add(productForAdd);
                    whContext.SaveChanges();  
                    return true;
                }
                else
                    return false;
            }
            else 
                return false;
        }

        public bool RemoveProductFromStorage(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var productForRemove = whContext.Products.Where(p => p.Code == code).FirstOrDefault();
                if (productForRemove != null)
                {
                    
                   whContext.Products.Remove(productForRemove);
                   whContext.SaveChanges();
                   return true;
                    
                }
                else return false;
            }
            else
                return false;
        }

        public List<ProductModel> ShowProductsInStorage()
        {
            List<ProductModel> products = new List<ProductModel>();

            var request = whContext.Products.ToList();
            foreach (var product in request)
            {
               products.Add(new ProductModel()
               {
                  Code = product.Code,
                  Name = product.Name,
                  Price = product.Price,
                  Quantity = product.Quantity,
               });
            }

            return products;
            
        }
    }
}
