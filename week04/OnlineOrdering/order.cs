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
    public double TotalCostOfOrder()
    {
        double totalCost = 0;
        foreach (Product item in _itemsInOrder)
        {
            totalCost += item.GetTotalCostOfItem();
        }
        if (_customerInfo.CheckIfUsa() == true)
        {
            totalCost = totalCost + 5;
        }
        else
        {
            totalCost = totalCost + 35;
        }
        return totalCost;
        
    }

}