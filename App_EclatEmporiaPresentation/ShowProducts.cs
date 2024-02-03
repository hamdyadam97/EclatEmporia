using App.Application.Services;
using App.Context;
using App.Infrastructure.Repositories;
using App.Models.Models;

namespace App_EclatEmporiaPresentation
{
    public partial class ShowProducts : Form
    {
        ShowProductService showProductService = new ShowProductService(new ShowProductRepositry(new StoreContext()));
        ProductService productService = new ProductService(new ProductRepository(new StoreContext()));
        CartProductServices CartProductServices = new CartProductServices(new CartRepositry(new StoreContext()));
        public User user { get; set; }
        public ShowProducts()
        {
            InitializeComponent(); ;




            var result = showProductService.GetCategories();
            foreach (var category in result)
            {
                comboBox1.Items.Add(category.CategoryName);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var selectedProduct = listView1.SelectedItems[0];
                    if (selectedProduct is null) return;
                    var productStringId = selectedProduct.Text;
                    var productId = Convert.ToInt32(productStringId);
                    var Product = productService.GetProductById(productId);
                    if (Product is null)
                        return;
                    textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
                    textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    MemoryStream stream = new MemoryStream(Product.Image ?? new List<byte>().ToArray());
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var Products = productService.GetProducts();

            foreach (var Product in Products)
            {
                if (Product.StockQuantity > 0)
                {
                    //var stream = new MemoryStream(Product.Image);
                    var item = listView1.Items.Add(Product.ProductID.ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.ProductName);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Description);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Price.ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.StockQuantity.ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.DateAdded.ToString());
                }
            }
            textBox5.Text = CartProductServices.GetCart(SessionData.Instance.user.UserID).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //Id
                var selectedProduct = listView1.SelectedItems[0];
                if (selectedProduct is null) return;
                var productStringId = selectedProduct.Text;
                var productId = Convert.ToInt32(productStringId);

                //Quantity
                var QuantityProduct = listView1.SelectedItems[0].SubItems[4];
                var QuantityProductstring = QuantityProduct.Text;
                var QuantityProductInt = Convert.ToInt32(QuantityProductstring);
                if (QuantityProductInt > 0)
                {
                    if (showProductService.check(productId, showProductService.usercartid(SessionData.Instance.user.UserID)) 
                        && !CartProductServices.CartStats(productId, showProductService.usercartid(SessionData.Instance.user.UserID)))
                    {
                        productService.updateQuantityProduct(productId);
                        showProductService.updateQuantity(productId, showProductService.usercartid(SessionData.Instance.user.UserID));
                        MessageBox.Show("The Product Added Successfully");
                    }
                    else if(showProductService.check(productId, showProductService.usercartid(SessionData.Instance.user.UserID))
                        && CartProductServices.CartStats(productId, showProductService.usercartid(SessionData.Instance.user.UserID)))
                    {
                        CartProductServices.UpdateCart(productId, showProductService.usercartid(SessionData.Instance.user.UserID));
                        productService.updateQuantityProduct(productId);
                        showProductService.updateQuantity(productId, showProductService.usercartid(SessionData.Instance.user.UserID));
                        MessageBox.Show("The Product Added Successfully");
                    }
                    else
                    {
                        if (CartProductServices.SearchCart(SessionData.Instance.user.UserID))
                        {
                            CartProductServices.AddCartProduct(new CartProducts()
                            {
                                ProductID = productId,
                                CartID = showProductService.usercartid(SessionData.Instance.user.UserID)

                            });
                            productService.updateQuantityProduct(productId);
                            showProductService.updateQuantity(productId, showProductService.usercartid(SessionData.Instance.user.UserID));
                            MessageBox.Show("The Product Added Successfully");
                        }
                        else
                        {
                            CartProductServices.AddCart(new Cart() { UserID = SessionData.Instance.user.UserID });
                            CartProductServices.AddCartProduct(new CartProducts()
                            {
                                ProductID = productId,
                                CartID = showProductService.usercartid(SessionData.Instance.user.UserID),
                                

                            });
                            productService.updateQuantityProduct(productId);
                            showProductService.updateQuantity(productId , showProductService.usercartid(SessionData.Instance.user.UserID));
                            MessageBox.Show("The Product Added Successfully");
                        }
                    }
                    ShowProducts_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Out of Stock");

                }
                textBox5.Text = CartProductServices.GetCart(SessionData.Instance.user.UserID).ToString();

            }
            else
            {
                MessageBox.Show("Please select the product");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ShowCart showCart = new ShowCart();
            //showCart.Show();
            ShowCart myOrders = new ShowCart();
            myOrders.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox1.SelectedItem == null) return;
            var productcat = showProductService.GetProductsByCat(comboBox1.SelectedItem.ToString());
            foreach (var item in productcat)
            {
                listView1.Items.Add(item.ProductID.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.ProductName);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.Description);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.Price.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.StockQuantity.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.DateAdded.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var productList = showProductService.GetProductByName(textBox1.Text);

            listView1.Items.Clear();

            foreach (var Product in productList)
            {
                listView1.Items.Add(Product.ProductID.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.ProductName);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Description);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.Price.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.StockQuantity.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Product.DateAdded.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
