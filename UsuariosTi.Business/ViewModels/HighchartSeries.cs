using System.Collections.Generic;

namespace Corretora.Business.ViewModels
{
    public class HighchartSeries
    {
        public HighchartSeries()
        {
            data = new List<double?>();
        }

        public string type { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public List<double?> data { set; get; }
    }
}
