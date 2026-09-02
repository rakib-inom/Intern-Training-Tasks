## Week 1 — Git Basics + C# Fundamentals: Detailed Task

### Overview

Build a simple **Library Management Console App** in C#, while separately practicing a real Git branching and PR workflow. This task covers all the listed sub-topics: Git workflow, PR workflow, value vs reference types, OOP, encapsulation, and access modifiers.

---

### Part A: Git Workflow

1. Clone the shared team repository.
2. Create your own feature branch to work on.
3. Commit your work in small, meaningful steps as you complete each piece of the console app (not one giant commit at the end) — for example, one commit for the interface, one for the classes, one for encapsulation, one for the value-vs-reference demo.
4. Push your branch regularly so your progress is backed up and visible to the team.
5. Once your app is working, open a Pull Request into the main branch. Get at least one review comment from a peer or mentor, address it, and then merge.

---

### Part B: Console App — Library Management System

**Step 0: Create the Project in Visual Studio**

1. Open Visual Studio.
2. Click **Create a new project**.
3. Select **Console App** (make sure it's the C# version, not VB or F#).
4. Give the project a name (e.g., `LibraryConsoleApp`) and choose a save location — ideally inside your cloned Git repo folder.
5. Choose the target .NET version (use whatever version your team standardizes on, e.g., .NET 8).
6. Click **Create**. Visual Studio will generate a basic `Program.cs` file with a starting point.
7. Run the default template once (press **F5** or click **Start**) to confirm the project builds and runs correctly before adding any code.

**1. Interface & Abstraction**

- Create an `ILibraryItem` interface with members like `Title`, `IsAvailable`, `CheckOut()`, and `Return()`.
- Create an abstract base class `LibraryItemBase` that implements the shared logic from this interface.

**2. OOP — Inheritance & Polymorphism**

- Derive two classes from `LibraryItemBase`: `Book` (with an extra `Author` property) and `Magazine` (with an extra `IssueNumber` property).
- Give each class its own version of a `Describe()` method.
- Demonstrate polymorphism by creating individual `Book` and `Magazine` instances, assigning each to an `ILibraryItem` variable, and calling `Describe()` on each one — notice each prints differently despite being called through the same interface type.

**3. Encapsulation & Access Modifiers**

- Keep all fields private, and expose them through public properties with basic validation (e.g., `Title` should not allow an empty or null value).
- Include at least one `protected` member in the base class that only derived classes can access, and briefly comment on why.

**4. Value vs Reference Types**

- Add a `struct` called `LibraryBranchInfo` with simple fields like `BranchCode` and `Location`.
- Write a short demo section in your app that shows:
  - Copying the struct into a new variable and changing the copy does **not** affect the original (value type behavior).
  - Copying a `Book` object into a new variable and changing the copy **does** affect the original, since both variables point to the same object (reference type behavior).
- Print the results clearly so the difference is visible when running the app.
