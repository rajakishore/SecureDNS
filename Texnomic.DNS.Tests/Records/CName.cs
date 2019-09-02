﻿using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Texnomic.DNS.Enums;
using Texnomic.DNS.Models;
using Texnomic.DNS.Resolvers;

namespace Texnomic.DNS.Tests.Records
{
    [TestClass]
    public class CName
    {
        private ushort ID;
        private IResolver Resolver;
        private Message RequestMessage;
        private Message ResponseMessage;
        

        [TestInitialize]
        public void Initialize()
        {
            ID = (ushort)new Random().Next();

            Resolver = new DoU(IPAddress.Parse("1.1.1.1"));

            RequestMessage = new Message()
            {
                ID = ID,
                //MessageType = MessageType.Query,
                //OperationCode = OperationCode.Query,
                //AuthoritativeAnswer = AuthoritativeAnswer.Cache,
                //Truncated = false,
                RecursionDesired = true,
                //RecursionAvailable = false,
                //Zero = 0,
                //AuthenticatedData = false,
                //CheckingDisabled = false,
                //ResponseCode = ResponseCode.NoError,
                //QuestionsCount = 1,
                //AnswersCount = 0,
                Questions = new[]
                {
                    new Question()
                    {
                        Domain = Domain.FromString("facebook.com"),
                        Class = RecordClass.Internet,
                        Type = RecordType.CNAME
                    }
                }
            };
        }

        [TestMethod]
        public async Task QueryAsync()
        {
            ResponseMessage = await Resolver.ResolveAsync(RequestMessage);

            Assert.AreEqual(ID, ResponseMessage.ID);
            Assert.IsNotNull(ResponseMessage.Questions);
            Assert.IsNotNull(ResponseMessage.Answers);
            Assert.AreEqual(ResponseCode.NXRRSet, ResponseMessage.ResponseCode);
            //Assert.IsInstanceOfType(ResponseMessage.Answers.First().Record, typeof(DNS.Records.CName));
        }
    }
}