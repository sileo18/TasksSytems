using System.ComponentModel;

namespace TasksSytems.Enums
{
    public enum StatusTask
    {
        [Description("To Do")]
        toDo = 1,
        [Description("Doing")]
        doing = 2,
        [Description("Done")]
        done = 3
    }
}
