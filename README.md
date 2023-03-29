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
## Twórcy projektu

* Paula Banach
* Igor Kołodziej
* Julia Pelczar
* Karolina Tymicka

pod czujnym okiem pana Dovgialo ;)