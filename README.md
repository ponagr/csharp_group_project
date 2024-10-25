# Spelutvecklingsplan

## Prioriterade Funktioner

### GameHandler (main)
- [ ] Tydligt flöde för spelhantering.

### GameLevel
- [x] Skapa Player- och en Enemy-karaktär.
- [x] Utveckla nivå 1 och implementera movement-metod.
- [x] Enklare interaktion mellan karaktärer (Player och Enemy).
- [ ] SetCururposition på mappen

### GameObject - Enemy - Player
- [ ] Lägg till viktiga egenskaper och metoder för Player och Enemy.

### Combat
- [ ] Skapa visuella representationer, t.ex. streckgubbar, för Player och Enemy under combat.
- [x] Formatera all text och gubbar så att det visas på ett snyggt sätt
- [x] Skapa en grundläggande struktur för combat-systemet.

### Skapa Arv för Olika Typer av Enemy
- [ ] Implementera specifika metoder och unika egenskaper för olika Enemy-typer.
- [ ] Göra en boss / level med specifika egenskaper utifrån enemyklasser
  
### Lägg till XP och Levels
- [x] Implementera XP-system och nivåer för Player.
- [x] Lägg till XP-drop hos Enemy.

### Fler Stats och Multipliers
- [ ] Utveckla fler stats och multipliers för både Player och Enemy.

---

## Ej Prioriterade Funktioner

### Items, Coins och Inventory
- [ ] Implementera en random drop-rate från dödade fiender och loot-system för kistor.

### Chests
- [ ] Få kistor att byta färg när de har öppnats (använda bool och koordinatjämförelse).

### ResourceBar/HealthBar/XPBar
- [ ] Utveckla UI-element för resurser, hälsa och XP.

### Fler GameLevels
- [ ] Utveckla nivå 2, nivå 3 osv. med unika funktioner, som kortare distanser och nya områden (t.ex. dörrar, trappor).

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

### Implementering i MonoGame
- [ ] Utvärdera möjligheten att implementera spelet i MonoGame eller liknande ramverk.
