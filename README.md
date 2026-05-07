# SpendSmart

## Overview
SpendSmart is a cross-platform budget and expense tracking application built using Blazor and C#. The application allows users to manage expenses, track their current balance, save transaction history, and reload saved data using JSON files. The project was designed to satisfy the requirements of a GUI-based software engineering course project.

---

# Features
- Add financial transactions
- Delete transactions
- Automatically timestamp transactions with the current date
- Set and manage a current balance
- Automatically subtract expenses from the balance
- Save transaction history to JSON files
- Load saved transaction data when reopening the application
- Support multiple users through separate save files
- Categorize transactions
- Display transaction history in a table
- Cross-platform support through Blazor

---

# Technologies Used
- C#
- Blazor
- .NET 9
- Bootstrap
- xUnit
- System.Text.Json

---

# Data Structures Used

The application uses several data structures beyond arrays and basic lists:

## Dictionary<string, List<Transaction>>
Used to organize transactions by category.

## HashSet<string>
Used to store unique transaction categories.

## PriorityQueue<Transaction, DateTime>
Used to manage upcoming bills and transaction ordering.

---

# File Storage

Transaction data is stored locally as JSON files inside the `Data` folder.
