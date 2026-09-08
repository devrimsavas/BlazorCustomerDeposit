# Blazor Server — Customer Deposit Tiles

A small **Blazor Server** application practicing component-based, interactive UI development in .NET — real-time, reactive interfaces built entirely in C#, without hand-written JavaScript.

## 🚀 What this demonstrates

- **Blazor Server with Interactive Server render mode** (`@rendermode InteractiveServer`) — UI updates are pushed over a live SignalR connection, so the page never does a full reload
- **Two-way data binding** (`@bind`) between form inputs and C# component state
- **Event handling** (`@onclick`) wired directly to C# methods — no JavaScript needed for interactivity
- **Client-side validation logic** written in C# (e.g. minimum name length), with inline error messages reactively shown/hidden
- **Reactive list rendering** — the customer table updates immediately when a new entry is added, using Blazor's `@key` directive for efficient diffing

## 🛠 Tech Stack

- .NET 9
- Blazor Server (Razor Components)
- Bootstrap (styling)

## 📂 Project Structure

```
BlazorTiles1/
├── Components/
│   ├── App.razor              — root component
│   ├── Routes.razor            — routing configuration
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   └── Pages/
│       ├── Home.razor
│       ├── Counter.razor        — default Blazor template counter demo
│       ├── Weather.razor         — default Blazor template weather demo
│       └── Tiles.razor            — the custom customer/deposit form (main feature)
├── Models/
│   ├── Customers.cs              — in-memory customer collection + business rules
│   └── Person.cs
└── Program.cs                   — configures Blazor Server + interactive render mode
```

## 🖥️ The Tiles Page (`/tiles`)

The main custom feature: a form for registering a customer name and a deposit amount, rendered into a live-updating table.

- Input is bound directly to component state via `@bind`
- Submitting validates the name (minimum length) entirely in C#, with no client-side JavaScript or server round-trip needed to show the error
- New entries appear in the table instantly — Blazor Server re-renders only the changed DOM nodes over the SignalR connection

## ▶️ Getting Started

```bash
cd BlazorTiles1
dotnet run
```
Navigate to `/tiles` to use the interactive form. `/counter` and `/weather` are the default Blazor project template pages, kept from initial scaffolding.

## 📝 Notes

This is a learning project focused on Blazor Server's core value proposition: building interactive, stateful web UIs in C# alone. It complements other .NET work in the portfolio — a Web API ([DevHouse4](https://github.com/devrimsavas/DevHouse4)), an MVC app, and a React/Next.js frontend ([NOVAMED](https://github.com/devrimsavas/Clinic-Appointment-FullStack)) — by covering a fourth distinct approach to building .NET web applications.
