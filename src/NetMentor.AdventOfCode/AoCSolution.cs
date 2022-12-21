namespace NetMentor.AdventOfCode;

public abstract class AoCSolution
{
    protected readonly string Input;

    protected AoCSolution(string path, string filename = "input.txt")
    {
        Input = ReadInputFromPath(path, filename);
    }

    protected AoCSolution(int year, int day, string filename = "input.txt")
    {
        Input = ReadInputFromYearDay(year, day, filename);
    }
    
    protected AoCSolution(string path, AoCFileType type = AoCFileType.Input)
    {
        Input = ReadInputFromPath(path, FileNameFromInput(type));
    }
    
    
    protected AoCSolution(int year, int day, AoCFileType type = AoCFileType.Input)
    {
        Input = ReadInputFromYearDay(year, day, FileNameFromInput(type));
    }

    public abstract string Part1();
    public abstract string Part2();

    private string FileNameFromInput(AoCFileType type) => type switch
    {
        AoCFileType.Input => "input.txt",
        AoCFileType.Test => "test.txt",
        _ => throw new Exception("that type is not supported")
    };

    private string ReadInputFromYearDay(int year, int day, string filename)
    {
        return ReadInputFromPath($"{year}/{FullDay()}", filename);

        string FullDay()
        {
            return day < 10 ? $"0{day}" : day.ToString();
        }
    }

    private string ReadInputFromPath(string path, string filename)
    {
        return File.ReadAllText($"{path}/{filename}");
    }
}