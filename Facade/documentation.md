# Facade (Strukturelles Entwurfsmuster)

Die Facade wird hauptsächlich bei zwei Themenbereichen eingesetzt.
- um Legacy Code zu umhüllen
- um komplexer Code einfacher zugänglich zu machen

Die Facade ist grundsätzlich eine Klasse. Diese Facade Klasse ist der einzige Zugang zu dem dahinter liegenden Code. Im nachfolgenden Beispiel, ist "VideoConverter" die Facade Klasse. <br>
[Hier](https://refactoring.guru/design-patterns/facade) findest Du weitere Informationen.

![Struktur](https://refactoring.guru/images/patterns/diagrams/facade/example-2x.png?id=f2c846d74041626c923ff3e8919b68a9)

In meinem Beispiel vereinfach meine "MyFacade" den Umgang mit dem dahinter liegenden Code(den Services). <br>
Eine externe Applikation muss nun nicht einzeln auf die Services zugreifen. Die Facade vereinfach den Zugang. <br>
Der Integrationtest veranschaulicht einen Aufruf der Facade.