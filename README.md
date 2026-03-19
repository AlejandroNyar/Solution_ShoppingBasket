# Basket Solution

## Overview
This project implements a simple "heaviest-first" strategy for selecting items to place in a shopping basket with a maximum weight limit.

Given a list of items with associated weights, the algorithm sorts the items by weight (descending) and adds them to the basket until the maximum allowed weight is reached.

---

## Technologies
- .NET
- C#
- xUnit (for testing)

---

## Project Structure
- `BasketApp` → Contains the core logic
- `BasketApp.Tests` → Contains unit tests

---

## How It Works
1. Items are sorted by weight in descending order.
2. The algorithm iterates through the sorted list.
3. Each item is added to the basket only if the total weight does not exceed the limit (20 kg).

---

## Example
Given the following items:

- Item A: 10 kg  
- Item B: 8 kg  
- Item C: 5 kg  

Maximum weight: 20 kg

Result:
- Item A (10 kg)
- Item B (8 kg)

Total: 18 kg

---

## Design Decisions

- The data is passed directly to the service instead of being retrieved from a database.
- This keeps the focus on the selection algorithm as required by the assignment.
- The solution prioritizes readability and maintainability over complexity.

---

## How to Run

### Run the tests
```bash
dotnet test