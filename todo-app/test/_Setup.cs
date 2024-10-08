﻿using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.ToDoApp
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<ToDoApp>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly ToDoAppContainer.ToDoAppStub ToDoAppStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            ToDoAppStub = GetToDoAppContractStub(DefaultKeyPair);
        }

        private ToDoAppContainer.ToDoAppStub GetToDoAppContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<ToDoAppContainer.ToDoAppStub>(ContractAddress, senderKeyPair);
        }
    }
    
}