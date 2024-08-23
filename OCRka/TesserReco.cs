using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace OCRka
{
    public class TesserReco
    {
        TesseractEngine engine;
        
        public TesserReco()
        {
            engine = new TesseractEngine("tessdata-fast", "rus+eng", EngineMode.Default);
            // details / wiki: https://github.com/charlesw/tesseract/wiki/Error-1 
        }

        public string Run(string fileName)
        {
            var img = Pix.LoadFromFile(fileName);
            var res = engine.Process(img);
            var result = res.GetText();
            img.Dispose();
            res.Dispose();

            return result;
        }
        
    }
}
