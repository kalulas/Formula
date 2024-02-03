using TreeSitter.Bindings;

if (args.Length < 2 || args[0] != "-file")
{
    Console.WriteLine("Invalid arguments. Please use -file followed by the file path.");
    return;
}

var filepath = args[1];
var sourceCode = File.ReadAllText(filepath);
var parser = new TSParser();
parser.set_language(Language.Formula);
var tree = parser.parse_string(null, sourceCode);
if (tree == null)
{
    Console.WriteLine($"Error. Parse file '{filepath}' to tree failed.");
    return;
}

// Console.WriteLine(tree.root_node().text(sourceCode));
Console.WriteLine(tree.root_node().to_string());