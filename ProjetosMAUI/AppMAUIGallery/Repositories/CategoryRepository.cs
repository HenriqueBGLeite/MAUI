﻿using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component {
                        Title = "Grid",
                        Description = "Organiza os elementos detro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionarr os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forrma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Componentes (Views)",
                Components = new List<Component> {
                    new Component {
                        Title = "BoxView",
                        Description = "Um componente que cria uma caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },
                    new Component {
                        Title = "Label",
                        Description = "Apresenta o texto na tela.",
                        Page = typeof(LabelPage)
                    },
                    new Component {
                        Title = "Button",
                        Description = "Apresenta um botão na tela.",
                        Page = typeof(ButtonPage)
                    },
                    new Component {
                        Title = "Image",
                        Description = "Apresenta uma imagem na tela.",
                        Page = typeof(ImagePage)
                    },
                    new Component {
                        Title = "ImageButton",
                        Description = "Apresenta uma imagem com comportamento de botão.",
                        Page = typeof(ImageButtonPage)
                    }
                }
            });

            return categories;
        }
    }
}
