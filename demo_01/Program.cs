using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.PowerPoint;

namespace demo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\MyFile\myPPT.ppt";
            //bool ret = true;
            //Microsoft.Office.Interop.PowerPoint.Application newApp = new Microsoft.Office.Interop.PowerPoint.Application();
            //Microsoft.Office.Interop.PowerPoint.DocumentWindows doc = null;
            //// 缺省参数 
            //object Unknown = Type.Missing;
            //try
            //{

            //    // 指定原文件和目标文件 
            //    object Source = path;
            //    object Target = path.Substring(0, path.LastIndexOf(".")) + ".html";
            //    //为了保险,只读方式打开 
            //    object readOnly = true;
            //    // 指定另存为格式(html) 
            //    object format = Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsOpenXMLShow;
            //    // 打开doc文件 
            //    doc = newApp.DefaultWebOptions.Open();
            //    // 转换格式 
            //    doc.SaveAs(ref Target, ref format,
            //        ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown,
            //        ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown, ref Unknown);
            //}

            var entity = new dmmusicteachingEntities();
            var list = entity.mag_user.ToList();
        }


        //protected bool DocToPDF(string sourcePath, string targetPath)
        //{
        //    bool result = false;
        //    PpSaveAsFileType exportFormat = PpSaveAsFileType.ppsaveas
        //    object paramMissing = Type.Missing;
        //    Word.ApplicationClass wordApplication = new Word.ApplicationClass();
        //    Word.Document wordDocument = null;
        //    try
        //    {
        //        object paramSourceDocPath = sourcePath;
        //        string paramExportFilePath = targetPath;
        //        Word.WdExportFormat paramExportFormat = exportFormat;
        //        bool paramOpenAfterExport = false;
        //        Word.WdExportOptimizeFor paramExportOptimizeFor = Word.WdExportOptimizeFor.wdExportOptimizeForPrint;
        //        Word.WdExportRange paramExportRange = Word.WdExportRange.wdExportAllDocument;
        //        int paramStartPage = 0;
        //        int paramEndPage = 0;
        //        Word.WdExportItem paramExportItem = Word.WdExportItem.wdExportDocumentContent;
        //        bool paramIncludeDocProps = true;
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
