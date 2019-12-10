﻿using System;
using Volo.Abp.Application.Dtos;

namespace Ec.Admin.Application.Contracts.DTO
{
    public class UserInfoDto : EntityDto<Guid>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
