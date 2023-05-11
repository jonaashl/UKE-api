# Caseoppgave for UKE (backend)

## Quickstart

Run visual studio solution or docker container (No database on docker as of now)


---

## Generelt om prosjektet

Veldig morsom oppgave!

Det har vært vanskelig å holde alle optional tasks i hver sin feature branch, men jeg har prøvd mitt beste!

Kun skrevet tester for backend, har svært lite erfaring med frontend unit-testing.

React med Oslo kommune styleguide har vært.. utfordrende

---

### Forbedringer

- Flytte konverteringslogikken ut av kontrolleren slik at det ikke er én funksjon som håndterer konverteringen, database-lagring og respons.
- Dette ville gjort applikasjonen mer modulær og fleksibel for skalering

- Endre fra en lokal database til f.eks SQLite som kan kjøre i docker containeren.
- Dette ville resultert i en fungerende docker container, men ingen data persistance - over mitt nivå.

- Logikken er riktig, men tar ikke hensyn til feilformaterte romertall. (gir et output selv om det burde vært en exception)

- Exception handling
---

License: MIT
