using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace nilnul.bit._test.expr.be_.tauto
{
	[TestClass]
	public class UnitTest2aa
	{
		[TestMethod]
		public void TwoThirdsLierProblem2()
		{

			/*
			 现在有四个命题
  
A：下雨
B：拥堵
C：若A则B
D：若A则非B
  
现在的问题是，已知C成立，问D是否成立
  
这里的问题跟AB是否成立根本没关系
只要看，能不能从C推出D就可以？
这俩命题可以互相推出吗？不能，这俩命题逻辑上根本就没有关系
所以就是不确定. 注意 表达式 是 不确定的；但命题总是确定的 “真” 或者 “假”
			 */


			var a1 = nilnul.bit.var.set.NamingContext.Create1("下雨");

			var a2 = nilnul.bit.var.set.NamingContext.Create1("拥堵");


			var rain_imply_jam= new nilnul.bit.expr_.call_.binary_.Imply( 
				
				a1, 
				
				a2
			) ;

			var rain_imply_nonJam= new nilnul.bit.expr_.call_.binary_.Imply(

				
				a1, 
				
				new nilnul.bit.expr_.call_.unary_.Not(a2)
			) ;

			var not__rain_imply_nonJam= new nilnul.bit.expr_.call_.unary_.Not(

				
				rain_imply_nonJam
			) ;

		


			var expr = new nilnul.bit.expr_.call_.binary_.Imply(


				rain_imply_jam
				,
				not__rain_imply_nonJam	
				
			);


			var isTauto = nilnul.bit.expr.be_.Tauto1.Be(expr);

			Debug.WriteLine($"{nameof(isTauto)}: {isTauto}");
			//expr = exprSimple;
			Debug.WriteLine(expr);

			var k1 = nilnul.bit.expr._InterpretX.GetTruthTable(expr);

			

			var possibleInterpretations=	k1.interprets.Where(
				
				x=>x.Value  && x.Key.Where(
				
				assi=> new nilnul.var.Set_ofVarI(a1,a2).Contains( assi.Key)  
			
			).Where(  
				
				assign=>  assign.Value
				
				).Count()==1 );

			Debug.WriteLine(
				bit.expr._interpret.TblX.ToTxt(
					possibleInterpretations.Select(a=> new nilnul.bit.expr._interpret.Row(a))));
			Debug.WriteLine("==========");

			Debug.WriteLine(
				nilnul.bit.expr._interpret.TblX.ToTxt_sortVar(
					k1.interprets.Select(a=>new nilnul.bit.expr._interpret.Row(a))	
				)	
			);
			//Debug.WriteLine(k.toTxt_inLines_sortVars());

			/*
			 逻辑推理都可以用集合来判断。
A = {下雨}
B = {拥堵}
若下雨，则拥堵 : A => B
A => B 为真，说明A是B的子集 （只要A发生则B发生）
A => !B 则为假，因为A是B的子集，就不可能是B的补集的子集

			用集合的观点来看命题逻辑也是可以的。A => B 永真等价于A包含于B，这个说法是对的。可惜他最后的结论错了。因为他忽略了一个情况就是A为空集时，A包含于B 和 A包含于B的补集 可以同时成立。


			对于 常年不下雨的地方来说，两句话都为真。

			对于常年拥堵的地方来说，第一个为真。第二个为假。真理是有条件的；对于特定场合，某些推理成立。


			“若p则q”等价于“非p或q”。比如我断言“若明天下雨则明天拥堵”，那么明天出现什么情况的时候我是对的？明天下雨且拥堵的时候我自然对了，而如果明天没下雨，那不管堵不堵我都是对的，因为我并没有说不下雨的时候会怎样。同理假如另外一个人断言“若明天下雨则明天不拥堵”，那么明天出现什么情况他是对的？如果明天下雨且不拥堵，那他对了，如果明天不下雨，他还是对的。这里可以看到如果明天下雨，那么我和他出现了分歧，必然我和他只能有一个人是对的，但如果明天不下雨，那我俩都是对的。
:     这里反直观的地方是我们把日常的经验带到了这个逻辑问题中。我们会觉得“若下雨则拥堵”和“若下雨则不拥堵”这两个不可能同时对啊，我们会有这样的直观是因为现实世界中下雨是一件有可能发生的事情。一件有可能发生的事情不应该推出两件矛盾的事情。而如果我们严格按逻辑分析，“若下雨则拥堵”和“若下雨则不拥堵”是可以同时成立的，同时成立的情况就是“不下雨”。就是说如果这个世界永远不可能下雨，那么从一个不可能的前提推出任何结论都是可以接受的。



			如果A，得到B，表示A和B之间存在着条件性的因果关系。
不是随便找两个命题搭配在一起都可以。
比如：
如果上帝发怒，那么我会成为一名图书编辑。----这句话在有的情况下成立。
如果今天早上你打了一个喷嚏，明天太平洋那边就会发生一次海啸。  ------这句话在有的情况下成立
			 */

		}



	}
}
