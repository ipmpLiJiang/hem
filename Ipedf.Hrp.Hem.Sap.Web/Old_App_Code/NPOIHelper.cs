using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using Ipedf.Hrp.Hem.Sap.Entity;
using System.Text;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace Ipedf.Hrp.Hem.Sap.Web
{
    public class NPOIHelper
    {
        public static void CreateHeaderRow(HSSFWorkbook workbook, ISheet sheet, IRow headerRow, ICellStyle HeadercellStyle, string HeaderName, int rowStart, int rowEnd, int cellStart, int cellEnd)
        {
            ICell cell = headerRow.CreateCell(cellStart);
            cell.SetCellValue(HeaderName);
            cell.CellStyle = HeadercellStyle;

            CellRangeAddress region = new CellRangeAddress(rowStart, rowEnd, cellStart, cellEnd);
            sheet.AddMergedRegion(region);
            RegionUtil.SetBorderTop(1, region, sheet, workbook);
            RegionUtil.SetBorderRight(1, region, sheet, workbook);
            RegionUtil.SetBorderLeft(1, region, sheet, workbook);
            RegionUtil.SetBorderBottom(1, region, sheet, workbook);
            //((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.Thin, NPOI.HSSF.Util.HSSFColor.Black.Index);
            //headerRow.GetCell(cellStart).CellStyle = HeadercellStyle;
            //sheet.AddMergedRegion(new CellRangeAddress(rowStart, rowEnd, cellStart, cellEnd));
        }

        //Datatable导出Excel
        public static string GridToExcelByNPOI(DataTable dt, DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemHeader, string strExcelFileName)
        {
            try
            {
                string SheetName = dt.TableName;

                if (SheetName == "T1")
                {
                    SheetName = "研究生";
                }
                else if (SheetName == "T2")
                {
                    SheetName = "往届生";
                }
                else if (SheetName == "T3")
                {
                    SheetName = "院内实习";
                }
                else if (SheetName == "T4")
                {
                    SheetName = "院外实习";
                }
                else if (SheetName == "T5")
                {
                    SheetName = "非护理";
                }
                else if (SheetName == "T6")
                {
                    SheetName = "派遣制";
                }
                else
                {
                    SheetName = "Shell1";
                }

                HSSFWorkbook workbook = new HSSFWorkbook();

                ISheet sheet = workbook.CreateSheet(SheetName);

                ICellStyle HeadercellStyle = workbook.CreateCellStyle();

                HeadercellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                HeadercellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                HeadercellStyle.WrapText = true;
                //字体
                NPOI.SS.UserModel.IFont headerfont = workbook.CreateFont();
                headerfont.Boldweight = (short)FontBoldWeight.Bold;
                HeadercellStyle.SetFont(headerfont);

                //foreach (DataColumn item in dt.Columns)
                //{
                //    CreateHeaderRow(sheet,headerRow,HeadercellStyle,item.ColumnName,0,2,icolIndex,icolIndex);
                //    //ICell cell = headerRow.CreateCell(icolIndex);
                //    //cell.SetCellValue(item.ColumnName);
                //    //cell.CellStyle = HeadercellStyle;
                //    //sheet.AddMergedRegion(new CellRangeAddress(0, 2, icolIndex, icolIndex));
                //    icolIndex++;
                //}
                int icolIndex = 51;

                int[] nRows = itemHeader.GroupBy(o => o.ROWSTART).Select(p => p.Key).ToArray();

                for (int i = 0; i < nRows.Length; i++)
                {
                    IRow headerRow = sheet.CreateRow(nRows[i]);
                    DisplayObject_V_HEM_STAFF_NPOI_ALL[] RowCells = itemHeader.Where(p => p.ROWSTART == nRows[i]).ToArray();
                    foreach (DisplayObject_V_HEM_STAFF_NPOI_ALL c in RowCells)
                    {
                        CreateHeaderRow(workbook, sheet, headerRow, HeadercellStyle, c.HEADERNAME, c.ROWSTART, c.ROWEND, c.CELLSTART, c.CELLEND);
                    }
                }

                ICellStyle cellStyle = workbook.CreateCellStyle();

                //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
                cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
                cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.WrapText = true;

                NPOI.SS.UserModel.IFont cellfont = workbook.CreateFont();
                cellfont.Boldweight = (short)FontBoldWeight.Normal;
                cellStyle.SetFont(cellfont);

                //建立内容行
                int iRowIndex = 3;
                int iCellIndex = 0;
                foreach (DataRow Rowitem in dt.Rows)
                {
                    IRow DataRow = sheet.CreateRow(iRowIndex);
                    foreach (DataColumn Colitem in dt.Columns)
                    {
                        String cllV = Rowitem[Colitem].ToString();
                        if (!String.IsNullOrEmpty(cllV))
                        {
                            cllV = cllV.Replace("@#", "\n");
                        }
                        ICell cell = DataRow.CreateCell(iCellIndex);
                        cell.SetCellValue(cllV);
                        cell.CellStyle = cellStyle;

                        iCellIndex++;
                    }
                    DataRow.Height = 38 * 20;
                    iCellIndex = 0;
                    iRowIndex++;
                }

                //自适应列宽度
                for (int i = 0; i < icolIndex; i++)
                {
                    sheet.AutoSizeColumn(i, true);
                }
                //获取当前列的宽度，然后对比本列的长度，取最大值
                for (int columnNum = 0; columnNum <= icolIndex; columnNum++)
                {
                    int columnWidth = sheet.GetColumnWidth(columnNum) / 256;
                    for (int rowNum = 1; rowNum <= sheet.LastRowNum; rowNum++)
                    {
                        IRow currentRow;
                        //当前行未被使用过
                        if (sheet.GetRow(rowNum) == null)
                        {
                            currentRow = sheet.CreateRow(rowNum);
                        }
                        else
                        {
                            currentRow = sheet.GetRow(rowNum);
                        }

                        if (currentRow.GetCell(columnNum) != null)
                        {
                            ICell currentCell = currentRow.GetCell(columnNum);
                            int length = Encoding.Default.GetBytes(currentCell.ToString()).Length;
                            if (columnWidth < length)
                            {
                                columnWidth = length;
                            }
                        }
                    }
                    if (columnWidth > 255)
                    {
                        columnWidth = 255;
                    }
                    sheet.SetColumnWidth(columnNum, columnWidth * 256);
                }


                //写Excel
                //FileStream file = new FileStream(strExcelFileName, FileMode.OpenOrCreate);
                //workbook.Write(file);
                //file.Flush();
                //file.Close();
                var context = HttpContext.Current;
                context.Response.ContentType = "application/vnd.ms-excel";
                context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", context.Server.UrlEncode(strExcelFileName)));
                context.Response.Clear();

                MemoryStream file = new MemoryStream();
                workbook.Write(file);
                context.Response.BinaryWrite(file.GetBuffer());

                file.Close();
                file.Dispose();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "OK";
        }

        //Datatable导出Excel
        public static string GridToMunyExcelByNPOI(DataSet ds, DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemHeaderAll, string strExcelFileName)
        {
            try
            {

                HSSFWorkbook workbook = new HSSFWorkbook();
                string SheetName = "";
                for (int ni = 1; ni <= ds.Tables.Count; ni++)
                {
                    DisplayObject_V_HEM_STAFF_NPOI_ALL[] itemHeader = itemHeaderAll.Where(p => p.NUM == ni).ToArray();

                    DataTable dt = ds.Tables["T" + ni.ToString()];

                    SheetName = dt.TableName;

                    if (SheetName == "T1")
                    {
                        SheetName = "研究生";
                    }
                    else if (SheetName == "T2")
                    {
                        SheetName = "往届生";
                    }
                    else if (SheetName == "T3")
                    {
                        SheetName = "院内实习";
                    }
                    else if (SheetName == "T4")
                    {
                        SheetName = "院外实习";
                    }
                    else if (SheetName == "T5")
                    {
                        SheetName = "非护理";
                    }
                    else
                    {
                        SheetName = "Shell" + ni.ToString();
                    }

                    ISheet sheet = workbook.CreateSheet(SheetName);

                    ICellStyle HeadercellStyle = workbook.CreateCellStyle();

                    HeadercellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    HeadercellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    HeadercellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    HeadercellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    HeadercellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    HeadercellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    HeadercellStyle.WrapText = true;
                    //字体
                    NPOI.SS.UserModel.IFont headerfont = workbook.CreateFont();
                    headerfont.Boldweight = (short)FontBoldWeight.Bold;
                    HeadercellStyle.SetFont(headerfont);

                    //foreach (DataColumn item in dt.Columns)
                    //{
                    //    CreateHeaderRow(sheet,headerRow,HeadercellStyle,item.ColumnName,0,2,icolIndex,icolIndex);
                    //    //ICell cell = headerRow.CreateCell(icolIndex);
                    //    //cell.SetCellValue(item.ColumnName);
                    //    //cell.CellStyle = HeadercellStyle;
                    //    //sheet.AddMergedRegion(new CellRangeAddress(0, 2, icolIndex, icolIndex));
                    //    icolIndex++;
                    //}
                    int icolIndex = 51;

                    int[] nRows = itemHeader.GroupBy(o => o.ROWSTART).Select(p => p.Key).ToArray();

                    for (int i = 0; i < nRows.Length; i++)
                    {
                        IRow headerRow = sheet.CreateRow(nRows[i]);
                        DisplayObject_V_HEM_STAFF_NPOI_ALL[] RowCells = itemHeader.Where(p => p.ROWSTART == nRows[i]).ToArray();
                        foreach (DisplayObject_V_HEM_STAFF_NPOI_ALL c in RowCells)
                        {
                            CreateHeaderRow(workbook, sheet, headerRow, HeadercellStyle, c.HEADERNAME, c.ROWSTART, c.ROWEND, c.CELLSTART, c.CELLEND);
                        }
                    }

                    ICellStyle cellStyle = workbook.CreateCellStyle();

                    //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
                    cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
                    cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                    cellStyle.WrapText = true;
                    NPOI.SS.UserModel.IFont cellfont = workbook.CreateFont();
                    cellfont.Boldweight = (short)FontBoldWeight.Normal;
                    cellStyle.SetFont(cellfont);

                    //建立内容行
                    int iRowIndex = 3;
                    int iCellIndex = 0;
                    foreach (DataRow Rowitem in dt.Rows)
                    {
                        IRow DataRow = sheet.CreateRow(iRowIndex);
                        foreach (DataColumn Colitem in dt.Columns)
                        {
                            String cllV = Rowitem[Colitem].ToString();
                            if (!String.IsNullOrEmpty(cllV))
                            {
                                cllV = cllV.Replace("@#", "\n");
                            }
                            ICell cell = DataRow.CreateCell(iCellIndex);
                            cell.SetCellValue(cllV);
                            cell.CellStyle = cellStyle;
                            iCellIndex++;
                        }
                        DataRow.Height = 38 * 20;
                        iCellIndex = 0;
                        iRowIndex++;
                    }

                    //自适应列宽度
                    for (int i = 0; i < icolIndex; i++)
                    {
                        sheet.AutoSizeColumn(i, true);
                    }
                    //获取当前列的宽度，然后对比本列的长度，取最大值
                    for (int columnNum = 0; columnNum <= icolIndex; columnNum++)
                    {
                        int columnWidth = sheet.GetColumnWidth(columnNum) / 256;
                        for (int rowNum = 1; rowNum <= sheet.LastRowNum; rowNum++)
                        {
                            IRow currentRow;
                            //当前行未被使用过
                            if (sheet.GetRow(rowNum) == null)
                            {
                                currentRow = sheet.CreateRow(rowNum);
                            }
                            else
                            {
                                currentRow = sheet.GetRow(rowNum);
                            }

                            if (currentRow.GetCell(columnNum) != null)
                            {
                                ICell currentCell = currentRow.GetCell(columnNum);
                                int length = Encoding.Default.GetBytes(currentCell.ToString()).Length;
                                if (columnWidth < length)
                                {
                                    columnWidth = length;
                                }
                            }
                        }

                        if (columnWidth > 255)
                        {
                            columnWidth = 255;
                        }
                        sheet.SetColumnWidth(columnNum, columnWidth * 256);
                    }
                }

                //写Excel
                //FileStream file = new FileStream(strExcelFileName, FileMode.OpenOrCreate);
                //workbook.Write(file);
                //file.Flush();
                //file.Close();
                var context = HttpContext.Current;
                context.Response.ContentType = "application/vnd.ms-excel";
                context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", context.Server.UrlEncode(strExcelFileName)));
                context.Response.Clear();

                MemoryStream file = new MemoryStream();
                workbook.Write(file);
                context.Response.BinaryWrite(file.GetBuffer());

                file.Close();
                file.Dispose();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "OK";
        }

        //Datatable导出Excel
        public static string GridToExcelByNPOI(DataTable dt, HEM_B_STAFF_HEADER[] itemHeader, string strExcelFileName)
        {
            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                ICellStyle HeadercellStyle = workbook.CreateCellStyle();

                HeadercellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                HeadercellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                HeadercellStyle.WrapText = true;
                //字体
                NPOI.SS.UserModel.IFont headerfont = workbook.CreateFont();
                headerfont.Boldweight = (short)FontBoldWeight.Bold;
                HeadercellStyle.SetFont(headerfont);

                //foreach (DataColumn item in dt.Columns)
                //{
                //    CreateHeaderRow(sheet,headerRow,HeadercellStyle,item.ColumnName,0,2,icolIndex,icolIndex);
                //    //ICell cell = headerRow.CreateCell(icolIndex);
                //    //cell.SetCellValue(item.ColumnName);
                //    //cell.CellStyle = HeadercellStyle;
                //    //sheet.AddMergedRegion(new CellRangeAddress(0, 2, icolIndex, icolIndex));
                //    icolIndex++;
                //}
                int icolIndex = 51;
                int[] nRows = itemHeader.GroupBy(o => o.RowStart).Select(p => p.Key).ToArray();

                for (int i = 0; i < nRows.Length; i++)
                {
                    IRow headerRow = sheet.CreateRow(nRows[i]);
                    HEM_B_STAFF_HEADER[] RowCells = itemHeader.Where(p => p.RowStart == nRows[i]).ToArray();
                    foreach (HEM_B_STAFF_HEADER c in RowCells)
                    {
                        CreateHeaderRow(workbook, sheet, headerRow, HeadercellStyle, c.HeaderName, c.RowStart, c.RowEnd, c.CellStart, c.CellEnd);
                    }
                }

                ICellStyle cellStyle = workbook.CreateCellStyle();

                //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
                cellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
                cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.WrapText = true;

                NPOI.SS.UserModel.IFont cellfont = workbook.CreateFont();
                cellfont.Boldweight = (short)FontBoldWeight.Normal;
                cellStyle.SetFont(cellfont);

                //建立内容行
                int iRowIndex = 3;
                int iCellIndex = 0;
                foreach (DataRow Rowitem in dt.Rows)
                {
                    IRow DataRow = sheet.CreateRow(iRowIndex);
                    foreach (DataColumn Colitem in dt.Columns)
                    {
                        String cllV = Rowitem[Colitem].ToString();
                        if (!String.IsNullOrEmpty(cllV))
                        {
                            cllV = cllV.Replace("@#", "\n");
                        }
                        ICell cell = DataRow.CreateCell(iCellIndex);
                        cell.SetCellValue(cllV);
                        cell.CellStyle = cellStyle;
                        iCellIndex++;
                    }
                    DataRow.Height = 38 * 20;
                    iCellIndex = 0;
                    iRowIndex++;
                }

                //自适应列宽度
                for (int i = 0; i < icolIndex; i++)
                {
                    sheet.AutoSizeColumn(i, true);
                }
                //获取当前列的宽度，然后对比本列的长度，取最大值
                for (int columnNum = 0; columnNum <= icolIndex; columnNum++)
                {
                    int columnWidth = sheet.GetColumnWidth(columnNum) / 256;
                    for (int rowNum = 1; rowNum <= sheet.LastRowNum; rowNum++)
                    {
                        IRow currentRow;
                        //当前行未被使用过
                        if (sheet.GetRow(rowNum) == null)
                        {
                            currentRow = sheet.CreateRow(rowNum);
                        }
                        else
                        {
                            currentRow = sheet.GetRow(rowNum);
                        }

                        if (currentRow.GetCell(columnNum) != null)
                        {
                            ICell currentCell = currentRow.GetCell(columnNum);
                            int length = Encoding.Default.GetBytes(currentCell.ToString()).Length;
                            if (columnWidth < length)
                            {
                                columnWidth = length;
                            }
                        }
                    }
                    sheet.SetColumnWidth(columnNum, columnWidth * 256);
                }


                //写Excel
                //FileStream file = new FileStream(strExcelFileName, FileMode.OpenOrCreate);
                //workbook.Write(file);
                //file.Flush();
                //file.Close();
                var context = HttpContext.Current;
                context.Response.ContentType = "application/vnd.ms-excel";
                context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", context.Server.UrlEncode(strExcelFileName)));
                context.Response.Clear();

                MemoryStream file = new MemoryStream();
                workbook.Write(file);
                context.Response.BinaryWrite(file.GetBuffer());

                file.Close();
                file.Dispose();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "OK";
        }

        public static EntityObject_HEM_B_STAFF_REAL[] GetImportExcelData(FileStream fs, string extension,string USER_ID, string sheetName, ref string retMessage)
        {
            IWorkbook workbook = null;
            ISheet sheet = null;
            DataTable data = new DataTable();
            sheetName = "Sheet1";
            int startRow = 0;

            EntityObject_HEM_B_STAFF_REAL[] itemEntity = null;

            if (extension.ToUpper() == ".XLSX") // 2007版本
                workbook = new XSSFWorkbook(fs);
            else if (extension.ToUpper() == ".XLS") // 2003版本
                workbook = new HSSFWorkbook(fs);

            if (sheetName != null)
            {
                sheet = workbook.GetSheet(sheetName);
                if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                {
                    sheet = workbook.GetSheetAt(0);
                }
            }
            else
            {
                sheet = workbook.GetSheetAt(0);
            }

            if (sheet != null)
            {
                IRow firstRow = sheet.GetRow(0);
                int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数
                startRow = 1;

                data.Columns.Add(new DataColumn("REAL_PHONE"));//电话号码
                data.Columns.Add(new DataColumn("REAL_NAME"));//姓名
                data.Columns.Add(new DataColumn("REAL_ZHRGRSG"));//身高
                data.Columns.Add(new DataColumn("REAL_ZHRGRTZ"));//体重
                data.Columns.Add(new DataColumn("REAL_ZHRSLJZ"));//视力
                data.Columns.Add(new DataColumn("WRITTEN_ENGLISH"));//笔试英语
                data.Columns.Add(new DataColumn("WRITTEN_THEORY"));//笔试理论
                data.Columns.Add(new DataColumn("OPERATOR_ONE"));//操作1
                //最后一列的标号
                int rowCount = sheet.LastRowNum;

                List<EntityObject_HEM_B_STAFF_REAL> list = new List<EntityObject_HEM_B_STAFF_REAL>();

                if (rowCount > 0)
                {
                    string strSwitch = "";
                    string strCell = "";
                    bool IsTrue = true;
                    int count = 1;
                    DateTime dateMC = DateTime.Now;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        EntityObject_HEM_B_STAFF_REAL entity = new EntityObject_HEM_B_STAFF_REAL();
                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                            {
                                //REAL_PHONE,REAL_NAME,REAL_ZHRGRSG,REAL_ZHRGRTZ,REAL_ZHRSLJZ,WRITTEN_ENGLISH
                                //WRITTEN_THEORY,OPERATOR_ONE,MODIFY_TIME,CREATE_TIME
                                strSwitch = data.Columns[j].ToString();
                                strCell = row.GetCell(j).ToString();
                                if (!string.IsNullOrEmpty(strCell))
                                {
                                    switch (strSwitch)
                                    {
                                        case "REAL_PHONE":
                                            entity.REAL_PHONE = strCell;
                                            break;
                                        case "REAL_NAME":
                                            entity.REAL_NAME = strCell;
                                            break;
                                        case "REAL_ZHRGRSG":
                                            entity.REAL_ZHRGRSG = decimal.Parse(strCell);
                                            break;
                                        case "REAL_ZHRGRTZ":
                                            entity.REAL_ZHRGRTZ = decimal.Parse(strCell);
                                            break;
                                        case "REAL_ZHRSLJZ":
                                            entity.REAL_ZHRSLJZ = decimal.Parse(strCell);
                                            break;
                                        case "WRITTEN_ENGLISH":
                                            entity.WRITTEN_ENGLISH = decimal.Parse(strCell);
                                            break;
                                        case "WRITTEN_THEORY":
                                            entity.WRITTEN_THEORY = decimal.Parse(strCell);
                                            break;
                                        case "OPERATOR_ONE":
                                            entity.OPERATOR_ONE = decimal.Parse(strCell);
                                            break;
                                        default:
                                            //WebControlHelper.ShowAlert(this, "导入的Excel文件标题列错误！");
                                            //return;
                                            break;
                                    }
                                }
                                else
                                {
                                    if (strSwitch == "REAL_PHONE")
                                    {
                                        IsTrue = false;
                                    }
                                }
                            }

                        }
                        if (IsTrue)
                        {
                            entity.CREATE_TIME = dateMC;
                            entity.MODIFY_TIME = dateMC;
                            entity.USER_ID = USER_ID;
                            entity.STATUS = 0;
                            entity.NUM = count;
                            list.Add(entity);
                            count = count + 1;
                        }
                        IsTrue = true;
                    }

                    itemEntity = list.ToArray();

                }
                else
                {
                    retMessage = "导入的Excel文件缺少行记录或数据模板不正确！";
                }

            }
            else
            {
                retMessage = "导入的Excel文件模板不正确！";
            }

            return itemEntity;
        }

    }
}
