using SAUSALibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace SAUSALibrary.File
{
    public class ReadDatabaseXML
    {
        public static List<DatabaseModel> GetDatabaseModel(string filePath)
        {

            List<DatabaseModel> models = new List<DatabaseModel>();

            using (XmlReader _Reader = XmlReader.Create(new FileStream(filePath, FileMode.Open), new XmlReaderSettings() { CloseInput = true }))
            {
                
                while (_Reader.Read()) //while reader can read
                {
                    DatabaseModel model = new DatabaseModel();
                    if ((_Reader.NodeType == XmlNodeType.Element) && (_Reader.Name == "Database")) //looks for xml parent node type of "project" (will look like <Database>
                    {
                        if (_Reader.HasAttributes) //if current line has attributes
                        {
                            //read each attribute in the line if it matches the definition 

                            model.Type = _Reader.GetAttribute("Type");
                            model.Server = _Reader.GetAttribute("Server");
                            model.Database = _Reader.GetAttribute("Database");
                            model.UserID = _Reader.GetAttribute("UserID");
                            model.PassWord = _Reader.GetAttribute("Password");
                            models.Add(model);
                        }
                    }                    
                }//end of while
            }

            return models;
        }        
    }
}
