﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\HP\source\repos\c#\Laba1_Spreadsheet\Laba1_Spreadsheet\Calc.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Laba1_Spreadsheet {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CalcParser : Parser {
	public const int
		T__0=1, NUMBER=2, IDENTIFIER=3, INT=4, EXPONENT=5, MULTIPLY=6, DIVIDE=7, 
		SUBTRACT=8, ADD=9, MAX=10, MIN=11, DESP=12, MMAX=13, MMIN=14, LPAREN=15, 
		RPAREN=16, WS=17;
	public const int
		RULE_compileUnit = 0, RULE_expression = 1, RULE_arglist = 2;
	public static readonly string[] ruleNames = {
		"compileUnit", "expression", "arglist"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", null, null, null, "'^'", "'*'", "'/'", "'-'", "'+'", "'max'", 
		"'min'", "','", "'mmax'", "'mmin'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, "NUMBER", "IDENTIFIER", "INT", "EXPONENT", "MULTIPLY", "DIVIDE", 
		"SUBTRACT", "ADD", "MAX", "MIN", "DESP", "MMAX", "MMIN", "LPAREN", "RPAREN", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public CalcParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class CompileUnitContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(CalcParser.Eof, 0); }
		public CompileUnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_compileUnit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterCompileUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitCompileUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompileUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CompileUnitContext compileUnit() {
		CompileUnitContext _localctx = new CompileUnitContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_compileUnit);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 6; expression(0);
			State = 7; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ParenthesizedExprContext : ExpressionContext {
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(CalcParser.RPAREN, 0); }
		public ParenthesizedExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterParenthesizedExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitParenthesizedExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesizedExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnarMinusExprContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public UnarMinusExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterUnarMinusExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitUnarMinusExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnarMinusExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnarPlusExprContext : ExpressionContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public UnarPlusExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterUnarPlusExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitUnarPlusExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnarPlusExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ExponentialExprContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode EXPONENT() { return GetToken(CalcParser.EXPONENT, 0); }
		public ExponentialExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterExponentialExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitExponentialExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExponentialExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultiplicativeExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLY() { return GetToken(CalcParser.MULTIPLY, 0); }
		public ITerminalNode DIVIDE() { return GetToken(CalcParser.DIVIDE, 0); }
		public MultiplicativeExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMultiplicativeExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMultiplicativeExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicativeExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditiveExprContext : ExpressionContext {
		public IToken operatorToken;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ADD() { return GetToken(CalcParser.ADD, 0); }
		public ITerminalNode SUBTRACT() { return GetToken(CalcParser.SUBTRACT, 0); }
		public AdditiveExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterAdditiveExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitAdditiveExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditiveExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberExprContext : ExpressionContext {
		public ITerminalNode NUMBER() { return GetToken(CalcParser.NUMBER, 0); }
		public NumberExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterNumberExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitNumberExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumberExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IdentifierExprContext : ExpressionContext {
		public ITerminalNode IDENTIFIER() { return GetToken(CalcParser.IDENTIFIER, 0); }
		public IdentifierExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterIdentifierExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitIdentifierExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdentifierExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MaxMinExprContext : ExpressionContext {
		public IToken operatorToken;
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(CalcParser.RPAREN, 0); }
		public ITerminalNode MAX() { return GetToken(CalcParser.MAX, 0); }
		public ITerminalNode MIN() { return GetToken(CalcParser.MIN, 0); }
		public MaxMinExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMaxMinExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMaxMinExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMaxMinExpr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MmaxMminExprContext : ExpressionContext {
		public IToken operatorToken;
		public ArglistContext paramlist;
		public ITerminalNode LPAREN() { return GetToken(CalcParser.LPAREN, 0); }
		public ArglistContext arglist() {
			return GetRuleContext<ArglistContext>(0);
		}
		public ITerminalNode MMAX() { return GetToken(CalcParser.MMAX, 0); }
		public ITerminalNode MMIN() { return GetToken(CalcParser.MMIN, 0); }
		public MmaxMminExprContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterMmaxMminExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitMmaxMminExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMmaxMminExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(_ctx, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 30;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case LPAREN:
				{
				_localctx = new ParenthesizedExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 10; Match(LPAREN);
				State = 11; expression(0);
				State = 12; Match(RPAREN);
				}
				break;
			case SUBTRACT:
				{
				_localctx = new UnarMinusExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 14; Match(SUBTRACT);
				State = 15; expression(9);
				}
				break;
			case ADD:
				{
				_localctx = new UnarPlusExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 16; Match(ADD);
				State = 17; expression(8);
				}
				break;
			case NUMBER:
				{
				_localctx = new NumberExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 18; Match(NUMBER);
				}
				break;
			case IDENTIFIER:
				{
				_localctx = new IdentifierExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 19; Match(IDENTIFIER);
				}
				break;
			case MAX:
			case MIN:
				{
				_localctx = new MaxMinExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 20;
				((MaxMinExprContext)_localctx).operatorToken = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==MAX || _la==MIN) ) {
					((MaxMinExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 21; Match(LPAREN);
				State = 22; expression(0);
				State = 23; Match(T__0);
				State = 24; expression(0);
				State = 25; Match(RPAREN);
				}
				break;
			case MMAX:
			case MMIN:
				{
				_localctx = new MmaxMminExprContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 27;
				((MmaxMminExprContext)_localctx).operatorToken = _input.Lt(1);
				_la = _input.La(1);
				if ( !(_la==MMAX || _la==MMIN) ) {
					((MmaxMminExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
				} else {
					if (_input.La(1) == TokenConstants.Eof) {
						matchedEOF = true;
					}

					_errHandler.ReportMatch(this);
					Consume();
				}
				State = 28; Match(LPAREN);
				State = 29; ((MmaxMminExprContext)_localctx).paramlist = arglist();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			_ctx.stop = _input.Lt(-1);
			State = 43;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 41;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
					case 1:
						{
						_localctx = new ExponentialExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 32;
						if (!(Precpred(_ctx, 7))) throw new FailedPredicateException(this, "Precpred(_ctx, 7)");
						State = 33; Match(EXPONENT);
						State = 34; expression(8);
						}
						break;

					case 2:
						{
						_localctx = new MultiplicativeExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 35;
						if (!(Precpred(_ctx, 6))) throw new FailedPredicateException(this, "Precpred(_ctx, 6)");
						State = 36;
						((MultiplicativeExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MULTIPLY || _la==DIVIDE) ) {
							((MultiplicativeExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 37; expression(7);
						}
						break;

					case 3:
						{
						_localctx = new AdditiveExprContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 38;
						if (!(Precpred(_ctx, 5))) throw new FailedPredicateException(this, "Precpred(_ctx, 5)");
						State = 39;
						((AdditiveExprContext)_localctx).operatorToken = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==SUBTRACT || _la==ADD) ) {
							((AdditiveExprContext)_localctx).operatorToken = _errHandler.RecoverInline(this);
						} else {
							if (_input.La(1) == TokenConstants.Eof) {
								matchedEOF = true;
							}

							_errHandler.ReportMatch(this);
							Consume();
						}
						State = 40; expression(6);
						}
						break;
					}
					} 
				}
				State = 45;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,2,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class ArglistContext : ParserRuleContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ArglistContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arglist; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterArglist(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitArglist(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitArglist(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ArglistContext arglist() {
		ArglistContext _localctx = new ArglistContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_arglist);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 46; expression(0);
			State = 49;
			_errHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 47; Match(T__0);
					State = 48; expression(0);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 51;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,3,_ctx);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 7);

		case 1: return Precpred(_ctx, 6);

		case 2: return Precpred(_ctx, 5);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x13\x38\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3!\n\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\a\x3,\n\x3\f\x3\xE\x3/\v\x3\x3\x4\x3\x4\x3"+
		"\x4\x6\x4\x34\n\x4\r\x4\xE\x4\x35\x3\x4\x2\x2\x3\x4\x5\x2\x2\x4\x2\x6"+
		"\x2\x2\x6\x3\x2\f\r\x3\x2\xF\x10\x3\x2\b\t\x3\x2\n\v>\x2\b\x3\x2\x2\x2"+
		"\x4 \x3\x2\x2\x2\x6\x30\x3\x2\x2\x2\b\t\x5\x4\x3\x2\t\n\a\x2\x2\x3\n\x3"+
		"\x3\x2\x2\x2\v\f\b\x3\x1\x2\f\r\a\x11\x2\x2\r\xE\x5\x4\x3\x2\xE\xF\a\x12"+
		"\x2\x2\xF!\x3\x2\x2\x2\x10\x11\a\n\x2\x2\x11!\x5\x4\x3\v\x12\x13\a\v\x2"+
		"\x2\x13!\x5\x4\x3\n\x14!\a\x4\x2\x2\x15!\a\x5\x2\x2\x16\x17\t\x2\x2\x2"+
		"\x17\x18\a\x11\x2\x2\x18\x19\x5\x4\x3\x2\x19\x1A\a\x3\x2\x2\x1A\x1B\x5"+
		"\x4\x3\x2\x1B\x1C\a\x12\x2\x2\x1C!\x3\x2\x2\x2\x1D\x1E\t\x3\x2\x2\x1E"+
		"\x1F\a\x11\x2\x2\x1F!\x5\x6\x4\x2 \v\x3\x2\x2\x2 \x10\x3\x2\x2\x2 \x12"+
		"\x3\x2\x2\x2 \x14\x3\x2\x2\x2 \x15\x3\x2\x2\x2 \x16\x3\x2\x2\x2 \x1D\x3"+
		"\x2\x2\x2!-\x3\x2\x2\x2\"#\f\t\x2\x2#$\a\a\x2\x2$,\x5\x4\x3\n%&\f\b\x2"+
		"\x2&\'\t\x4\x2\x2\',\x5\x4\x3\t()\f\a\x2\x2)*\t\x5\x2\x2*,\x5\x4\x3\b"+
		"+\"\x3\x2\x2\x2+%\x3\x2\x2\x2+(\x3\x2\x2\x2,/\x3\x2\x2\x2-+\x3\x2\x2\x2"+
		"-.\x3\x2\x2\x2.\x5\x3\x2\x2\x2/-\x3\x2\x2\x2\x30\x33\x5\x4\x3\x2\x31\x32"+
		"\a\x3\x2\x2\x32\x34\x5\x4\x3\x2\x33\x31\x3\x2\x2\x2\x34\x35\x3\x2\x2\x2"+
		"\x35\x33\x3\x2\x2\x2\x35\x36\x3\x2\x2\x2\x36\a\x3\x2\x2\x2\x6 +-\x35";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Laba1_Spreadsheet
