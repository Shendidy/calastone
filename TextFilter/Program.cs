using TextFilter;
using TextFilter.Services;
using TFS = TextFilter.Services;

var path = @"./Files/input.txt";

var text = File.ReadAllText(path);

IFilter1 filter1 = new Filter1();
IFilter2 filter2 = new Filter2();
IFilter3 filter3 = new Filter3();

ITextFilter textFilter = new TFS.TextFilter(filter1, filter2, filter3);

Console.WriteLine(textFilter.GetFilteredText(text));