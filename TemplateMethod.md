# Template Method
## Problem
Unter Umständen kann es vorkommen, dass teile eines Algorithmus Variabel gestaltet werden müssen.
## Lösung
Damit hierfür nicht alle konstanten Teile des Algorithmus redundant erstellt werden müssen wurde das Template Method Pattern entwickelt. Hierbei wird in der Basisklasse des Algorithmus eine templateMethod erstellt, diese wiederum ruft aus einer Subklasse, die der Situation geschuldete Methode auf.
Dieses Konzept lässt sich auch auf ganze Klassen ausweiten.
## UML Diagramm
![Bild UML Diagramm](https://www.dofactory.com/img/diagrams/net/template.png)
## Vorteil/Nachteil
### Pro	
Verminderung von Redundanz	
Leicht erweiterbar	
Zentral verwaltet	
	
### Contra
Unübersichtlich bei extremer Variabilität