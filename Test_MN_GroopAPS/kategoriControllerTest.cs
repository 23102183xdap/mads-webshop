using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MN_Groop_A.P.S.Controllers;
using MN_Groop_A.P.S.IServices;
using Moq;
using Xunit;
using MN_Groop_A.P.S.Domain;

namespace Test_MN_GroopAPS
{
    public class KategoriControllerTest
    {
        private readonly KategoriController _sut;
        private readonly Mock<IKategoriServices> _kategoriServicesmock = new();
        public KategoriControllerTest()
        {
            _sut = new KategoriController(_kategoriServicesmock.Object);
        }
        
        [Fact]
        public async Task GetAll_ShouldTeturn200_WhenDataExist()
        {

            //arrange
            List<Kategori> kategoris = new List<Kategori>();
            kategoris.Add(new Kategori());



        }
    }
}
