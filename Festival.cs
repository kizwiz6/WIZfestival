using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIZfestival
{
    /// <summary>
    /// Client class that depends on IPerformanceService
    /// </summary>
    public class Festival
    {
        private readonly IPerformanceService _performanceService;

        /// <summary>
        /// Constructor injection
        /// </summary>
        /// <param name="performanceService"></param>
        public Festival(IPerformanceService performanceService)
        {
            this._performanceService = performanceService;
        }

        /// <summary>
        /// Parameterless constructor for dynamic instantiation
        /// </summary>
        public Festival()
        {
            // You may provide a default implementation here
            _performanceService = new MusicPerformanceService(); // Default to MusicPerformanceService
        }

        public void Start()
        {
            Console.WriteLine("Festival begins!");
            _performanceService.StartPerformance();
        }

    }
}
