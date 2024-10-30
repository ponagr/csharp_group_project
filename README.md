# Spelutvecklingsplan

## Prioriterade Funktioner

### GameHandler (main)
- [ ] Tydligt flöde för spelhantering.

### GameLevel
- [x] Skapa Player- och en Enemy-karaktär.
- [x] Utveckla nivå 1 och implementera movement-metod.
- [x] Enklare interaktion mellan karaktärer (Player och Enemy).
- [ ] SetCururposition på mappen FÖR ATT SLIPPA GLITCH
- [x] Hjärta för att få liv på banan

### GameObject - Enemy - Player
- [ ] Lägg till viktiga egenskaper och metoder för Player och Enemy.

### Combat
- [x] Skapa visuella representationer, t.ex. streckgubbar, för Player och Enemy under combat.
- [x] Formatera all text och gubbar så att det visas på ett snyggt sätt
- [x] Skapa en grundläggande struktur för combat-systemet.

### Skapa Arv för Olika Typer av Enemy
- [ ] Implementera specifika metoder och unika egenskaper för olika Enemy-typer.
- [ ] Göra en boss / level med specifika egenskaper utifrån enemyklasser
  
### Lägg till XP och Levels
- [x] Implementera XP-system och nivåer för Player.
- [x] Lägg till XP-drop hos Enemy.

### Fler Stats och Multipliers
- [x] Utveckla fler stats och multipliers för Player.
- [ ] Utveckla fler stats och multipliers för Enemy.

---

## Ej Prioriterade Funktioner

### Items, Coins och Inventory
- [ ] Skapa item-klass och olika items att lägga i flera listor och slumpa ifrån
- [ ] Implementera en random drop-rate från dödade fiender och loot-system för kistor.
- [ ] Skapa en inventory (array med typ 5 items) i player-klassen
- [ ] Begränsningar beroende på itemtyp - hjälm, plate osv.
- [ ] Lägg till en Merchant som man kan sälja/köpa ifrån - en char-ikon i stället för klass.
- [ ] Potions
- [ ] T.ex nycklar i kistor för att kunna öppna gates på banan för att komma vidare 

### Chests
- [ ] Få kistor att byta färg när de har öppnats (använda bool och koordinatjämförelse).

### ResourceBar/HealthBar/XPBar
- [ ] Utveckla UI-element för resurser, hälsa och XP.
- [ ] Lägg till Xp-bar under mappen

### Fler GameLevels
- [ ] Utveckla nivå 2, nivå 3 osv. m d unika funktioner, som kortare distanser och nya områden (t.ex. dörrar, trappor).
- [ ] Lägg till t.ex. vatten med en ö man behöver hoppa till

### Random Enemy Movement
- [ ] Implementera random rörelse för fiender på kartan.
- [ ] Göra vissa fiender osynliga på kartan (t.ex. assassins).
- [ ] Definiera en specifik aggro-range för olika enemy-klasser.               

### Fler Player-funktioner
- [ ] Implementera ytterligare funktioner för Player, som att hoppa över fiender.

### Meny
- [ ] Skapa en meny med alternativ för att spela, ladda, spara och avsluta.
- [ ] Använda JSON för att hantera spara/ladda.
- [ ] Designa en rolig bild eller ikon för menyn.

### Story
- [ ] Utveckla en grundläggande berättelse för spelet.

### Generera RandomMaps
- [ ] Implementera en funktion för att generera slumpmässiga kartor.

---

## EVENTUELLT

### Multiplayer
- [ ] Utforska möjligheten för multiplayer-läge.

### Implementering i Monogame / Unity
- [ ] Utvärdera möjligheten att implementera spelet i MonoGame eller liknande ramverk.
