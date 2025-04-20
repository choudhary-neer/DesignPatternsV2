# 🏗️ Combining Factory and Strategy Patterns in C#

# 💳 Factory + Strategy Pattern in C#

This repository demonstrates how to combine the **Factory** and **Strategy** design patterns using **C#** and **Dependency Injection** — applied to a real-world scenario: a **Payment Gateway** system.

## 📌 Why This Matters

During real-world development, two of the most common design challenges are:

- Avoiding messy `switch` or `if-else` logic based on types.
- Writing code that is scalable, testable, and follows SOLID principles.

This example shows how combining **Strategy Pattern** (for behavior) with **Factory Pattern** (for instantiation) can solve both — cleanly.


## Why Use Both?

**Factory** and **Strategy** can (and often should) go hand in hand.  
However, they solve different problems, and when combined, they can lead to **flexible**, **maintainable**, and **extensible** codebases.

Using the **Strategy pattern** is one of the best ways to avoid long `switch` or `if-else` statements based on types or behavior.

---

## 📊 Factory vs Strategy Recap

| Pattern   | Responsibility                      | When to Use                                      |
|-----------|--------------------------------------|--------------------------------------------------|
| **Factory**  | Encapsulates object creation logic  | When you need to abstract how objects are created |
| **Strategy** | Encapsulates behavior/algorithm     | When you need to switch behaviors dynamically     |

---

## 🧩 When to Combine Them

Here’s a good practice scenario:

- ✅ **Use Strategy** to encapsulate behaviors like payment methods, notification sending, etc.
- ✅ **Use a Factory** (or **DI container**) to create or select the right strategy at runtime.

---

## 💳 Real-World Example: Payment Gateway

Imagine you're building an **e-commerce checkout**.

- You have multiple payment strategies: `CreditCard`, `PayPal`, `ApplePay`, etc.
- The system receives a payment request with a `paymentType` string.

### ✅ Here's how you combine the two:

- **Strategies**: Each payment type has a class that implements `IPaymentStrategy`.
- **Factory**: A `PaymentStrategyFactory` selects the correct strategy based on input (could be a dictionary or injected strategies).
- **DI Container**: Registers all strategies automatically.

---

## 🔍 This Combo:

- 🧩 **Keeps creation logic isolated** (Factory or DI)
- 🧠 **Keeps behavior encapsulated and swappable** (Strategy)
- 🧱 **Follows Open/Closed Principle** — easy to extend with new payment types

---

## 🧠 Best Practices Summary

- ✅ Use **Strategy** to encapsulate variations in logic.
- ✅ Use **Factory or DI** to manage the complexity of selecting or instantiating the right strategy.

Together, they help build:

- 🔁 Flexible
- 🧪 Testable
- 🧱 Extensible systems

---

## 🛠 Tech Used

- **Strategy Pattern** → Each payment method.
- **Factory (via DI)** → To resolve the correct strategy.
- ✅ Clean, extensible, testable design.

---

## ✅ Benefits of This Approach

- 🔄 **Easily extensible**: Add new payment types by just creating a new strategy class.
- 🤖 **No switch-case**: Clean selection using DI + Dictionary.
- ✅ **Follows SOLID**: Especially Open/Closed and Single Responsibility.
- 🧪 **Testable**: Each strategy and service can be unit tested independently.

