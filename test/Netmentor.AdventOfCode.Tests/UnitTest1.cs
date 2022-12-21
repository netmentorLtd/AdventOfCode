using NetMentor.AdventOfCode.Tests._2022._01;

namespace NetMentor.AdventOfCode.Tests;

public class UnitTest1
{
    //this does not calculates the value, only ensures the input/output is corect
    [Fact]
    public void WhenTest_then_Reads_testFile()
    {
        Day01 day01 = new Day01("test.txt");
        string result = day01.Part1();
        Assert.Equal("1000", result);
    }
    
    [Fact]
    public void WhenInput_then_reads_inputFile()
    {
        Day01 day01 = new Day01(AoCFileType.Input);
        string result = day01.Part1();
        Assert.Equal("10130", result);
    }
}