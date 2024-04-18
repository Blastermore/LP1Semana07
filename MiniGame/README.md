```mermaid
---
title: MiniGame
---
classDiagram
    Character "1" --o "*" Weapon
    Weapon <|-- Gun
    Weapon <|-- Sword
    Character <|-- Player
    Character <|-- Enemy
    
    class Weapon
        #power : float