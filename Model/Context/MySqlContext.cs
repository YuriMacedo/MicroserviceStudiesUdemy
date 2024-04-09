using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProdutAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(){}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Guts - Beserk - Action Figure",
                Price = new decimal(70.0),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus. Aliquam porta pulvinar ante. Donec in ultrices nulla. Aliquam luctus volutpat dolor, maximus maximus nulla laoreet non. Ut pulvinar fermentum ipsum",
                ImageUrl = "https://ae01.alicdn.com/kf/S13d07d1225ab4a87a870851780272e29a.jpg_640x640Q90.jpg_.webp",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Dark Knight - Final Fanatsy XIV Action Figure - Shadowbringers",
                Price = new decimal(74.6),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan. Etiam faucibus pharetra arcu et cursus.",
                ImageUrl = "https://preview.redd.it/k4bw3e0hm7o71.jpg?width=1080&crop=smart&auto=webp&s=2ce430bc58d02b0705b747ab0b4661dbcb28c024",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Red - Pokémon - Action Figure",
                Price = new decimal(46.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://cdn.awsli.com.br/1029/1029045/produto/195648290/figure-059905_01-78d314f018.jpg",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Caneca - Garoto de Programa",
                Price = new decimal(33.6),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://images.tcdn.com.br/img/img_prod/650501/caneca_garoto_de_programa_6267_1_514e868e9ae68bafe7c0108b88e490fb.jpg",
                CategoryName = "Coffe Mug",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Best ghost pokémons - Pokémon - Action Figure",
                Price = new decimal(66.6),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_613219-MLU69935631223_062023-O.webp",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Shirohige - One Piece - Action Figure",
                Price = new decimal(46.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://down-br.img.susercontent.com/file/5e2e1d1fd71c8af12f27f4a226987494",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Artorias - Dark Souls - Action Figure",
                Price = new decimal(120.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://ae01.alicdn.com/kf/Hac356c576da546c8886439e6e02b7efby/Dark-Souls-Faraam-PVC-Figura-Artorias-O-Abysswalker-Cavaleiro-Negro-Avan-ado-Cavaleiro-Guerreiro-Collectible-Toy.jpg",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Ikki de Fênix - Cavaleiros do Zodíaco - Action Figure",
                Price = new decimal(46.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://lojaarenagames.com.br/wp-content/uploads/2022/08/Action_Figure_Saint_Seiya_Ikki_V2_Revival___Cloth_Myth_Ex_84402-1.jpg",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "T-Shirt - Já abriu o chamado?",
                Price = new decimal(30.2),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/565bee29c0eceef0e0f0f88bae929287.webp",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "T-Shirt - Null dias sem bug em produção",
                Price = new decimal(57.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/a7af8b5d4549363b447892493d866642.webp",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "T-Shirt - Sem condições",
                Price = new decimal(93),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/0a8d91c21e81bc3c5fcc58267cb4074b.webp",
                CategoryName = "Action Figure",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "T-Shirt- Update sem where",
                Price = new decimal(74.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/25da5ad4b22720198c1f07a8fef6e1b7.webp",
                CategoryName = "T-Shirt",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "T-Shirt Go Horse process",
                Price = new decimal(46.9),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse sit amet porta dolor. In vel arcu ac diam efficitur accumsan.",
                ImageUrl = "https://rsv-ink-images-production.s3.sa-east-1.amazonaws.com/images/product_v2/main_image/b105eab5dba8797567789a02d3be923c.webp",
                CategoryName = "T-Shirt",
            });

        }
    }
}
