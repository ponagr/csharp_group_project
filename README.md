# Spelutvecklingsplan

## Prioriterade Funktioner

### Map (main)
- [x] Tydligt flöde för spelhantering.

### MapLevels
- [x] Skapa Player- och en Enemy-karaktär.
- [x] Utveckla nivå 1 och implementera movement-metod.
- [x] Enklare interaktion mellan karaktärer (Player och Enemy).
- [x] SetCururposition på mappen FÖR ATT SLIPPA GLITCH
- [x] Hjärta för att få liv på banan
- [x] Balancera fiender/player/items på level 1
- [x] Balancera fiender/player/items på level 2
- [x] Balancera fiender/player/items på level 3
- [x] Balancera fiender/player/items på level 4

### GameObject - Enemy - Player
- [x] Viktiga egenskaper och metoder för Player och Enemy.
- [x] När sceletons kommer så dödar vi de på ett slag men får en random skada automatiskt

### Combat
- [x] Skapa visuella representationer, t.ex. streckgubbar, för Player och Enemy under combat.
- [x] Formatera all text och gubbar så att det visas på ett snyggt sätt
- [x] Skapa en grundläggande struktur för combat-systemet.
- [x] Möjlighet att försvara sig

### Skapa Arv för Olika Typer av Enemy
- [x] Implementera specifika metoder och unika egenskaper för olika Enemy-typer.
- [x] Göra en boss / level med specifika egenskaper utifrån enemyklasser
  
### Lägg till XP och Levels
- [x] Implementera XP-system och nivåer för Player.
- [x] Lägg till XP-drop hos Enemy.
- [x] Xp-drop ska baseras på players level/maxXp

### Fler Stats och Multipliers
- [x] Utveckla fler stats och multipliers för Player.
- [x] Utveckla fler stats och multipliers för Enemy.

---

## Ej Prioriterade Funktioner

### Items, Coins och Inventory
- [x] Skapa item-klass och olika items att lägga i flera listor och slumpa ifrån
- [x] Implementera drop-rate från dödade bossar och loot-system för kistor.
- [x] Skapa en inventory (array med typ 5 items) i player-klassen
- [x] Begränsningar beroende på itemtyp - hjälm, plate osv.
- [x] Potions
- [ ] T.ex nycklar i kistor för att kunna öppna gates på banan för att komma vidare LÅTA BLI?
- [x] Fler items i level 1
- [x] Fler items i level 2
- [x] LevelCap för items
- [x] Dropfunktion för items och equipment

### Chests
- [x] Få kistor att byta färg när de har öppnats (använda bool och koordinatjämförelse).
- [x] Sortera listan över våra items efter pengar i Merchant-mode

### Merchant
- [x] Merchant man kan köpa ifrån och sälja till
- [x] Sälja allt via en knapp
- [x] Sortera listan över items efter pris i fallande ordning när man vill sälja
- [x] Maxantal items 10, + potions att köpa med Q
- [x] Visa items i rött/grönt beroende på vår level requirement

### ResourceBar/HealthBar/XPBar
- [x] Utveckla UI-element för resurser, hälsa och XP.
- [x] Xp-bar under mappen
- [x] Fixa så att healing pots healar en viss % av players total hp istället för flat ammount
- [x] Highscore

### Fler GameLevels
- [x] Utveckla nivå 2, nivå 3 osv. m d unika funktioner, som kortare distanser och nya områden (t.ex. dörrar, trappor).
- [ ] Lägg till t.ex. vatten med en ö man behöver hoppa till
- [x] Balancera fienden på de olika banorna, ordning, styrka osv.

### Random Enemy Movement
- [ ] Implementera random rörelse för fiender på kartan.
- [x] Göra vissa fiender osynliga på kartan (t.ex. assassins).
- [ ] Definiera en specifik aggro-range för olika enemy-klasser.               

### Fler Player-funktioner
- [ ] Implementera ytterligare funktioner för Player, som att hoppa över fiender.

### Meny
- [x] Skapa en första bild när man startar spelet
- [x] Skapa en meny med alternativ för att spela, ladda, spara och avsluta.
- [x] Använda JSON för att hantera highscore
- [x] Anpassa utskrift av highscore vid DEAD och vid val att skriva ut Highscores i mainmenyn
- [x] Använda JSON för att hantera spara/ladda.
- [x] Designa en rolig bild eller ikon för menyn.
- [ ] Fixa så att folk kan pusha och uppdatera highscore.json

### Story
- [ ] Utveckla en grundläggande berättelse för spelet

### Generera RandomMaps
- [ ] Implementera en funktion för att generera slumpmässiga kartor. 

---

## EVENTUELLT

### Multiplayer
- [ ] Utforska möjligheten för multiplayer-läge.

### Implementering i Monogame / Unity
- [ ] Utvärdera möjligheten att implementera spelet i MonoGame eller liknande ramverk.
