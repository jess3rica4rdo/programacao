﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestão.utilidades
{
    public static class excel
    {
        public static void exportToExcel(this DataTable DataTable, string ExcelFilePath = null)
        {
            try
            {
                int ColumnsCount;
                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;
                object[] Header = new object[ColumnsCount];
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;
                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)Worksheet.Cells[1, 1], (Microsoft.Office.Interop.Excel.Range)Worksheet.Cells[1, ColumnsCount]);
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                HeaderRange.Font.Bold = true;
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)Worksheet.Cells[2, 1], (Microsoft.Office.Interop.Excel.Range)Worksheet.Cells[RowsCount + 1, ColumnsCount]).Value = Cells;
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();
                        MessageBox.Show("Ficheiro Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                          + ex.Message);
                    }
                }
                else
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        public static DataTable DataGridView_To_Datatable(DataGridView dg)
        {
            DataTable ExportDataTable = new DataTable();
            foreach (DataGridViewColumn col in dg.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dg.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                ExportDataTable.Rows.Add(dRow);
            }
            return ExportDataTable;
        }
    }
}

