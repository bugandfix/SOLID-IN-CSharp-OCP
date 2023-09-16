using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_IN_CSharp.Entity;

namespace SOLID_IN_CSharp.Infra;

public class JsonAssetSerializer
{
    public Asset GetAssetFromJsonString(string jsonString)
    {
        return JsonConvert.DeserializeObject<Asset>(jsonString,
            new StringEnumConverter());
    }
}
