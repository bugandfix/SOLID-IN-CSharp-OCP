using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.TaxEngine;

public class IntangibleAssetsTaxCalculator : TaxEngineBase
{
    public IntangibleAssetsTaxCalculator(AssetTaxEngine engine, ConsoleLogger logger)
        : base(engine, logger)
    {
    }

    public override void CalculateTaxRate(Asset asset)
    {
        _logger.Log("Calculating Intangible Assets...");
        _logger.Log("Validating Asset.");
        if (String.IsNullOrEmpty(asset.Make))
        {
            _logger.Log("Intangible Asset must specify Make");
            return;
        }
        if (asset.Make == "Microsoft")
        {
            if (asset.Deductible < 500)
            {
                _engine.TaxRate = 20;
            }
            _engine.TaxRate = 30;
        }
    }
}
