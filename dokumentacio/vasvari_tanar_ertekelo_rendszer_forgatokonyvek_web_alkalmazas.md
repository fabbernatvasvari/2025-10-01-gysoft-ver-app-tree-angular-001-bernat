## **Web alkalmazás**


<table>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" >Token alapú autentikáció
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" > Értékelő diákok
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >Token alapú autentikáció annak ellenőrzése, hogy a diák adott-e le már értékelést illetve osztály (csoport?) meghatározása. Token ami tartalmazza az osztály kódot (csoport kódot) és egy egyedi (gerelát) részt. Ezt ki kell osztani a diákoknak személyesen, hogy a tanárok értékelése előtt a kódot megadva azonosítsák osztályt amelyben járnak,mert ez által meghatározható azon diákok köre amelyikbe járnak.
<ol>

<li>A diák betölti a weboldalt</li>

<li>Egy szövegmezőben megadja a kérdőívezés előtt kapott egyedi kódját. RestApi: Tároljuk, hogy avval a tokennel már megkezdtek egy értékelést.</li>
</ol>
   </td>
   <td>A token olyan osztály azonosít ami nem létezik a rendszerben.
<p>
A token nem valid.
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" ><em>Értékelésben résztvevő tanárok meghatározása az értékelésben résztvevő diák által a tanulói csoportok kiválasztásával</em>
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" > Értékelő diákok
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >
<ol>

<li>Megjelennek azoknak a tanároknak a nevei akik az osztályban tanítanak. (RestApi: Token alapján azon osztályok lekérdezése, akik tanítják az osztályt</li>

<li>A tanárok nevei felett megjelennek radiobuttonokkal azok a tanulói csoportok amelyek egyikébe biztos jár a diák (pl. angol kezdő vagy angol haladó). Megjelennek azok a csoportok amelyek választható csoportok (pl. matek korepetálás vagy fakultáció)</li>

<li>A diák kiválasztja az osztályhoz tartozó csoportok közül azokat amelyekbe jár (checbox, későbbi fejlesztés hogy checkbox és radio button).</li>

<li>Amikor egy tanulói csoportot kiválaszt a diák amelyikbe jár (radio buttonnal, vagy checkboxal) akkor frissülnek a tanár nevek azokkal a nevekkel amelyek az adott tanulói csoportot tanítják. (RestApi kérés: csoportazonosító alapján a tanár nevek maghatározása)</li> 
<ol>
 
<li>Ezek a tanár nevek frissítésre kerülnek egy lekérés gombbal vagy automatikusan.A tanárokat neveit változtatni lehet addig amíg csak azok a tanárok jelennek meg, akik az adott értékelő diákot tanítják.</li> 
</ol>

<li>Ha a diák befejezte a tanárok meghatározását egy lezárás gombbal lezárja a csoport választást és elkezdődhet az értékelés.</li>
</ol>
   </td>
   <td>
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" >Értékelés
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" >  Értékelő diákok
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >
<ol>

<li>Egy új oldalon a lap tetején megjelenik az első kérdés (miután a diák értékelt a lap tetején vagy a lap alján tovább léphet a következő kérdésre). RestApi kérés: az összes kérdés lekérdezése</li>

<li>Bal oldalt egy oszlopban egymás alatt megjelenik az összes tanár. (RestApi kérés: már meghatározásra került előbb hogy kik tanítják, nem szükséges újra lekérdezni a tanáradatokat)</li>

<li>Egy tanárral egy sorban megjelennek a lehetséges válaszok (1 2 4 5 ).</li>

<li>A diák minden sorban értékelést ad. (Az értékelések kérdésenként és tanáronként a memóriában tárolódnak)</li>

<li>Értékelését befejezve továbblép a következő kérdésre</li>

<li>Ha a kérdések elfogynak a diák befejezi az értékelést. RestApi: Az összes tanárra leadott összes értékelés tárolásra kerül.</li>
</ol>
   </td>
   <td>
   </td>
  </tr>
</table>



## **Consol alkalmazás**


<table>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" >
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" >
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >
   </td>
   <td>
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" >
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" > 
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >
   </td>
   <td>
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Munkafolyamat neve</strong>
   </td>
   <td colspan="2" >
   </td>
  </tr>
  <tr>
   <td colspan="2" ><strong>Ki (kik végzik)?</strong> 
   </td>
   <td colspan="2" > 
   </td>
  </tr>
  <tr>
   <td colspan="3" ><strong>Lépések</strong>
   </td>
   <td> <strong>Hibalehetőségek</strong>
   </td>
  </tr>
  <tr>
   <td colspan="3" >
   </td>
   <td>
   </td>
  </tr>
</table>
