using System;
using GreenHorn.Essentials.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreenHorn.Essentials.Tests
{
    [TestClass]
    public class CoreTests
    {
        private static Core _core { get; set; }

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            _core = new Core();
        }

        [TestMethod]
        public void Core_Retry_pass_in_primitive_return_type_method_returns_primitive_value()
        {
            var result = _core.Retry(GetName, new RetryInfo());

            Assert.AreEqual(
                expected: "Name",
                actual: result);
        }

        [TestMethod]
        public void Core_Retry_pass_in_parameterized_method_return_value()
        {
            var result = _core.Retry(() => GetValueFrom(1, 2), new RetryInfo());

            Assert.AreEqual(
                expected: 2,
                actual: result
                );
        }

        [TestMethod]
        public void Core_Retry_pass_in_complex_delegate_return_value()
        {
            var result = _core.Retry(() => {
                var one = GetName().Length;
                var two = GetValue() * 2;
                return GetValueFrom(one, two);
            }, new RetryInfo());

            Assert.AreEqual(
                expected: 8,
                actual: result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Core_Retry_pass_in_null_retryInfo_thow_ArgumentNullException()
        {
            _core.Retry(GetName, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Core_Retry_returns_NullReferenceException()
        {
            _core.Retry(()=> {
                string errorString = null;
                return errorString.Length;
            }, new RetryInfo() { Timeout = 1, Attempts = 1, WaitTime = 5});
        }

        public string GetName() => "Name";

        public int GetValue() => 1;

        public double GetValueFrom(double one, double two) => (one * two);
    }
}
