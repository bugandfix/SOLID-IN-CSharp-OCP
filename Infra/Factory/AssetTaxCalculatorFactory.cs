using SOLID_IN_CSharp.Entity;
using SOLID_IN_CSharp.Infra.TaxEngine;
using SOLID_IN_CSharp.RulesIndicator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IN_CSharp.Infra.Factory
{
    public class AssetTaxCalculatorFactory
    {
        public TaxEngineBase Create(Asset asset, AssetTaxEngine engine)
        {
            try
            {
                return (TaxEngineBase)Activator.CreateInstance(
                        Type.GetType($"SOLID_IN_CSharp.Infra.TaxEngine.{asset.Type}TaxCalculator"),
                        new object[] { engine, engine.Logger });
            }
            catch
            {
                return null;
            }
        }
    }
}
