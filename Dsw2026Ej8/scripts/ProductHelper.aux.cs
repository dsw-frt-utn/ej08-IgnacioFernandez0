using System;

public partial class ProductHelper
{
	public string FormatearMoneda(decimal price)
	{
		return price.ToString("C2");
    }

    
}
