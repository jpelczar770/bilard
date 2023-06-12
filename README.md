# Bilard

Tworzymy dwuwymiarową grę w bilard za pomocą Pythona i Unity. 

## Pobieranie plików

W wybranym przez siebie miejscu na swoim komputerze stwórz folder. Kliknij w niego prawym przyciskiem myszy i otwórz Git Bash:

```git bash
git remote add origin https://gitlab.com/projekt-gra-pijk/bilard.git
```
Powiedz Bashowi, kim jesteś, żeby móc dokonywać zmian w projekcie:

```git bash
git config --global user.name “Your Name”
git config --global user.email “you@example.com”
```

## Dodawanie plików

Zanim zmienisz coś w plikach, utwórz branch o jakiejś nazwie i do niego przejdź:

```git bash
git branch [branch_name]
git checkout [branch_name]
git push --set-upstream origin [branch_name]
```
Później stwórz lub edytuj pliki, które chcesz zmienić. Na końcu zrób commit i push:
```git bash
git add [file]
git commit
git push
```

## Żeby być na bieżąco...

...za każdym razem, kiedy chcesz dokonać jakichś zmian w projekcie, upewnij się, że masz na swoim komputerze wszystkie pliki, które mogły być zmieniane w ostatnim czasie przez innych:

```git bash
git pull
```
## Jak dodać zaktualizowaną grę na itch.io?

1. Otwieramy projekt w Unity i wybieramy File -> Build Settings.
2. Wybieramy w Platfrom WebGL, wybieramy sceny, które chcemy zbudować i wchodząc w Player Settings, wybieramy Disabled w Compression Format, a następnie klikamy Build.
3. Robimy .zip ze wszystkich plików w folderze, który powstał. 
4. Wchodzimy na itch.io, edytujemy nasz projekt (lub Upload New Project, Kind of project->HTML).
5. Następnie wybieramy Upload files, dodajemy nasz plik .zip i zaznaczamy opcję 'This file will be played in browser'. 
6. Klikamy Save and view page.

## ZASADY GRY W BILARD

W momencie rozpoczęcia gry na stole znajduje się bila biała (rozgrywająca) i 15 kolorowych bil rozgrywanych, ponumerowanych od 1 do 15. Bile o numerach od 1 do 7 to bile pełne (jednolitego koloru), natomiast bile od 9 do 15 to połówki (białe z kolorowym paskiem). Bila o numerze 8 jest jednolicie czarna i nie należy do żadnej z grup.

## Ustawianie bil na stole

Bile do rozbicia powinny być ustawione tak ściśle jak to możliwe, w formie trójkąta; na punkcie głównym stołu ma się znaleźć bila stanowiąca wierzchołek trójkąta, bila8 w jego środku. W dolnych wierzchołkach trójkąta powinny znajdować się bile z różnych grup. Pozostałe bile muszą być ustawiane losowo, z wyłączeniem jakiegokolwiek świadomego ich umieszczania w wybranym, konkretnym miejscu trójkąta

## Rozbicie

Gracz zadeklarowany (lub przydzielony przez system) jako Gracz 1 rozbija ustawiony trójkąt. Jeśli rozbiciem uda mu się wbić jakąkolwiek kolorową bilę do łuzy, może wykonać kolejny ruch. Jeśli nie, tura przechodzi na Gracza 2.

## Wbijanie bil

Stół pozostaje otwarty do momentu, gdy jeden z graczy wbije swoją pierwszą po rozbiciu bilę. W zależności od wbitej bili, zostają mu przydzielone pełne lub połówki, natomiast drugi gracz otrzymuje bile z przeciwnej grupy, a stół zostaje zamknięty. Jeśli wbite zostanie kilka bil z obu grup, graczowi zostaje przydzielona ta grupa, której bila wpadła pierwsza. Zawodnik kontynuuje następnie grę, wbijając bile należące do jego grupy.
Podczas gry nie ma znaczenia, która bila gracza zostanie zagrana jako pierwsza, ani która z bil gracza zostanie wbita. Nie jest wymagane nominowanie bil ani łuz (poza bilą nr 8).
Gra kończy się, gdy gracz wbije wszystkie bile należące do jego grupy, a następnie wbije prawidłowo bilę nr 8 do łuzy naprzeciwko (w przypadku łuz w środku stołu) lub po przekątnej (w przypadku łuz na rogach stołu).

## Faule

Za faul uznawane są następujące sytuacje:
* gdy zawodnik nie trafi bilą białą w żadną bilę kolorową,
* gdy zawodnik wbije bilę białą,
* gdy zawodnik trafi jako pierwszą bilę przeciwnika lub bilę nr 8 w sytuacji, gdy na stole wciąż znajdują się bile należące do jego grupy.

Przeciwnik faulującego gracza ma prawo do wykonania zagrania z białą bilą „w ręce”, tj. z dowolnego miejsca stołu.

## Natychmiastowa przegrana

Faul połączony z wbiciem bili nr 8 skutkuje natychmiastową przegraną:
* gdy zawodnik wbije poza rozbiciem bilę nr 8 przed wbiciem wszystkich pozostałych bil ze swojej grupy,
* gdy zawodnik wbije bilę nr 8 do innej łuzy, niż zadeklarowana.

 
## Twórcy projektu

* Paula Banach
* Igor Kołodziej
* Julia Pelczar
* Karolina Tymicka

pod czujnym okiem pana Dovgialo ;)
