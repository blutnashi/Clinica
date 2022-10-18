using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Respaldo_Restauracion_Exportar_Excell
{
    class csimprimirgridview
    {
        public csimprimirgridview()
        {
        }
        public void imprimirGridView(string Titulo1, string Titulo2, GridView gridview)
        {

            Excel.Application AppExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelBook = xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet hoja = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets[1];


            Excel.Range formatRange;
            hoja.Cells[1, 1] = Titulo1;

            formatRange = hoja.get_Range("A1", "I1");
            formatRange.EntireRow.Font.Bold = true;
            formatRange.Font.Size = 24;
            formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            formatRange.HorizontalAlignment = 3;
            formatRange.VerticalAlignment = 3;
            formatRange.Merge(true);


            Excel.Range formatRange1;
            hoja.Cells[3, 1] = Titulo2;

            formatRange1 = hoja.get_Range("A3", "I3");
            formatRange1.EntireRow.Font.Bold = true;
            formatRange1.Font.Size = 24;
            formatRange1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            formatRange1.HorizontalAlignment = 3;
            formatRange1.VerticalAlignment = 3;
            formatRange1.Merge(true);



            string[] cabecera = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            int iniciofila = 6;
            for (int i = 1; i <= gridview.Columns.Count; i++)
            {
                Excel.Range formatRange2;
                if (gridview.Columns[i - 1].Visible == true)
                {
                    hoja.Cells[iniciofila, i] = gridview.Columns[i - 1].Caption;
                    formatRange2 = hoja.get_Range(cabecera[i - 1] + iniciofila.ToString(), cabecera[i - 1] + iniciofila.ToString());
                    formatRange2.EntireRow.Font.Bold = true;
                }



            }

            //Obtener todos los Fielname
            List<string> fielsname = new List<string>();
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                fielsname.Add(gridview.Columns[i].FieldName);
            }

            //i sera usado para el excel
            //j para acceder al grid view
            for (int i = iniciofila + 1, j = 0; j < gridview.RowCount; j++)
            {
                for (int m = 0; m < gridview.Columns.Count; m++)
                {
                    if (gridview.Columns[m].Visible != false)
                    {
                        //fielsname.Add(gridview.Columns[i].FieldName);
                        if (gridview.GetRowCellValue(j, fielsname[m]) != null)
                        {


                            string valor = gridview.GetRowCellValue(j, fielsname[m]).ToString();

                            if (gridview.Columns[m].DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                            {
                                //MessageBox.Show("f1=" + valor);
                                DateTime ff = Convert.ToDateTime(valor);

                                // ff.ToString("d MMMM yyyy");
                                // string fecha = Convert.ToDateTime(valor).ToShortDateString();
                                string fecha = ff.ToString("M/d/yyyy");
                                //string[] fecha1 = fecha.Split(' ');
                                //MessageBox.Show("fecha="+fecha1[0]);
                                //MessageBox.Show("f2="+fecha);

                                hoja.Cells[i, m + 1] = fecha;
                            }
                            else
                            {
                                // MessageBox.Show(valor);
                                hoja.Cells[i, m + 1] = valor;
                            }

                        }
                        else
                        {
                            hoja.Cells[i, m + 1] = "";
                        }
                    }
                }
                i++;
                //if (Convert.ToInt32(gridView1.GetRowCellValue(j, "cuotaspendiente").ToString()) > 0)
                //{
                //    string nombrecompleto = gridView1.GetRowCellValue(j, "idcliente.nombrecompleto").ToString();
                //    string direccion = gridView1.GetRowCellValue(j, "idcliente.direccion").ToString();
                //    string codigoexp = gridView1.GetRowCellValue(j, "idcliente.codigoExpediente").ToString();
                //    string telefono = gridView1.GetRowCellValue(j, "idcliente.telefono").ToString();
                //    string fechainicial = gridView1.GetRowCellValue(j, "fechainicial").ToString();
                //    string fechaultimacuota = gridView1.GetRowCellValue(j, "fechainicial").ToString();
                //    string cantidadcuotas = gridView1.GetRowCellValue(j, "cantidadcuotas").ToString();
                //    string cuotaspendientes = gridView1.GetRowCellValue(j, "cuotaspendiente").ToString();
                //    string lotesasiganados = gridView1.GetRowCellValue(j, "lotesasignados").ToString();

                //    hoja.Cells[i, 1] = nombrecompleto;
                //    hoja.Cells[i, 2] = direccion;
                //    hoja.Cells[i, 3] = codigoexp;
                //    hoja.Cells[i, 4] = telefono;
                //    hoja.Cells[i, 5] = fechainicial;
                //    hoja.Cells[i, 6] = fechaultimacuota;
                //    hoja.Cells[i, 7] = cantidadcuotas;
                //    hoja.Cells[i, 8] = cuotaspendientes;
                //    hoja.Cells[i, 9] = lotesasiganados;
                //    i++;
                //}

            }
            xlApp.Visible = true;

        }
        public void imprimirGridView(string Titulo1, string Titulo2, GridView gridview, int column_total)
        {

            Excel.Application AppExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelBook = xlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet hoja = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets[1];


            Excel.Range formatRange;
            hoja.Cells[1, 1] = Titulo1;

            formatRange = hoja.get_Range("A1", "I1");
            formatRange.EntireRow.Font.Bold = true;
            formatRange.Font.Size = 24;
            formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            formatRange.HorizontalAlignment = 3;
            formatRange.VerticalAlignment = 3;
            formatRange.Merge(true);


            Excel.Range formatRange1;
            hoja.Cells[3, 1] = Titulo2;

            formatRange1 = hoja.get_Range("A3", "I3");
            formatRange1.EntireRow.Font.Bold = true;
            formatRange1.Font.Size = 24;
            formatRange1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange);
            formatRange1.HorizontalAlignment = 3;
            formatRange1.VerticalAlignment = 3;
            formatRange1.Merge(true);



            string[] cabecera = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U" };
            int iniciofila = 6;
            for (int i = 1; i <= gridview.Columns.Count; i++)
            {
                Excel.Range formatRange2;
                if (gridview.Columns[i - 1].Visible == true)
                {
                    hoja.Cells[iniciofila, i] = gridview.Columns[i - 1].Caption;
                    formatRange2 = hoja.get_Range(cabecera[i - 1] + iniciofila.ToString(), cabecera[i - 1] + iniciofila.ToString());
                    formatRange2.EntireRow.Font.Bold = true;
                }



            }

            //Obtener todos los Fielname
            List<string> fielsname = new List<string>();
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                fielsname.Add(gridview.Columns[i].FieldName);
            }

            //i sera usado para el excel
            //j para acceder al grid view
            float total = 0;
            for (int i = iniciofila + 1, j = 0; j < gridview.RowCount; j++)
            {
                for (int m = 0; m < gridview.Columns.Count; m++)
                {
                    if (gridview.Columns[m].Visible != false)
                    {
                        //fielsname.Add(gridview.Columns[i].FieldName);
                        if (gridview.GetRowCellValue(j, fielsname[m]) != null)
                        {



                            string valor = gridview.GetRowCellValue(j, fielsname[m]).ToString();

                            if (gridview.Columns[m].DisplayFormat.FormatType == DevExpress.Utils.FormatType.DateTime)
                            {
                                //MessageBox.Show("f1=" + valor);
                                DateTime ff = Convert.ToDateTime(valor);

                                // ff.ToString("d MMMM yyyy");
                                // string fecha = Convert.ToDateTime(valor).ToShortDateString();
                                string fecha = ff.ToString("M/d/yyyy");
                                //string[] fecha1 = fecha.Split(' ');
                                //MessageBox.Show("fecha="+fecha1[0]);
                                //MessageBox.Show("f2="+fecha);

                                hoja.Cells[i, m + 1] = fecha;
                            }
                            else
                            {
                                // MessageBox.Show(valor);
                                hoja.Cells[i, m + 1] = valor;
                                if (column_total == m)
                                {
                                    total += float.Parse(valor);
                                }
                            }


                        }
                        else
                        {
                            hoja.Cells[i, m + 1] = "";
                        }
                    }
                }
                i++;
                //if (Convert.ToInt32(gridView1.GetRowCellValue(j, "cuotaspendiente").ToString()) > 0)
                //{
                //    string nombrecompleto = gridView1.GetRowCellValue(j, "idcliente.nombrecompleto").ToString();
                //    string direccion = gridView1.GetRowCellValue(j, "idcliente.direccion").ToString();
                //    string codigoexp = gridView1.GetRowCellValue(j, "idcliente.codigoExpediente").ToString();
                //    string telefono = gridView1.GetRowCellValue(j, "idcliente.telefono").ToString();
                //    string fechainicial = gridView1.GetRowCellValue(j, "fechainicial").ToString();
                //    string fechaultimacuota = gridView1.GetRowCellValue(j, "fechainicial").ToString();
                //    string cantidadcuotas = gridView1.GetRowCellValue(j, "cantidadcuotas").ToString();
                //    string cuotaspendientes = gridView1.GetRowCellValue(j, "cuotaspendiente").ToString();
                //    string lotesasiganados = gridView1.GetRowCellValue(j, "lotesasignados").ToString();

                //    hoja.Cells[i, 1] = nombrecompleto;
                //    hoja.Cells[i, 2] = direccion;
                //    hoja.Cells[i, 3] = codigoexp;
                //    hoja.Cells[i, 4] = telefono;
                //    hoja.Cells[i, 5] = fechainicial;
                //    hoja.Cells[i, 6] = fechaultimacuota;
                //    hoja.Cells[i, 7] = cantidadcuotas;
                //    hoja.Cells[i, 8] = cuotaspendientes;
                //    hoja.Cells[i, 9] = lotesasiganados;
                //    i++;
                //}

            }
            hoja.Cells[gridview.RowCount + 2, 4] = total;
            xlApp.Visible = true;

        }
        public static string ChangeIt(DateTime date)
        {
            switch (date.Day)
            {
                case 1:
                case 21:
                case 31:
                    return date.ToString("d'st' MMMM yyyy");
                case 2:
                case 22:
                    return date.ToString("d'nd' MMMM yyyy");
                case 3:
                case 23:
                    return date.ToString("d'rd' MMMM yyyy");
                default:
                    return date.ToString("d'th' MMMM yyyy");
            }
        }
    }
}
