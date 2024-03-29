﻿using SAUSALibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace SAUSALibrary.File
{
    public class ReadLastProjects
    {
        public static List<LastProjectModel> ReadProjects(string filePath)
        {
            List<LastProjectModel> models = new List<LastProjectModel>();

            using (XmlReader _Reader = XmlReader.Create(new FileStream(filePath, FileMode.Open), new XmlReaderSettings() { CloseInput = true }))
            {
                while (_Reader.Read())
                {
                    LastProjectModel model = new LastProjectModel();
                    if ((_Reader.NodeType == XmlNodeType.Element) && (_Reader.Name == "Project"))
                    {
                        if (_Reader.HasAttributes)
                        {
                            model.Name = _Reader.GetAttribute("Definition");
                            model.Path = _Reader.GetAttribute("Path");
                            model.Time = _Reader.GetAttribute("Time");
                            models.Add(model);
                        }
                    }
                    
                }
            }

            return models;
        }
    }
}
