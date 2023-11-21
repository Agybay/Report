namespace OpenCity.Report.Infrastructure.Impl.Templates {
    partial class RegistrationNotice {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationNotice));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.barCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText4 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText3,
            this.xrRichText4,
            this.xrBarCode1,
            this.barCode1,
            this.xrRichText2,
            this.xrRichText1});
            this.Detail.HeightF = 327.5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // barCode1
            // 
            this.barCode1.AutoModule = true;
            this.barCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[Qr]")});
            this.barCode1.LocationFloat = new DevExpress.Utils.PointFloat(457.8471F, 190.2367F);
            this.barCode1.Name = "barCode1";
            this.barCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.barCode1.ShowText = false;
            this.barCode1.SizeF = new System.Drawing.SizeF(107.89F, 101.43F);
            this.barCode1.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.Q;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.barCode1.Symbology = qrCodeGenerator1;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 559.1667F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrRichText1
            // 
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<H3>\'+ [TitleKk]+\' </H3>\'")});
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(128.3333F, 28.33333F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(350.8333F, 30.50001F);
            // 
            // xrRichText2
            // 
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<div style=\"text-align:left;font-size: 15px;font-family: Times New Roman;\">\' +[B" +
                    "odyKk] +\'</div>\'\n")});
            this.xrRichText2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(45F, 83.33334F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(575.8333F, 77.99998F);
            // 
            // xrRichText1
            // 
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<H3>\'+ [TitleKk]+\' </H3>\'")});
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(128.3333F, 28.33333F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(406.6667F, 30.50001F);
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrRichText3
            // 
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<div style=\"text-align:left;font-size: 15px;font-family: Times New Roman;\">\' +[B" +
                    "odyRu] +\'</div>\'\n")});
            this.xrRichText3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(45F, 71.66666F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(575.8333F, 77.99998F);
            // 
            // xrRichText4
            // 
            this.xrRichText4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<H3>\'+ [TitleRu]+\' </H3>\'")});
            this.xrRichText4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrRichText4.LocationFloat = new DevExpress.Utils.PointFloat(128.3333F, 20.83333F);
            this.xrRichText4.Name = "xrRichText4";
            this.xrRichText4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText4.SerializableRtfString = resources.GetString("xrRichText4.SerializableRtfString");
            this.xrRichText4.SizeF = new System.Drawing.SizeF(406.6667F, 30.50001F);
            this.xrRichText4.StylePriority.UseFont = false;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[Qr]")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(457.8471F, 178.5701F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(107.89F, 101.43F);
            this.xrBarCode1.StylePriority.UsePadding = false;
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator2.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.Q;
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBarCode1.Symbology = qrCodeGenerator2;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrRichText4,
            this.xrRichText3});
            this.BottomMargin.HeightF = 559.1667F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // RegistrationNotice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 100F, 559.1667F);
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRBarCode barCode1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.XRRichText xrRichText4;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
    }
}
