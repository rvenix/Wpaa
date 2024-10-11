using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryField
{
    public class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
            int invoiceNumber = 12345;
            PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

            // Generowanie faktury
            pdfWriter.Write("Invoice Content");
            pdfWriter.Close();
        }

        public void OtherMethod()
        {
            // Metoda, która nie korzysta z tymczasowych pól
        }
    }

    public class PdfWriter
    {
        public PdfWriter()
        {
                
        }

        public PdfWriter(string pdf)
        {
            
        }

        public void Write(string text) { }
        public void Close() { }
    }
}
