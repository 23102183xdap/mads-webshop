using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.Domain;
using Microsoft.EntityFrameworkCore;

//den hedder test prep og vil gerne have at den indnholder alle repos
// eller så laver jeg en for alle men den her indneholder produkt
namespace Test_MN_GroopAPS
{
    public class ProduktRepoTest
    {
        private readonly DbContextOptions<MNGroupDBConktext> _options;
        private readonly MNGroupDBConktext _context;
        public ProduktRepoTest()
        {
            _options = new DbContextOptionsBuilder<MNGroupDBConktext>()
                .UseInMemoryDatabase(databaseName: "RepositoryDatabase")
                .Options;


            _context = new MNGroupDBConktext(_options);
            _context.Database.EnsureDeleted();

            _context.Kategori.Add(new Kategori
            {
                Id = 1, 
                Title = "Vingummi",
                Beskrivelse ="spisligt"

            });
            _context.Kategori.Add(new Kategori
            {
                Id = 2,
                Title = "bolcher",
                Beskrivelse = "spisligt"

            });

            _context.SaveChanges();

            //adding manule for test 1
            _context.Produkt.Add(new Produkt
            {
                Id = 1,
                Name = "Monster",
                Beskrivelse ="med citrion og lemon curd",
                Pris = 20,
                KategoriId = 1
            }) ;

            //adding manule for test 2
            _context.Produkt.Add(new Produkt
            {
                Id = 2,
                Name = "cult",
                Beskrivelse = "med yosu og lemon curd",
                Pris = 20,
                KategoriId = 2
            });

            //adding manule for test 3
            _context.Produkt.Add(new Produkt
            {
                Id = 3,
                Name = "smag",
                Beskrivelse = "med jordbær og lemon",
                Pris = 25,
                KategoriId = 1
            });

            _context.SaveChanges();

        }

        [Fact]
        public async Task GetAllProdukts_ShoudReturn_whenProduktsEksist()
        {
            //arrange
            ProduktRepository produktRepository = new ProduktRepository(_context);

            //act 
            var produkt = await produktRepository.GetAll();

            //assert
            Assert.NotNull(produkt);
            Assert.Equal(3, produkt.Count);

        }

        [Fact]
        public async Task GetById_shoudreturnprodukts_whenprotucktseksist()
        {
            //arrange 
            ProduktRepository produktRepository = new ProduktRepository(_context);

            //art
            var produkt = await produktRepository.GetById(1);

            //assert
            Assert.NotNull(produkt);
            Assert.Equal(1, produkt.Id);
            Assert.Equal("Monster", produkt.Name);
            Assert.Equal("med citrion og lemon curd", produkt.Beskrivelse);
            Assert.Equal(20, produkt.Pris);
        }

        [Fact]
        public async Task create_shoudReturnProduktwithnewDateTime_whencreated()
        {

            //arrange 
            ProduktRepository produktRepository = new ProduktRepository(_context);
            Produkt newprodukt = new Produkt
            {
                Name = "monnerbolsher",
                Beskrivelse = "den smager af kaffe, og for folk til at holde kæft",
                KategoriId = 1
                
            };
            var produkts = await produktRepository.GetAll();
            //act
            var produkt = await produktRepository.Create(newprodukt);

            //assert
            Assert.NotNull(produkt);
            Assert.NotEqual(DateTime.MinValue, produkt.CreateAt);
            Assert.Equal(produkts.Count + 1, produkt.Id); // hvis vi sletter et produkt med et id 6,
                                                          // og den bliver oprettet igen så vil den få produkt 7 i stenden for 

        }
        [Fact]
        private async Task Update_ShoudReturnProduktWhenUpdatetDatetime_whenUpdatet()
        {
            //arrange 
            ProduktRepository produktRepository = new ProduktRepository(_context);
            int produktId = 1;
            Produkt updateProdukt = new Produkt { Name = "kaffebolgser", Beskrivelse = "bolsher samger af kaffe" };
            //act
            var produkt = await produktRepository.Update(produktId, updateProdukt);
            //assert
            Assert.NotNull(produkt);
            Assert.Equal(produktId, produkt.Id);
            Assert.Equal(updateProdukt.Name, produkt.Name);
            Assert.Equal(updateProdukt.Beskrivelse, produkt.Beskrivelse);
            Assert.Equal(updateProdukt.Pris, produkt.Pris);

            Assert.NotNull(produkt.UpdatetAt);
           
        }

        [Fact]
        private async Task Deleted_ShoudReturnProduktWhenDeletedDatetime_whenDeletd()
        {
            //arrange 
            ProduktRepository produktRepository = new ProduktRepository(_context);
            int produktId = 1;

           
            //act
            var produkt = await produktRepository.Delete(produktId);
            //assert
            Assert.NotNull(produkt);
            Assert.NotNull(produkt.DelitedAt);

        }
    }
}
