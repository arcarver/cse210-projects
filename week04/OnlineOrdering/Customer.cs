using System.Reflection;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }
    public bool CheckIfUsa()
    {

        if (_customerAddress.IsUsa() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
        //could have also just returned _customerAddress.IfUsa()
    }
}