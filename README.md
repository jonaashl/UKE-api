# Caseoppgave for UKE (backend)

## Quickstart

Run visual studio solution or docker container (No database on docker as of now)


---

## Generelt om prosjektet

Veldig morsom oppgave!

Det har v�rt vanskelig � holde alle optional tasks i hver sin feature branch, men jeg har pr�vd mitt beste!

Kun skrevet tester for backend, har sv�rt lite erfaring med frontend unit-testing.

React med Oslo kommune styleguide har v�rt.. utfordrende

---

### Forbedringer

- Flytte konverteringslogikken ut av kontrolleren slik at det ikke er �n funksjon som h�ndterer konverteringen, database-lagring og respons.
- Dette ville gjort applikasjonen mer modul�r og fleksibel for skalering

- Endre fra en lokal database til f.eks SQLite som kan kj�re i docker containeren.
- Dette ville resultert i en fungerende docker container, men ingen data persistance - over mitt niv�.

- Logikken er riktig, men tar ikke hensyn til feilformaterte romertall. (gir et output selv om det burde v�rt en exception)

- Exception handling
---

License: MIT
