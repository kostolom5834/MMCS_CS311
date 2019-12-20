%{
// Ёти объ€влени€ добавл€ютс€ в класс GPPGParser, представл€ющий собой парсер, генерируемый системой gppg
    public Parser(AbstractScanner<int, LexLocation> scanner) : base(scanner) { }
%}

%output = SimpleYacc.cs

%namespace SimpleParser

%token BEGIN END CYCLE INUM RNUM ID ASSIGN SEMICOLON FOR TO DO REPEAT UNTIL WHILE THEN IF ELSE//for to do

%%

progr   : block
		;

stlist	: statement 
		| stlist SEMICOLON statement 
		;

statement: assign
		| block  
		| cycle  
		| for //
		| repeat
		| while
		| if
		| write
		| var
		;

ident 	: ID 
		;
	
assign 	: ident ASSIGN expr 
		;

expr	: ident  
		| INUM 
		;

block	: BEGIN stlist END 
		;

cycle	: CYCLE expr statement 
		;

for		: FOR assign TO expr DO stlist //
		;
	
repeat	: REPEAT cycle UNTIL
		;

while	: WHILE assign CYCLE
		;

if		: IF assign THEN ident ELSE ident
		;
%%
