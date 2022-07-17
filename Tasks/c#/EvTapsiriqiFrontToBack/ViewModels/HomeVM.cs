using EvTapsiriqiFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTapsiriqiFrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Sliders> Sliders { get; set; }
        public SliderDescription SliderDescription { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public ValentineDescription ValentineDescriptions { get; set; }
        public FlowerExpert FlowerExperts { get; set; }
        public IEnumerable<FlowerExpertItem> FlowerExpertItems { get; set; }
        public EmailSection EmailSections { get; set; }
        public Blog Blogs { get; set; }
        public IEnumerable<BlogItem> BlogItems { get; set; }
        public IEnumerable<SliderFlorist> SliderFlorists { get; set; }
    }
}

