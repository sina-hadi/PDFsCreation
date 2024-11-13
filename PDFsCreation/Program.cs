// See https://aka.ms/new-console-template for more information
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PDFsCreation;
using PdfSharp.Fonts;
using System.Diagnostics;

Document document = CreatePdf.CreateDocument();

MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, "MigraDoc.mdddl");

PdfDocumentRenderer renderer = new PdfDocumentRenderer();
renderer.Document = document;

GlobalFontSettings.FontResolver = new FileFontResolver();

renderer.RenderDocument();

// Save the document...
string filename = "C:\\Users\\sinah\\source\\repos\\PDFsCreation\\PDFsCreation\\Images\\HelloMigraDoc.pdf";
renderer.PdfDocument.Save(filename);
// ...and start a viewer.
//Process.Start(filename);