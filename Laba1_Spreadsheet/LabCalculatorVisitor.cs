using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace Laba1_Spreadsheet
{
    class CalcVisitor : CalcBaseVisitor<double>
    {
        //Dictionary<string, double> tableIdentifier = new Dictionary<string, double>();
        public override double VisitCompileUnit(CalcParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitNumberExpr(CalcParser.NumberExprContext context)
        {
            var result = Convert.ToDouble(context.GetText());
            Debug.WriteLine(result);
            return result;

        }
        //IdentifierExpr
        public override double VisitIdentifierExpr(CalcParser.IdentifierExprContext context)
        {
            var expr = context.GetText();
            if (Form1.GetFormCopy().IsContainValue(expr))
            {
                return Double.Parse((Form1.GetFormCopy().GetValueFromName(expr)));
            }
            else
            {
                return 0.0;
            }
        }
        public override double VisitParenthesizedExpr(CalcParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitExponentialExpr(CalcParser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("{0} ^ {1}", left, right);
            return System.Math.Pow(left, right);
        }
        public override double VisitAdditiveExpr(CalcParser.AdditiveExprContext context)
        {           
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == CalcLexer.ADD)
            {
                Debug.WriteLine("{0} + {1}", left, right);
                return left + right;
            }
            else //LabCalculatorLexer.SUBTRACT
            {
                Debug.WriteLine("{0} - {1}", left, right);
                return left - right;
            }
        }
        public override double VisitMultiplicativeExpr(CalcParser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == CalcLexer.MULTIPLY)
            {
                Debug.WriteLine("{0} * {1}", left, right);
                return left * right;
            }

            else
            {
                Debug.WriteLine("{0} / {1}", left, right);
                return left / right;
            }
        }   
        public override double VisitMaxMinExpr(CalcParser.MaxMinExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == CalcLexer.MAX)
            {
                Debug.WriteLine("max( {0} , {1} )", left, right);

                return Math.Max(left, right);
            }

            else
            {
                Debug.WriteLine("min( {0} , {1} )", left, right);
                return Math.Min(left, right);
            }
        }
        public override double VisitMmaxMminExpr(CalcParser.MmaxMminExprContext context)
        {
            double maxValue = Double.NegativeInfinity;
            double minValue = Double.PositiveInfinity;

            if (context.operatorToken.Type == CalcLexer.MMAX)
            {
                foreach (var expr in context.paramlist.children.OfType<CalcParser.ExpressionContext>())
                {
                    double exprValue = Visit(expr);

                    if (exprValue > maxValue)
                    {
                        maxValue = exprValue;
                    }
                }
                return maxValue;
            }
            else
            {
                foreach (var expr in context.paramlist.children.OfType<CalcParser.ExpressionContext>())
                {
                    double exprValue = Visit(expr);

                    if (exprValue < minValue)
                    {
                        minValue = exprValue;
                    }
                }
                return minValue;
            }

        }
        public override double VisitUnarMinusExpr(CalcParser.UnarMinusExprContext context)
        {
            if (WalkLeft(context) == 0)
            {
                return 0;
            }
            else
            {
                return -1 * WalkLeft(context);
            }

        }
        public override double VisitUnarPlusExpr(CalcParser.UnarPlusExprContext context)
        {
            return WalkLeft(context);
        }
        private double WalkLeft(CalcParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<CalcParser.ExpressionContext>(0));
        }
        private double WalkRight(CalcParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<CalcParser.ExpressionContext>(1));
        }
    }
}
