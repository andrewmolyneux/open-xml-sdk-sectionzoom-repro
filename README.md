**Description**
My code needs to find all images in a PowerPoint presentation, and it attempts this by enumerating all the "slide-like" parts (slides, slide masters, slide layouts, notes slides etc.) within the presentation and finding all Blip elements (from the DocumentFormat.OpenXml.Office.Drawing namespace - i.e. {http://schemas.openxmlformats.org/drawingml/2006/main}blip elements) in each part. However, in cases where a slide contains a "Slide Zoom" shape, any blips that belong to those shapes are omitted from the results when I call `part.RootElement.Descendants<Blip>()`.

**Information**
- .NET Target: .NET Standard 2.0
- DocumentFormat.OpenXml Version: 2.11.2

**Repro**

```csharp

// Please add a self-contained, minimum viable repro of the issue.
// If you require external resources, please provide a gist or GitHub repro
// An Xunit style test is preferred, but a console application would work too.
``` 

**Observed**

Please add your observed behavior here

**Expected**

Please add your expected behavior here.
