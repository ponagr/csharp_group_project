# Spelutvecklingsplan

## Prioriterade Funktioner

// Från NATAFANSUSSANNE
HIGHSCORE!
Autosave vid ny nivå
Skydda sig

### GameHandler (main)
- [x] Tydligt flöde för spelhantering.

### GameLevel
- [x] Skapa Player- och en Enemy-karaktär.
- [x] Utveckla nivå 1 och implementera movement-metod.
- [x] Enklare interaktion mellan karaktärer (Player och Enemy).
- [x] SetCururposition på mappen FÖR ATT SLIPPA GLITCH
- [x] Hjärta för att få liv på banan

### GameObject - Enemy - Player
- [x] Lägg till viktiga egenskaper och metoder för Player och Enemy.

### Combat
- [x] Skapa visuella representationer, t.ex. streckgubbar, för Player och Enemy under combat.
- [x] Formatera all text och gubbar så att det visas på ett snyggt sätt
- [x] Skapa en grundläggande struktur för combat-systemet.

### Skapa Arv för Olika Typer av Enemy
- [x] Implementera specifika metoder och unika egenskaper för olika Enemy-typer.
- [x] Göra en boss / level med specifika egenskaper utifrån enemyklasser
  
### Lägg till XP och Levels
- [x] Implementera XP-system och nivåer för Player.
- [x] Lägg till XP-drop hos Enemy.

### Fler Stats och Multipliers
- [x] Utveckla fler stats och multipliers för Player.
- [x] Utveckla fler stats och multipliers för Enemy.

---

## Ej Prioriterade Funktioner

### Items, Coins och Inventory
- [x] Skapa item-klass och olika items att lägga i flera listor och slumpa ifrån
- [ ] Implementera en random drop-rate från dödade fiender och loot-system för kistor.
- [x] Skapa en inventory (array med typ 5 items) i player-klassen
- [x] Begränsningar beroende på itemtyp - hjälm, plate osv.
- [x] Lägg till en Merchant som man kan sälja/köpa ifrån - en char-ikon i stället för klass.
- [x] Potions
- [ ] T.ex nycklar i kistor för att kunna öppna gates på banan för att komma vidare LÅTA BLI?
- [ ] Lägg till fler items redan i level 1
- [ ] Lägg till LevelCap för items?

### Chests
- [x] Få kistor att byta färg när de har öppnats (använda bool och koordinatjämförelse).
- [x] Sortera listan över våra items efter pengar i Merchant-mode

### ResourceBar/HealthBar/XPBar
- [x] Utveckla UI-element för resurser, hälsa och XP.
- [x] Lägg till Xp-bar under mappen

### Fler GameLevels
- [x] Utveckla nivå 2, nivå 3 osv. m d unika funktioner, som kortare distanser och nya områden (t.ex. dörrar, trappor).
- [ ] Lägg till t.ex. vatten med en ö man behöver hoppa till, LÅTA BLI?
- [ ] Balancera fienden på de olika banorna, ordning, styrka osv.

### Random Enemy Movement
- [ ] Implementera random rörelse för fiender på kartan.
- [x] Göra vissa fiender osynliga på kartan (t.ex. assassins).
- [ ] Definiera en specifik aggro-range för olika enemy-klasser.               

### Fler Player-funktioner
- [ ] Implementera ytterligare funktioner för Player, som att hoppa över fiender. LÅTA BLI?

### Meny
- [x] Skapa en första bild när man startar spelet
- [x] Skapa en meny med alternativ för att spela, ladda, spara och avsluta.
- [ ] Använda JSON för att hantera spara/ladda.
- [x] Designa en rolig bild eller ikon för menyn.

### Story
- [ ] Utveckla en grundläggande berättelse för spelet. LÅTA BLI?

### Generera RandomMaps
- [ ] Implementera en funktion för att generera slumpmässiga kartor. 

---

## EVENTUELLT

### Multiplayer
- [ ] Utforska möjligheten för multiplayer-läge.

### Implementering i Monogame / Unity
- [ ] Utvärdera möjligheten att implementera spelet i MonoGame eller liknande ramverk.
