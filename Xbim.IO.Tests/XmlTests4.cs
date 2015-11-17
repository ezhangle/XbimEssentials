﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Common;
using Xbim.Ifc4;
using Xbim.Ifc4.Kernel;
using Xbim.IO.Memory;
using Xbim.IO.Xml;
using Xbim.IO.Xml.BsConf;

namespace Xbim.MemoryModel.Tests
{
    [TestClass]
    [DeploymentItem("TestFiles")]
    public class XmlTests4
    {
       

        [TestMethod]
        public void Ifc4HeaderSerialization()
        {
            const string outPath = "..\\..\\SampleIfc4.xml";
            using (var model = new MemoryModel<EntityFactory>())
            {
                model.Header.FileName.Name = "Sample model";
                model.Header.FileName.AuthorName.Add("Martin");
                model.Header.FileName.AuthorizationMailingAddress.Add("martin.cerny@northumbria.ac.uk");
                model.Header.FileName.AuthorizationName = "Martin Cerny, xBIM Team";
                model.Header.FileName.Organization.Add("xBIM Team");
                model.Header.FileName.OriginatingSystem = "xBIM Toolkit";
                model.Header.FileName.PreprocessorVersion = "4.0";
                model.Header.FileName.TimeStamp = DateTime.Now.ToString("s");
                model.Header.FileDescription.Description.Add("xBIM Team Model View Definition");
                model.Header.FileDescription.ImplementationLevel = "1.0";

                using (var xml = XmlWriter.Create(outPath, new XmlWriterSettings{Indent = true}))
                {
                    var writer = new XbimXmlWriter4(configuration.IFC4Add1);
                    writer.Write(model, xml);   
                    xml.Close();
                }

                var errs = ValidateIfc4(outPath);
                Assert.AreEqual(0, errs);
            }
        }

        [TestMethod]
        public void SampleHouseXmlSerialization()
        {
            const string outPath = "..\\..\\SampleHouse4.xml";
            using (var model = new MemoryModel<EntityFactory>())
            {
                model.Open("SampleHouse4.ifc");

                using (var xml = XmlWriter.Create(outPath, new XmlWriterSettings { Indent = true }))
                {
                    var writer = new XbimXmlWriter4(configuration.IFC4Add1);
                    var entities = model.Instances.OfType<IfcProduct>()
                        .Concat(model.Instances.OfType<IfcRelationship>().Cast<IPersistEntity>())
                        .Concat(model.Instances);
                    writer.Write(model, xml, entities);
                    xml.Close();
                }

                var errs = ValidateIfc4(outPath);
                Assert.AreEqual(0, errs);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="path">Path of the file to be validated</param>
        /// <returns>Number of errors</returns>
        private static int ValidateIfc4(string path)
        {
            var logPath = Path.ChangeExtension(path, ".log");
            var errCount = 0;

            using (var file = File.OpenText(path))
            {
                using (var logFile = File.CreateText(logPath))
                {
                    var settings = new XmlReaderSettings { ValidationType = ValidationType.Schema };
                    settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                    settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                    settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                    settings.ValidationEventHandler += (sender, args) =>
                    {
                        Debug.WriteLine("Validation {0}: {1} \nLine: {2}, Position: {3}", args.Severity, args.Message, args.Exception.LineNumber, args.Exception.LinePosition);
                        logFile.WriteLine("Validation {0}: {1} \nLine: {2}, Position: {3}", args.Severity, args.Message, args.Exception.LineNumber, args.Exception.LinePosition);
                        errCount++;
                    };
                    var reader = XmlReader.Create(file, settings);

                    while (reader.Read())
                    {

                    }   

                    logFile.Close();
                    file.Close();
                }
            }

            return errCount;
        }
    }
}
