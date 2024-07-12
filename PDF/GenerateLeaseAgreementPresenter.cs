using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using System;
using System.IO;
using YourProply.Services;
using YourProply.Entities;
using YourProply.Presenters;
using YourProply.Views;

namespace YourProply.PDF
{
    public class GenerateLeaseAgreementPresenter
    {
        private readonly YourProplyDbContext _context;
        private readonly User _loggedInUser;
        private readonly IGenerateLeaseAgreementView _view;
        private readonly OpenAIService _openAIService;

        public GenerateLeaseAgreementPresenter(IGenerateLeaseAgreementView view, YourProplyDbContext context, User loggedInUser, OpenAIService openAIService)
        {
            _view = view;
            _openAIService = openAIService;
            _context = context;
            _loggedInUser = loggedInUser;
            _view.BackToMenuClick += OnBackToMenuClick;
            _view.GeneratePDF += GeneratePdf;

            QuestPDF.Settings.License = LicenseType.Community;
        }

        /// <summary>
        /// Metoda obsługująca powrót do menu.
        /// </summary>
        private void OnBackToMenuClick(object sender, EventArgs e)
        {
            var landlordMenu = new LandlordMenu(_loggedInUser);
            var landlordMenuPresenter = new LandlordMenuPresenter(landlordMenu, _context, _loggedInUser, _openAIService);
            _view.Hide();
            landlordMenu.FormClosed += (s, args) => _view.Show();
            landlordMenu.Show();
        }

        /// <summary>
        /// Generowanie PDF umowy najmu.
        /// </summary>
        public void GeneratePdf(object sender, EventArgs e)
        {
            try
            {
                // Walidacja danych
                if (string.IsNullOrWhiteSpace(_view.LandlordFirstName) || string.IsNullOrWhiteSpace(_view.LandlordLastName) ||
                    string.IsNullOrWhiteSpace(_view.LandlordDOB) || string.IsNullOrWhiteSpace(_view.LandlordID) ||
                    string.IsNullOrWhiteSpace(_view.TenantFirstName) || string.IsNullOrWhiteSpace(_view.TenantLastName) ||
                    string.IsNullOrWhiteSpace(_view.TenantDOB) || string.IsNullOrWhiteSpace(_view.TenantID) ||
                    string.IsNullOrWhiteSpace(_view.PropertyName) || string.IsNullOrWhiteSpace(_view.PropertyAddress) ||
                    string.IsNullOrWhiteSpace(_view.PropertyType) || string.IsNullOrWhiteSpace(_view.RentalAmount) ||
                    string.IsNullOrWhiteSpace(_view.RentalStartDate) || string.IsNullOrWhiteSpace(_view.RentalEndDate))
                {
                    _view.ShowMessage("Proszę uzupełnić wszystkie pola.");
                    return;
                }

                var model = new RentalAgreementModel
                {
                    LandlordFirstName = _view.LandlordFirstName,
                    LandlordLastName = _view.LandlordLastName,
                    LandlordDOB = _view.LandlordDOB,
                    LandlordID = _view.LandlordID,
                    TenantFirstName = _view.TenantFirstName,
                    TenantLastName = _view.TenantLastName,
                    TenantDOB = _view.TenantDOB,
                    TenantID = _view.TenantID,
                    PropertyName = _view.PropertyName,
                    PropertyAddress = _view.PropertyAddress,
                    PropertyType = _view.PropertyType,
                    RentalAmount = _view.RentalAmount,
                    RentalStartDate = _view.RentalStartDate,
                    RentalEndDate = _view.RentalEndDate
                };

                var document = CreateRentalAgreementDocument(model);
                string filePath = "Umowa_najmu.pdf";
                document.GeneratePdf(filePath);

                _view.ShowMessage($"PDF został wygenerowany w: {Path.GetFullPath(filePath)}");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Błąd podczas generowania PDF: {ex.Message}");
            }
        }

        /// <summary>
        /// Tworzenie dokumentu umowy najmu.
        /// </summary>
        private IDocument CreateRentalAgreementDocument(RentalAgreementModel model)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Content()
                        .Column(column =>
                        {
                            column.Item().Text("Umowa najmu")
                                .FontSize(24)
                                .Bold()
                                .Underline()
                                .AlignCenter();

                            column.Item().Text($"Data: {DateTime.Now:MMMM dd, yyyy}")
                                .FontSize(12)
                                .AlignRight();

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Imię i nazwisko wynajmującego: {model.LandlordFirstName} {model.LandlordLastName}")
                                .FontSize(14)
                                .Bold());

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Data urodzenia wynajmującego: {model.LandlordDOB}")
                                .FontSize(14));

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Numer dowodu osobistego wynajmującego: {model.LandlordID}")
                                .FontSize(14));

                            column.Item().PaddingTop(10).PaddingBottom(10).Element(Container => Container.Text($"Imię i nazwisko najemcy: {model.TenantFirstName} {model.TenantLastName}")
                                .FontSize(14)
                                .Bold());

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Data urodzenia najemcy: {model.TenantDOB}")
                                .FontSize(14));

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Numer dowodu osobistego najemcy: {model.TenantID}")
                                .FontSize(14));

                            column.Item().PaddingTop(10).PaddingBottom(10).Element(Container => Container.Text($"Nazwa nieruchomości: {model.PropertyName}")
                                .FontSize(14)
                                .Bold());

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Adres nieruchomości: {model.PropertyAddress}")
                                .FontSize(14));

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Typ nieruchomości: {model.PropertyType}")
                                .FontSize(14));

                            column.Item().PaddingTop(10).PaddingBottom(10).Element(Container => Container.Text($"Koszt najmu: {model.RentalAmount}")
                                .FontSize(14)
                                .Bold());

                            column.Item().PaddingBottom(10).Element(Container => Container.Text($"Okres najmu: od {model.RentalStartDate} do {model.RentalEndDate}")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("§ 1. Przedmiot Umowy")
                                .FontSize(14)
                                .Bold());

                            column.Item().Element(Container => Container.Text("Wynajmujący oddaje Najemcy do używania nieruchomość opisaną powyżej, a Najemca zobowiązuje się do zapłaty czynszu najmu oraz innych opłat związanych z użytkowaniem nieruchomości.")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("§ 2. Okres Obowiązywania Umowy")
                                .FontSize(14)
                                .Bold());

                            column.Item().Element(Container => Container.Text($"Umowa zostaje zawarta na czas określony od dnia {model.RentalStartDate} do dnia {model.RentalEndDate}.")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("§ 3. Czynsz Najmu")
                                .FontSize(14)
                                .Bold());

                            column.Item().Element(Container => Container.Text($"Najemca zobowiązuje się do zapłaty Wynajmującemu czynszu najmu w kwocie {model.RentalAmount} zł miesięcznie, płatnego do 10. dnia każdego miesiąca.")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("§ 4. Obowiązki Stron")
                                .FontSize(14)
                                .Bold());

                            column.Item().Element(Container => Container.Text("Wynajmujący zobowiązuje się do utrzymania nieruchomości w stanie umożliwiającym jej używanie zgodnie z przeznaczeniem. Najemca zobowiązuje się do użytkowania nieruchomości zgodnie z jej przeznaczeniem oraz do terminowej zapłaty czynszu.")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("§ 5. Postanowienia Końcowe")
                                .FontSize(14)
                                .Bold());

                            column.Item().Element(Container => Container.Text("Wszelkie zmiany Umowy wymagają formy pisemnej pod rygorem nieważności. W sprawach nieuregulowanych Umową mają zastosowanie przepisy Kodeksu cywilnego.")
                                .FontSize(14));

                            column.Item().PaddingTop(20).Element(Container => Container.Text("Umowa zawarta pomiędzy wynajmującym i najemcą obowiązuje od dnia podpisania umowy.")
                                .FontSize(14));

                            column.Item().PaddingTop(50).Row(row =>
                            {
                                row.RelativeItem().Column(innerColumn =>
                                {
                                    innerColumn.Item().Text("_________________________").AlignCenter();
                                    innerColumn.Item().Text("Podpis Wynajmującego").AlignCenter();
                                });

                                row.ConstantItem(50);

                                row.RelativeItem().Column(innerColumn =>
                                {
                                    innerColumn.Item().Text("_________________________").AlignCenter();
                                    innerColumn.Item().Text("Podpis Najemcy").AlignCenter();
                                });
                            });
                        });
                });
            });
        }
    }
}
