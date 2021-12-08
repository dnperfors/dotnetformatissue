var fsharpTest = Array.Empty<fsharp.Test>();
var fsharpTestById = fsharpTest.ToDictionary(x => x.Id);

_ = fsharpTestById[Guid.Empty].Text;// <- generates CS1503

// workaround
var fsharpTestWorkAround = Array.Empty<fsharp.Test>();
Dictionary<Guid, fsharp.Test>? fsharpTestByIdWorkAround = fsharpTestWorkAround.ToDictionary(x => x.Id); // <- prevents CS1503

_ = fsharpTestByIdWorkAround[Guid.Empty].Text;

// no issues

var csharpTest = Array.Empty<csharplib.Test>();
var csharpTestById = csharpTest.ToDictionary(x => x.Id);

_ = csharpTestById[Guid.Empty].Text;

var test = Array.Empty<Test>();
var testById = test.ToDictionary(x => x.Id);

_ = testById[Guid.Empty].Text;

public class Test
{
    public Guid Id { get; }
    public string Text { get; } = "";
}