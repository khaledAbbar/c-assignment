using System;
using System.Collections.Generic;
using System.Xml.Linq;



Customer customer = new Customer
{
    
};

Order order = new Order
{
   
};


OrderDetails orderDetails = new OrderDetails
{
   
};

Item item = new Item
{
    
};


Payment payment = new Payment
{
   
};


Cash cashPayment = new Cash
{
   
};


Credit creditPayment = new Credit
{
    
};

Check checkPayment = new Check
{
  
};




public class Customer
{
    private string address { get; set; }
    private string Name { get; set; }



}

public class Order
{
    private string status { get; set; }
    private DateTime date { get; set; }


    public void calcSubTotal()
    {

    }

    public void calcTask()
    {

    }

    public void calcTotal()
    {

    }
    public void calcTotalWeight()
    {

    }
}

public class OrderDetails
{
    private string quality { get; set; }
    private string taxStatus { get; set; }


    public void calcSubTotal()
    {

    }

    public void calcWeight()
    {

    }

    public void calcSubTax()
    {

    }

}

public class Item
{
    private string shipingWeight { get; set; }
    private string descrebtion { get; set; }


    public void getPriceForQuantity()
    {

    }

    public void getTax()
    {

    }

    public void inStock()
    {

    }
}

public class Payment
{

    private float Amount { get; set; }

}

public class Cash : Payment
{
    private float CashTendered { get; set; }


}

public class Credit : Payment
{
    private string name { get; set; }
    private string type { get; set; }
    private DateTime expDate { get; set; }

    public  void authorized()
    {

    }
}

public class Check : Payment
{
    private string bankId { get; set; }
    private string name { get; set; }

    public  void authorized()
    {

    }
}


