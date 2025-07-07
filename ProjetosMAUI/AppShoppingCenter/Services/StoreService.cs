using AppShoppingCenter.Models;
using AppShoppingCenter.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.Services
{
    public class StoreService
    {
        public List<Establishment> GetStores()
        {
            return MockStoreService.GetStore();
        }
    }

    public class MockStoreService
    {
        public static List<Establishment> GetStore()
        {
            return new List<Establishment>
            {
                new Establishment
                {
                    Id = 1,
                    Name = "Arezzo",
                    Description = "Fundada em 1972 pelos irmãos Anderson e Jefferson Birman, a Arezzo comemora 50 anos de uma história dedicada a arte de transitar pelo mundo da moda e traduzir tendências para mulheres da vida real. Hoje, a Arezzo é a maior marca de varejo de calçados femininos fashion da América Latina e conta com 450 lojas em sua rede de franquias, estando presente em 180 municípios de todos os estados brasileiros",
                    Localization = "1 Piso, Loja 01 - Setor Norte",
                    Phone = "(31) 3154-5583",
                    Type = EstablishmentType.Store,
                    Logo = "https://diskfone.com.br/appDiskFone/assets/image/DocumentoCliente/023221/logo.jpg",
                    Cover = "https://www.estadao.com.br/resizer/rBqzc0YbW4dBIs4uZIXLJ8qaZTE=/arc-anglerfish-arc2-prod-estadao/public/KP7KNT6STVP5PCSIQOMJMAT3HY.jpg"
                },
                new Establishment
                {
                    Id = 2,
                    Name = "Any Any",
                    Description = "Há 27 anos, a Any Any inspira-se nos momentos simples e significativos, que se transformam nas memórias mais deliciosas da vida. Nossa inspiração vem de um acordar mais leve, de um sorriso bobo ao ver os primeiros raios do dia nascer, de uma noite vibrante e de muitas risadas até o amanhecer.",
                    Localization = "1 Piso, Loja 02 - Setor Norte",
                    Phone = "(61) 3154-1234",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://iguatemi.com.br/patiohigienopolis/sites/patiohigienopolis/files/logo-1360262833900.png",
                    Cover = "https://media.fashionnetwork.com/cdn-cgi/image/format=auto/m/3e5f/1097/8d6b/7475/3014/949c/cf47/f833/4f55/1a3f/1a3f.jpg"
                },
                new Establishment
                {
                    Id = 3,
                    Name = "BadBoy",
                    Description = "Bad Boy é uma marca alternativa americana de esportes e estilo de vida. É notável por sua presença tanto na moda como em equipamentos esportivos.",
                    Localization = "1 Piso, Loja 03 - Setor Norte",
                    Phone = "(61) 3154-1563",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://w7.pngwing.com/pngs/1022/751/png-transparent-badboy-hd-logo.png",
                    Cover = "https://badboybrasilia.com.br/imagens/produtos/lojas/taguatinga_maior.JPG"
                },
                new Establishment
                {
                    Id = 4,
                    Name = "BioMundo",
                    Description = "Fundada por Edmar Mothé, que possui mais de 40 anos de experiência no varejo, a Rede de lojas Bio Mundo opera no segmento de produtos naturais e está presente em 17 estados brasileiros. A empresa promove saúde e bem estar oferecendo o mix de produtos mais completo do Brasil, incluindo produtos diet, light, integrais, veganos, funcionais, sem glúten, sem lactose e suplementos vitamínicos e esportivos.",
                    Localization = "1 Piso, Loja 04 - Setor Norte",
                    Phone = "(61) 3154-5594",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://biomundo.com.br/wp-content/uploads/2022/07/Bio1.png",
                    Cover = "https://viventeandante.com/wp-content/uploads/2023/03/biomundo-em-macae.jpg"
                },
                new Establishment
                {
                    Id = 5,
                    Name = "Brossman",
                    Description = "Luxo e sofisticação são encontrados na loja Brossman, que tem como carro chefe a marca Dudalina. Contamos com diversas opções em roupas sociais para homens.",
                    Localization = "1 Piso, Loja 05 - Setor Norte",
                    Phone = "(61) 3154-4153",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://pbs.twimg.com/profile_images/1122972200/Logo_diferente_400x400.jpg",
                    Cover = "https://photos.wikimapia.org/p/00/02/58/51/10_full.jpg"
                },
                new Establishment
                {
                    Id = 6,
                    Name = "C&A",
                    Description = "C&A é uma cadeia internacional de lojas de vestuário, fundada nos Países Baixos em 1841 pelos irmãos Clemens e August como uma empresa têxtil. No Brasil, é uma das maiores redes de lojas de departamento do país e a décima segunda maior empresa varejista, segundo ranking do Ibevar de 2012.",
                    Localization = "1 Piso, Loja 06,07,08 - Setor Norte",
                    Phone = "(61) 3154-1355",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://img.offers-cdn.net/assets/uploads/stores/br/logos/200x72/c-a-61597689b7d5d.png",
                    Cover = "https://ecommercedesucesso.com.br/wp-content/uploads/2021/08/ca-1-1024x683.png"
                },
                new Establishment
                {
                    Id = 7,
                    Name = "Camicado",
                    Description = "Na Camicado você encontra diversas opções itens de decoração, eletro, cozinha, cama, mesa e banho, churrasco. E também pode criar a sua lista de presentes.",
                    Localization = "1 Piso, Loja 11, 12- Setor Norte",
                    Phone = "(61) 3679-2395",
                    Type = EstablishmentType.Store,

                    Logo = "https://4.bp.blogspot.com/-mXqmy1EuwsY/VydkyZu1wJI/AAAAAAAAKhM/ejPQD8J1DeIMqXFM3vcN3Zs5N5dKVLc9ACLcB/w1200-h630-p-k-no-nu/cami.jpg",
                    Cover = "https://catracalivre.com.br/wp-content/uploads/2020/06/camicado-loja.jpg"
                },
                new Establishment
                {
                    Id = 8,
                    Name = "Casas Bahia",
                    Description = "Casas Bahia é uma popular rede de varejo de móveis e eletrodomésticos do Brasil. Foi fundada em 1952, em São Caetano do Sul, São Paulo, onde se localiza a matriz, pelo imigrante polonês Samuel Klein.",
                    Localization = "2 Piso, Loja 10 - 16- Setor Norte",
                    Phone = "(61) 3679-153",
                    Type = Models.Enums.EstablishmentType.Store,

                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Casas_Bahia_logo.svg/2560px-Casas_Bahia_logo.svg.png",
                    Cover = "https://admin.cnnbrasil.com.br/wp-content/uploads/sites/12/2021/06/31094_4F90E37C9A3EFCF1-1.jpeg"
                },

                new Establishment()
                {
                    Id = 9,
                    Name = "Renner",
                    Description = "A Lojas Renner S.A. é uma rede de lojas de departamento brasileira.",
                    Localization = "2 Andar - Loja 10/11/12/13/14 - Entrada Norte",
                    Phone = "(61) 3333-3333",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/122012/renner_0.png?itok=VvGKSsDe",
                    Cover = "https://th.bing.com/th/id/OIP.Xge9v8IC43h0iborL-k5rwHaEM?pid=ImgDet&rs=1",
                },
                new Establishment()
                {
                    Id = 10,
                    Name = "Samsung",
                    Description = "Agora, você tem mais uma opção para experimentar e conhecer os produtos Samsung, antes de tomar a sua decisão de compra. Isso porque, nas Lojas Samsung, você pode manusear celulares, tablets, câmeras, smartphones e notebooks livremente, e ainda conta com consultoria e atendimento de vendedores especializados. A experiência de compra de equipamentos tecnológicos deixa de ser impessoal e ganha um caráter mais assertivo e direcionado ao seu verdadeiro desejo.",
                    Localization = "2 Andar - Loja 01/02 - Entrada Norte",
                    Phone = "(61) 3475-2650",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052012/samsung.png?itok=Mq0egkoi",
                    Cover = "https://th.bing.com/th/id/OIP.kC06IAxn8ES8p7nzooX6tgHaFj?pid=ImgDet&rs=1",
                },
                new Establishment()
                {
                    Id = 11,
                    Name = "Chilli Beans",
                    Description = "A maior rede brasileira de óculos escuros e acessórios”. Essa definição resume a Chilli Beans: provocativa, ardente e envolvente. É a marca da pimenta. Uma marca que, toda semana, lança novos óculos, novos relógios e novas possibilidades. Ou seja, novas formas de compor seu visual. Com mais de 580 pontos de venda exclusivos no Brasil, Estados Unidos, Portugal, Peru, Colômbia e Kuwait, a Chilli Beans é uma marca diversificada, com uma linha de produtos que inclui, além dos óculos escuros e relógios, armações de óculos de grau e lentes em pontos de vendas exclusivos. Além disso, a marca está por trás de um mundo de ações de patrocínio de festas, shows, esportes e ações sociais",
                    Localization = "2 Andar - Loja 03 - Entrada Norte",
                    Phone = "(61) 3475-2744",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/052016/logo_chilli_beans_1c.png?itok=w_B1Ywks",
                    Cover = "https://mercadoeconsumo.com.br/wp-content/uploads/2020/10/C5D_9838.jpg"
                },
                new Establishment()
                {
                    Id = 12,
                    Name = "POLYÉLLE",
                    Description = "Em 1984, iniciou-se a trajetória da Polyelle no segmento de calçados. Depois de um tempo, esse segmento foi ampliado também para bolsas, cintos, carteiras e artigos esportivos e hoje, conta com mais de duzentos fornecedores de marcas nacionais e internacionais. A empresa foi estruturada para inovar por meio de pesquisas de consumidores e concorrentes, sempre preocupada em oferecer a melhor seleção das tendências mundiais a preços acessíveis.",
                    Localization = "2 Andar - Loja 04/05/06 - Entrada Norte",
                    Phone = "(61) 3313-7843",
                    Type = EstablishmentType.Store,

                    Logo = "https://dcstudio.com.br/wp-content/uploads/2018/02/POLYELLE.jpg",
                    Cover = "https://th.bing.com/th/id/OIP.lEirkTYChv3JuC8mFRZSdgHaGR?pid=ImgDet&rs=1"
                },
                new Establishment()
                {
                    Id = 13,
                    Name = "LOJAS AMERICANAS",
                    Description = "Aqui você encontra de tudo um pouco: De eletrodomésticos a artigos de vestuário feminino, masculino e infantil.",
                    Localization = "2 Andar - Loja 07/08/09 - Entrada Norte",
                    Phone = "-",

                    Type = EstablishmentType.Store,
                    Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Lojas_Americanas_Logo.svg/2560px-Lojas_Americanas_Logo.svg.png",
                    Cover = "https://assets.multiplan.com.br/Multiplan/filer_public/3b/79/3b79da52-df20-430d-a345-f5e4c08ebcbd/vinidallarosa2024-7956.jpg?ims=x800"
                },
                new Establishment()
                {
                    Id = 14,
                    Name = "HERING STORE",
                    Description = "A Hering Store é uma loja de roupas femininas e masculinas que atende ao público adulto.",
                    Localization = "2 Andar - Loja 10/11 - Entrada Norte",
                    Phone = "(61) 3973-3352",
                    Type = EstablishmentType.Store,

                    Logo = "https://shoppingtaboao.com.br/lojas_files/20265.jpg",
                    Cover = "https://boulevardbelem.com.br/lojas_files/37954.jpg"
                },
                new Establishment()
                {
                    Id = 15,
                    Name = "O BOTICÁRIO",
                    Description = "O Boticário é uma loja de cosméticos em geral que oferece produtos para pele, cabelo, esmaltes, maquiagem e perfumaria.",
                    Localization = "1 Andar - Loja 20/21 - Entrada Sul",
                    Phone = "(61) 3475-2646",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032013/boticario_0.jpg?itok=bEHTxK_c",
                    Cover = "https://s2.glbimg.com/Gc7x7RoHCPC9XjfF15iayXgUSAw=/0x0:607x350/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_ba3db981e6d14e54bb84be31c923b00c/internal_photos/bs/2021/n/g/YK7Pe5QQqz4X67rxGHnQ/2020-11-24-boticario-pop-up-sustentavel-4.jpg"
                },
                new Establishment()
                {
                    Id = 16,
                    Name = "OI",
                    Description = "A Oi é uma loja que representa a operadora de telefonia de mesmo nome. A Loja Oi presta assistência, auxilia o consumidor a respeito de novos planos e vende celulares/smartphones.",
                    Localization = "1 Andar - Loja 22/23 - Entrada Sul",
                    Phone = "(61) 3475-2689",
                    Type = EstablishmentType.Store,

                    Logo = "https://cdn.folhape.com.br/upload/dn_arquivo/2020/12/logo-oi-2020.jpg",
                    Cover = "https://www.crama.com.br/wp-content/uploads/2013/10/oiloja_012.jpg"
                },
                new Establishment()
                {
                    Id = 17,
                    Name = "CLARO",
                    Description = "A Claro é uma loja de telefonia que vende aparelhos e presta assistência a clientes da operadora de mesmo nome.",
                    Localization = "1 Andar - Loja 24/25 - Entrada Sul",
                    Phone = "**",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/092011/claro_2_1.jpg?itok=EYXF3uUg",
                    Cover = "https://shoppingleblon.com.br/lojas_files/36190.jpg"
                },
                new Establishment()
                {
                    Id = 18,
                    Name = "CVC VIAGENS",
                    Description = "Compre suas passagens aéreas com pacotes completos na CVC do JK Shopping.  Sempre com os melhores preços e promoções para você viajar o mundo todo.",
                    Localization = "1 Andar - Loja 26/27 - Entrada Sul",
                    Phone = "**",
                    Type = EstablishmentType.Store,

                    Logo = "https://d1yjjnpx0p53s8.cloudfront.net/styles/logo-thumbnail/s3/032017/untitled-2_42.png?itok=a0FktvOz",
                    Cover = "https://neofeed.com.br/wp-content/uploads/2021/06/LojaCVC.jpg"
                },
                new Establishment()
                {
                    Id = 19,
                    Name = "POLISHOP",
                    Description = "Na Polishop você encontra Soluções Inteligentes para sua Casa, Saúde e Beleza. Produtos exclusivos e novidades que facilitam sua vida.",
                    Localization = "1 Andar - Loja 28/29 - Entrada Sul",
                    Phone = "**",
                    Type = EstablishmentType.Store,

                    Logo = "https://botw-pd.s3.amazonaws.com/styles/logo-thumbnail/s3/0022/2333/brand.gif?itok=m1Wcro5R",
                    Cover = "https://www.parkshopping.com.br/sites/pks/files/lojas/polishop.jpg"
                },
                new Establishment()
                {
                    Id = 20,
                    Name = "FUJIOKA",
                    Description = "O Fujioka é uma loja de eletrônicos e informática que oferece, ainda, produtos de áudio, vídeo, telefonia e serviços fotográficos.",
                    Localization = "1 Andar - Loja 30/31 - Entrada Sul",
                    Phone = "(61) 3471-8600",
                    Type = EstablishmentType.Store,

                    Logo = "https://wp.logos-download.com/wp-content/uploads/2019/11/Fujioka_Logo.png?dl",
                    Cover = "https://storage.googleapis.com/ancarx-stores-images-prd/0011I00000KMaSxQAL.jpeg"
                },
                new Establishment()
                {
                    Id = 21,
                    Name = "QUEM DISSE, BERENICE?",
                    Description = "A Quem disse, Berenice? é uma loja de maquiagens e cosméticos que tem uma proposta jovial e alegre que veio para quebrar padrões.",
                    Localization = "1 Andar - Loja 34 - Entrada Sul",
                    Phone = "(61) 3475-2419",
                    Type = EstablishmentType.Store,

                    Logo = "https://yt3.googleusercontent.com/BW_pYl1WiinhCWkfE4LyME8q-eBQL_5YsdLsEKNHyH2QTBMnyQRT_TTbxztNd_8aiOfKpu_3KA=s900-c-k-c0x00ffffff-no-rj",
                    Cover = "https://www.salvadorshopping.com.br/storage/stores/vitrine_405.jpg"
                },
                new Establishment()
                {
                    Id = 22,
                    Name = "PARIS JÓIAS",
                    Description = "A Paris Jóias é uma loja de jóias e semi jóias que atrai pelo glamour e design das peças.",
                    Localization = "1 Andar - Loja 35 - Entrada Sul",
                    Phone = "**",
                    Type = EstablishmentType.Store,

                    Logo = "https://jkshoppingdf.com.br/pycmokse/bfi_thumb/paris-joias-74h5b8vljq47xsxhrnblwmfg5zssn8uuu5uo271omfu.png",
                    Cover = "https://storage.googleapis.com/sf-image-cache/0011I00000KMadaQAD.jpg"
                },
                new Establishment()
                {
                    Id = 23,
                    Name = "COOL CAT",
                    Description = "A Cool Cat é uma loja de roupas casuais para homens e mulheres, com foco na moda surfware e streetware.",
                    Localization = "1 Andar - Loja 36 - Entrada Sul",
                    Phone = "61 3491-2407",

                    Type = EstablishmentType.Store,
                    Logo = "https://www.hezzitubones.com.br/wp-content/uploads/2017/12/LOGO-COOL-CAT_cinza.png",
                    Cover = "https://photos.wikimapia.org/p/00/02/58/71/54_big.jpg"
                },
                new Establishment()
                {
                    Id = 24,
                    Name = "TNG",
                    Description = "Com DNA jovem a TNG lança tendências com estilo e autenticidade. Conheça as coleções masculinas e femininas. Aproveite o melhor da moda. Confira!",
                    Localization = "1 Andar - Loja 37 - Entrada Sul",
                    Phone = "(11) 4689-7375",
                    Type = EstablishmentType.Store,

                    Logo = "https://bazarpop.files.wordpress.com/2008/06/logo_tng.gif",
                    Cover = "https://s2.glbimg.com/JPYjdV5PmwJbzHLQN5PZgpxMM8w=/0x0:1266x942/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_f035dd6fd91c438fa04ab718d608bbaa/internal_photos/bs/2021/O/j/AzfDphQQG5qy0wlfMTvg/loja-tng-reproducao-facebook-1.jpg"
                },
                new Establishment()
                {
                    Id = 25,
                    Name = "PITICAS",
                    Description = "Piticas: Ano de Fundação: 2010: Inicio do Franchising: 2011: Unidades Franqueadas: 340: Comunicado Franchise Store: Os dados e conteúdos informados foram fornecidos exclusivamente pela Franqueadora. ",
                    Localization = "1 Andar - Loja 38 - Entrada Sul",
                    Phone = "(61) 3053-8009",
                    Type = EstablishmentType.Store,

                    Logo = "https://yt3.googleusercontent.com/R9m_Ghi6LquIsxvy7RH9rQIwpgkIFAIXYknM0kUK4HjgGG5VZGybhAfZ3MTILWvz2Ygs3cXX=s900-c-k-c0x00ffffff-no-rj",
                    Cover = "https://s2.glbimg.com/9bW5xeF2TzgK6yrJ2IQF_gCMv2k=/e.glbimg.com/og/ed/f/original/2020/08/17/foto_materia_loa_01.jpg"
                },
                new Establishment()
                {
                    Id = 26,
                    Name = "ZINZANE",
                    Description = "Zinzane é uma marca de moda feminina que nasceu em 2002, no Rio de Janeiro, na charmosa Babilônia Feira Hype. Atualmente, possuímos 113 lojas físicas próprias e estamos presentes em 19 estados brasileiros, além da forte atuação no canal digital, através da nossa loja online, com o objetivo de levar as últimas tendências para todo o Brasil. Lançamos semanalmente novos produtos exclusivos e nossa missão é encantar o cliente, ofertando o melhor produto, com o melhor custo benefício. Nossas estampas exclusivas são o carro-chefe da marca, vistas em produtos de variados estilos e modelagens. Aqui, você encontra o look perfeito para estar no seu guarda-roupa.",
                    Localization = "1 Andar - Loja 39 - Entrada Sul",
                    Phone = "(61) 3475-2789",
                    Type = EstablishmentType.Store,

                    Logo = "https://www.cupomvalido.com.br/logo/www.zinzane.com.br.png.pagespeed.ce.cTfK8gTDeL.png",
                    Cover = "https://www.parkshopping.com.br/sites/pks/files/lojas/zinzane_01.jpg"
                }
            };
        }
    }
}
