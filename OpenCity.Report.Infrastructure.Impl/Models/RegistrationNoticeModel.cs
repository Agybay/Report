using DevExpress.XtraReports.UI;

namespace OpenCity.Report.Infrastructure.Impl.Models {
    public class RegistrationNoticeModel : ReportAssemblyModel {
        public string ApplicantNameOrOrganizaionName { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationNumber { get; set; }
        public string TitleRu { get; set; }
        public string TitleKk { get; set; }
        public string BodyRu { get; set; }
        public string BodyKk { get; set; }
        public string Qr { get; set; }
        public override string ReportName { get; set; } = "Извещение о регистрации";
        public override XtraReport GetTemplate() {
            return new Templates.RegistrationNotice();
        }

        public override void PrepareModelForBinding() {
            TitleKk = $"Өтінішті тіркеу туралы хабарлама";
            TitleRu = $"Извещение о регистрации обращения";

            BodyKk = $"<div style='text-indent: 30px;'>Құрметті, {ApplicantNameOrOrganizaionName}, өтінішіңіз {Date.ToString("dd.MM.yyyy")} ж. {RegistrationNumber} тіркелді.</div><br>" +
                     $"<div style='text-indent: 30px;'>Өтінішіңіз бойынша деректерді https://frontoffice.open-almaty.kz/ порталындағы жеке кабинетіңізден көре аласыз.</div>";

            BodyRu = $"<div style='text-indent: 30px;'>Уважаемый(ая), {ApplicantNameOrOrganizaionName}, Ваше обращение зарегистрировано под № {RegistrationNumber} от {Date.ToString("dd.MM.yyyy")} года.</div><br>" +
                     $"<div style='text-indent: 30px;'>Данные по Вашему обращению можно просмотреть в личном кабинете на портале https://frontoffice.open-almaty.kz.</div>";

            Qr = $"{RegistrationNumber} {Date.ToString("dd.MM.yyyy")} https://frontoffice.open-almaty.kz/";

        }

    }
}
