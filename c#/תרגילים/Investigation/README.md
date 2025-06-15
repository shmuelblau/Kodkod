
# 🕵️‍♂️ Investigation System

This is a C# simulation system for managing different agent types using sensors, inheritance, and design patterns such as Factory. The system uses interfaces to define behaviors and extends them via rank-specific classes and sensors.

---

## 🧩 Interfaces

### `IAgent`
**Methods:**
- `void Investigate()`
- `void CounterAttack()`

---

### `ISensor`
**Methods:**
- `void Activate()`

---

### `IBaseCounterattack`
**Methods:**
- `void Counter()`

---

## 🧱 Classes

### `Agent` : `IAgent`
**Description:**  
Base class for all agent types.

**Properties:**
- `List<ISensor> Sensors`

**Methods:**
- `virtual void Investigate()`
- `virtual void CounterAttack()`

---

### `Rank2Agent` : `Agent`
**Overrides:**
- `Investigate()`
- `CounterAttack()`

---

### `Rank4Agent` : `Agent`, `IBaseCounterattack`
**Overrides:**
- `Investigate()`
- `CounterAttack()`
- `Counter()` (via `IBaseCounterattack`)

---

### `Rank6Agent` : `Agent`, `IBaseCounterattack`
**Overrides:**
- `Investigate()`
- `CounterAttack()`
- `Counter()` (via `IBaseCounterattack`)

---

### `Rank8Agent` : `Agent`, `IBaseCounterattack`
**Overrides:**
- `Investigate()`
- `CounterAttack()`
- `Counter()` (via `IBaseCounterattack`)

---

### `AudioSensor` : `ISensor`
**Methods:**
- `void Activate()`

---

### `PulseSensor` : `ISensor`
**Methods:**
- `void Activate()`

---

## 🏭 Factory Pattern

### `Factory`
**Method:**
- `public static Agent Create(string name)`

Uses `Activator.CreateInstance` to instantiate agents by name using type mapping from `Typs`.

---

### `Typs`
**Field:**
- `public static Dictionary<string, Type> Types`

Maps strings like `"Rank2"` to class types like `typeof(Rank2Agent)`.

---

## 🧰 Helpers

### `Menu`
Likely responsible for CLI interaction or running demo/testing scenarios.

---

## ▶️ Running the Application

1. Open the project in Visual Studio.
2. Build the project.
3. Run `Program.cs` which likely invokes `Menu.Run()` or similar.

---

## 🧠 Summary

This project demonstrates use of:
- Interfaces for modular design
- Inheritance for agent specialization
- Factory pattern for dynamic instantiation
- Sensor and counterattack components for behavior extension
