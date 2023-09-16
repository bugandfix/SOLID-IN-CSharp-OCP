using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.TaxEngine;

public class FinancialAssetsTaxCalculator : TaxEngineBase
{
    public FinancialAssetsTaxCalculator(AssetTaxEngine engine, ConsoleLogger logger)
        : base(engine, logger)
    {
    }

    public override void CalculateTaxRate(Asset asset)
    {
        _logger.Log("Calculating Financial Asset...");
        _logger.Log("Validating Asset.");
        if (asset.DateOfPurchase == DateTime.MinValue)
        {
            _logger.Log("Calculating Asset must include Date Of Purchase.");
            return;
        }
        if (asset.DateOfPurchase < DateTime.Today.AddYears(-100))
        {
            _logger.Log("Not eligible for Being an Asset.");
            return;
        }
        if (asset.Amount == 0)
        {
            _logger.Log("Financial Asset must include an Amount.");
            return;
        }
        int age = DateTime.Today.Year - asset.DateOfPurchase.Year;
        if (asset.DateOfPurchase.Month == DateTime.Today.Month &&
            DateTime.Today.Day < asset.DateOfPurchase.Day ||
            DateTime.Today.Month < asset.DateOfPurchase.Month)
        {
            age--;
        }
        decimal baseTaxRate = asset.Amount * age / 200;
        if (asset.CurrencyInUSD)
        {
            _engine.TaxRate = baseTaxRate * 2;
        }
    }
}
