using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }


        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    public class GroupMovie : List<Movie>
    {
        public string CompanyName { get; set; }
    }

    public class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGoup = new GroupMovie() { CompanyName = "Disney" };

            disneyGoup.Add(new Movie()
            {
                Id = 1,
                Name = "Premonição 6: Laços de Sangue",
                Description = "Atormentada por um pesadelo violento e recorrente, uma estudante universitária volta para casa em busca da única pessoa que pode ser capaz de quebrar o ciclo de morte e salvar sua família do terrível destino que inevitavelmente os aguarda.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 23, 0)
            });
            disneyGoup.Add(new Movie()
            {
                Id = 2,
                Name = "A Maldição de Cinderela",
                Description = "Depois de anos de abuso e humilhação, Cinderela é empurrada para o seu limite. Desesperada por vingança, ela recebe um poder perigoso e sinistro da Fada Madrinha. Ela é transformada em um monstro terrível com uma cabeça de abóbora. Determinada a colocar um fim em sua tormenta e humilhação, Cinderela embarca em uma missão implacável para limpar a casa de uma vez por todas.",
                LaunchYear = 2025,
                Duration = new TimeSpan(1, 51, 0)
            });
            disneyGoup.Add(new Movie()
            {
                Id = 3,
                Name = "Até a Última Gota",
                Description = "Uma mãe solo é levada ao seu limite pelas dificuldades financeiras. Desesperada, sem ter onde morar e vendo a vida de sua filha ameaçada, ela invade um banco e faz todos de reféns.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 03, 0)
            });

            var paramountGroup = new GroupMovie() { CompanyName = "Paramount" };

            paramountGroup.Add(new Movie()
            {
                Id = 4,
                Name = "O Último Respiro",
                Description = "Mergulhadores experientes enfrentam os elementos em fúria para resgatar um colega de equipe preso a centenas de metros abaixo da superfície do oceano.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 47, 0)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 5,
                Name = "Novocaine: À Prova da Dor",
                Description = "A garota dos sonhos de um homem é sequestrada. Ele transforma sua incapacidade de sentir dor em uma vantagem inesperada enquanto luta contra um bando de bandidos para resgatá-la.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 29, 0)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Pequenas Coisas como Estas",
                Description = "Em 1985, o comerciante de carvão Bill Furlong descobre segredos perturbadores em uma pequena cidade irlandesa controlada pela Igreja Católica Romana.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 10, 0)
            });
            paramountGroup.Add(new Movie()
            {
                Id = 7,
                Name = "No Other Land",
                Description = "O documentário produzido por um coletivo palestino-israelense mostra a destruição de Masafer Yatta por soldados israelenses na Cisjordânia ocupada e a aliança que se desenvolve entre o ativista palestino Basel e o jornalista israelense Yuval.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 35, 0)
            });

            var universalGroup = new GroupMovie() { CompanyName = "Universal" };

            universalGroup.Add(new Movie()
            {
                Id = 8,
                Name = "Número 24",
                Description = "Às vésperas da 2ª Guerra Mundial, a determinação de um jovem norueguês em resistir aos nazistas muda o rumo de sua vida e de seu país.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 51, 0)
            });
            universalGroup.Add(new Movie()
            {
                Id = 9,
                Name = "Perto de Você",
                Description = "Sam é um homem trans e não vê sua família há quatro anos. Ao retornar para casa, ele reencontra seu primeiro amor e enfrenta conflitos familiares.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 55, 0)
            });
            universalGroup.Add(new Movie()
            {
                Id = 10,
                Name = "A Viúva Clicquot",
                Description = "A história por trás da família e empresa de champanhe Veuve Clicquot que começou no século 18.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 30, 0)
            });

            List<GroupMovie> list = new List<GroupMovie>() 
            { 
                disneyGoup,
                paramountGroup,
                universalGroup
            };

            return list;
        }

        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie()
            {
                Id = 1,
                Name = "Premonição 6: Laços de Sangue",
                Description = "Atormentada por um pesadelo violento e recorrente, uma estudante universitária volta para casa em busca da única pessoa que pode ser capaz de quebrar o ciclo de morte e salvar sua família do terrível destino que inevitavelmente os aguarda.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 23, 0)
            });
            list.Add(new Movie()
            {
                Id = 2,
                Name = "A Maldição de Cinderela",
                Description = "Depois de anos de abuso e humilhação, Cinderela é empurrada para o seu limite. Desesperada por vingança, ela recebe um poder perigoso e sinistro da Fada Madrinha. Ela é transformada em um monstro terrível com uma cabeça de abóbora. Determinada a colocar um fim em sua tormenta e humilhação, Cinderela embarca em uma missão implacável para limpar a casa de uma vez por todas.",
                LaunchYear = 2025,
                Duration = new TimeSpan(1, 51, 0)
            });
            list.Add(new Movie()
            {
                Id = 3,
                Name = "Até a Última Gota",
                Description = "Uma mãe solo é levada ao seu limite pelas dificuldades financeiras. Desesperada, sem ter onde morar e vendo a vida de sua filha ameaçada, ela invade um banco e faz todos de reféns.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 03, 0)
            });
            list.Add(new Movie()
            {
                Id = 4,
                Name = "O Último Respiro",
                Description = "Mergulhadores experientes enfrentam os elementos em fúria para resgatar um colega de equipe preso a centenas de metros abaixo da superfície do oceano.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 47, 0)
            });
            list.Add(new Movie()
            {
                Id = 5,
                Name = "Novocaine: À Prova da Dor",
                Description = "A garota dos sonhos de um homem é sequestrada. Ele transforma sua incapacidade de sentir dor em uma vantagem inesperada enquanto luta contra um bando de bandidos para resgatá-la.",
                LaunchYear = 2025,
                Duration = new TimeSpan(2, 29, 0)
            });
            list.Add(new Movie()
            {
                Id = 6,
                Name = "Pequenas Coisas como Estas",
                Description = "Em 1985, o comerciante de carvão Bill Furlong descobre segredos perturbadores em uma pequena cidade irlandesa controlada pela Igreja Católica Romana.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 10, 0)
            });
            list.Add(new Movie()
            {
                Id = 7,
                Name = "No Other Land",
                Description = "O documentário produzido por um coletivo palestino-israelense mostra a destruição de Masafer Yatta por soldados israelenses na Cisjordânia ocupada e a aliança que se desenvolve entre o ativista palestino Basel e o jornalista israelense Yuval.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 35, 0)
            });
            list.Add(new Movie()
            {
                Id = 8,
                Name = "Número 24",
                Description = "Às vésperas da 2ª Guerra Mundial, a determinação de um jovem norueguês em resistir aos nazistas muda o rumo de sua vida e de seu país.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 51, 0)
            });
            list.Add(new Movie()
            {
                Id = 9,
                Name = "Perto de Você",
                Description = "Sam é um homem trans e não vê sua família há quatro anos. Ao retornar para casa, ele reencontra seu primeiro amor e enfrenta conflitos familiares.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 55, 0)
            });
            list.Add(new Movie()
            {
                Id = 10,
                Name = "A Viúva Clicquot",
                Description = "A história por trás da família e empresa de champanhe Veuve Clicquot que começou no século 18.",
                LaunchYear = 2023,
                Duration = new TimeSpan(1, 30, 0)
            });

            return list;
        }
    }
}
