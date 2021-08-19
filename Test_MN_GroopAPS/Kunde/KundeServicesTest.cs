using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.services;
namespace Test_MN_GroopAPS
{
    public class KundeServicesTest
    {
        private readonly KundeServices _sut;
        private readonly Mock<IKundeRepository> _KundeRepositoryMock = new();

        public KundeServicesTest()
        {
            _sut = new KundeServices(_KundeRepositoryMock.Object);
        }

        [Fact]
        public async Task GetById_ShoudReturnNull_WhenKategoriSoesNotEksist()
        {
            //Arrange 0
            _KundeRepositoryMock
                .Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);


            //Act
            var kategori = await _sut.GetKundeById(123);


            //Assert
            Assert.Null(kategori);
        }
    }
}
