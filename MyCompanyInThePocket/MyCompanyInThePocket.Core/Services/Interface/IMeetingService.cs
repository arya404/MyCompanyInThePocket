﻿using MyCompanyInThePocket.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyInThePocket.Core.Services.Interface
{
    public interface IMeetingService
    {
        Task<List<Meeting>> GetMeetingsAsync();
    }
}
