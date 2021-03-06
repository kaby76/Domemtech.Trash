# Trash

Trash is a collection of command-line tools to support the analysis and editing
of grammars and parse tree data with Antlr4. The toolkit can generate a parser
application for an Antlr4 grammar for targets in C++, C#, Dart, Go, Java,
JavaScript, PHP, or Python3.
The toolkit supports operations
on parse trees including grammars themselves as they are represented as parse trees.
Parse trees from one app in the toolkit can be passed to another,
using standard input and output, which allows for very complicated refactorings.

Each app in `Trash` is implemented as a [Dotnet Tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) console application, and can be used on Windows, Linux, or Mac.
No prerequisites are required other than installing the
[NET SDK](https://dotnet.microsoft.com/), and the toolchains
for any other targets you want to use.

The toolkit uses [Antlr](https://www.antlr.org/) and
[XPath2](https://en.wikipedia.org/wiki/XPath).
The code is implemented in C#.

An application of the toolkit was used to scrape and refactor the Dart2
grammar from spec. See [this script](https://github.com/kaby76/ScrapeDartSpec/blob/master/refactor.sh).

## Install

Linux: Right-click, "save target as" of file
<a href="https://raw.githubusercontent.com/kaby76/Domemtech.Trash/master/_scripts/simple-install.sh">simple-install.sh</a>
, then run the script in the Bash shell (or `bash simple-install.sh`).

Windows: Right-click, "save target as" of file
<a href="https://raw.githubusercontent.com/kaby76/Domemtech.Trash/master/_scripts/install.ps1">install.ps1</a>
, then run the script in Powershell (or `powershell install.ps1`).

## Examples

### Parse a grammar

    git clone https://github.com/kaby76/Domemtech.Trash.git; cd Domemtech.Trash/_tests/trconvert/antlr2; \
        trparse ada.g4 | trtree | vim -

This command parses the Antlr4 grammar
[ada.g4](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4)
using [trparse](https://github.com/kaby76/Domemtech.Trash/tree/main/trparse),
prints out the parse tree data as a simple
[text-oriented diagram](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4.tree)
using [trtree](https://github.com/kaby76/Domemtech.Trash/tree/main/trtree),
then opens [vim](https://www.vim.org/) on the diagram. If you are not
familiar with `Vim`, then you can use [less](http://www.greenwoodsoftware.com/less/),
or save the output from `trtree` to a file
and open that with any other editor you would like. `trparse` can infer the type of
parse from the file name suffix.

`trtree` is only one of several ways to view parse tree data.
Other programs for different output are
[trjson](https://github.com/kaby76/Domemtech.Trash/tree/main/trjson) for [JSON output](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4.json),
[trxml](https://github.com/kaby76/Domemtech.Trash/tree/main/trxml) for [XML output](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4.xml),
[trst](https://github.com/kaby76/Domemtech.Trash/tree/main/trst) for [Antlr runtime ToStringTree output](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4.st),
[trdot](https://github.com/kaby76/Domemtech.Trash/tree/main/trdot),
[trprint](https://github.com/kaby76/Domemtech.Trash/tree/main/trprint) for input text for the parse,
and
[tragl](https://github.com/kaby76/Domemtech.Trash/tree/main/tragl).

### Convert grammars to Antlr4

    trparse ada.g2 | trconvert | trprint | less

This command parses an [old Antlr2 grammar](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g2)
using [trparse](https://github.com/kaby76/Domemtech.Trash/tree/main/trparse),
converts the parse tree data to Antlr4 syntax using
 [trconvert](https://github.com/kaby76/Domemtech.Trash/tree/main/trconvert)
 and
finally [prints out the converted parse tree data, ada.g4](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/trconvert/antlr2/ada.g4)
using
[trprint](https://github.com/kaby76/Domemtech.Trash/tree/main/trprint). Other
grammar that can be converted are Antlr3, Bison, and ISO EBNF. In order to
use the grammar to parse data, you will need to convert it to an Antlr4 grammar.

### Generate a parser application

    mkdir foobar; cd foobar; \
        trgen

This command creates a parser application for the C# target.
If executed in an empty directory, which is done in the example
shown above, [trgen](https://github.com/kaby76/Domemtech.Trash/tree/main/trgen)
creates an application using the Arithmetic grammar.
If executed in a directory containing
a Antlr Maven plugin (`pom.xml`), `trgen` will create a program according
to the information specified in the `pom.xml` file. Either way, it creates a directory
`Generated/`, and places the source code there.

`trgen` has many options to generate a parser from any Antlr4 grammar, for any target.
But, if a parser is generated for the C# target, built using the NET SDK, then `trparse`
can execute the generated parser, and can be used with all the other tools in Trash. _NB:
In order to use the generate parser application, you must first build it:

    dotnet restore Generated/Test.csproj
    dotnet build Generated/Test.csproj

### Run the generated parser application

    trparse -i "1+2+3" | trtree

After using `trgen` to generate a parser program in C#, shown previously,
and after building the program, you can run the parser using `trparse`. This program 
looks for the generated parser in directory `Generated/`. If it exists,
it will run the parser application in the directory. You can pass
as command-line arguments an input string or input file. If no command-line
arguments are supplied, the program will read stdin. The output of `trparse`, as
with most tools of Trash, is parse tree data.

### Find nodes in the parse tree using XPath

    mkdir empty; cd empty; trgen; dotnet build Generated/Test.csproj; \
        trparse -i "1+2+3" | trxgrep " //SCIENTIFIC_NUMBER" | trst

With this command, a directory is created, the Arithmetic grammar generated, build,
and then run using [trparse](https://github.com/kaby76/Domemtech.Trash/tree/main/trparse).
The `trparse` tool unifies all parsing, whether it's parsing a grammar or parsing input
using a generated parser application. The output from the `trparse` tool is a parse
tree which you can search. [Trxgrep](https://github.com/kaby76/Domemtech.Trash/tree/main/trxgrep)
is the generalized search program for parse trees. `Trxgrep` uses XPath expressions to
precisely identify nodes in the parse tree.

XPath was added to Antlr4, but `Trash` takes the idea
further with the addition of an XPath2 engine ported from the
[Eclipse Web toolkit](https://git.eclipse.org/r/admin/repos/sourceediting%2Fwebtools.sourceediting).
XPath is a well-defined language that should be
used more often in compiler construction.

### Rename a symbol in a grammar, generate a parser for new grammar

    trparse Arithmetic.g4 | trrename "//parserRuleSpec//labeledAlt//RULE_REF[text() = 'expression']" "xxx" | trtext > new-source.g4
    trparse Arithmetic.g4 | trrename -r "expression,expression_;atom,atom_;scientific,scientific_" | trprint

In these two examples, the Arithmetic grammar is parsed.
[trrename](https://github.com/kaby76/Domemtech.Trash/tree/main/trrename) reads the parse tree data and
modifies it by renaming the `expression` symbol two ways: first by XPath expression identifying the LHS terminal
symbol of the `expression` symbol, and the second by assumption that the tree is an Antlr4 parse tree,
then renaming a semi-colon-separated list of paired renames. The resulting code is reconstructed and saved.
`trrename` does not rename symbols in actions, nor does it rename identifiers corresponding to the
grammar symbols in any support source code (but it could if the tool is extended).

### Count method declarations in a Java source file

    git clone https://github.com/antlr/grammars-v4.git; \
        cd grammars-v4/java/java9; \
        trgen; dotnet build Generated/Test.csproj;\
        trparse examples/AllInOne8.java | trxgrep " //methodDeclaration" | trst | wc

This command clones the Antlr4 grammars-v4 repo, generates a parser for the Java9 grammar,
then runs the parser on [examples/AllInOne8.java](https://github.com/antlr/grammars-v4/blob/master/java/java9/examples/AllInOne8.java).
The parse tree is then piped to `trxgrep` to find all parse tree nodes that are
a `methodDeclaration` type, converts it to a simple string, and counts the result using
`wc`.

### Strip a grammar of all non-essential CFG

    trparse Java9.g4 | trstrip | trtext > Essential-Java9.g4

### Split a grammar

Since Antlr2, one can written a combined parser/lexer in one file,
or a split parser/lexer in two files.
While it's not hard to split or combine
a grammar, it's tedious. For automating transformations, it's
necessary because Antlr4 requires the grammars to be split
when super classes are needed for different targets.

    trcombine ArithmeticLexer.g4 ArithmeticParser.g4 | trprint > Arithmetic.g4

This command calls [trcombine](https://github.com/kaby76/Domemtech.Trash/tree/main/trcombine)
which parses two split grammar files
[ArithmeticLexer.g4](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/combine/ArithmeticLexer.g4)
and
[ArithmeticParser.g4](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/combine/ArithmeticParser.g4),
and creates a [combined grammar](https://github.com/kaby76/Domemtech.Trash/blob/main/_tests/combine/Arithmetic.g4)
for the two.

    trparse Arithmetic.g4 | trsplit | trsponge -o true

This command calls [trsplit](https://github.com/kaby76/Domemtech.Trash/tree/main/trsplit)
which splits the grammar into two parse tree results, one that defines
ArithmeticLexer.g4 and the other that defines ArithmeticParser.g4.
The tool [trsponge](https://github.com/kaby76/Domemtech.Trash/tree/main/trsponge)
is similar to the [tee](https://en.wikipedia.org/wiki/Tee_(command)) in
Linux: the parse tree data is split and placed in files.

## Parsing Result Sets -- the data passed between commands

A *parsing result set* is a JSON serialization of an array of:

* A set of parse tree nodes.
* Parser information related to the parse tree nodes.
* Lexer information related to the parse tree nodes.
* The name of the input corresponding to the parse tree nodes.
* The input text corresponding to the parse tree nodes.

Most commands in Trash read and/or write parsing result sets.

## Commands of Trash

The list of currently available commands is:

    tragl -- display a parse tree using Microsoft Automatic Graph Layout
    tranalyze -- analyze a grammar
    trcombine -- combine a split Antlr4 grammar
    trconvert -- convert a grammar from one for to another
    trdelabel -- remove labels from an Antlr4 grammar
    trdelete -- delete a point in a parse tree
    trdot -- print a parse tree in Graphvis Dot format
    trfold -- perform fold transform on a grammar
    trfoldlit -- perform fold transform on grammar with literals
    trformat -- perform reformat of grammar using machine learning
    trgen -- generate an Antlr4 parser for a given target language
    trgroup -- perform a group transform on a grammar
    trinsert -- insert a string into a point in a parse tree
    trjson -- print a parse tree in JSON
    trkleene -- perform a Kleene transform of a grammar
    trparse -- parse a grammar or use generated parse to parse input
    trprint -- print a parse tree leaves
    trrename -- rename symbols in a grammar
    trrr -- convert left recursion in a grammar to right recursion
    trrup -- remove useless parentheses in a grammar
    trsplit -- split a combined Antlr4 grammar
    trsponge -- extract parsing results output of Trash command into files
    trst -- print a parse tree in Antlr4 ToStringTree()
    trstrip -- strip a grammar of all actions, labels, etc.
    trtext -- print a parse tree leaves
    trtokens -- print tokens in a parse tree
    trtree -- print a parse tree in a human-readable format
    trunfold -- perform an unfold transform on a grammar
    trungroup -- perform an ungroup transform on a grammar
    trwdog -- kill a program that runs too long
    trxgrep -- grep for nodes in a parse tree using XPath
    trxml -- print a parse tree in XML
    trxml2 -- print an enumeration of all paths in a parse tree to leaves

## Supported grammars

| Grammars | File suffix |
| ---- | ---- |
| Antlr4 | .g4 |
| Antlr3 | .g3 |
| Antlr2 | .g2 |
| Bison | .y |
| LBNF | .cf |
| W3C EBNF | .ebnf |
| ISO 14977 | .iso14977, .iso |

## Analysis

### Recursion

* [Has direct/indirect recursion](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/analysis.md#has-directindirect-recursion)

## Refactoring

Antlrvsix provides a number of transformations that can help to make grammars cleaner (reformatting),
more readable (reducing the length of the RHS of a rule),
and more efficient (reducing the number of non-terminals) for Antlr.

Some of these refactorings are very specific for Antlr due to the way
the parser works, e.g., converting a prioritized chain of productions recognizing
an arithmetic expression to a recursive alternate form.
The refactorings implemented are:

### Raw tree editing

* [Delete parse tree node](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#delete-parse-tree-node)

### Reordering

* [Move start rule to top](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#move-start-rule)
* [Reorder parser rules](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#reorder-parser-rules)
* [Sort modes](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#sort-modes)

### Changing rules

* [Remove useless parentheses](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#remove-useless-parentheses)
* [Remove useless parser rules](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#remove-useless-productions)
* [Rename lexer or parser symbol](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#rename)
* [Unfold](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#Unfold)
* [Group alts](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#group-alts)
* [Ungroup alts](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#ungroup-alts)
* [Upper and lower case string literals](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#upper-and-lower-case-string-literals)
* [Fold](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#Fold)
* Replace direct left recursion with right recursion
* [Replace direct left/right recursion with Kleene operator](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#Kleene)
* Replace indirect left recursion with right recursion
* Replace parser rule symbols that conflict with Antlr keywords
* [Replace string literals in parser with lexer symbols](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#replace-literals-in-parser-with-lexer-token-symbols)
* Replace string literals in parser with lexer symbols, with lexer rule create
* [Delabel removes the annoying and mostly useless labeling in an Antlr grammar](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#delabel)

### Splitting and combining

* [Split combined grammars](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#splitting-and-combining-grammars)
* [Combine splitted grammars](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/refactoring.md#splitting-and-combining-grammars)

## Conversion

* [Antlr3 import](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/Import.md#antlr3)
* [Antlr2 import](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/Import.md#antlr2)
* [Bison import](https://github.com/kaby76/AntlrVSIX/blob/master/Trash/doc/Import.md#bison)

---------

The source code for the extension is open source, free of charge, and free of ads. For the latest developments on the extension,
check out my [blog](http://codinggorilla.com).

# Building

    git clone https://github.com/kaby76/Domemtech.TrashBase
    cd Domemtech.TrashBase
    make
    cd ..
    git clone https://github.com/kaby76/Domemtech.Trash
    cd Domemtech.Trash
    make; make install
    
You must have the NET SDK installed to build and run.

# Current release

## 0.16.4.

This release contains significant changes in the representation and operations
on parse tree data, which is passed from one app to another of the toolkit. trinsert,
trdelete, and trmove now perform editing on the Antlr data structures to provide a
consistent data structure. For example, when a sub-tree is deleted from a parse tree, the
associated token stream and character stream need to be adjusted to delete tokens and
characters in the input file. This goes far beyond anything offered in the Antlr4 runtime: [TokenStreamRewriter](https://www.antlr.org/api/Java/org/antlr/v4/runtime/TokenStreamRewriter.html) allows one to 
insert character input, but it does not modify the token stream or underlying buffer.
Char stream, token stream and parse tree are all kept consistent. This allows for faster
chained operations.

There are many bug fixes in this release. Generated driver programs from trgen all now
have timing information. trsplit is again working. trinsert, trdelete, trmove have all
been changed to not reparse the changed parse tree data. trparse now has a "-p" option to
specify where the built generated parser driver program. It also has a "-e" option to only
output the errors from the parse and avoid outputing parse tree data. "trsort" was added.

This version of the toolkit was used to scrape and refactor the Dart2 grammar from the
[Dart Language Specification](https://github.com/dart-lang/language/blob/master/specification/dartLangSpec.tex).

# Prior Releases

# Roadmap

## Planned for v1

Trash is a long-term project (already going on 3 years).
I'm envisioning for the "first" release to support:

* reading and conversion of ABNF, Antlr2/3/4, Bison, Coco/R,
ISO14977, JavaCC, Lark, LBNF, Pegen, Peg.js, Pest, Rex,
W3C EBNF, XText
* xgrep
* print a parse tree in various formats
* sponge (converts parse tree data into files)
* basic refactorings (insert, delete, rename, reorder, split,
combine, fold, unfold)
* basic analyses (indirect and direct recursion, infinite recursion,
LL(1), LR(1), LALR(1),
SLR(1), LR(0), etc)
* string generation from grammars
* grammar extraction from pdfs and text files
* full documentation

If you have any questions, email me at ken.domino <at> gmail.com
