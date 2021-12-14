namespace ACT.Core.Interfaces.WebServices.Storage
{

    public interface I_Storage
    {

        string GetRawLocation(string ShortcutName, string SecurityToken, string APIKey);


        string GetLocation(string LocationName, string SecurityToken, string APIKey);


        string GetLocationRaw(string RawLocation, string SecurityToken, string APIKey);


        FileStream GetFileByShortcut(string ShortcutName, string SecurityToken, string APIKey);


        FileStream GetFile(string FileName, string LocationName, string SecurityToken, string APIKey);


        FileStream GetFileRaw(string FileName, string RawLocation, string SecurityToken, string APIKey);


        FileStream GetFileFullRaw(string FullRawLocation, string SecurityToken, string APIKey);


        string SaveFile(FileStream ModifiedFile, string SecurityToken, string APIKey);


        string[] GetAllFileShortcuts(string SecurityToken, string APIKey);


        string[] GetAllLocationShortcuts(string SecurityToken, string APIKey);


        string DeleteFileByFullLocation(string SecurityToken, string FullRawLocation, string APIKey);


        string DeleteFile(string SecurityToken, string Name, string RawLocation, string APIKey);


        string DeleteLocation(string SecurityToken, string RawLocation, string APIKey, bool RecursiveDelete = false);


        bool EvaluatePermission(bool Read, bool Write, bool Modify, string RawLocation, string SecurityToken, string APIKey);

        #region String Operations


        string GetStringValue(string SecurityToken, string Name, string APIKey, string Group = "");


        string[] GetStringGroups(string SecurityToken, string APIKey);


        string[] GetStringGroupNames(string SecurityToken, string Group, string APIKey);


        string SetString(string SecurityToken, string Name, string Value, string APIKey, string Group = "");


        string DeleteString(string SecurityToken, string Name, string APIKey, string Group = "");


        string AddLocation(string SecurityToken, string ParentRawLocation, string Name, bool VersionControl, string APIKey);


        #endregion

    }
}
