# PlayerManagerMVC

## UML Class Diagram

```mermaid
classDiagram
    Player "0..*" --o "1" Controller
    Player ..|> IComparable
    Controller "1" --> "*" IComparer
    CompareByName "1" ..> "*" Player
    CompareByName ..|> IComparer
    Program "1" --> "1" Controller
    View ..|> IView
    Controller ..> PlayerOrder
    Controller "1" --> "1" View

    <<interface>> IView
    <<interface>> IComparer
    <<interface>> IComparable
    <<enumeration>> PlayerOrder
