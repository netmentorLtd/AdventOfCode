namespace NetMentor.AdventOfCode.Tests._2022._01;

public class Day01 : AoCSolution
{
    public Day01(string filename) : base(2022, 01, filename)
    {
            
    }
    
    public Day01(AoCFileType filetype) : base(2022, 01, filetype)
    {
            
    }

    public override string Part1()
    {
        return Input.Split(Environment.NewLine).First();
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }
}