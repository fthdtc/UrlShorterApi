using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UrlShorterApi.Data
{
    public class DbContext : IDbContext
    {
        public async Task<string> Get()
        {
            var assembly = Assembly.GetEntryAssembly();
            var resourceStream = assembly.GetManifestResourceStream("UrlShorterApi.Data.SampleDatabase.json");

            using (var reader = new StreamReader(resourceStream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
