using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes.Developer
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class Dev : Attribute
    {
        private bool _toDo = false;
        private string _toDoDescription = "";
        private bool _removeBeforeRelease = false;
        private string _removeBeforeReleaseDescription = "";
        private int _priority = 0;
        private string _originaDeveloperInfo = "";
        private string _lastDeveloperInfo = "";

        public Dev() { }


        public bool ToDo { get { return _toDo; } set { _toDo = value; } }
        public string ToDo_Description { get { return _toDoDescription; } set { _toDoDescription = value; } }
        public bool RemoveBeforeRelease { get { return _removeBeforeRelease; } set { _removeBeforeRelease = value; } }
        public string RemoveBeforeRelease_Description { get { return _removeBeforeReleaseDescription; } set { _removeBeforeReleaseDescription = value; } }
        public int Priority { get { return _priority; } set { _priority = value; } }
        // string i.e "Mark Alicz, Darkbit@gmail.com"
        public string OriginaDeveloperInfo { get { return _originaDeveloperInfo; } set { _originaDeveloperInfo = value; } }
        // string i.e "John Prine, JohnPrineForever@goofmail.com"
        public string LastDeveloperInfo { get { return _lastDeveloperInfo; } set { _lastDeveloperInfo = value; } }

        public static Attribute_Single_Development_Definition ToDevelopmentDefinition(Dev devInstance, string ClassName, string TypeName)
        {
            Attribute_Single_Development_Definition TmpReturn = new Attribute_Single_Development_Definition();

            TmpReturn.Classname = ClassName;
            TmpReturn.Typename = TypeName;
            TmpReturn.Todo = devInstance.ToDo.ToString();
            TmpReturn.Todo_Description = devInstance.ToDo_Description.ToString();
            TmpReturn.Removebeforerelease = devInstance.RemoveBeforeRelease.ToString();
            TmpReturn.Removebeforerelease_Description = devInstance.RemoveBeforeRelease_Description.ToString();
            TmpReturn.Priority = devInstance.Priority;
            TmpReturn.Originadeveloperinfo = devInstance.OriginaDeveloperInfo.ToString();
            TmpReturn.Lastdeveloperinfo = devInstance.LastDeveloperInfo.ToString();

            return TmpReturn;
        }

        public static string ToJson(Dev devInstance, string ClassName, string TypeName)
        {
            string TmpReturn = "{" + Environment.NewLine;

            TmpReturn += "\"classname\":\"" + ClassName + "\"" + Environment.NewLine;
            TmpReturn += "\"typename\":\"" + TypeName + "\"" + Environment.NewLine;
            TmpReturn += "\"todo\":\"" + devInstance.ToDo.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"todo_description\":\"" + devInstance.ToDo_Description.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"removebeforerelease\":\"" + devInstance.RemoveBeforeRelease.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"removebeforerelease_description\":\"" + devInstance.RemoveBeforeRelease_Description.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"priority\":\"" + devInstance.Priority.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"originadeveloperinfo\":\"" + devInstance.OriginaDeveloperInfo.ToString() + "\"" + Environment.NewLine;
            TmpReturn += "\"lastdeveloperinfo\":\"" + devInstance.LastDeveloperInfo.ToString() + "\"" + Environment.NewLine;


            TmpReturn += "}";
            return TmpReturn;
        }
    }
}
