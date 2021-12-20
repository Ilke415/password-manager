using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shared.Models;
using DataLayer;

namespace VaultRepositoryTest
{
    [TestClass]
    public class VaultRepositoryTests
    {
        public Vault vault;
        public VaultRepository vaultRepository;
        [TestInitialize]
        public void init()
        {




            vaultRepository = new VaultRepository();


        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
