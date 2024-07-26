using Savonia.xUnit.Helpers;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace tests;

public class UnitTest : AppTestBase
{
    string path = "../../../../../src/ConsoleApp/ConsoleApp.csproj";

    public UnitTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async void Checkpoint05_ProjectReference()
    {
        var result = GetFileContent(path);
        Assert.True(result.fileExists);
        Assert.NotNull(result.content);
        Assert.Contains("<ProjectReference Include=\"..\\ShapesLibrary\\ShapesLibrary.csproj\" />", result.content);
    }

    [Fact]
    public async void Checkpoint05_RunApp()
    {
        ProcessStartInfo psi = new ProcessStartInfo("dotnet", $"run --project {path}");
        psi.CreateNoWindow = true;
        psi.RedirectStandardOutput = true;
        Process? p = Process.Start(psi);
        Assert.NotNull(p);
        await p.WaitForExitAsync();
        string pout = await p.StandardOutput.ReadToEndAsync();
        Assert.Contains("Rectangle with width 4.00 and height 5.00 has area 20.00 and circumference 18.00".SetDecimalSeparator(), pout);
        Assert.Contains("Circle with radius 3.00 has area 28.27 and circumference 18.85".SetDecimalSeparator(), pout);
        WriteLine(pout);
    }
}