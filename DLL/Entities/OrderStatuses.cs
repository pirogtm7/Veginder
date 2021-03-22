using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DLL.Entities
{
    public enum OrderStatuses
    {
        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "PaymentReceived")]
        PaymentReceived,

        [EnumMember(Value = "PaymentFailed")]
        PaymentFailed,

        [EnumMember(Value = "Sent")]
        Sent,

        [EnumMember(Value = "Delivered")]
        Delivered
    }
}
