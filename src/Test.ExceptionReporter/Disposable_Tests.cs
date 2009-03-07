﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using ExceptionReporter.Core;
using NUnit.Framework;

namespace ExceptionReporter.Tests
{
    [TestFixture]
    public class DisposableTests
    {
        [SetUp]
        public void SetUp()
        {
            DisposeUnmanagedResourcesCalled = false;
            DisposeManagedResourcesCalled = false;
        }

    	private static bool DisposeUnmanagedResourcesCalled { get; set; }
    	private static bool DisposeManagedResourcesCalled { get; set; }

    	private class MockDisposable : Disposable
        {
            protected override void DisposeManagedResources()
            {
                DisposeManagedResourcesCalled = true;
            }

            protected override void DisposeUnmanagedResources()
            {
                DisposeUnmanagedResourcesCalled = true;
            }
        }

        [Test]
        public void FailFromFinalize()
        {
            var list = new List<TraceListener>();
            foreach (TraceListener listener in Debug.Listeners)
            {
                list.Add(listener);
            }

            Trace.Listeners.Clear();

            try
            {
                new MockDisposable();
                GC.Collect();
                //Wait for finalize
                Thread.Sleep(1000);		//TODO this should be removed, the test more abstracted, we should never sleep in unit tests
            }
            finally
            {
                foreach (var listener in list)
                {
                    Trace.Listeners.Add(listener);
                }
            }

            Assert.IsFalse(DisposeManagedResourcesCalled);
            Assert.IsTrue(DisposeUnmanagedResourcesCalled);
        }

        [Test]
        public void TestDispose()
        {
            var disposable = new MockDisposable();
            disposable.Dispose();
            Assert.IsTrue(disposable.IsDisposed);
            Assert.IsTrue(DisposeManagedResourcesCalled);
            Assert.IsTrue(DisposeUnmanagedResourcesCalled);
        }
    }
}