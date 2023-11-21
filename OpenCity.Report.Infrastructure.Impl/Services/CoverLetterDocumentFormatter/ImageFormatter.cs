using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Net.Codecrete.QrCodeGenerator;
using OpenCity.Report.Application.Extensions;
using OpenCity.Report.Application.Services;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;

namespace OpenCity.Applications.Infrastructure.Impl.Services.CoverLetterDocumentFormatter {
    /// <summary>
    /// Средство форматирования изображений
    /// </summary>
    public class ImageFormatter : ICoverLetterFormatter<string> {
        public ImageFormatter(bool needExecute, string parameter) {
            Parameter = parameter;
            NeedExecute = needExecute;
        }

        public string Parameter { get; set; }
        public bool NeedExecute { get; set; }

        public void Execute(Document documentx) {
            if(!NeedExecute) {
                return;
            }

            var qrCode = GetQr(Parameter);
            var mainPart = documentx.MainDocumentPart;
            var imagePart = mainPart.AddImagePart(ImagePartType.Png);
            using(MemoryStream stream = new MemoryStream(qrCode)) {
                imagePart.FeedData(stream);
            }

            var element1 = GetImageElement(mainPart.GetIdOfPart(imagePart));

            documentx.MainDocumentPart.Document.Body.Elements<Paragraph>()
                .FirstOrDefault(f => f.InnerText.Contains("QR_CODE"))?.AppendChild(new Run(element1));

            var element2 = GetImageElement(mainPart.GetIdOfPart(imagePart));

            documentx.MainDocumentPart.Document.Body.Elements<Paragraph>()
                .LastOrDefault(f => f.InnerText.Contains("QR_CODE"))?.AppendChild(new Run(element2));
        }
        private Drawing GetImageElement(string relationshipId) {
            var drawing = new Drawing();
            DW.Anchor anchor = new DW.Anchor() {
                DistanceFromTop = (UInt32Value)0U,
                DistanceFromBottom = (UInt32Value)0U,
                DistanceFromLeft = (UInt32Value)114300U,
                DistanceFromRight = (UInt32Value)114300U,
                SimplePos = false,
                RelativeHeight = (UInt32Value)251662848U,
                BehindDoc = true,
                Locked = false,
                LayoutInCell = true,
                AllowOverlap = true,
                EditId = "50D079" + new Random().Next(10, 99)
            };
            var extent = new DW.Extent() { Cx = 1645920L, Cy = 1668780L };
            var affectExtent = new DW.EffectExtent() {
                LeftEdge = 0L,
                TopEdge = 0L,
                RightEdge = 0L,
                BottomEdge = 0L
            };

            DW.SimplePosition simplePosition = new DW.SimplePosition() { X = 0L, Y = 0L };
            DW.HorizontalPosition horizontalPosition = new DW.HorizontalPosition() { RelativeFrom = DW.HorizontalRelativePositionValues.Column };
            DW.PositionOffset positionOffset1 = new DW.PositionOffset();
            positionOffset1.Text = "0";
            horizontalPosition.Append(positionOffset1);
            DW.VerticalPosition verticalPosition = new DW.VerticalPosition() { RelativeFrom = DW.VerticalRelativePositionValues.Paragraph };
            DW.PositionOffset positionOffset2 = new DW.PositionOffset();
            positionOffset2.Text = "32385";
            verticalPosition.Append(positionOffset2);

            DW.WrapTight wrapTight = new DW.WrapTight() { WrapText = DW.WrapTextValues.BothSides };
            DW.WrapPolygon wrapPolygon = new DW.WrapPolygon() { Edited = false };
            DW.StartPoint startPoint1 = new DW.StartPoint() { X = 0L, Y = 0L };
            DW.LineTo lineTo1 = new DW.LineTo() { X = 0L, Y = 21036L };
            DW.LineTo lineTo2 = new DW.LineTo() { X = 21551L, Y = 21036L };
            DW.LineTo lineTo3 = new DW.LineTo() { X = 21551L, Y = 0L };
            DW.LineTo lineTo4 = new DW.LineTo() { X = 0L, Y = 0L };
            wrapPolygon.Append(startPoint1);
            wrapPolygon.Append(lineTo1);
            wrapPolygon.Append(lineTo2);
            wrapPolygon.Append(lineTo3);
            wrapPolygon.Append(lineTo4);
            wrapTight.Append(wrapPolygon);


            var docProps = new DW.DocProperties() {
                Id = (UInt32Value)(uint)new Random().Next(1, 999999),
                Name = "Picture 1"
            };
            var nonVisualProps = new DW.NonVisualGraphicFrameDrawingProperties(
                new A.GraphicFrameLocks() { NoChangeAspect = true });
            var graphics = new A.Graphic(
            new A.GraphicData(
            new PIC.Picture(
                            new PIC.NonVisualPictureProperties(
                                new PIC.NonVisualDrawingProperties() {
                                    Id = (UInt32Value)(uint)new Random().Next(1, 999999),
                                    Name = "qr.JPG"
                                },
                                new PIC.NonVisualPictureDrawingProperties()),
                            new PIC.BlipFill(
                                new A.Blip(
                                    new A.BlipExtensionList(
                                        new A.BlipExtension() {
                                            Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}"
                                        })
                                ) {
                                    Embed = relationshipId,
                                    CompressionState = A.BlipCompressionValues.Print
                                },
                                new A.Stretch(new A.FillRectangle())),
                            new PIC.ShapeProperties(
                                new A.Transform2D(
                                    new A.Offset() { X = 0L, Y = 0L },
                                    new A.Extents() { Cx = 1645920L, Cy = 1668780L }),
                                new A.PresetGeometry(
                                        new A.AdjustValueList()
                                    ) { Preset = A.ShapeTypeValues.Rectangle }))
                    ) { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" });

            anchor.Append(simplePosition);
            anchor.Append(horizontalPosition);
            anchor.Append(verticalPosition);
            anchor.Append(extent);
            anchor.Append(affectExtent);
            anchor.Append(wrapTight);
            anchor.Append(docProps);
            anchor.Append(nonVisualProps);
            anchor.Append(graphics);
            drawing.Append(anchor);
            return drawing;
        }


        private byte[] GetQr(string textToEncode) {
            var qr = QrCode.EncodeText(textToEncode, QrCode.Ecc.Medium);
            return qr.ToPng(2, 10);
        }
    }
}
