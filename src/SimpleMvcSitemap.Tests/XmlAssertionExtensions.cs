using System;
using FluentAssertions;
using FluentAssertions.Primitives;
using System.Xml.Linq;
using System.IO;
using Microsoft.DotNet.InternalAbstractions;

namespace SimpleMvcSitemap.Tests
{
    public static class XmlAssertionExtensions
    {
        public static void BeXmlEquivalent(this StringAssertions assertions, string filename)
        {
            Console.WriteLine("Generatex XML");
            Console.WriteLine(assertions.Subject);

            var fullPath = Path.Combine(ApplicationEnvironment.ApplicationBasePath, "Samples", filename);
            XDocument doc1 = XDocument.Parse(File.ReadAllText(fullPath));
            XDocument doc2 = XDocument.Parse(assertions.Subject);

            
            XNode.DeepEquals(doc1, doc2).Should().BeTrue();
        }
    }
}