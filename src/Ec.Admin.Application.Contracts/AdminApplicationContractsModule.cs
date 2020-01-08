﻿using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Ec.Admin.Application.Contracts
{
    [DependsOn(
        // module
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule)
        )]
    public class AdminApplicationContractsModule : AbpModule
    {
    }
}
