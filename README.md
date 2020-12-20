# TaTeTi

Una version simple del TaTeTi, que se puede jugar de a uno o de a dos

# Funcionamiento
Se elige primero cuantos jugadores van a jugar.
Cada jugador se le asignara una forma (O / X) y dara inicio el juego.
Por turnos, cada uno elegira un cuadro libre del tablero, que sera marcado con la forma que tiene asignada.

# Modo 1 Jugador
El jugador se enfrentara a una IA simplificada.

+ Jugador 1 (Humano): O
+ Jugador 2 (IA): X

Luego de cada eleccion del jugador, la IA elegira al azar un cuadro libre del tablero para marcar.
La IA no elegirá cuadros que ya hayan sido elegidos anteriormente.
La desicion de la IA es completamente al azar, siendo posible que no elija un recuadro que pueda hacerle ganar.

# Modo 2 Jugadores
Dos jugadores humanos se enfrentaran.

+ Jugador 1 (Humano): O
+ Jugador 2 (Humano): X

Luego de cada eleccion de un jugador, le tocara el turno al jugador oponente.

# Fin del juego
El juego procederá hasta que se cumpla alguna de las siguientes condiciones

+ Hay 3 cuadros con la misma forma que estan puestos de forma horizontal
+ Hay 3 cuadros con la misma forma que estan puestos de forma vertical
+ Hay 3 cuadros con la misma forma que estan puestos en alguna de las dos diagonales posibles.
+ Ya no hay mas cuadros libres para marcar

Cuando alguna de las condiciones se cumpla, el juego se detendra y mostrara los botones para elegir jugadores para empezar una nueva partida.
