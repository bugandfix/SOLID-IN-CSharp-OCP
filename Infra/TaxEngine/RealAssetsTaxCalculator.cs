using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.TaxEngine;

public class RealAssetsTaxCalculator : TaxEngineBase
{
    public RealAssetsTaxCalculator(AssetTaxEngine engine, ConsoleLogger logger)
        : base(engine, logger)
    {
    }

    public override void CalculateTaxRate(Asset asset)
    {
        _logger.Log("Calculating Real Assets...");
        _logger.Log("Validating Asset.");
        if (asset.Amount == 0 || asset.Valuation == 0)
        {
            _logger.Log("Real Asset must specify Amount and Valuation.");
        }
        if (asset.Amount < 0.8m * asset.Valuation)
        {
            _logger.Log("Insufficient amount.");
        }
        _engine.TaxRate = asset.Amount * 0.05m;
    }
}
