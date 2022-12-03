using System;

namespace Wunderman.App.DTO
{
    public interface IOrderParamsDTO<TEnum> where TEnum : Enum
    {
        bool Ascending { get; set; }
        TEnum Orderby { get; set; }
    }
}
