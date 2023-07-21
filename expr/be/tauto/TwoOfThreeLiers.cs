using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace nilnul.bit._test.expr.be.tauto
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TwoThirdsLierProblem()
		{


			var a1 = nilnul.bit.var.set.NamingContext.Create1("a1");

			var a2 = nilnul.bit.var.set.NamingContext.Create1("a2");
			var a3 = nilnul.bit.var.set.NamingContext.Create1("a3");
			var p1= nilnul.bit.var.set.NamingContext.Create1("p1");

			var p2= nilnul.bit.var.set.NamingContext.Create1("p2");

			var p3 = nilnul.bit.var.set.NamingContext.Create1("p3");


			var p1_eq_a1= nilnul.bit.expr.duo.Eq.Call( 
				
				p1, 
				
				a1
			) ;

			var p3_eq_a3= nilnul.bit.expr.duo.Eq.Call( 
				
				p3, 
				
				a3
			) ;

			var p2_eq_a2= nilnul.bit.expr.duo.Eq.Call( 
				
				p2, 
				
				a2
			) ;
			var p3eq___p2_eq_a2__and__a3 = nilnul.bit.expr.duo.Eq.Call( 
				
				p3, 
				
				nilnul.bit.expr.duo.Min.Call(
					p2_eq_a2
					,a3
				)
			) ;
			var p3eq___a3 = nilnul.bit.expr.duo.Eq.Call( 
				
				p3
				,a3
				 
			) ;

			var p3eq___p2_eq_a2  = nilnul.bit.expr.duo.Eq.Call( 
				
				p3, 
				
				 
					p2_eq_a2
				 
			) ;

			var p2eqA2_and_a3 = nilnul.bit.expr.duo.Eq.Call(


				p2_eq_a2
				,
				a3	
				
			);


			var p2_vs_p3 = nilnul.bit.expr.duo.Eq.Call(


				p2_eq_a2
				,
				a3	
				
			);

			var expr = nilnul.bit.expr.str.aggregate_.Conjunct.ToExpr(
				
				p3eq___p2_eq_a2
				,p3eq___a3
				,
				 

				p1_eq_a1
				, p3_eq_a3
				, (p2_eq_a2) 




			)			
			;


			Debug.WriteLine(expr);

			var k=nilnul.bit.expr.TruthTableX.GetTruthTable(
				expr	
			);

		//	var k1 = nilnul.bit.expr.TruthTable1.Create(expr);



			var possibleInterpretations=	k.getInterpretatios().Where(
				
				x=>x.result  && x.assignment.Where(
				
				assi=> new nilnul.var.Set_ofVarI(a1,a2,a3).Contains( assi.Key)  
			
			).Where(  
				
				assign=>  assign.Value
				
				).Count()==1 );

			Debug.WriteLine(bit.expr.Interpretations.ToTxt(possibleInterpretations));
			Debug.WriteLine("==========");
			Debug.WriteLine(k.toTxt_inLines_sortVars());
 


		}



	}
}
