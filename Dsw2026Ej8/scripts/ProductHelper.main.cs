using System;

public partial class ProductHelper
{
	public string ObtenerEtiquetaProducto(long code, string description, decimal price)
	{
        string priceFormat = FormatearMoneda(price);
        return $"[ {code} ], {description} - {priceFormat}";
    }
}
