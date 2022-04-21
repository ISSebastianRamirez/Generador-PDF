using GenPDFItext.Models;
using GenPDFItext.Processes;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenPDFItext.Controllers
{
    public class CrearPDFController : Controller
    {
        IngreParticipante inp = new IngreParticipante();
        // GET: CrearPDF
        public ActionResult Index()
        {
            inp.LimpiarTabla("sp_BorrarTbParticipantes");
            return View();
        }

        [HttpPost]
        public ActionResult IngreParti(Participantes objParticipante)
        {
            var nombre = objParticipante.Nombre;
            var cargo = objParticipante.Cargo;
            var celular = objParticipante.Celular;
            var email = objParticipante.Email;
            inp.IngresarParticipante("sp_InsertParticipantes",nombre,cargo,celular,email);
            return new HttpStatusCodeResult(204);
        }
        [HttpPost]
        public ActionResult IngreConector(Conector objConector)
        {
            var conector = objConector.Conectores;
            inp.IngresarConector("sp_InsertConectores",conector);
            return new HttpStatusCodeResult(204);
        }
        [HttpPost]
        public ActionResult IngreConsulta(ConsultasERP objConsultasERP)
        {
            var consultas = objConsultasERP.Consultas;
            var campos = objConsultasERP.Campos;
            var filtros = objConsultasERP.Filtros;
            inp.IngresarConsultaERP("sp_InsertConsultaERP",consultas,campos,filtros);
            return new HttpStatusCodeResult(204);
        }
        public ActionResult PDF()
        {
            MemoryStream ms = new MemoryStream();
            PdfWriter pw = new PdfWriter(ms);
            PdfDocument pdfdoc = new PdfDocument(pw);
            Document doc = new Document(pdfdoc, PageSize.LETTER);
            doc.SetMargins(75,35,70,35);
            doc.Add(new Paragraph("Hello"));
            doc.Close();
            byte[] byteStream = ms.ToArray();
            ms = new MemoryStream();
            ms.Write(byteStream, 0, byteStream.Length);
            ms.Position = 0;
            return new FileStreamResult(ms,"application/pdf");
        }
    }
}