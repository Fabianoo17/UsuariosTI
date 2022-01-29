using System.Collections.Generic;

namespace Corretora.Business.ViewModels
{
    public class Highchart
    {
        public Highchart()
        {
            categories = new List<string>();
            series = new List<HighchartSeries>();
        }

        public string title { get; set; }

        public List<string> categories { get; set; }

        public List<HighchartSeries> series { get; set; }
    }
}
