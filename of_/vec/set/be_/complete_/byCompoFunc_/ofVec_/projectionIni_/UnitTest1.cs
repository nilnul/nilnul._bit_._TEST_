using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.op.set.be_.complete_.byCompoFunc_.ofVec.projectionIni_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			assertComplete(
				nilnul.bit.op_.unary_.Not1.Singleton
				,
				nilnul.bit.op_.binary_.Le.Singleton

			);

			assertComplete(
				bit.op_.binary_.Nand.Singleton
			);


			assertComplete(
				bit.op_.binary_.Nor.Singleton
			);

			assertIncomplete(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.One.Singleton
			);


			assertComplete(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.Nil.Singleton
			);



			assertIncompletes();
			assertCompletes();



		}

		void assertIncompletes()
		{

			var incompletes = new nilnul.bit.OpI2[][] {
				new bit.OpI2[]{
					new bit.op_.Ternary(
						(bool x,bool y,bool z)=>x && !y && z || x&&!y&&!z || x && y
					)
				}


				,



			};
			foreach (var item in incompletes)
			{
				assertIncomplete(item);
			}




			assertIncomplete(
				bit.op_.binary_.Le.Singleton

			);


			assertIncomplete(
				new bit.op_.of_.vec_.Tabuleau(
					 bit.tup.sortie_.omni.Poll.OfResults(
						 1, 1, 0, 0
						 ,
						 0, 0, 1, 1
						)
				)

			);


			assertIncomplete(
				bit.op_.binary_.Le.Singleton
				,
				bit.op_.nary_.One.Singleton
			);

		}

		void assertCompletes()
		{


			var completes = new nilnul.bit.OpI2[][] {
				new bit.OpI2[]{
					bit.op_.binary_.Nand.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Nor.Singleton
				}


				,
				new bit.OpI2[]{
					bit.op_.binary_.Le.Singleton
					,
					bit.op_.nary_.Nil.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Ge.Singleton
					,
					bit.op_.nary_.Nil.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Gt.Singleton
					,
					bit.op_.nary_.One.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Lt.Singleton
					,
					bit.op_.nary_.One.Singleton
				}
				,


				new bit.OpI2[]{
					bit.op_.binary_.Max.Singleton
					,
					bit.op_.unary_.Not1.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.unary_.Not1.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Max.Singleton
					,
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.unary_.Not1.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Max.Singleton
					,
					bit.op_.binary_.Ne.Singleton
					,
					bit.op_.nary_.One.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.binary_.Eq.Singleton
					,
					bit.op_.nary_.Nil.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.binary_.Ne.Singleton
					,
					bit.op_.nary_.One.Singleton
				}
				,
				new bit.OpI2[]{
					bit.op_.binary_.Max.Singleton
					,
					bit.op_.binary_.Eq.Singleton
					,
					bit.op_.nary_.Nil.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Le.Singleton
					,
					bit.op_.unary_.Not1.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Ge.Singleton
					,
					bit.op_.unary_.Not1.Singleton
				}
				,

				new bit.OpI2[]{
					new bit.op_.Ternary(
						(bool x,bool y,bool z)=>
						!x && y && z
						|| x&&!y
						|| !y && !z
					)
				}
				,

				new bit.OpI2[]{
					new bit.op_.Ternary(
						(bool x,bool y,bool z)=>
						!x || y&&!z
					)
				}
				,

			};
			foreach (var item in completes)
			{
				assertComplete(item);
			}




		}


		public void assertComplete(params bit.OpI2[] ops)
		{
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.ofVec_.ProjectionIni(
				ops
			);
			var computed = builder.compute();
			Debug.Assert(
				computed
			);

		}

		public void assertIncomplete(params bit.OpI2[] ops)
		{
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.ofVec_.ProjectionIni(
				ops
			);
			var computed = builder.compute();
			Debug.Assert(
				!computed
			);

		}


	}
}
