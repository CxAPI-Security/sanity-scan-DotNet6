using System.ComponentModel;

namespace Sanity_Scan_CSharp.Models
{
    public enum GovernmentForm
    {
        [Description("Monarchy")] MONARCHY,
        [Description("ARISTOCRACY")] ARISTOCRACY,
        [Description("TIMOCRACY")] TIMOCRACY,
        [Description("OLIGARCHY")] OLIGARCHY,
        [Description("DEMOCRACY")] DEMOCRACY,
        [Description("THEOCRACY")] THEOCRACY,
        [Description("TYRANNY")] TURANNY,
        [Description("OTHER")] OTHER
    }
}