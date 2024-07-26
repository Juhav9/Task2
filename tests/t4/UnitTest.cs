using Savonia.xUnit.Helpers;
using ShapesLibrary;
using System;
using Xunit;
using Xunit.Abstractions;

namespace tests;

public class UnitTest : AppTestBase
{
    public UnitTest(ITestOutputHelper output) : base(output)
    {
    }

    [Theory]
    [JsonFileData("testdata.json", "rectangle", typeof(Tuple<double, double>), typeof(string))]
    public async void Checkpoint04_Shape1_ToString(Tuple<double, double> data, string expected)
    {
        IShape shape = new Rectangle(data.Item1, data.Item2);
        Assert.Equal(expected.SetDecimalSeparator(), shape.ToString());
    }

    [Theory]
    [JsonFileData("testdata.json", "circle", typeof(double), typeof(string))]
    public async void Checkpoint04_Shape2_ToString(double data, string expected)
    {
        IShape shape = new Circle(data);
        Assert.Equal(expected.SetDecimalSeparator(), shape.ToString());
    }

}