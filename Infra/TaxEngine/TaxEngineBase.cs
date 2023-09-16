using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.TaxEngine;

public abstract class TaxEngineBase
{
    protected readonly AssetTaxEngine _engine;
    protected readonly ConsoleLogger _logger;

    public TaxEngineBase(AssetTaxEngine engine, ConsoleLogger logger)
    {
        _engine = engine;
        _logger = logger;
    }

    public abstract void CalculateTaxRate(Asset asset);
}
