using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.TaxEngine;

public class UnknownAssetTaxCalculator : TaxEngineBase
{
    public UnknownAssetTaxCalculator(AssetTaxEngine engine, ConsoleLogger logger)
        : base(engine, logger)
    {
    }

    public override void CalculateTaxRate(Asset asset)
    {
        _logger.Log("Unknown Asset type");
    }
}
