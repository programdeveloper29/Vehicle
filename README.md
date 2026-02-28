# 🚗 Vehicle Management Console App

## 📌 Description
This is a simple C# console application that demonstrates core **Object-Oriented Programming (OOP)** concepts.

The application allows the user to select a vehicle type and calculate:

- Fuel Range (Capacity × KiloPerLitre)
- Speed (with validation)
- Custom properties (e.g., Goods Type for Lorry)

---

## 🧠 OOP Concepts Applied

- ✅ Inheritance (Base class: Vehicles)
- ✅ Encapsulation (Private fields + Properties)
- ✅ Method Overloading
- ✅ Virtual & Override (Polymorphism concept)
- ✅ Input Validation using TryParse
- ✅ Ternary Operator for value control

---

## 🏗️ Project Structure

### 🔹 Base Class
`Vehicles`
- Capacity
- KiloPerLitre
- Speed (virtual)
- Range() method

### 🔹 Derived Classes
- `Car`
- `Train` (Overrides Speed)
- `Lorry` (Adds GoodsType property)

---

## ⚙️ How It Works

1. User selects vehicle type (car, train, lorry)
2. User enters:
   - Fuel Capacity
   - Kilometers per Litre
   - Speed
3. The program calculates and displays:
   - Vehicle Range
   - Vehicle Speed
4. Lorry allows entering Goods Type

---

## 🧮 Example Output

```
Enter the Vehicle type (car, train, lorry): car

--- Car ---
Enter Capacity: 50
Enter KiloPerLitre: 15
Enter Speed (0-300): 120

Car Range = 750
Car Speed = 120
```

---

## 🎯 Speed Validation

Speed is limited between 0 and 300 using a ternary operator:

```csharp
_speed = (value >= 0 && value <= 300) ? value : 0;
```

---

## 📚 What I Learned

- How to use Inheritance properly
- How to apply Method Overloading
- How virtual and override work
- How to reduce code duplication using shared methods
- How to validate user input safely

---

## 🚀 Future Improvements

- Add abstract base class
- Apply full polymorphism without overload
- Add exception handling (try-catch)
- Implement maximum speed per vehicle type
- Add vehicle size or fuel type

---

## 👩‍💻 Author

Developed as part of learning C# OOP concepts.
