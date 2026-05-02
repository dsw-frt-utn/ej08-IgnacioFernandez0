using System;

public class Sale
{
    private decimal _importeBase;
	public virtual decimal CalcularTotal()
	{
        return _importeBase;
	}

    public void setImporteBase(decimal importeBase)
    {
        _importeBase = importeBase;
    }
    public decimal getImporteBase()
    {
        return _importeBase;
    }
}

public class RetailSale : Sale
{
    public override decimal CalcularTotal()
    {
        return getImporteBase();
    }
}

public class WholesaleSale : Sale
{
    public override decimal CalcularTotal()
    {
        return getImporteBase() * 0.9m;
    }
}

public class Problema5
{
	public decimal ObtenerImporteFinal(Sale sale)
	{
        sale.CalcularTotal();
	}
}
