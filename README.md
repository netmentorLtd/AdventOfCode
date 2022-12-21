# NetMentor.AdventOfCode


Library to help you on the execution of advent of code challenges using C#


| Pacakge in nuget                                                                |     .NET     | 
|---------------------------------------------------------------------------------|:------------:|
| [NetMentor.AdventOfCode](https://www.nuget.org/packages/NetMentor.AdventOfCode) |     7.0      | 


## Usage
once the library is imported you can use the abstract class `AoCSolution`. which will give you a variety of constructors:

- `path` and `filename`
- `year`, `day` and `filename`

Filename is defaulted as `input.txt`

- `path` and `AoCFileType`
- `year`, `day` and `AoCFileType`

`AoCFileType` is default at `AoCFileType.Input` the alternative is `AoCFileType.Test`



And then two abstract methods for `Part1` and `Part2`


When using the path you can specify an absolute and a relative path, be sure you can access the files.

when using the `year`,`day` constructor the library expects the files to be in a relative path.
Is common use in the AdventOfCode community to use folders like `2022/01`,`2022/02` etc, so one folder for the year and a subfolder for the day your working on.

For example if you create a test library to execute the AdventOfCode challenges the folder must be in the root of that project. Similar to [this](https://github.com/netmentorLtd/AdventOfCode/tree/main/test/Netmentor.AdventOfCode.Tests) example.

By the way C# works it will not copy the files when building the project, be sure you **go to the properties and copy them**.

### File Names
It is standardized the usage of `input.txt` and `test.txt` for the files doing the challenge. In this library we keep them, but you can change them on the constructor.




## Contributions
Any idea to improve the functionality is welcome

## Give the project a star ⭐
If you like the project, don't hesitate to give it a star or economically support it by [donating a coffee](https://www.buymeacoffee.com/NetMentor)


**Disclaimer**: This library was created totally for the craic; I didn't even stop to think about performance.