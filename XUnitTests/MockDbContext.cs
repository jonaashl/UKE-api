using Microsoft.EntityFrameworkCore;
using Moq;
using UKE_api.Data;
using UKE_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace UKEUnitTests

{
    public class MockDbContext
    {
        public Mock<NumeralDbContext> _mockContext;
        public Mock<DbSet<ConversionHistory>> _mockSet;

        public MockDbContext()
        {
            _mockSet = new Mock<DbSet<ConversionHistory>>();
            _mockContext = new Mock<NumeralDbContext>();
            _mockContext.Setup(c => c.ConversionHistory).Returns(_mockSet.Object);
        }
    }
}

