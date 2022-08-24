namespace ACT.Core.Interfaces.WebServices
{

    public class ACTProjectData
    {
        string _xml = "";

        public string Xml { get { return _xml; } set { _xml = value; } }

        public string Id { get; set; }

        public string Name { get; set; }
    }


    public interface I_ACTProjects
    {

        List<ACTProjectData> GetMyProjects(string SecurityToken, string apiKey);


        bool SaveProject(string SecurityToken, ACTProjectData Project, string apiKey);


        bool DeleteProject(string SecurityToken, string id, string apiKey);


        ACTProjectData GetProjectByName(string SecurityToken, string Name, string apiKey);


        string GetAllProjects(string SecurityToken, string apiKey);


        bool SaveAllProjects(string SecurityToken, string apiKey, bool OverwriteExisting, string xml);
    }

}
