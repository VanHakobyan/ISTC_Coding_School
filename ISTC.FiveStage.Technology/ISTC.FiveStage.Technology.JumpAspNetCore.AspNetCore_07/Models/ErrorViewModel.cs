using System;

namespace ISTC.FiveStage.Technology.JumpAspNetCore.AspNetCore_07.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
