using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Wunderman.App.DTO
{
    public abstract class ValidationResultDTO
    {
        public bool IsValid => !Errors.Any();
        public IEnumerable<string> Errors { get; set; } = new List<string>();
    }
}
