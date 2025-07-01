﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists.Models.Utils
{
    public class MovieTemplateSelector : DataTemplateSelector
    {
        public required DataTemplate TemplateDefault { get; set; }
        public required DataTemplate TemplateLongMovie { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Movie movie = (Movie)item;

            return (movie.Duration.Hours > 1) ? TemplateLongMovie : TemplateDefault;
        }
    }
}
