﻿using System.Threading.Tasks;
using Telnyx;
using Telnyx.net.Entities;
using Telnyx.net.Services.PhoneNumbers;
using Xunit;
using System.Threading;
using Telnyx.net.Entities.Notifications;
using System.Net.Mime;
using Telnyx.net.Entities.NumberPortouts;
using System;
using System.Collections.Generic;
using Telnyx.net.Services.PhoneNumbers.NumberBackgroundJobs;

namespace TelnyxTests.Services.Notifications.Notifications.NumberBackgroundJobLists

{
    /// <summary>
    /// Test class for NumberBackgroundJobListTest.
    /// </summary>
    public class NumberBackgroundJobListTest : BaseTelnyxTest
    {
        private readonly NumberBackgroundJobService service;
        private readonly NumberBackgroundJobListOptions NumberBackgroundJobListOptions;
        private readonly RequestOptions requestOptions;
        private readonly BaseOptions baseOptions;
        private const string Id = "6a09cdc3-8948-47f0-aa62-74ac943d6c58";

        public NumberBackgroundJobListTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new NumberBackgroundJobService();
            this.baseOptions = new BaseOptions();
            this.requestOptions = new RequestOptions();
            this.NumberBackgroundJobListOptions = new NumberBackgroundJobListOptions()
            {
                Type = Telnyx.net.Entities.Enum.PhoneNumbers.NumberBackgroundJobs.PhoneNumberJobType.UpdatePhoneNumbers,
                Sort = "created_at",
            };
        }

        [Fact]
        public void List()
        {
            var result = this.service.ListNumberBackgroundJobs(this.NumberBackgroundJobListOptions, this.requestOptions);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }

        [Fact]
        public async Task ListSync()
        {
            var cts = new CancellationTokenSource();
            var result = await this.service.ListNumberBackgroundJobsAsync(this.NumberBackgroundJobListOptions, this.requestOptions, cts.Token);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }
        [Fact]
        public void Retrieve()
        {
            var result = this.service.RetrieveNumberBackgroundJob(Id,this.baseOptions, this.requestOptions);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }

        [Fact]
        public async Task RetrieveSync()
        {
            var cts = new CancellationTokenSource();
            var result = await this.service.RetrieveNumberBackgroundJobAsync(Id, this.baseOptions, this.requestOptions, cts.Token);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }
    }
}
