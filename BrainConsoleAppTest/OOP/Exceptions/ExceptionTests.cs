
using System;
using BrainConsoleApp.OOP.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Exceptions
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void ExpectedException()
        {
            (new ExceptionsInvestigation()).ExceptionFarm();
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void AssertFinallyIsExpectedAnywayTest()
        {
            bool isConnectionOpen = false;
            try
            {
                // -----------------
                try
                {
                    isConnectionOpen = true;
                    (new ExceptionsInvestigation()).ExceptionFarm();
                }
                finally
                {
                    isConnectionOpen = false;
                }
                // -----------------

                Assert.Fail();
            }
            finally
            {
                Assert.IsFalse(isConnectionOpen);
            }
        }

        [TestMethod]
        public void SurpperessingExceptionTest()
        {
            MyException loggedException = null;
            bool isConnectionOpen = false;

            try
            {
                isConnectionOpen = true;
                (new ExceptionsInvestigation()).ExceptionFarm();

                Assert.Fail();
            }
            catch (MyException ex)
            {
                loggedException = ex;
            }
            finally
            {
                isConnectionOpen = false;
            }

            Assert.IsNotNull(loggedException);
            Assert.IsFalse(isConnectionOpen);
        }

        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void ThrowingExceptionFromFinallyTest()
        {
            try
            {
                (new ExceptionsInvestigation()).ExceptionFarm();
                Assert.Fail();
            }
            finally
            {
                throw new AggregateException();
            }
        }

        [TestMethod]
        public void RethrowingExceptionWithoutLoosingStackTraceTest()
        {
            string methodName = null;

            try
            {
                try
                {
                    (new ExceptionsInvestigation()).ExceptionFarm();
                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception ex2)
            {
                methodName = ex2.TargetSite.Name;
            }

            Assert.AreEqual("ExceptionFarm", methodName);
        }
        
        [TestMethod]
        public void RethrowingExceptionAndLoosingStackTraceTest()
        {
            string methodName = null;

            try
            {
                try
                {
                    (new ExceptionsInvestigation()).ExceptionFarm();
                    Assert.Fail();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex2)
            {
                methodName = ex2.TargetSite.Name;
            }

            Assert.AreEqual("RethrowingExceptionAndLoosingStackTraceTest", methodName);
        }

        [TestMethod]
        [ExpectedException(typeof(MoreAbstractMyException))]
        public void ReplacingCaughtExceptionTest()
        {
            try
            {
                (new ExceptionsInvestigation()).ExceptionFarm();
                Assert.Fail();
            }
            catch (MyException)
            {
                throw new MoreAbstractMyException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(WrappingException))]
        public void ExceptionWrappingTest()
        {
            try
            {
                (new ExceptionsInvestigation()).ExceptionFarm();
                Assert.Fail();
            }
            catch (MyException ex)
            {
                throw new WrappingException(ex);
            }
        }
    }
}
