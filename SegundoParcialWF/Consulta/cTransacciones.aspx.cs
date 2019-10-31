using BLL;
using DAL;
using Entity;
using Microsoft.Reporting.WebForms;
using SegundoParcialWF.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialWF.Consulta
{
    public partial class cTransacciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FechaIncio.Text = DateTime.Now.ToString("yyyy-MM-dd");
                FechaFin.Text = DateTime.Now.ToString("yyyy-MM-dd");
                LlenaReport();
            }

        }

        public void LlenaReport()
        {
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>(new Contexto());
            MyReportViewer.ProcessingMode = ProcessingMode.Local;
            MyReportViewer.Reset();
            MyReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\Reporte.rdlc");
            MyReportViewer.LocalReport.DataSources.Clear();
            MyReportViewer.LocalReport.DataSources.Add(new ReportDataSource("Transacion", repositorio.GetList(e => true)));
            MyReportViewer.LocalReport.Refresh();
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Transacciones, bool>> Filtro = x => true;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>(new Contexto());
            DateTime desde = Utils.ToDateTime(FechaIncio.Text);
            DateTime hasta = Utils.ToDateTime(FechaFin.Text);

            int id;
            id = Utils.ToInt(TextBoxCriterio.Text);

            if (checkbox.Checked == true)
            {
                switch (DropDrom.SelectedIndex)
                {
                    case 0:
                        Filtro = x => x.Fecha >= desde && x.Fecha <= hasta;
                        break;
                    case 1:
                        Filtro = x => x.TransaccionesId == id && x.Fecha >= desde && x.Fecha <= hasta;
                        break;
                    case 2:
                        Filtro = x => x.TransaccionesId == id && x.Fecha >= desde && x.Fecha <= hasta;
                        break;


                }

            }
            else
            {

                switch (DropDrom.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        Filtro = x => x.TransaccionesId == id;
                        break;
                    case 2:
                        Filtro = x => x.TransaccionesId == id;
                        break;

                }
            }

            DatosGridView.DataSource = repositorio.GetList(Filtro);
            DatosGridView.DataBind();


        }

    }
}