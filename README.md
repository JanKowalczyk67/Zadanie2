Ćwiczenia 2 - Projekt obiektowy w C#
Opis projektu

Aplikacja konsolowa napisana w języku C#, umożliwiająca obsługę uczelnianej wypożyczalni sprzętu.
System pozwala na zarządzanie sprzętem, użytkownikami oraz procesem wypożyczeń i zwrotów, wraz z obsługą ograniczeń oraz naliczaniem kar.

**Funkcjonalności:**
Dodawanie użytkowników (Student, Employee)
Dodawanie sprzętu (Laptop, Projector, Camera)
Wyświetlanie wszystkich urządzeń
Wyświetlanie dostępnego sprzętu
Wypożyczanie sprzętu
Zwrot sprzętu (z uwzględnieniem kary za opóźnienie)
Blokowanie wypożyczenia przy przekroczeniu limitu
Raport podsumowujący stan systemu

**Sprzęt:**
Klasa abstrakcyjna Equipment
Klasy dziedziczące:
Laptop
Projector
Camera

Każdy typ sprzętu posiada wspólne cechy (ID, nazwa, dostępność) oraz własne pola specyficzne.

**Użytkownicy**
Klasa abstrakcyjna User
Klasy dziedziczące:
Student (limit: 2 wypożyczenia)
Employee (limit: 5 wypożyczeń)

**Wypożyczenie**
Klasa Rental przechowująca:
użytkownika
sprzęt
datę wypożyczenia
termin zwrotu
datę zwrotu
informację o opóźnieniu
Struktura projektu

Projekt został podzielony na logiczne części:

**folder Models**

Zawiera klasy domenowe:

Equipment, Laptop, Projector, Camera
User, Student, Employee
Rental

**folder Services**

Zawiera logikę biznesową:

EquipmentService – zarządzanie sprzętem
UserService – zarządzanie użytkownikami
RentalService – obsługa wypożyczeń i zwrotów
ReportService – generowanie raportów

**plik Program.cs**

Odpowiada za uruchomienie aplikacji i prezentację scenariusza działania.

Decyzje projektowe
Zasada pojedynczej odpowiedzialności (SRP)

Każda klasa ma jedną, jasno określoną rolę:

modele przechowują dane
serwisy realizują logikę biznesową
Niskie sprzężenie (Low Coupling)

Logika została rozdzielona między klasy serwisowe, dzięki czemu zmiany w jednym obszarze nie wpływają bezpośrednio na inne.

Dziedziczenie

Zastosowane tam, gdzie ma sens domenowy:

Equipment → różne typy sprzętu

User → różne typy użytkowników i limity

Centralizacja reguł biznesowych

Limity użytkowników są definiowane w klasach (Student, Employee)

Naliczanie kar znajduje się w jednym miejscu (RentalService)

Reguły biznesowe

Student może mieć maksymalnie 2 aktywne wypożyczenia

Pracownik może mieć maksymalnie 5 aktywnych wypożyczeń

Nie można wypożyczyć niedostępnego sprzętu

Przekroczenie limitu blokuje wypożyczenie

Opóźniony zwrot powoduje naliczenie kary (10 jednostek za dzień)


Scenariusz działania

Program demonstruje:

Dodanie sprzętu różnych typów

Dodanie użytkowników

Poprawne wypożyczenie sprzętu

Próbę przekroczenia limitu (obsługa błędu)

Zwrot sprzętu

Wygenerowanie raportu końcowego
