namespace ACT.Core.Interfaces.WebServices
{

    public class ACTProjectData
    {
        string _XML = "";

        public string XML { get { return _XML; } set { _XML = value; } }

        public string ID { get; set; }

        public string Name { get; set; }
    }


    public interface I_ACTProjects
    {

        List<ACTProjectData> GetMyProjects(string SecurityToken, string APIKey);


        bool SaveProject(string SecurityToken, ACTProjectData Project, string APIKey);


        bool DeleteProject(string SecurityToken, string ID, string APIKey);


        ACTProjectData GetProjectByName(string SecurityToken, string Name, string APIKey);


        string GetAllProjects(string SecurityToken, string APIKey);


        bool SaveAllProjects(string SecurityToken, string APIKey, bool OverwriteExisting, string XML);
    }

}
