using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace nilnul.bit._test.expr.be.tauto
{
	[TestClass]
	public class UnitTest2aa
	{
		[TestMethod]
		public void TwoThirdsLierProblem2()
		{
			/// if we run all tests, there might be remained names;
			///
			nilnul.obj.var.set.NamingContext.Instance.clean();


			var a1 = nilnul.bit.var.set.NamingContext.Create1("a1");

			var a2 = nilnul.bit.var.set.NamingContext.Create1("a2");
			var a3 = nilnul.bit.var.set.NamingContext.Create1("a3");
			var p1= nilnul.bit.var.set.NamingContext.Create1("p1");

			var p2= nilnul.bit.var.set.NamingContext.Create1("p2");

			var p3 = nilnul.bit.var.set.NamingContext.Create1("p3");


			var p1_eq_a1= nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p1, 
				
				a1
			) ;

			var p3_eq_a3= nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p3, 
				
				a3
			) ;

			var p2_eq_a2= nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p2, 
				
				a2
			) ;
			var p3eq___p2_eq_a2__and__a3 = nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p3, 
				
				nilnul.bit.expr.call_.Duo.CreateMi(
					p2_eq_a2
					,a3
				)
			) ;
			var p3eq___a3 = nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p3
				,a3
				 
			) ;

			var p3eq___p2_eq_a2  = nilnul.bit.expr.call_.Duo.CreateEq( 
				
				p3, 
				
				 
					p2_eq_a2
				 
			) ;

			var p2eqA2_and_a3 = nilnul.bit.expr.call_.Duo.CreateEq(


				p2_eq_a2
				,
				a3	
				
			);


			var p2_vs_p3 = nilnul.bit.expr.call_.Duo.CreateEq(


				p2_eq_a2
				,
				a3	
				
			);

			var expr = nilnul.bit.expr.str.aggregate_.Conjunct1.ToExpr(
				
				p3eq___p2_eq_a2
				,p3eq___a3
				,
				 

				p1_eq_a1
				, p3_eq_a3
				, (p2_eq_a2) 




			)			
			;




			ExprI1 exprSimple = nilnul.bit.expr.call_.No.CreateNil();

			 exprSimple = new nilnul.bit.expr_.VarAsExpr(a1);
			 exprSimple = nilnul.bit.expr.call_.Duo.CreateImply(a1,a2);


			//expr = exprSimple;
			Debug.WriteLine(expr);

			var k1 = nilnul.bit.expr._TruthTableX.GetTruthTable(expr);

			

			var possibleInterpretations=	k1.interprets.Where(
				
				x=>x.Value  && x.Key.Where(
				
				assi=> new nilnul.var.Set_ofVarI(a1,a2,a3).Contains( assi.Key)  
			
			).Where(  
				
				assign=>  assign.Value
				
				).Count()==1 );

			Debug.WriteLine(bit.var.set.state.Interprets.ToTxt(possibleInterpretations.Select(a=> new nilnul.bit.var.set.state.Interpret(a))));
			Debug.WriteLine("==========");

			Debug.WriteLine(
				nilnul.bit.var.set.state.Interprets.ToTxt_sortVar(
					k1.interprets.Select(a=>new nilnul.bit.var.set.state.Interpret(a))	
				)	
			);
			//Debug.WriteLine(k.toTxt_inLines_sortVars());
 


		}



	}
}
