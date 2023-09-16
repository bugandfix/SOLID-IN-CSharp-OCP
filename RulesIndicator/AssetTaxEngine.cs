using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.Enums;
using SOLID_IN_CSharp.Infra;
using SOLID_IN_CSharp.Infra.Factory;


namespace SOLID_IN_CSharp.RulesIndicator;

public class AssetTaxEngine
{
    public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
    public FileAssetSource AssetSource { get; set; } = new FileAssetSource();
    public JsonAssetSerializer AssetSerializer { get; set; } = new JsonAssetSerializer();
    public decimal TaxRate { get; set; }
    public void CalculateTaxRate()
    {
        Logger.Log("Starting Calculation.");

        Logger.Log("Loading Data.");

        string assetinJson = AssetSource.GetAssetFromSource();

        var assetData = AssetSerializer.GetAssetFromJsonString(assetinJson);

        var factory = new AssetTaxCalculatorFactory();

        var TaxRateIndicator = factory.Create(assetData, this);
        TaxRateIndicator?.CalculateTaxRate(assetData);

        Logger.Log("Calculating is completed.");

        #region SwitchandCase
        //switch (assetData.Type)
        //{
        //    case AssetType.IntangibleAssets:
        //        Logger.Log("Calculating Intangible Assets...");
        //        Logger.Log("Validating Asset.");
        //        if (String.IsNullOrEmpty(assetData.Make))
        //        {
        //            Logger.Log("Intangible Asset must specify Make");
        //            return;
        //        }
        //        if (assetData.Make == "Microsoft")
        //        {
        //            if (assetData.Deductible < 500)
        //            {
        //                TaxRate = 20;
        //            }
        //            TaxRate = 30;
        //        }
        //        break;

        //    case AssetType.RealAssets:
        //        Logger.Log("Calculating Real Assets...");
        //        Logger.Log("Validating Asset.");
        //        if (assetData.Amount == 0 || assetData.Valuation == 0)
        //        {
        //            Logger.Log("Real Asset must specify Amount and Valuation.");
        //            return;
        //        }
        //        if (assetData.Amount < 0.8m * assetData.Valuation)
        //        {
        //            Logger.Log("Insufficient amount.");
        //            return;
        //        }
        //        TaxRate = assetData.Amount * 0.05m;
        //        break;

        //    case AssetType.FinancialAssets:
        //        Logger.Log("Calculating Financial Asset...");
        //        Logger.Log("Validating Asset.");
        //        if (assetData.DateOfPurchase == DateTime.MinValue)
        //        {
        //            Logger.Log("Calculating Asset must include Date Of Purchase.");
        //            return;
        //        }
        //        if (assetData.DateOfPurchase < DateTime.Today.AddYears(-100))
        //        {
        //            Logger.Log("Not eligible for Being an Asset.");
        //            return;
        //        }
        //        if (assetData.Amount == 0)
        //        {
        //            Logger.Log("Financial Asset must include an Amount.");
        //            return;
        //        }
        //        int age = DateTime.Today.Year - assetData.DateOfPurchase.Year;
        //        if (assetData.DateOfPurchase.Month == DateTime.Today.Month &&
        //            DateTime.Today.Day < assetData.DateOfPurchase.Day ||
        //            DateTime.Today.Month < assetData.DateOfPurchase.Month)
        //        {
        //            age--;
        //        }
        //        decimal baseTaxRate = assetData.Amount * age / 200;
        //        if (assetData.CurrencyInUSD)
        //        {
        //            TaxRate = baseTaxRate * 2;
        //            break;
        //        }
        //        baseTaxRate = baseTaxRate;
        //        break;

        //    default:
        //        Logger.Log("Unknown Asset type");
        //        break;
        //}
        #endregion

    }
}
