using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul._bit_._TEST_.op_.of_.vec.set.be_.complete_.ofNeMin
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			



			assertIncompletes();
			assertCompletes();



		}

		void assertIncompletes()
		{
			var incompletes = new nilnul.bit.OpI2[][] {
				new[]{
					bit.op_.binary_.Ne.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.binary_.Min.Singleton
				}

				
				,
				bit.op_.binary.set_.Projection.ops
				
				,
				new bit.OpI2[]{
					bit.op_.binary_.Ne.Singleton
					,
					bit.op_.binary_.Min.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.nary_.Nil.Singleton
					,
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.binary_.Ne.Singleton
				}
				,

				new bit.OpI2[]{
					bit.op_.nary_.Nil.Singleton
					,
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.binary_.Ne.Singleton
				}.Concat(
					bit.op_.binary.set_.Projection.ops
				).ToArray()
				,



		};




			foreach (var item in incompletes)
			{
				assertIncomplete(item);
			}
		}

		void assertCompletes()
		{
			var completes = new nilnul.bit.OpI2[][] {
				


				new bit.OpI2[]{
					bit.op_.nary_.One.Singleton
					,
					bit.op_.binary_.Min.Singleton
					,
					bit.op_.binary_.Ne.Singleton
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
			var builder = new nilnul.bit.of_.vec.set.be_.Complete(
				ops
			);
			var computed = builder.compute();
			Debug.Assert(
				computed
			);

		}

		public void assertIncomplete(params bit.OpI2[] ops)
		{
			var builder = new nilnul.bit.of_.vec.set.be_.Complete(
				ops
			);
			var computed = builder.compute();
			Debug.Assert(
				!computed
			);

		}


	}
}
