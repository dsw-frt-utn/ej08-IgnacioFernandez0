using System;

public class Problema2
{
	public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
	{
		decimal total = quantity >= 0 ? quantity * unitPrice : 0;
        var resumen = new { Code = productCode, Description= productDescription, Quantity = quantity, Total= total};
		return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
	}
}
