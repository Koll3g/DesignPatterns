# State

## Problem

Die Hauptidee ist, dass es zu jedem Zeitpunkt eine endliche Anzahl von Zuständen gibt, in denen sich ein Programm befinden kann. Innerhalb jedes einzigartigen Zustands verhält sich das Programm anders, und das Programm kann sofort von einem Zustand in einen anderen umgeschaltet werden.

Zustandsmaschinen werden normalerweise mit vielen bedingten Operatoren (if oder switch) implementiert, die das geeignete Verhalten in Abhängigkeit vom aktuellen Zustand des Objekts auswählen.

Code wie dieser ist sehr schwierig zu warten, da jede Änderung an der Übergangslogik eine Änderung der Zustandsbedingungen in jeder Methode erfordern kann.

![Bild Problem](https://refactoring.guru/images/patterns/diagrams/state/problem2-en.png)

## Lösung

Das State-Pattern schlägt vor, dass Sie neue Klassen für alle möglichen Zustände eines Objekts erstellen und alle zustandsspezifischen Verhaltensweisen in diese Klassen extrahieren.

Diese Struktur mag dem Strategy-Pattern ähneln, aber es gibt einen wesentlichen Unterschied. Im State-Pattern können sich die einzelnen Zustände gegenseitig bewusst sein und Übergänge von einem Zustand zum anderen einleiten, während Strategien fast nie voneinander wissen.

![Bild Lösung](https://refactoring.guru/images/patterns/diagrams/state/solution-en.png)

## UML Diagramm

![Bild UML Diagramm](https://refactoring.guru/images/patterns/diagrams/state/structure-en.png)

## Vorteile

* Grundsatz der Einzelverantwortung. Der Code, welcher sich auf bestimmt Zustände bezieht wird in separaten Klassen organisiert.

* Open/Closed-Prinzip. Neue Zustände können erstellt werden, ohne bestehende Zustandsklassen oder den Kontext zu ändern.

* Code des Kontektes wird vereinfacht, indem Sie sperrige Zustandsmaschinenbedingungen eliminiert werden.

## Nachteile

* Das Anwenden des Musters kann übertrieben sein, wenn eine Zustandsmaschine nur wenige Zustände hat oder sich selten ändert.
