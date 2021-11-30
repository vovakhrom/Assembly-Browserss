﻿using NUnit.Framework;
using AssemblyAnalyzer;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        AssemblyBrowser assemblyBrowser = new AssemblyBrowser();
        private string path = "C:\\Users\\37529\\source\\repos\\Assembly-Browser\\ProjectForUnitTest\\bin\\Debug\\ProjectForUnitTest.dll";
        List<Container> assemblyInfo;

        [SetUp]
        public void SetUp()
        {
            assemblyInfo = assemblyBrowser.GetAssemblyInfo(path);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(assemblyInfo == null, false, "Couldn't load assembly info.");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(assemblyInfo[0].Class, "private   class  Program", "Wrong name for first class.");
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(assemblyInfo[0].Signature, "ProjectForUnitTest", "Wrong first namespace.");
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(assemblyInfo.Count, 2, "Wrong number of namespaces.");
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(assemblyInfo[0].Members.Count, 1, "Wrong number of members in first namespace.");
        }
    }
}