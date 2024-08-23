using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCRka
{
    public class IronReco
    {
        IronTesseract ironOcr;

        public IronReco()
        {
            ironOcr = new IronTesseract();
            ironOcr.Language = OcrLanguage.Russian;

        }
    }
}
