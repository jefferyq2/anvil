﻿using System;
using System.Threading.Tasks;
using Certify.ACME.Anvil.Acme.Resource;
using Certify.ACME.Anvil.Tests;
using Xunit;
using Xunit.Abstractions;
using static Certify.ACME.Anvil.IntegrationHelper;

namespace Certify.ACME.Anvil
{
    public partial class AcmeContextIntegration
    {
        public class AccountFlowTests : AcmeContextIntegration
        {
            public AccountFlowTests(ITestOutputHelper output)
                : base(output)
            {
            }

            [Fact]
            public async Task CanRunAccountFlows()
            {
                var dirUri = await GetAcmeUriV2();

                var ctx = new AcmeContext(dirUri, http: GetAcmeHttpClient(dirUri));
                var accountCtx = await ctx.NewAccount(
                    new[] { $"mailto:certes-{DateTime.UtcNow.Ticks}@{Helper.TestCI_Domain1}" }, true);
                var account = await accountCtx.Resource();
                var location = accountCtx.Location;

                Assert.NotNull(account);
                Assert.Equal(AccountStatus.Valid, account.Status);

                await accountCtx.Update(agreeTermsOfService: true);
                await accountCtx.Update(contact: new[] { $"mailto:certes-{DateTime.UtcNow.Ticks}@{Helper.TestCI_Domain1}" });

                account = await accountCtx.Deactivate();
                Assert.NotNull(account);
                Assert.Equal(AccountStatus.Deactivated, account.Status);
            }
        }
    }
}
