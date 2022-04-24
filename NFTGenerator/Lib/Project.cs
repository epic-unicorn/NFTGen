using System.Collections.Generic;

namespace NFTGenerator.Lib
{
    public class Project
    {
        public Project()
        {
            ProjectName = "New Project";
            Settings = new ProjectSettings();
            overlays = new List<ProjectLayer>();
            groups = new List<Group>();
        }

        public string ProjectName { get; set; }
        //public string ProjectDecription { get; set; }

        /// <summary>
        /// Total expected number of items in the collection
        /// </summary>
        public int TotalItems { get; set; }
        public string LastGeneratedJSON {get;set;}

        private List<Group> groups;
        public List<Group> Groups
        {
            get
            {
                return groups;
            }
            set { groups = value; }
        }

        public ProjectSettings Settings
        {
            get; set;
        }

        private List<ProjectLayer> overlays = null;
        public List<ProjectLayer> Overlays
        {
            get
            {
                return overlays;
            }
            set
            {
                overlays = value;
            }
        }


        public string ToJSON()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public static Project FromJSON(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Lib.Project>(json);
        }

        public static Project Load(string fileName)
        {
            string json = System.IO.File.ReadAllText(fileName);
            return Project.FromJSON(json);
        }
    }


}
