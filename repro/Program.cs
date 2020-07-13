using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Linq;

namespace repro
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var doc = PresentationDocument.Open("slidezoom.pptx", false))
            {
                var presPart = doc.PresentationPart;
                var pres = presPart.Presentation;
                var firstSlideId = pres.SlideIdList.ChildElements.OfType<SlideId>().First();
                var slidePart = presPart.GetPartById(firstSlideId.RelationshipId) as SlidePart;
                var blipElements = slidePart.Slide.Descendants<Blip>();
                foreach (var blipElement in blipElements)
                {
                    Console.WriteLine(blipElement.OuterXml);
                }
            }
        }
    }
}
