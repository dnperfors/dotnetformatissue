﻿var input = Array.Empty<Guid>();
var fsharpTest = Array.Empty<fsharp.Test>();
var fsharpTestById = fsharpTest.ToDictionary(x => x.Id);

_ =
    from item in input
    let text = fsharpTestById[item].Text
    select text;

var csharpTest = Array.Empty<csharplib.Test>();
var csharpTestById = csharpTest.ToDictionary(x => x.Id);

_ =
    from item in input
    let text = csharpTestById[item].Text
    select text;

var test = Array.Empty<Test>();
var testById = test.ToDictionary(x => x.Id);

_ =
    from item in input
    let text = testById[item].Text
    select text;

public class Test
{
    public Guid Id { get; }
    public string Text { get; } = "";
}