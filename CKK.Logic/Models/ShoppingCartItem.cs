
namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product product;
        private int quantity;

        public ShoppingCartItem(Product productt, int quantityy)
        {
            product = productt;
            quantity = quantityy;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public Product GetProduct()
        {
            return product;
        }

        public void SetProduct(Product product)
        {
            this.product = product;
        }
    }
}
