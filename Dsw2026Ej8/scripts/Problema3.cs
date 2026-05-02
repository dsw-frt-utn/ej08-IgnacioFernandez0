using System;

public class Product
{
	private long _code;
    private string _description;
    private decimal _price;

	public void setDescription(string description)
	{
		_description = description;
	}
	public string getDescription() 
	{
		return _description;	
	}
}

public class Problema3
{
	public string CompararCopias(int originalValue, Product product)
	{
		int copyValue = originalValue;
		copyValue++;
		Product copyProduct = product;
		copyProduct.setDescription("Esta es la descripcion del producto copiado modificada");
		return $"{originalValue}-{copyValue}-{copyProduct.getDescription}";
    }
}
