using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Routing;
using WebApi.Controllers;
using Xunit;

namespace WebApi.Tests.Unit
{
  public class ControllersHttpMethodAttributeTests
  {
    [Theory]
    [MemberData(nameof(GetAllControllersPublicMethods))]
    public void EveryPublicMethod_Should_HaveHttpMethodAttribute(MethodInfo method)
    {
      bool hasHttpMethodAttribute = method.CustomAttributes
        .Any(x => x.AttributeType.IsSubclassOf(typeof(HttpMethodAttribute)));

      hasHttpMethodAttribute.Should().BeTrue();
    }
    
    public static IEnumerable<object[]> GetAllSubclassesOfAbstractController()
    {
      Assembly assembly = Assembly.GetAssembly(typeof(BaseApiController))!;
      IEnumerable<Type> controllers = assembly.GetTypes()
          .Where(x => x.IsSubclassOf(typeof(BaseApiController)));

      return controllers.Select(x => new object[] { x });
    }

    public static IEnumerable<object[]> GetAllControllersPublicMethods()
    {
      List<MethodInfo> methods = new List<MethodInfo>();
      IEnumerable<Type> controllers = GetAllSubclassesOfAbstractController().Select(x => (Type)x.First()).ToList();

      foreach (var type in controllers)
      {
        var typeMethods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        methods.AddRange(typeMethods);
      }

      return methods.Select(x => new object[] { x });
    }
  }
}