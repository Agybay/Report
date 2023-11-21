namespace OpenCity.Report.Infrastructure.Impl.Templates {
    partial class ApplicationCardPortal {
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
            DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationCardPortal));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.DetailReportKk = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode5 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.DetailReportRu = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.ReportHeader1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // xrBarCode1
            // 
            xrBarCode1.AutoModule = true;
            xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[QRRu]")});
            xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(74.16666F, 167.5F);
            xrBarCode1.Name = "xrBarCode1";
            xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            xrBarCode1.ShowText = false;
            xrBarCode1.SizeF = new System.Drawing.SizeF(130F, 112.5F);
            xrBarCode1.StylePriority.UseBorders = false;
            xrBarCode1.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.Q;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            xrBarCode1.Symbology = qrCodeGenerator1;
            // 
            // Detail
            // 
            this.Detail.HeightF = 13.33364F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 21.66667F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReportKk
            // 
            this.DetailReportKk.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportHeader,
            this.ReportFooter});
            this.DetailReportKk.Level = 0;
            this.DetailReportKk.Name = "DetailReportKk";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrLabel6,
            this.xrLabel8,
            this.xrBarCode5,
            this.xrLabel9,
            this.xrRichText1});
            this.Detail1.Expanded = false;
            this.Detail1.HeightF = 452.5006F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(89.33334F, 26.66667F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(538.1669F, 17.37427F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Өтініш";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Angle = 90F;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Қол қойылды: \' + [ApplicantNameOrOrganizaionName] + NewLine()+\n\'Күні: \' + [Date]" +
                    "")});
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9F);
            this.xrLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.66667F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(36.66667F, 318.8336F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[Date]")});
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(441.6667F, 163.3333F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(163.3333F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            // 
            // xrBarCode5
            // 
            this.xrBarCode5.AutoModule = true;
            this.xrBarCode5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[QRKk]")});
            this.xrBarCode5.LocationFloat = new DevExpress.Utils.PointFloat(63.33333F, 254.1667F);
            this.xrBarCode5.Name = "xrBarCode5";
            this.xrBarCode5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode5.ShowText = false;
            this.xrBarCode5.SizeF = new System.Drawing.SizeF(130F, 115F);
            this.xrBarCode5.StylePriority.UseBorders = false;
            this.xrBarCode5.StylePriority.UsePadding = false;
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator2.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.Q;
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBarCode5.Symbology = qrCodeGenerator2;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(63.33333F, 105.8333F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(553.3333F, 22.99998F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Менің сөзімнен дұрыс жазылған, менімен оқылған, толықтыруларым жоқ.";
            // 
            // xrRichText1
            // 
            this.xrRichText1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<div style=\"text-align: justify;\">\'+[ApplicationText] + \'</div>\'")});
            this.xrRichText1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(63.33333F, 59.16667F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(553.3333F, 23F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5});
            this.ReportHeader.Expanded = false;
            this.ReportHeader.HeightF = 212.4994F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'ЖСН: \' + IsNull([Xin], \'Ақпарат жоқ\' )")});
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 86.83334F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(300.8333F, 23.00001F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "xrLabel11";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 10F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(300.8333F, 30.83333F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "«Open Almaty» Алматы қаласы әкімдігінің қоғамдық қабылдау бөлмесіне";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 40.83333F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Кімнен:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'ТӘЖ: \'+ IsNull([ApplicantNameOrOrganizaionName], \'Ақпарат жоқ\' )")});
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 63.83334F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(300.8333F, 23.00001F);
            this.xrLabel3.StylePriority.UseFont = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Мекен-жайы:\' + IsNull([AddressKk], \'Ақпарат жоқ\' )")});
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 109.8334F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(300.8333F, 23.00001F);
            this.xrLabel4.StylePriority.UseFont = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Телефон нөмірі: \' + IsNull([TelephonNumber], \'Ақпарат жоқ\' )")});
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 132.8334F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(300.8333F, 25.5F);
            this.xrLabel5.StylePriority.UseFont = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Expanded = false;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            // 
            // DetailReportRu
            // 
            this.DetailReportRu.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.ReportHeader1,
            this.ReportFooter1});
            this.DetailReportRu.Level = 1;
            this.DetailReportRu.Name = "DetailReportRu";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrLabel7,
            this.xrLabel19,
            xrBarCode1,
            this.xrLabel10,
            this.xrRichText2});
            this.Detail2.HeightF = 378.3327F;
            this.Detail2.Name = "Detail2";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(89.33334F, 15.33337F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(538.1669F, 21.54094F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Обращение";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Angle = 90F;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Подписано: \' + [ApplicantNameOrOrganizaionName] + NewLine()+\n\'От: \' + [Date]")});
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9F);
            this.xrLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 15.33335F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(36.66667F, 316.0003F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.AutoWidth = true;
            this.xrLabel19.CanShrink = true;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'\'+[Date]")});
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(453.3333F, 128.3333F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(163.3333F, 23F);
            this.xrLabel19.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(74.16666F, 86.16669F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(553.3333F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "С  моих  слов  записано  верно,  мною  прочитано, дополнений не имею.";
            // 
            // xrRichText2
            // 
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "\'<div style=\"text-align: justify;\">\'+[ApplicationText] + \'</div>\'")});
            this.xrRichText2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(74.16666F, 50.33335F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(553.3333F, 23F);
            // 
            // ReportHeader1
            // 
            this.ReportHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12});
            this.ReportHeader1.HeightF = 185.0004F;
            this.ReportHeader1.Name = "ReportHeader1";
            // 
            // xrLabel17
            // 
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'ИИН: \' + IsNull([Xin], \'Отсутствует\' )")});
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 86.83329F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(300.8331F, 23.00001F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.Text = "xrLabel17";
            // 
            // xrLabel16
            // 
            this.xrLabel16.AutoWidth = true;
            this.xrLabel16.CanShrink = true;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Номер телефона: \' + IsNull([TelephonNumber], \'Отсутствует\' )")});
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(426.6665F, 133.9999F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(300.8333F, 25.5F);
            this.xrLabel16.StylePriority.UseFont = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.AutoWidth = true;
            this.xrLabel15.CanShrink = true;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Адрес: \' + IsNull([AddressRu], \'Отсутствует\' )")});
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(426.6665F, 111.0001F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(300.8333F, 23.00001F);
            this.xrLabel15.StylePriority.UseFont = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.AutoWidth = true;
            this.xrLabel14.CanShrink = true;
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'ФИО: \'+ IsNull([ApplicantNameOrOrganizaionName], \'Отсутствует\' )")});
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 63.83331F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(300.8333F, 23.00001F);
            this.xrLabel14.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.AutoWidth = true;
            this.xrLabel13.CanShrink = true;
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 40.83333F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "От кого:";
            // 
            // xrLabel12
            // 
            this.xrLabel12.AutoWidth = true;
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(426.6667F, 10F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(300.8333F, 30.83333F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "В общественную приемную акимата города Алматы «Open Almaty»";
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // ApplicationCardPortal
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReportKk,
            this.DetailReportRu});
            this.Margins = new DevExpress.Drawing.DXMargins(39F, 48F, 21.66667F, 10F);
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReportKk;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReportRu;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
    }
}
