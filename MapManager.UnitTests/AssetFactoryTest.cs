﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MapManager.UnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AssetFactoryTest
    {
        [TestCaseSource(typeof(construct_validInput_Tests))]
        public void construct_ValidInput(string targetDirectory,IEnumerable<Asset> expected)
        {
            IEnumerable<Asset> actual = AssetFactory.Construct(targetDirectory);

            Assert.That(actual, Is.EquivalentTo(expected));
        }
    }

    internal class construct_validInput_Tests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData
            (
                Path.Combine(TestContext.CurrentContext.TestDirectory,"TestData","assetFactorTestConstruct1"),
                new Asset[]
                {
                    new Asset(Path.Combine(TestContext.CurrentContext.TestDirectory,"TestData","assetFactorTestConstruct1","Flashpoint.png")),
                    new Asset(Path.Combine(TestContext.CurrentContext.TestDirectory,"TestData","assetFactorTestConstruct1","Folder1","Aftershock.png")),
                    new Asset(Path.Combine(TestContext.CurrentContext.TestDirectory,"TestData","assetFactorTestConstruct1","Folder2","Fault_Line.png")),
                    new Asset(Path.Combine(TestContext.CurrentContext.TestDirectory,"TestData","assetFactorTestConstruct1","Folder2","Folder3","Rolling_Thunder.png")),
                }
            );
        }
    }
}
