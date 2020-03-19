﻿using GroupDocs.Annotation.Examples.CSharp.AdvancedUsage;
using GroupDocs.Annotation.Examples.CSharp.BasicUsage;
using System;
using GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading;
using GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Saving;
using GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument;

namespace GroupDocs.Annotation.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            //NOTE: Please uncomment the example you want to try out
            #region Quick Start
            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();
            #endregion

            #region Get supported file formats
            GetSupportedFileFormats.Run();
            #endregion

            #region Get file info
            GetFileInfo.Run();
            #endregion

            #region Load document from local disk
            LoadDocumentFromLocalDisk.Run();
            #endregion

            #region Load document from stream
            LoadDocumentFromStream.Run();
            #endregion

            #region Load password-protected documents
            LoadPasswordProtectedDocuments.Run();
            #endregion

            #region Load document from url
            //LoadDocumentFromUrl.Run();
            #endregion

            #region Load document from FTP
            //LoadDocumentFromFtp.Run();
            #endregion

            #region Load document from AmazonS3
            //LoadDocumentFromAmazonS3.Run();
            #endregion

            #region Load document from Azure
            //LoadDocumentFromAzure.Run();
            #endregion

            #region Extract annotations from document
            ExtractAnnotationsFromDocument.Run();
            #endregion

            #region Remove annotation from document by Annotation
            RemoveAnnotationByAnnotation.Run();
            #endregion

            #region Remove annotation from document by Id
            RemoveAnnotationById.Run();
            #endregion

            #region Remove annotations from document by Annotations
            RemoveAnnotationsByAnnotations.Run();
            #endregion

            #region Remove annotations from document by Ids
            RemoveAnnotationsByIds.Run();
            #endregion

            #region Remove annotations from document using SaveOptions
            RemoveAnnotationUsingSaveOptions.Run();
            #endregion

            #region Generate document pages preview
            GenerateDocumentPagesPreview.Run();
            #endregion

            #region Saving specific page range
            SavingSpecificPageRange.Run();
            #endregion

            #region Saving only pages with annotations
            SavingOnlyPagesWithAnnotations.Run();
            #endregion

            #region Filtering annotation types
            /// TODO: Raised an exception with 19.11
            // FilteringAnnotationTypes.Run();
            #endregion

            #region Add area annotation
            AddAreaAnnotation.Run();
            #endregion

            #region Add arrow annotation
            AddArrowAnnotation.Run();
            #endregion

            #region Add distance annotation
            AddDistanceAnnotation.Run();
            #endregion

            #region Add ellipse annotation
            AddEllipseAnnotation.Run();
            #endregion

            #region Add image annotation using local path
            AddImageAnnotationLocalPath.Run();
            #endregion

            #region Add image annotation using remote path
            AddImageAnnotationRemotePath.Run();
            #endregion

            #region Add link annotation
            AddLinkAnnotation.Run();
            #endregion

            #region Add point annotation
            AddPointAnnotation.Run();
            #endregion

            #region Add resources redaction annotation
            AddResourcesRedactionAnnotation.Run();
            #endregion

            #region Add text highlight annotation
            AddTextHighlightAnnotation.Run();
            #endregion

            #region Add text field annotation
            AddTextFieldAnnotation.Run();
            #endregion

            #region Add text redaction annotation
            AddTextRedactionAnnotation.Run();
            #endregion

            #region Add text replacement annotation
            AddTextReplacementAnnotation.Run();
            #endregion

            #region Add text strikeout annotation
            AddTextStrikeoutAnnotation.Run();
            #endregion

            #region Add polyline annotation
            AddPolylineAnnotation.Run();
            #endregion

            #region Add underline annotation
            AddTextUnderlineAnnotation.Run();
            #endregion

            #region Add watermark annotation
            AddWatermarkAnnotation.Run();
            #endregion

            #region Add replies annotation
            AddReplies.Run();
            #endregion

            #region Remove replies
            RemoveReplies.Run();
            #endregion

            #region Remove replies by Id
            RemoveRepliesById.Run();
            #endregion

            #region Remove replies by user name
            RemoveRepliesByUserName.Run();
            #endregion

            #region Update annotation
            UpdateAnnotation.Run();
            #endregion

            Console.WriteLine();
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}
