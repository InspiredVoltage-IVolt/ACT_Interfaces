namespace ACT.Core.Interfaces.WebServices.Storage
{

    public interface I_Storage
    {

        string GetRawLocation(string ShortcutName, string SecurityToken, string apiKey);


        string GetLocation(string LocationName, string SecurityToken, string apiKey);


        string GetLocationRaw(string RawLocation, string SecurityToken, string apiKey);


        FileStream GetFileByShortcut(string ShortcutName, string SecurityToken, string apiKey);


        FileStream GetFile(string FileName, string LocationName, string SecurityToken, string apiKey);


        FileStream GetFileRaw(string FileName, string RawLocation, string SecurityToken, string apiKey);


        FileStream GetFileFullRaw(string FullRawLocation, string SecurityToken, string apiKey);


        string SaveFile(FileStream ModifiedFile, string SecurityToken, string apiKey);


        string[] GetAllFileShortcuts(string SecurityToken, string apiKey);


        string[] GetAllLocationShortcuts(string SecurityToken, string apiKey);


        string DeleteFileByFullLocation(string SecurityToken, string FullRawLocation, string apiKey);


        string DeleteFile(string SecurityToken, string Name, string RawLocation, string apiKey);


        string DeleteLocation(string SecurityToken, string RawLocation, string apiKey, bool RecursiveDelete = false);


        bool EvaluatePermission(bool Read, bool Write, bool Modify, string RawLocation, string SecurityToken, string apiKey);

        #region String Operations


        string GetStringValue(string SecurityToken, string Name, string apiKey, string Group = "");


        string[] GetStringGroups(string SecurityToken, string apiKey);


        string[] GetStringGroupNames(string SecurityToken, string Group, string apiKey);


        string SetString(string SecurityToken, string Name, string Value, string apiKey, string Group = "");


        string DeleteString(string SecurityToken, string Name, string apiKey, string Group = "");


        string AddLocation(string SecurityToken, string ParentRawLocation, string Name, bool VersionControl, string apiKey);


        #endregion

    }
}
