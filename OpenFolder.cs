using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nc_excel
{
    class OpenFolder
    {
        public Form1 Form1 { get; set; }

        public OpenFolder()
        {

        }
        public OpenFolder(Form1 MainForm)
        {
            Form1 = MainForm;
        }

        public async Task KlasorAc(string klasor_adi)
        {

            if (klasor_adi != "")
            {
                // xml dosyasında klasor yolunun degistirilmesi
                ReadWriteXML rwxml = new ReadWriteXML();
                rwxml.FolderPath(klasor_adi);

                // listview e klasor icindeki excel dosyalarinin adi yazilacak
                ExcelData ed = new ExcelData(Form1);
                await ed.FillListView(klasor_adi);
            }

            GC.Collect();
        }
    }
}
