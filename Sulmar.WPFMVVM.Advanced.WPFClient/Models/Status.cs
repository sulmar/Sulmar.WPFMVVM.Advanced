using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Advanced.WPFClient.Models
{
    public enum Status
    {
        [Description("Utworzone")]
        Created = 0,

        [Description("W trakcie")]
        InProgress = 1,

        [Description("Gotowe")]
        Completed = 2
    }
}
