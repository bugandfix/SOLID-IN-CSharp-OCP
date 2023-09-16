using SOLID_IN_CSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID_IN_CSharp.Entity;

public class Asset
{
    public string Type { get; set; }

    #region FinancialAssets
    public string? Description { get; set; }
    public DateTime DateOfPurchase { get; set; }
    public bool CurrencyInUSD { get; set; }
    public decimal Amount { get; set; }
    #endregion

    #region RealAssets
    public string? Address { get; set; }
    public decimal Size { get; set; }
    public decimal Valuation { get; set; }
    public decimal ValueinUSD { get; set; }
    #endregion

    #region IntangibleAssets
    public string? Make { get; set; }
    public string? BrandName { get; set; }
    public int ReleaseDate { get; set; }
    public int Age { get; set; }
    public decimal Deductible { get; set; }
    #endregion
}
