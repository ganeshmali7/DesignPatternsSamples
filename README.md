````
# Simple Demos: DRY, KISS, OOD & SOLID
````

### 1. DRY (Don't Repeat Yourself)

* **DRY_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/DRY_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/DRY_Violated.cs) 
   *Shows duplicated code to demonstrate why repetition is bad.*
* **DRY_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/DRY_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/DRY_Followed.cs)
  *Shows extracting a helper to remove duplication.*

### 2. KISS (Keep It Simple, Stupid)

* **KISS_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/KISS_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/KISS_Violated.cs)
  *Over-engineered approach — harder to read.*
* **KISS_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/KISS_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/KISSAndDRY/KISS_Followed.cs)
  *Simple, clear solution — easy to understand.*

### 3. OOD (Object-Oriented Design)

* **EncapsulationExample.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/EncapsulationExample.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/EncapsulationExample.cs)
  *Hiding internal state and exposing behavior via methods/properties.*
* **InheritanceExample.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/InheritanceExample.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/InheritanceExample.cs)
  *Shows base/derived classes and reuse.*
* **PolymorphismExample.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/PolymorphismExample.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/OOD/PolymorphismExample.cs)
  *Using a common type to work with different implementations.*

### 4. SOLID Principles (each shown Violated / Followed)

* **SRP_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/SRP_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/SRP_Violated.cs)
  *Single Responsibility violated — class does multiple jobs.*

* **SRP_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/SRP_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/SRP_Followed.cs)
  *SRP followed — responsibilities separated.*

* **OCP_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/OCP_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/OCP_Violated.cs)
  *Open/Closed violated — changing code required for new behavior.*

* **OCP_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/OCP_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/OCP_Followed.cs)
  *OCP followed — extend behavior without modifying existing code.*

* **LSP_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/LSP_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/LSP_Violated.cs)
  *Liskov Substitution violated — derived types break expectations.*

* **LSP_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/LSP_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/LSP_Followed.cs)
  *LSP followed — safe substitution of derived types.*

* **ISP_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/ISP_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/ISP_Violated.cs)
  *Interface Segregation violated — clients forced to implement unused members.*

* **ISP_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/ISP_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/ISP_Followed.cs)
  *ISP followed — small, focused interfaces.*

* **DIP_Violated.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/DIP_Violated.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/DIP_Violated.cs)
  *Dependency Inversion violated — high-level modules depend on concretes.*

* **DIP_Followed.cs** — [https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/DIP_Followed.cs](https://github.com/ganeshmali7/DesignPatternsSamples/blob/main/DesignPatternsSamples/SOLID/DIP_Followed.cs)
  *DIP followed — depend on abstractions, not concrete implementations.*

