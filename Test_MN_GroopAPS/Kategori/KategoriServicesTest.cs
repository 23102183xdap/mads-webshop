using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using MN_Groop_A.P.S.services;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.IRepositories;

namespace Test_MN_GroopAPS
{
    public class KategoriServicesTest
    {
        private readonly KategoriServices _sut;
        private readonly Mock<IKategoriRepository> _kategoriRepositoryMock = new();

        public KategoriServicesTest()
        {
            _sut = new KategoriServices(_kategoriRepositoryMock.Object);
        }

        [Fact]
        public async Task GetById_ShoudReturnNull_WhenKategoriSoesNotEksist()
        {
            //Arrange 0
            _kategoriRepositoryMock
                .Setup(x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);


            //Act
            var kategori = await _sut.GetKategoriById(123);


            //Assert
            Assert.Null(kategori);
        }
    }
}
