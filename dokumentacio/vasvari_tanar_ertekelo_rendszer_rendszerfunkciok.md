## **1. Összefüggések és a szoftver képességei**

*A megvalósítandó szoftver funkciók:*

-   Adottak a Krétából amelyek alapján a tanár értékelést meg kell
    valósítani: az osztályok, osztály csoportok, tanárok, tanárok által
    tanított osztályok vagy csoportok. Ezeket az adatokat el kell
    juttatni adatbázisba/backendbe.

-   A diákok értékelik a tanárokat. Adminisztrációs oldalon nyomon
    követhető legyen az az adatok érkezése.

-   Statisztika készítése az értékelések alapján (pl. pdf).

A VÉR App web alkalmazás

-   A diákok tokenekkel azonosítják, az osztály ahova járnak, illetve
    kiválaszthatják azokat a tanulmányi csoportokat amelyekbe járnak. Ez
    által meghatározásra kerülnek az értékelendő tanárok. Majd lezárják
    a tanárok kiválasztását.

-   A diákok értékelik a tanárokat, kapnak egy kérdést, és az adot
    kérdésnél mindent tanárt leértékelnek akik tanították őket. Majd a
    következő tanárra lépnek. Ha befejezték az értékelést kilépnek a
    rendszerből.

A VÉR App consol (kifejleszthető a desktop I. alkalmazás részeként is).

-   Adatok feltöltése az adatbázisba (a meglévő kréta exportok alapján
    elkészíti a backend adatbázist amely szükséges a tanár értékeléshez
    a frontendnek)

-   A csv fájlokból feltöltött adatok ellenőrzése pl: tanárok számának,
    osztályok számának stb kiírása a képernyőre fájlból történő
    beolvasás után, majd a backend adatbázis feltöltése után a
    backendről ugyan ezen adatok letöltése és megjelenítése, hogy a
    feltöltés sikeressége ellenőrizhető legyen

A VÉR App desktop alkalmazásban I.

Adminisztrációs oldal amin nyomon követhetőek az adatok érkezése a
tesztek kitöltése során illetve a rendszerben lévő adatok statisztikái:

-   Osztályok száma, osztályok csoportjainak száma, tanárok száma,\...

-   Az előzők listája, pl osztály azonosítók listája, tanár nevek
    listája, stb.

-   Osztályonként hány diák adta le az értékelését

A VÉR App desktop alkalmazásban II.

Tanári statisztika készítése az értékelések alapján (pdf)

-   Adott tanár, adott kérdésnél milyen átlagot ért el

**Fejlesztési lehetőségek**

Több egymás utáni tanár értékelés esetén a megoldandó feladatok:

-   Egy értékelés egy évszám és hónap rendelése, amellyel beazonosítható
    melyik értékelésről van szó.

-   Egy adott időszak értékelésének lezárása

-   Egy új időszak értékelésének megnyitása

    -   az új értékelés megvalósulhat teljesen új adatokkal

    -   az új értékelés megvalósulhat felhasználva már bizonyos meglévő
        adatokat (csak bizonyos tanárok változnak. Osztályok
        előrelépnek, bizonyos osztály bontások maradnak, mások
        megszűnnek, és újak jönnek létre.

-   A tanárok és a vezetőség is a statisztikákat nyomonkövetkzetnék és
    elemezhetnék több időszakot összehasonlítva.
