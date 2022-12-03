using System.Collections.Generic;

namespace Wunderman.App.DTO
{
    public class ErrorDTO
    {
        public ErrorDTO(bool isChecked, string code, IDictionary<string, object> metadata)
        {
            IsChecked = isChecked;
            Code = code;
            Metadata = metadata;
        }
        public bool IsChecked { get; set; }
        public string Code { get; set; }
        public IDictionary<string, object> Metadata { get; set; }
    }
}
