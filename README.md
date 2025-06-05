# 🏠 YourProply – Zarządzanie Nieruchomościami

**YourProply** to aplikacja desktopowa do zarządzania nieruchomościami, napisana w C# z użyciem Windows Forms i wzorca projektowego MVP. Umożliwia właścicielom i zarządcom łatwe prowadzenie wynajmu, kontakt z najemcami, generowanie dokumentów oraz automatyzację kluczowych procesów. Projekt został zrealizowany w ramach przedmiotu *Szkolenie Techniczne 1*.

## 🔧 Funkcje aplikacji

- Rejestracja i logowanie właścicieli oraz najemców
- Zarządzanie ofertami najmu (dodawanie, edytowanie, usuwanie)
- Przeglądanie dostępnych nieruchomości i ich statusu
- Dodawanie i edycja danych najemców
- Rezerwacje oraz wypowiadanie umów
- Generowanie umów PDF (QuestPDF)
- Wysyłanie wiadomości e-mail (SMTP – MailKit/MimeKit)
- Chatbot oparty na OpenAI (ChatGPT) do obsługi zapytań
- Panel użytkownika z możliwością zmiany hasła i adresu
- Szacowanie rentowności nieruchomości
- Import / eksport danych do/z plików CSV
- Szyfrowanie haseł SHA-256

## 🧱 Technologie

- C#
- Windows Forms (.NET 8.0)
- Entity Framework Core
- SQL Server + SQL Server Management Studio
- MVP (Model–View–Presenter)
- QuestPDF
- OpenAI API
- MailKit / MimeKit
- Git + GitHub

## 💻 Wymagania

- Windows 7 lub nowszy
- Visual Studio
- .NET 8.0
- SQL Server + SSMS
- 2 GB RAM, 100 MB wolnego miejsca

## ▶️ Jak odpalić

1. Sklonuj repozytorium:  
   `git clone https://github.com/Kacper20001/YourProply_repo.git`
2. Otwórz projekt w **Visual Studio**
3. Skonfiguruj połączenie z lokalnym SQL Server (baza danych EF Core)
4. Przygotuj dane startowe lub użyj importu CSV
5. Uruchom aplikację (startowy formularz logowania)

## 🧠 Autor

**Kacper Kulig**  
Numer albumu: w69199  
Projekt zrealizowany w ramach zajęć **Szkolenie Techniczne 1**

---
