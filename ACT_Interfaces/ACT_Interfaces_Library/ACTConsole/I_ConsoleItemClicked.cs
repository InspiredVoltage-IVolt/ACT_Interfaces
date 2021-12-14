﻿namespace ACT.Core.Interfaces.ACTConsole
{
    public interface I_ConsoleItemClicked
    {
        Interfaces.Common.I_ResultExpanded ExecuteMenuCommand(string MenuCommand);
        string GlobalID { get; }

        event EventHandler OnMenuCommandCompleted;
    }
}
