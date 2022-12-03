using System;
using System.Collections.Generic;
using System.Text;

namespace Wunderman.App.DTO
{
    public interface IPagingParamsDTO
    {
        int Page { get; set; }
        int PageSize { get; set; }
    }
}
