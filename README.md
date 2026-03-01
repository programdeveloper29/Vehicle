# Vehicle Management System

This is a **C# Console Application** that allows users to manage different types of vehicles, including **Car**, **Train**, and **Lorry**. The program calculates vehicle range, handles vehicle speed, and allows specific properties such as number of passengers for Cars and Trains or goods type for Lorries.

---

## Features

- Supports three vehicle types: **Car**, **Train**, and **Lorry**.
- Calculates **Range** based on capacity and fuel efficiency (`KiloPerLitre`).
- Handles **Speed** of vehicles with validation (0-300 km/h).
- Implements **interface `IPassengers`** for Cars and Trains.
- Custom property `GoodsType` for Lorries.
- Reusable input method for shared vehicle properties.
- User-friendly console interface with repeatable input.

---

## Vehicle Details

### Car
- Can store number of passengers.
- Calculates range: `Capacity * KiloPerLitre`.
- Speed can be set by the user.

### Train
- Can store number of passengers.
- Overrides speed (`Speed + 3` km/h for demonstration).
- Calculates range: `Capacity * KiloPerLitre`.

### Lorry
- Custom property: `GoodsType` (type of goods carried).
- Calculates range: `Capacity * KiloPerLitre`.
- Speed can be set by the user.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/VehicleManagementSystem.git