using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFsCreation
{
    public class FileFontResolver : IFontResolver // FontResolverBase
    {
        public string DefaultFontName => throw new NotImplementedException();

        public byte[] GetFont(string faceName)
        {
            using (var ms = new MemoryStream())
            {
                using (var fs = File.Open(faceName, FileMode.Open))
                {
                    fs.CopyTo(ms);
                    ms.Position = 0;
                    return ms.ToArray();
                }
            }
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Verdana", StringComparison.CurrentCultureIgnoreCase))
            {
                if (isBold && isItalic)
                {
                    return new FontResolverInfo("Fonts/Verdana.ttf");
                }
                else if (isBold)
                {
                    return new FontResolverInfo("Fonts/Verdana.ttf");
                }
                else if (isItalic)
                {
                    return new FontResolverInfo("Fonts/Verdana.ttf");
                }
                else
                {
                    return new FontResolverInfo("Fonts/Verdana.ttf");
                }
            }
            if (familyName.Equals("Arial", StringComparison.CurrentCultureIgnoreCase))
            {
                if (isBold && isItalic)
                {
                    return new FontResolverInfo("Fonts/Arial.ttf");
                }
                else if (isBold)
                {
                    return new FontResolverInfo("Fonts/Arial.ttf");
                }
                else if (isItalic)
                {
                    return new FontResolverInfo("Fonts/Arial.ttf");
                }
                else
                {
                    return new FontResolverInfo("Fonts/Arial.ttf");
                }
            }
            if (familyName.Equals("Courier New", StringComparison.CurrentCultureIgnoreCase))
            {
                if (isBold && isItalic)
                {
                    return new FontResolverInfo("Fonts/Cour.ttf");
                }
                else if (isBold)
                {
                    return new FontResolverInfo("Fonts/Cour.ttf");
                }
                else if (isItalic)
                {
                    return new FontResolverInfo("Fonts/Cour.ttf");
                }
                else
                {
                    return new FontResolverInfo("Fonts/Cour.ttf");
                }
            }
            return null;
        }
    }
}
