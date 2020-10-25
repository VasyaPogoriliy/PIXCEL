grammar Calc;

/*
* Parser Rules
*/
compileUnit : expression EOF;
expression :
LPAREN expression RPAREN #ParenthesizedExpr
| '-' expression #UnarMinusExpr
| '+' expression #UnarPlusExpr
| expression EXPONENT expression #ExponentialExpr
| expression operatorToken=(MULTIPLY | DIVIDE) expression #MultiplicativeExpr
| expression operatorToken=(ADD | SUBTRACT) expression #AdditiveExpr
| NUMBER #NumberExpr
| IDENTIFIER #IdentifierExpr
| operatorToken=(MAX | MIN) LPAREN expression ';' expression RPAREN #MaxMinExpr
| operatorToken=(MMAX | MMIN) LPAREN paramlist=arglist #MmaxMminExpr
;

/*
* Lexer Rules
*/
arglist: expression (';' expression)+;
NUMBER : INT (DESP INT)?;
IDENTIFIER : [A-Z]+[1-9]+;
INT : ('0'..'9')+;
EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
MAX : 'max';
MIN : 'min';
DESP : ',';
MMAX : 'mmax';
MMIN : 'mmin';
LPAREN : '(';
RPAREN : ')';
WS : [ \t\r\n] -> channel(HIDDEN);



