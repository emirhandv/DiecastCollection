# DiecastCollection 🚗📦

A C# console application developed to learn and practice **Layered Architecture** principles. This project is designed to manage a diecast model car collection in an organized manner.

## 🛠️ Technologies & Language
* **Language:** C# [.NET]
* **Architecture:** Layered Architecture
* **IDE:** Visual Studio

## 📂 Project Structure (Layers)

The project is divided into 4 core layers to separate concerns and maintain clean code principles:

1. **Entities:** Contains the core data models and classes representing database objects/entities.
2. **DataAccess:** Manages communication with data sources, implementing CRUD operations and using interfaces (e.g., `IProductDal`) to abstract data access logic.
3. **Business:** Implements the business logic, validation rules, and acts as a bridge between the DataAccess and Presentation layers.
4. **ConsoleUI:** The presentation layer where users interact with the application via the console.

## 🚀 Project Goals
- Understand and apply Layered Architecture concepts.
- Minimize dependencies between classes using Interfaces.
- Build clean, scalable, and maintainable C# code.
