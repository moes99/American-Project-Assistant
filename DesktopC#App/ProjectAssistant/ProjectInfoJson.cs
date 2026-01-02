using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectAssistant
{
    internal class ProjectInfoJson
    {
        public string Client { get; set; }
        public string Director { get; set; }
        public string Manager { get; set; }
        public List<string> ScopeOfWork { get; set; }
        public List<string> TradeDevelopers { get; set; }
        public string ProjectName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string FullAddress { get; set; }
        public string BuilidngType { get; set; }
        public string BuildingFunction { get; set; }
        public string BuildingCondition { get; set; }


        public ProjectInfoJson()
        {

        }

        public ProjectInfoJson(string client, string director, string manager, List<string> scopeOfWork, List<string> tradeDevelopers, string name, string country, string state, string fullAddress, string buildingType, string buildingFunction, string buildingCondition)
        {
            Client = client;
            Director = director;
            Manager = manager;
            ScopeOfWork = scopeOfWork;
            TradeDevelopers = tradeDevelopers;
            ProjectName = name;
            Country = country;
            State = state;
            FullAddress = fullAddress;
            BuilidngType = buildingType;
            BuildingFunction = buildingFunction;
            BuildingCondition = buildingCondition;
        }
    }
}
