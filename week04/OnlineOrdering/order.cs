using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _itemsInOrder;
    private Customer _customerInfo;

    public Order(List<Product> items, Customer info)
    {
        _itemsInOrder = items;
        _customerInfo = info;
    }
    // public double TotalCostOfOrder()
    // {
    //     for item in Product
    // }

}