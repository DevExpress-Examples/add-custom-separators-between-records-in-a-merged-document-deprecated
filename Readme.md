<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128608789/15.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5073)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomSeparator/Form1.cs) (VB: [Form1.vb](./VB/CustomSeparator/Form1.vb))
* [HtmlSeparatorForm.cs](./CS/CustomSeparator/HtmlSeparatorForm.cs) (VB: [HtmlSeparatorForm.vb](./VB/CustomSeparator/HtmlSeparatorForm.vb))
* [MyMailMergeExportForm.cs](./CS/CustomSeparator/MyMailMergeExportForm.cs) (VB: [MyMailMergeExportForm.vb](./VB/CustomSeparator/MyMailMergeExportForm.vb))
* [RichSeparatorForm.cs](./CS/CustomSeparator/RichSeparatorForm.cs) (VB: [RichSeparatorForm.vb](./VB/CustomSeparator/RichSeparatorForm.vb))
<!-- default file list end -->
# How to provide custom separators between records in a merged document

> **Note**
>
> As you may already know, the [WinForms Snap control](https://docs.devexpress.com/WindowsForms/11373/controls-and-libraries/snap) and [Snap Report API](https://docs.devexpress.com/OfficeFileAPI/15188/snap-report-api) are now in maintenance support mode. No new features or capabilities are incorporated into these products. We recommend that you use [DevExpress Reporting](https://docs.devexpress.com/XtraReports/2162/reporting) tool to generate, edit, print, and export your business reports/documents.

<p>This example demonstrates how to provide a custom element to separate each record in a document when none of the standard separators meets your requirements. Handle the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapSnapControl_MailMergeExportFormShowingtopic">SnapControl.MailMergeExportFormShowing</a> event and use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressSnapCoreOptionsSnapMailMergeExportOptions_CustomSeparatortopic">SnapMailMergeExportOptions.CustomSeparator</a> property to create a custom separator.</p>
<p>Run this example, click <strong>Finish&Merge</strong> on the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument16496"><u>Data Tools: Mail Merge</u></a> toolbar and specifya custom separator  that is inserted between each pair of master sections, as illustated in the picture below.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-provide-custom-separators-between-records-in-a-merged-document-e5073/15.1.9+/media/499d75dc-4cf6-11e6-80bf-00155d62480c.png"></p>
<p>See also: <a href="https://www.devexpress.com/Support/Center/p/E5074">How to add a custom progress indicator to a Snap application</a>.</p>

<br/>


