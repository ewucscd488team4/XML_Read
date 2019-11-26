using SAUSALibrary.Models;
using SAUSALibrary.File;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace XML_Read
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant file paths 
            const string PROJECT = @"\Sausa\project.xml";
            const string SETTINGS = @"\Sausa\Settings.xml";

            //*** ApplicationData       = C:\Users\Diesel\AppData\Roaming\Sausa\project.xml //WORKING DIRECTORY
            //*** CommonApplicationData = C:\ProgramData\Sausa\project.xml                  //SETTINGS DIRECTORY
            //*** MyDocuments           = C:\Users\Diesel\Documents\Sausa\project.xml       //DEFAULT Projects Folder
             

            string _ProjectPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + PROJECT; //actual path to c:\Users\Diesel\AppData\Roaming plus RECENT
            string _SettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + SETTINGS; //actual path to c:\Users\Diesel\AppData\Roaming plus RECENT   

            List<LastProjectModel> projects = ReadLastProjects.ReadProjects(_SettingsPath);

            foreach (LastProjectModel model in projects)
            {
                List<string> models = ProcessProjectModel(model);
                Console.WriteLine(models[0] + " " + models[1] + " " + models[2]);

            }
        }//end of main

        private static List<string> ProcessProjectModel(LastProjectModel model)
        {
            List<string> returnMe = new List<string>();
            returnMe.Add(model.Name);
            returnMe.Add(model.Path);
            returnMe.Add(model.Time);            
            return returnMe;
        }

        private static List<string> ProcessDatabaseModel(DatabaseModel model)
        {
            List<string> returnMe = new List<string>();
            returnMe.Add(model.Type);
            returnMe.Add(model.Server);
            returnMe.Add(model.Database);
            returnMe.Add(model.UserID);
            returnMe.Add(model.PassWord);
            return returnMe;
        }
    }
}
