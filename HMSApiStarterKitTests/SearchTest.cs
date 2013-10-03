using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using com.healthmarketscience.api.samples.dotnet.domain;

namespace com.healthmarketscience.api.samples.dotnet
{
    [TestClass]
    public class SearchTest
    {
        [TestInitialize]
        public void Init()
        {
            Core.SetConfiguration(TestConstants.TEST_API_CONFIGURATION);
        }

        [TestMethod]
        public void FindAllTest()
        {
            SearchResponse matches = Search.findAll(TestConstants.GetSearchParameters(), TestConstants.DEFAULT_SECRET);
            matches.Practitioners.ForEach(p => p.DebugPrint());
        }

    }
}
