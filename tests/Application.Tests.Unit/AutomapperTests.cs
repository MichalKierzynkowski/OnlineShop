using Application.Mappings;
using Xunit;

namespace Application.Tests.Unit
{
  public class AutomapperTests
  {
    [Fact]
    public void MappingTest()
    {
      var automapper = AutoMaperConfig.Initialize();

      automapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
  }
}
