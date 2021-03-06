

grammar XQuery;

xpath 
:
	( module )? EOF
	;


module 
: 	
	( versionDecl )?
	( libraryModule
		| 
		mainModule
	)
	;

versionDecl
:
	'xquery' 'version' STRING_LITERAL ('encoding' STRING_LITERAL)? separator
	;
	
mainModule 
: 
	(xqdocComment)? 
	prolog
	queryBody	 
	;

libraryModule 
: 
	(xqdocComment)? moduleDecl prolog
	;

moduleDecl
: 
	'module' 'namespace'ncnameOrKeyword EQstrippedStringLiteral separator
	;

/*
 * Note, the prolog production does not enforce the ordering requirements of the October
 * 2004 spec. This was the easiest way to handle some non-determinism problems, since we 
 * are assuming for xqDoc that we are getting valid XQuery.
 */
prolog 
:
	(
		( boundarySpaceDecl
			| defaultCollationDecl
			|  baseUriDecl 
			| constructionDecl
			| orderingModeDecl
			| emptyOrderingDecl
			| copyNamespacesDecl
			| schemaImport
			| moduleImport 
			| moduleImport 
			| namespaceDecl
			| setterOld 
			| varDecl 
			| varDecl 
			| functionDecl
			| functionDecl
			| optionDecl
		)
		separator
	)*
	;
	
setter
:
	(
		( boundarySpaceDecl
			| defaultCollationDecl
			|  baseUriDecl 
			| constructionDecl
			| orderingModeDecl
			| emptyOrderingDecl
			| copyNamespacesDecl
		)
		separator
	)
	;	
		
setterOld
:
	(
		'declare' 'default' 
		(
			( 'element' 'namespace' STRING_LITERAL )
			|
			( 'function' 'namespace'strippedStringLiteral )			
		)					
	)
	;

separator
:
	SEMICOLON
	;
	
namespaceDecl
:
	'declare' 'namespace'ncnameOrKeyword EQstrippedStringLiteral
	;

boundarySpaceDecl
:
	'declare' 'boundary-space' ('preserve' | 'strip')
	;

optionDecl
:
	'declare' 'option' qName STRING_LITERAL
	;

orderingModeDecl
:
	'declare' 'ordering' ('ordered' | 'unordered')
	;

emptyOrderingDecl
:
	'declare' 'default' 'order' 'empty' ( 'greatest' | 'least' ) 
	;

copyNamespacesDecl
:
	'declare' 'copy-namespaces' ('preserve' | 'no-preserve') COMMA ('inherit' | 'no-inherit' )
	;

defaultCollationDecl
:
	'declare' 'default' 'collation' STRING_LITERAL
	;
	
baseUriDecl
:
	'declare' 'base-uri' STRING_LITERAL
	;

schemaImport
:
	'import' 'schema' ( schemaPrefix )? STRING_LITERAL ( 'at' STRING_LITERAL (COMMA STRING_LITERAL)*)?
	;
	
schemaPrefix
:
	('namespace'ncnameOrKeyword EQ) | ('default' 'element' 'namespace')
	;

moduleImport
:
	(xqdocComment)? 'import' 'module' ( 'namespace'ncnameOrKeyword EQ )?strippedStringLiteral ('at'STRING_LITERAL (COMMA STRING_LITERAL)* )?		
	;

varDecl
:
	(xqdocComment)? 'declare' 'variable' DOLLARqName( typeDeclaration )? ( (COLON EQ exprSingle ) | 'external' )
	;
	
constructionDecl
:
	'declare' 'construction' ('preserve' | 'strip')
	;

annotations
:
    (annotation)*
;
    
annotation
:
	MODqName
	(LPAREN annotList RPAREN)?
;

annotList 
:
	annotationParam ( COMMA annotationParam )*
	;

annotationParam 
:STRING_LITERAL
	;

functionDecl
:
	(xqdocComment)? 	
	'declare' (annotations)? 'function'qName	
	LPAREN ( paramList )?
	RPAREN ( returnType )?
	( functionBody | 'external' )
	;

returnType 
: 
	'as' sequenceType ;
	
functionBody 
:
	
	 LCURLY expr  RCURLY
	;
	
paramList 
:
	param ( COMMA param )*
	;

param
:
	DOLLARqName ( typeDeclaration )?
	;

enclosedExpr 
:
	LCURLY
	expr RCURLY
	;

queryBody 
:
	expr
;

expr 
:
	exprSingle ( ARROW exprSingle )* ( BANG exprSingle )* ( COMMA exprSingle ( ARROW exprSingle )* ( BANG exprSingle )* )*
	;

exprSingle 
: flworExpr
	| quantifiedExpr
	| switchExpr
	| typeswitchExpr
	| existUpdateExpr
	| ifExpr 
	| tryCatchExpr
	| inlineFunctionExpr
	| orExpr
	;
	
inlineFunctionExpr
:
	'function' LPAREN ( paramList )?
	RPAREN ( returnType )?
	functionBody
	;

tryCatchExpr
:
	'try' LCURLY expr RCURLY 'catch' LPAREN DOLLARqName RPAREN LCURLY expr RCURLY
	;
	
existUpdateExpr
:
	'update'
	(
		existReplaceExpr
		| existValueExpr
		| existInsertExpr
		| existDeleteExpr
		| existRenameExpr
	)	
	;
	
existReplaceExpr
:
	'replace' expr 'with' exprSingle
	;

existValueExpr
:
	'value' expr 'with' exprSingle
	;
	
existInsertExpr
:
	'insert' exprSingle 
	( 'into' | 'preceding' | 'following' ) exprSingle
	;

existDeleteExpr
:
	'delete' exprSingle
	;

existRenameExpr
:
	'rename' exprSingle 'as' exprSingle
	;
				
flworExpr 
:
	( forClause | letClause )+ ( whereClause )? ( orderByClause )? 'return' exprSingle
	;

forClause 
:
	'for' inVarBinding ( COMMA inVarBinding )*
	;

inVarBinding
:
	DOLLARqName ( typeDeclaration )? ( positionalVar )? 'in' exprSingle
	;
	
positionalVar
:
	'at' DOLLARqName
	;

letClause 
:
	'let' letVarBinding ( COMMA letVarBinding )*
	;
	
letVarBinding
:
	DOLLARqName ( typeDeclaration )? COLON EQ exprSingle ( ARROW exprSingle )* ( BANG exprSingle )*
	;
	
whereClause
:
	'where' exprSingle
	;
	
orderByClause 
:
	('stable')? 'order' 'by' orderSpecList
	;
	
orderSpecList 
:
	orderSpec ( COMMA orderSpec )*
	;

orderSpec 
:
 	exprSingle orderModifier 
 	;

orderModifier
:
	( 'ascending' | 'descending' )? ( 'empty' ( 'greatest' | 'least' ) )? ( 'collation' STRING_LITERAL )?
	;

quantifiedExpr 
:
	( 'some' | 'every' ) quantifiedInVarBinding ( COMMA quantifiedInVarBinding )* 'satisfies' exprSingle
	;


quantifiedInVarBinding
:
	DOLLARqName ( typeDeclaration )? 'in' exprSingle
	;

switchExpr 
: 
	'switch' LPAREN expr RPAREN (switchCaseClause)+ 'default' 'return' exprSingle
	;

switchCaseClause
:
	( 'case' switchCaseOperand )+ 'return' exprSingle
	;

switchCaseOperand
:
    exprSingle
    ;
    	
typeswitchExpr
: 
	'typeswitch' LPAREN expr RPAREN (caseClause)+ 'default' (DOLLARqName)? 'return' exprSingle
	;

caseClause
:
	'case' (DOLLARqName 'as')? sequenceType 'return' exprSingle
	;
	
ifExpr 
: 
	'if' LPAREN expr RPAREN 'then' exprSingle ( ARROW exprSingle )* ( BANG exprSingle )* 'else' exprSingle ( ARROW exprSingle )* ( BANG exprSingle )* 
	;

orExpr 
:
	andExpr ( 'or' andExpr )*
	;

andExpr 
:
	comparisonExpr ( 'and' comparisonExpr )*
	;

comparisonExpr 
:
	stringConcatExpr ( LT LT rangeExpr 
		| GT GT rangeExpr
		| ( ( 'eq' | 'ne' | 'lt' | 'le' | 'gt' | 'ge' ) rangeExpr )
		| ( ( EQ | NEQ | GT | GTEQ | LT | LTEQ ) rangeExpr )
		| ( ( 'is' ) rangeExpr )
	)?
	;

stringConcatExpr
:
    rangeExpr ( CONCAT rangeExpr )*
    ;
    
rangeExpr 
:
	additiveExpr ( 'to' additiveExpr )?
	;

additiveExpr 
:
	multiplicativeExpr ( ( PLUS | MINUS ) multiplicativeExpr )*
	;

multiplicativeExpr 
:
	unionExpr ( ( STAR | 'div' | 'idiv' | 'mod' ) unionExpr )*
	;

unionExpr 
:
	intersectExceptExpr
	( ( 'union' | UNION ) intersectExceptExpr )*
	;

intersectExceptExpr 
:
	instanceofExpr
	( ( 'intersect' | 'except' ) instanceofExpr )*
	;
	
instanceofExpr 
:
	treatExpr ( 'instance' 'of' sequenceType )?
	;

treatExpr
:
	castableExpr ('treat' 'as' sequenceType)?
	;
	
castableExpr 
:
	castExpr ( 'castable' 'as' singleType )?
	;
	
castExpr 
:
	unaryExpr ( 'cast' 'as' singleType )?
	;

unaryExpr 
:
	(MINUS | PLUS)* valueExpr
	;
	
valueExpr	
:
	validateExpr | pathExpr | extensionExpr
	;
	
validateExpr
:
	'validate' (validationMode)? LCURLY expr RCURLY
	;

extensionExpr
:
	(PRAGMA)+ LCURLY (expr)? RCURLY
	;
	
pathExpr 
:
	relativePathExpr
	| SLASH relativePathExpr
	|
	SLASH
	|
	DSLASH relativePathExpr
	;

relativePathExpr 
:
	stepExpr ( ( SLASH | DSLASH | BANG | ARROW ) stepExpr )*
	;

stepExpr 
: axisStep
	| filterExpr
	| filterExpr
	| filterExpr
	|
	axisStep
	;
	
axisStep 
:
	( forwardOrReverseStep ) predicateList
	;
	
forwardOrReverseStep 
: forwardAxis nodeTest
	| reverseAxis nodeTest
	|
	abbrevStep
	;
	
abbrevStep 
:
	( AT )? nodeTest | PARENT
	;
	
forwardAxis 
: 
	forwardAxisSpecifier COLON COLON ;

forwardAxisSpecifier
:
	'child' | 'self' | 'attribute' | 'descendant' | 'descendant-or-self' | 'following' | 'following-sibling'
	;
	
reverseAxis 
: 
	reverseAxisSpecifier COLON COLON ;

reverseAxisSpecifier
:
	'parent' | 'ancestor' | 'ancestor-or-self' | 'preceding' | 'preceding-sibling'
	;
	
nodeTest 
: kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	|
	nameTest
	;

nameTest
: wildcard
	|qName
	;
	
wildcard
: STAR COLONncnameOrKeyword
	|ncnameOrKeyword COLON STAR
	|
	// *
	STAR
	;
	
filterExpr 
: 
	primaryExpr predicateList 
	;
	
predicateList 
:
	( predicate )*
	;

predicate 
:
	LPPAREN expr RPPAREN
	;
	
primaryExpr
:
	orderedExpr
	|
	unorderedExpr
	| computedConstructor
	| computedConstructor
	|
	constructor
	|
	functionCall
	|
	contextItemExpr
	|
	parenthesizedExpr
	|
	DOLLARqName
	|
	literal
	;
	
literal
:
	STRING_LITERAL | numericLiteral
	;

numericLiteral
:
	DOUBLE_LITERAL | DECIMAL_LITERAL | INTEGER_LITERAL
	;

parenthesizedExpr 
:
	LPAREN ( expr )? RPAREN
	;
	
contextItemExpr 
: 
	SELF 
	;
	
orderedExpr
:
	'ordered' LCURLY expr RCURLY
	;

unorderedExpr
:
	'unordered' LCURLY expr RCURLY
	;

functionCall
:qName LPAREN ( functionParameters )? RPAREN	
	;	
	
functionParameters 
:
	exprSingle ( COMMA exprSingle )*
	;


constructor
:
	directConstructor
	|
	computedConstructor
	;
	
directConstructor
:
	dirElemConstructor
	|
	dirCommentConstructor
	|
	dirPIConstructor
	;
	
dirElemConstructor 
: elementWithAttributes | elementWithoutAttributes
	;

elementWithoutAttributes
:
	LTqName
	(
		(
			SLASH GT
		)
		|
		(
			GT
			mixedElementContent END_TAG_STARTqName GT
		)
	)
	;

elementWithAttributes
:
	LTqName attributeList
	(
		(
			SLASH GT
		)
		|
		(
			GT
			mixedElementContent END_TAG_STARTqName GT
		)
	)
	;

mixedElementContent 
:
	( dirElemContent )*
	;

dirElemContent 
:
	directConstructor
	|
	ELEMENT_CONTENT
	|
	enclosedExpr
	|
	cdataSection
	;
	
attributeList 
:
	( attributeDef )+
	;

attributeDef
:qName EQ 
	attributeValue
	;
	
attributeValue
:

	QUOT
	( quotAttrValueContent )*
	QUOT
	| 
	APOS
	( aposAttrValueContent )*
	APOS

	;

quotAttrValueContent  
:
	QUOT_ATTRIBUTE_CONTENT
	|
	attrCommonContent
	;

aposAttrValueContent 
:
	APOS_ATTRIBUTE_CONTENT
	|
	attrCommonContent
	;
	
attrCommonContent 
: LCURLY LCURLY
	|
	RCURLY RCURLY
	|
	attributeEnclosedExpr
	;


attributeEnclosedExpr 
:
	LCURLY
	expr RCURLY
	;

xqdocComment 
:XQDOC_COMMENT
	;
	
dirCommentConstructor
: 
	XML_COMMENT XML_COMMENT_END 
	;
	
dirPIConstructor 
: 
	XML_PI XML_PI_END 
	;
	
cdataSection
:
	XML_CDATA XML_CDATA_END
	;
	
computedConstructor 
:
	compDocConstructor
	|
	compElemConstructor
	|
	compAttrConstructor
	|
	compTextConstructor
	|
	compCommentConstructor
	|
	compPIConstructor
	|
	compArrayNodeConstructor
	|
	compObjectNodeConstructor
	|
	compNumberNodeConstructor
	|
	compBooleanNodeConstructor
	|
	compNullNodeConstructor
	;

compObjectNodeConstructor 
:
	'object-node' LCURLY compObjectDecl ( COMMA compObjectDecl )* RCURLY
	;

compObjectDecl
:
    exprSingle COLON exprSingle
    ;
	
compArrayNodeConstructor 
:
	'array-node' LCURLY expr RCURLY
	;
	
compNumberNodeConstructor 
:
	'number-node' LCURLY exprSingle RCURLY
	;
	
compBooleanNodeConstructor 
:
	'boolean-node' LCURLY exprSingle RCURLY
	;
	
compNullNodeConstructor 
:
	'null-node' LCURLY RCURLY
	;
	
compDocConstructor 
:
	'document' LCURLY expr RCURLY
	;
	
compElemConstructor
:	'element' LCURLY expr RCURLY LCURLY (contentExpr)? RCURLY
	|
	'element'qName LCURLY (contentExpr)? RCURLY
	;
	
contentExpr 
:	
	expr
	;

compAttrConstructor
: 'attribute' LCURLY expr RCURLY LCURLY (expr)? RCURLY
	|
	'attribute'qName LCURLY (expr)? RCURLY
	;
	
compTextConstructor 
:
	'text' LCURLY expr RCURLY
	;

compCommentConstructor 
:
	'comment' LCURLY expr RCURLY
	;
		
compPIConstructor
: 'processing-instruction' LCURLY expr RCURLY LCURLY (expr)? RCURLY
	|
	'processing-instruction'ncnameOrKeyword LCURLY (expr)? RCURLY
	;
	
singleType 
:
	atomicType ( QUESTION )?
	;
	
typeDeclaration 
: 
	'as' sequenceType 
	;

sequenceType 
: 'empty-sequence' LPAREN RPAREN | itemType ( occurrenceIndicator )?
	;
	
occurrenceIndicator
:
	QUESTION | STAR | PLUS
	;

itemType 
: 'item' LPAREN RPAREN 
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	| kindTest
	|
	atomicType
	;
	
atomicType
:qName
	;
	
kindTest
:
	documentTest | elementTest | attributeTest | schemaElementTest | schemaAttributeTest | piTest | commentTest | textTest | objectTest | arrayTest | anyKindTest
	;
anyKindTest 
: 
	'node' LPAREN RPAREN 
	;

documentTest 
: 
	'document-node' LPAREN (elementTest | schemaElementTest)? RPAREN 
	;

textTest 
: 
	'text' LPAREN RPAREN 
	;

objectTest 
: 
	'object-node' LPAREN RPAREN 
	;

arrayTest 
: 
	'array-node' LPAREN RPAREN 
	;

commentTest 
: 
	'comment' LPAREN RPAREN 
	;
		
piTest 
: 
	'processing-instruction' LPAREN (NCNAME | STRING_LITERAL)? RPAREN 
	;
	
attributeTest
: 
	'attribute' LPAREN ( attributeNameOrWildcard (COMMAqName)? ) ? RPAREN 
	;

attributeNameOrWildcard
:
	STAR 
	|qName 
	;
	
schemaAttributeTest
:
	'schema-attribute' LPARENqName RPAREN
	;
	
elementTest
: 
	'element' LPAREN ( elementNameOrWildcard (COMMAqName (QUESTION)?)? )? RPAREN 
	;

elementNameOrWildcard
:
	STAR 
	|qName 
	;

schemaElementTest
:
	'schema-element' LPARENqName RPAREN
	;	

validationMode
:
	'lax' | 'strict' 
	;
		
qName
:ncnameOrKeyword COLONncnameOrKeyword
	|ncnameOrKeyword
	;
		
/* All of the literals used in this grammar can also be
 * part of a valid QName. We thus have to test for each
 * of them below.
 */
ncnameOrKeyword
:NCNAME
	|reservedKeywords
	;

strippedStringLiteral
:STRING_LITERAL
	;
	
reservedKeywords
:
	'ancestor'
	|
	'ancestor-or-self'
	|
	'and'
	|
	'as'
	|
	'ascending'
	|
	'at'
	|
	'attribute'
	|
	'base-uri'
	|
	'boundary-space'
	|
	'by'
	|
	'case'
	|
	'cast'
	|
	'castable'
	|
	'catch'
	|
	'child'
	|
	'collation'
	|	
	'comment'
	|
	'construction'
	|
	'copy-namespaces'
	|
	'declare'
	|
	'default'
	|
	'delete'
	|	
	'descendant'
	|
	'descendant-or-self'
	|
	'descending'
	|
	'div'
	|
	'document'
	|
	'document-node'
	|
	'element'
	|
	'else'
	|
	'empty'
	|
	'empty-sequence'
	|
	'encoding'
	|
	'eq'
	|
	'every'
	|
	'except'
	|
	'external'
	|
	'following'
	|
	'following-sibling'
	|
	'for'
	|
	'function'
	|
	'ge'
	|
	'greatest'
	|
	'gt'
	|
	'idiv'
	|
	'if'
	|
	'import'
	|
	'in'
	|	
	'inherit'
	|
	'insert'
	|	
	'instance'
	|
	'intersect'
	|
	'into'
	|	
	'is'
	|
	'item'
	|
	'lax'
	|
	'le'
	|
	'least'
	|
	'let'
	|
	'lt'
	|
	'mod'
	|
	'module'
	|
	'namespace'
	|
	'ne'
	|
	'node'
	|
	'no-inherit'
	|
	'no-preserve'
	|
	'of'
	|
	'option'
	|
	'or'
	|
	'order'
	|
	'ordered'
	|
	'ordering'
	|
	'parent'
	|
	'preceding'
	|
	'preceding-sibling'
	|
	'preserve'
	|
	'processing-instruction'
	|
	'rename'
	|
	'replace'
	|	
	'return'
	|
	'satisfies'
	|
	'schema'
	|
	'schema-attribute'
	|
	'schema-element'
	|
	'self'
	|
	'some'
	|
	'stable'
	|
	'strict'
	|
	'strip'
	|
	'text'
	|
	'then'
	|
	'to'
	|
	'treat'
	|
	'try'
	|
	'typeswitch'
	|
	'xquery'
	|
	'union'
	|
	'unordered'
	|
	'update'
	|	
	'validate'
	|
	'value'
	|	
	'variable'
	|
	'version'
	|
	'where'
	|
	'with'	
	; SLASH : '/' ; DSLASH : '/' '/' ; COLON : ':' ; COMMA : ',' ; SEMICOLON : ';' ; STAR : '*' ; QUESTION : '?' ; PLUS : '+' ; MINUS : '-' ; LPPAREN : '[' ; RPPAREN : ']' ; LPAREN : '(' ; RPAREN : ')' ; SELF : '.' ; PARENT : '..' ; UNION : '|' ; AT : '@' ; DOLLAR : '$' ; ANDEQ : '&=' ; OREQ : '|=' ; EQ : '=' ; NEQ : '!=' ; GT : '>' ; GTEQ : '>=' ; QUOT : '"' ; APOS : '\''; LTEQ : '<=' ; BANG : '!'; ARROW : '=>'; MOD : '%' ; CONCAT : '||'; LT : '<' ; END_TAG_START : '</' ; LCURLY : '{' ; RCURLY : '}' ; XML_COMMENT_END : '-->' ; XML_CDATA_END : ']]>' ; XML_PI_START : '<?' ; XML_PI_END : '?>' ; LETTER
:
	( BASECHAR | IDEOGRAPHIC )
	; DIGITS
:
	( DIGIT )+
	; HEX_DIGITS
:
	( '0'..'9' | 'a'..'f' | 'A'..'F' )+
	; NMSTART
:
	( LETTER | '_' )
	; NMCHAR
:
	( LETTER | DIGIT | '.' | '-' | '_' | COMBINING_CHAR | EXTENDER )
	; NCNAME
:
	NMSTART ( NMCHAR )*
	; WS
:
	(
		' '
		|
		'\t'
		|
		'\n'
		|
		'\r'
	)+
	; EXPR_COMMENT
:
	'(:' ( CHAR | ':' | EXPR_COMMENT )* ':)'
	; XQDOC_COMMENT
:
	'(:~' ( CHAR | ':' )* ':)'
	; PRAGMA:
	'(#' WS PRAGMA_QNAME WS 
	( PRAGMA_CONTENT )? '#' ')'
	; PRAGMA_CONTENT
:
	( ~( ' ' | '\t' | '\n' | '\r' ) ) 
	( CHAR | '#' )+
	; PRAGMA_QNAME
:
	NCNAME ( ':' NCNAME )?
	; INTEGER_LITERAL : 
	{ !(inElementContent || inAttributeContent) }? DIGITS ; DOUBLE_LITERAL
:
	{ !(inElementContent || inAttributeContent) }?
	( ( '.' DIGITS ) | ( DIGITS ( '.' ( DIGIT )* )? ) ) ( 'e' | 'E' ) ( '+' | '-' )? DIGITS
	; DECIMAL_LITERAL
:
	{ !(inElementContent || inAttributeContent) }?
	( '.' DIGITS ) | ( DIGITS ( '.' ( DIGIT )* )? )
	; PREDEFINED_ENTITY_REF
:
	'&' ( 'lt' | 'gt' | 'amp' | 'quot' | 'apos' ) ';'
	; CHAR_REF
:
	'&' '#' ( DIGITS | ( 'x' HEX_DIGITS ) ) ';'
	; STRING_LITERAL
:
	'"' ( PREDEFINED_ENTITY_REF | CHAR_REF | ( '"' '"' ) | ~ ( '"' | '&' ) )*
	'"'
	|
	'\'' ( PREDEFINED_ENTITY_REF | CHAR_REF | ( '\'' '\'' ) | ~ ( '\'' | '&' ) )*
	'\''
	; QUOT_ATTRIBUTE_CONTENT
:
	( ~( '"' | '{' | '}' | '<' ) )+
	; APOS_ATTRIBUTE_CONTENT
:
	( ~( '\'' | '{' | '}' | '<' ) )+
	; ELEMENT_CONTENT
:
	( '\t' | '\r' | '\n' | '\u0020'..'\u003b' | '\u003d'..'\u007a' | '\u007c' | '\u007e'..'\uFFFD' )+
	; XML_COMMENT
:
	'<!--' ( ~ ( '-' ) | '-' )+
	; XML_CDATA
:
	'<![CDATA[' ( ~ ( ']' ) | ']' )+
	; XML_PI
:
	XML_PI_START NCNAME ' ' ( ~ ( '?' ) | '?' )+
	;

/**
 * Main method that decides which token to return next.
 * We need this as many things depend on the current
 * context. 
 */
NEXT_TOKEN
:
	XML_COMMENT
	|
	XML_CDATA
	| XML_PI
	|
	END_TAG_START
	|
	LT
	|
	LTEQ
	|
	LCURLY
	|
	RCURLY
	|
	{ inAttributeContent  && attrDelimChar == '"' }?
	QUOT_ATTRIBUTE_CONTENT
	|
	{ inAttributeContent && attrDelimChar == '\'' }?
	APOS_ATTRIBUTE_CONTENT
	|
	{ !(parseStringLiterals || inElementContent) }?
	QUOT
	|
	{ !(parseStringLiterals || inElementContent) }?
	APOS
	|
	{ inElementContent }?
	ELEMENT_CONTENT
	|
	WS
	| PRAGMA
	| XQDOC_COMMENT
	|
	EXPR_COMMENT
	|NCNAME
	|
	{ parseStringLiterals }?
	STRING_LITERAL
	|
	{ !(inAttributeContent || inElementContent) }?
	PARENT
	| DECIMAL_LITERAL
    | DECIMAL_LITERAL
	| SELF
	| DOUBLE_LITERAL
	| DECIMAL_LITERAL
	|
	INTEGER_LITERAL
	|
	SLASH
	|
	{ !(inAttributeContent || inElementContent) }?
	DSLASH
	|
	COLON
	|
	COMMA
	|
	BANG
	|
	ARROW
	|
	CONCAT
	|
	MOD
	|
	SEMICOLON
	|
	STAR
	|
	QUESTION
	|
	PLUS
	|
	MINUS
	|
	LPPAREN
	|
	RPPAREN
	|
	LPAREN
	|
	RPAREN
	|
	UNION
	|
	AT
	|
	DOLLAR
	|
	{ !(inAttributeContent || inElementContent) }?
	OREQ
	|
	{ !(inAttributeContent || inElementContent) }?
	ANDEQ
	|
	EQ
	|
	{ !(inAttributeContent || inElementContent) }?
	NEQ
	|
	XML_COMMENT_END
	|
	XML_CDATA_END
	|
	GT
	|
	{ !(inAttributeContent || inElementContent) }?
	GTEQ
	|
	XML_PI_END
	; CHAR
:
	( '\t' | '\n' | '\r' | '\u0020'..'\u0039' | '\u003B'..'\uD7FF' | '\uE000'..'\uFFFD' )
	; BASECHAR
:
	(
		'\u0041'..'\u005a'
		|
		'\u0061'..'\u007a'
		|
		'\u00c0'..'\u00d6'
		|
		'\u00d8'..'\u00f6'
		|
		'\u00f8'..'\u00ff'
		|
		'\u0100'..'\u0131'
		|
		'\u0134'..'\u013e'
		|
		'\u0141'..'\u0148'
		|
		'\u014a'..'\u017e'
		|
		'\u0180'..'\u01c3'
		|
		'\u01cd'..'\u01f0'
		|
		'\u01f4'..'\u01f5'
		|
		'\u01fa'..'\u0217'
		|
		'\u0250'..'\u02a8'
		|
		'\u02bb'..'\u02c1'
		|
		'\u0386'
		|
		'\u0388'..'\u038a'
		|
		'\u038c'
		|
		'\u038e'..'\u03a1'
		|
		'\u03a3'..'\u03ce'
		|
		'\u03d0'..'\u03d6'
		|
		'\u03da'
		|
		'\u03dc'
		|
		'\u03de'
		|
		'\u03e0'
		|
		'\u03e2'..'\u03f3'
		|
		'\u0401'..'\u040c'
		|
		'\u040e'..'\u044f'
		|
		'\u0451'..'\u045c'
		|
		'\u045e'..'\u0481'
		|
		'\u0490'..'\u04c4'
		|
		'\u04c7'..'\u04c8'
		|
		'\u04cb'..'\u04cc'
		|
		'\u04d0'..'\u04eb'
		|
		'\u04ee'..'\u04f5'
		|
		'\u04f8'..'\u04f9'
		|
		'\u0531'..'\u0556'
		|
		'\u0559'
		|
		'\u0561'..'\u0586'
		|
		'\u05d0'..'\u05ea'
		|
		'\u05f0'..'\u05f2'
		|
		'\u0621'..'\u063a'
		|
		'\u0641'..'\u064a'
		|
		'\u0671'..'\u06b7'
		|
		'\u06ba'..'\u06be'
		|
		'\u06c0'..'\u06ce'
		|
		'\u06d0'..'\u06d3'
		|
		'\u06d5'
		|
		'\u06e5'..'\u06e6'
		|
		'\u0905'..'\u0939'
		|
		'\u093d'
		|
		'\u0958'..'\u0961'
		|
		'\u0985'..'\u098c'
		|
		'\u098f'..'\u0990'
		|
		'\u0993'..'\u09a8'
		|
		'\u09aa'..'\u09b0'
		|
		'\u09b2'
		|
		'\u09b6'..'\u09b9'
		|
		'\u09dc'..'\u09dd'
		|
		'\u09df'..'\u09e1'
		|
		'\u09f0'..'\u09f1'
		|
		'\u0a05'..'\u0a0a'
		|
		'\u0a0f'..'\u0a10'
		|
		'\u0a13'..'\u0a28'
		|
		'\u0a2a'..'\u0a30'
		|
		'\u0a32'..'\u0a33'
		|
		'\u0a35'..'\u0a36'
		|
		'\u0a38'..'\u0a39'
		|
		'\u0a59'..'\u0a5c'
		|
		'\u0a5e'
		|
		'\u0a72'..'\u0a74'
		|
		'\u0a85'..'\u0a8b'
		|
		'\u0a8d'
		|
		'\u0a8f'..'\u0a91'
		|
		'\u0a93'..'\u0aa8'
		|
		'\u0aaa'..'\u0ab0'
		|
		'\u0ab2'..'\u0ab3'
		|
		'\u0ab5'..'\u0ab9'
		|
		'\u0abd'
		|
		'\u0ae0'
		|
		'\u0b05'..'\u0b0c'
		|
		'\u0b0f'..'\u0b10'
		|
		'\u0b13'..'\u0b28'
		|
		'\u0b2a'..'\u0b30'
		|
		'\u0b32'..'\u0b33'
		|
		'\u0b36'..'\u0b39'
		|
		'\u0b3d'
		|
		'\u0b5c'..'\u0b5d'
		|
		'\u0b5f'..'\u0b61'
		|
		'\u0b85'..'\u0b8a'
		|
		'\u0b8e'..'\u0b90'
		|
		'\u0b92'..'\u0b95'
		|
		'\u0b99'..'\u0b9a'
		|
		'\u0b9c'
		|
		'\u0b9e'..'\u0b9f'
		|
		'\u0ba3'..'\u0ba4'
		|
		'\u0ba8'..'\u0baa'
		|
		'\u0bae'..'\u0bb5'
		|
		'\u0bb7'..'\u0bb9'
		|
		'\u0c05'..'\u0c0c'
		|
		'\u0c0e'..'\u0c10'
		|
		'\u0c12'..'\u0c28'
		|
		'\u0c2a'..'\u0c33'
		|
		'\u0c35'..'\u0c39'
		|
		'\u0c60'..'\u0c61'
		|
		'\u0c85'..'\u0c8c'
		|
		'\u0c8e'..'\u0c90'
		|
		'\u0c92'..'\u0ca8'
		|
		'\u0caa'..'\u0cb3'
		|
		'\u0cb5'..'\u0cb9'
		|
		'\u0cde'
		|
		'\u0ce0'..'\u0ce1'
		|
		'\u0d05'..'\u0d0c'
		|
		'\u0d0e'..'\u0d10'
		|
		'\u0d12'..'\u0d28'
		|
		'\u0d2a'..'\u0d39'
		|
		'\u0d60'..'\u0d61'
		|
		'\u0e01'..'\u0e2e'
		|
		'\u0e30'
		|
		'\u0e32'..'\u0e33'
		|
		'\u0e40'..'\u0e45'
		|
		'\u0e81'..'\u0e82'
		|
		'\u0e84'
		|
		'\u0e87'..'\u0e88'
		|
		'\u0e8a'
		|
		'\u0e8d'
		|
		'\u0e94'..'\u0e97'
		|
		'\u0e99'..'\u0e9f'
		|
		'\u0ea1'..'\u0ea3'
		|
		'\u0ea5'
		|
		'\u0ea7'
		|
		'\u0eaa'..'\u0eab'
		|
		'\u0ead'..'\u0eae'
		|
		'\u0eb0'
		|
		'\u0eb2'..'\u0eb3'
		|
		'\u0ebd'
		|
		'\u0ec0'..'\u0ec4'
		|
		'\u0f40'..'\u0f47'
		|
		'\u0f49'..'\u0f69'
		|
		'\u10a0'..'\u10c5'
		|
		'\u10d0'..'\u10f6'
		|
		'\u1100'
		|
		'\u1102'..'\u1103'
		|
		'\u1105'..'\u1107'
		|
		'\u1109'
		|
		'\u110b'..'\u110c'
		|
		'\u110e'..'\u1112'
		|
		'\u113c'
		|
		'\u113e'
		|
		'\u1140'
		|
		'\u114c'
		|
		'\u114e'
		|
		'\u1150'
		|
		'\u1154'..'\u1155'
		|
		'\u1159'
		|
		'\u115f'..'\u1161'
		|
		'\u1163'
		|
		'\u1165'
		|
		'\u1167'
		|
		'\u1169'
		|
		'\u116d'..'\u116e'
		|
		'\u1172'..'\u1173'
		|
		'\u1175'
		|
		'\u119e'
		|
		'\u11a8'
		|
		'\u11ab'
		|
		'\u11ae'..'\u11af'
		|
		'\u11b7'..'\u11b8'
		|
		'\u11ba'
		|
		'\u11bc'..'\u11c2'
		|
		'\u11eb'
		|
		'\u11f0'
		|
		'\u11f9'
		|
		'\u1e00'..'\u1e9b'
		|
		'\u1ea0'..'\u1ef9'
		|
		'\u1f00'..'\u1f15'
		|
		'\u1f18'..'\u1f1d'
		|
		'\u1f20'..'\u1f45'
		|
		'\u1f48'..'\u1f4d'
		|
		'\u1f50'..'\u1f57'
		|
		'\u1f59'
		|
		'\u1f5b'
		|
		'\u1f5d'
		|
		'\u1f5f'..'\u1f7d'
		|
		'\u1f80'..'\u1fb4'
		|
		'\u1fb6'..'\u1fbc'
		|
		'\u1fbe'
		|
		'\u1fc2'..'\u1fc4'
		|
		'\u1fc6'..'\u1fcc'
		|
		'\u1fd0'..'\u1fd3'
		|
		'\u1fd6'..'\u1fdb'
		|
		'\u1fe0'..'\u1fec'
		|
		'\u1ff2'..'\u1ff4'
		|
		'\u1ff6'..'\u1ffc'
		|
		'\u2126'
		|
		'\u212a'..'\u212b'
		|
		'\u212e'
		|
		'\u2180'..'\u2182'
		|
		'\u3041'..'\u3094'
		|
		'\u30a1'..'\u30fa'
		|
		'\u3105'..'\u312c'
		|
		'\uac00'..'\ud7a3'
	)
	; IDEOGRAPHIC
:
	( '\u4e00'..'\u9fa5' | '\u3007' | '\u3021'..'\u3029' )
	; COMBINING_CHAR
:
	(
		'\u0300'..'\u0345'
		|
		'\u0360'..'\u0361'
		|
		'\u0483'..'\u0486'
		|
		'\u0591'..'\u05a1'
		|
		'\u05a3'..'\u05b9'
		|
		'\u05bb'..'\u05bd'
		|
		'\u05bf'
		|
		'\u05c1'..'\u05c2'
		|
		'\u05c4'
		|
		'\u064b'..'\u0652'
		|
		'\u0670'
		|
		'\u06d6'..'\u06dc'
		|
		'\u06dd'..'\u06df'
		|
		'\u06e0'..'\u06e4'
		|
		'\u06e7'..'\u06e8'
		|
		'\u06ea'..'\u06ed'
		|
		'\u0901'..'\u0903'
		|
		'\u093c'
		|
		'\u093e'..'\u094c'
		|
		'\u094d'
		|
		'\u0951'..'\u0954'
		|
		'\u0962'..'\u0963'
		|
		'\u0981'..'\u0983'
		|
		'\u09bc'
		|
		'\u09be'
		|
		'\u09bf'
		|
		'\u09c0'..'\u09c4'
		|
		'\u09c7'..'\u09c8'
		|
		'\u09cb'..'\u09cd'
		|
		'\u09d7'
		|
		'\u09e2'..'\u09e3'
		|
		'\u0a02'
		|
		'\u0a3c'
		|
		'\u0a3e'
		|
		'\u0a3f'
		|
		'\u0a40'..'\u0a42'
		|
		'\u0a47'..'\u0a48'
		|
		'\u0a4b'..'\u0a4d'
		|
		'\u0a70'..'\u0a71'
		|
		'\u0a81'..'\u0a83'
		|
		'\u0abc'
		|
		'\u0abe'..'\u0ac5'
		|
		'\u0ac7'..'\u0ac9'
		|
		'\u0acb'..'\u0acd'
		|
		'\u0b01'..'\u0b03'
		|
		'\u0b3c'
		|
		'\u0b3e'..'\u0b43'
		|
		'\u0b47'..'\u0b48'
		|
		'\u0b4b'..'\u0b4d'
		|
		'\u0b56'..'\u0b57'
		|
		'\u0b82'..'\u0b83'
		|
		'\u0bbe'..'\u0bc2'
		|
		'\u0bc6'..'\u0bc8'
		|
		'\u0bca'..'\u0bcd'
		|
		'\u0bd7'
		|
		'\u0c01'..'\u0c03'
		|
		'\u0c3e'..'\u0c44'
		|
		'\u0c46'..'\u0c48'
		|
		'\u0c4a'..'\u0c4d'
		|
		'\u0c55'..'\u0c56'
		|
		'\u0c82'..'\u0c83'
		|
		'\u0cbe'..'\u0cc4'
		|
		'\u0cc6'..'\u0cc8'
		|
		'\u0cca'..'\u0ccd'
		|
		'\u0cd5'..'\u0cd6'
		|
		'\u0d02'..'\u0d03'
		|
		'\u0d3e'..'\u0d43'
		|
		'\u0d46'..'\u0d48'
		|
		'\u0d4a'..'\u0d4d'
		|
		'\u0d57'
		|
		'\u0e31'
		|
		'\u0e34'..'\u0e3a'
		|
		'\u0e47'..'\u0e4e'
		|
		'\u0eb1'
		|
		'\u0eb4'..'\u0eb9'
		|
		'\u0ebb'..'\u0ebc'
		|
		'\u0ec8'..'\u0ecd'
		|
		'\u0f18'..'\u0f19'
		|
		'\u0f35'
		|
		'\u0f37'
		|
		'\u0f39'
		|
		'\u0f3e'
		|
		'\u0f3f'
		|
		'\u0f71'..'\u0f84'
		|
		'\u0f86'..'\u0f8b'
		|
		'\u0f90'..'\u0f95'
		|
		'\u0f97'
		|
		'\u0f99'..'\u0fad'
		|
		'\u0fb1'..'\u0fb7'
		|
		'\u0fb9'
		|
		'\u20d0'..'\u20dc'
		|
		'\u20e1'
		|
		'\u302a'..'\u302f'
		|
		'\u3099'
		|
		'\u309a'
	)
	; DIGIT
:
	(
		'\u0030'..'\u0039'
		|
		'\u0660'..'\u0669'
		|
		'\u06f0'..'\u06f9'
		|
		'\u0966'..'\u096f'
		|
		'\u09e6'..'\u09ef'
		|
		'\u0a66'..'\u0a6f'
		|
		'\u0ae6'..'\u0aef'
		|
		'\u0b66'..'\u0b6f'
		|
		'\u0be7'..'\u0bef'
		|
		'\u0c66'..'\u0c6f'
		|
		'\u0ce6'..'\u0cef'
		|
		'\u0d66'..'\u0d6f'
		|
		'\u0e50'..'\u0e59'
		|
		'\u0ed0'..'\u0ed9'
		|
		'\u0f20'..'\u0f29'
	)
	; EXTENDER
:
	(
		'\u00b7'
		|
		'\u02d0'
		|
		'\u02d1'
		|
		'\u0387'
		|
		'\u0640'
		|
		'\u0e46'
		|
		'\u0ec6'
		|
		'\u3005'
		|
		'\u3031'..'\u3035'
		|
		'\u309d'..'\u309e'
		|
		'\u30fc'..'\u30fe'
	)
	;
