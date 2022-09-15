using Pronia.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pronia.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Setting> Settings { get; set; }
    }
}
