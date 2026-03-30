# 🧠 Ollama Query Dashboard

A production-ready **Angular 16** dashboard application that lets users type natural language questions and receive SQL query results visualized as interactive charts and data tables — powered by an **Ollama / Llama 3** backend API.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Tech Stack](#tech-stack)
- [Project Architecture](#project-architecture)
- [Features](#features)
- [Folder Structure](#folder-structure)
- [Getting Started](#getting-started)
- [Backend API](#backend-api)
- [Key Components](#key-components)
- [Services & Interceptors](#services--interceptors)
- [Routing](#routing)
- [Styling & Design System](#styling--design-system)
- [Scripts](#scripts)

---

## Overview

This project is an **Angular 16 single-page application (SPA)** that acts as a front-end interface for an AI-powered SQL query engine. Users type natural language queries (e.g., _"Show me all permits created in 2024"_), which are sent to a .NET backend. The backend uses **Ollama with the Llama 3 model** to convert the text into a validated SQL query and return the results. The Angular app then renders those results in a responsive **bar/pie/line chart** (via Chart.js) and a **paginated, sortable data table** (via Angular Material).

---

## Tech Stack

### Frontend
| Technology | Version | Purpose |
|---|---|---|
| **Angular** | 16.x | Core SPA framework |
| **TypeScript** | ~5.1.3 | Type-safe development |
| **Angular Material (CDK)** | ^16.2.14 | UI component library (Sidenav, Table, Cards, Snackbar, etc.) |
| **Bootstrap** | ^5.3.8 | Supplemental grid and utility CSS |
| **Chart.js** | ^4.4.1 | Canvas-based data visualization engine |
| **ng2-charts** | ^5.0.4 | Angular wrapper (directives) for Chart.js |
| **RxJS** | ~7.8.0 | Reactive programming, Observables, BehaviorSubject |
| **SCSS** | — | Component and global styling |
| **Google Fonts — Inter** | — | Primary UI typeface |

### Dev Tools
| Tool | Purpose |
|---|---|
| **Angular CLI** | ^16.2.16 | Project scaffolding and build tooling |
| **Karma + Jasmine** | Unit testing framework and test runner |
| **karma-chrome-launcher** | Headless Chrome for test execution |
| **karma-coverage** | Code coverage reports |
| **@angular-devkit/build-angular** | Webpack-based build system |

### Backend (External API)
| Technology | Purpose |
|---|---|
| **ASP.NET Core Web API** | REST API host |
| **Ollama / Llama 3 LLM** | Natural language → SQL conversion |
| **SQL Server + Entity Framework Core** | Dynamic query execution |

---

## Project Architecture

This project follows **Clean / Modular Architecture** using Angular's recommended LIFT pattern (Locate, Identify, Flat, Try DRY):

```
src/
├── app/
│   ├── core/              ← Singleton services, HTTP interceptors, data models
│   ├── features/
│   │   └── dashboard/     ← Lazy-loaded feature module
│   │       ├── components/ ← Smart / Presentational sub-components
│   │       └── pages/      ← Routed page components
│   ├── shared/            ← Shared Angular Material re-exports
│   └── layout/            ← App shell: sidenav + toolbar
├── styles.scss            ← Global design tokens & animations
└── index.html
```

### Module Architecture

```
AppModule (root)
 ├── AppRoutingModule      ← Root routes with lazy loading
 ├── CoreModule            ← HTTP_INTERCEPTORS, singleton providers
 ├── SharedModule          ← Common Material module re-exports
 └── LayoutComponent       ← Shell (MatSidenav, MatToolbar)
      └── [Lazy] DashboardModule
           ├── DashboardPageComponent  ← Orchestrates data flow
           ├── SearchChatComponent     ← Chat-style input + history
           ├── ResultsChartComponent   ← Dynamic Chart.js bar/pie/line chart
           └── ResultsTableComponent   ← Material paginated + sortable table
```

---

## Features

- 🔍 **Natural Language Query Input** — Chat-style input with keyboard (`Enter`) submission
- 📜 **Query History** — Last 10 queries stored in `localStorage`, clickable to re-run
- 📊 **Dynamic Data Visualization** — Auto-detects numeric vs string columns to build a meaningful bar, pie, or line chart
- 📋 **Sortable & Paginated Data Table** — Angular Material table with `MatPaginator` and `MatSort`
- ⚡ **Reactive Data Flow** — Uses RxJS `Subject + switchMap` to cancel in-flight requests
- 🔄 **Global Loading Indicator** — `LoadingService` tracks concurrent HTTP requests
- 🚨 **Global Error Notifications** — API errors surfaced via `MatSnackBar` toast
- 🧩 **HTTP Interceptor** — Centrally manages loading state and error handling for all API calls
- 📱 **Responsive Layout** — Collapsible `MatSidenav` shell with toggle button
- 🎨 **Premium Design System** — CSS custom properties, Inter font, smooth animations

---

## Folder Structure

```
ollama-app/
├── src/
│   ├── app/
│   │   ├── app.component.{ts,html,scss}
│   │   ├── app.module.ts
│   │   ├── app-routing.module.ts
│   │   │
│   │   ├── core/
│   │   │   ├── core.module.ts
│   │   │   ├── interceptors/
│   │   │   │   └── api.interceptor.ts         ← Global HTTP interceptor
│   │   │   ├── models/
│   │   │   │   └── query.model.ts             ← TypeScript interfaces
│   │   │   └── services/
│   │   │       ├── loading.service.ts         ← BehaviorSubject-based loading state
│   │   │       ├── error-handler.service.ts   ← MatSnackBar error toasts
│   │   │       └── query/
│   │   │           └── query.service.ts       ← HTTP POST + history management
│   │   │
│   │   ├── features/
│   │   │   └── dashboard/
│   │   │       ├── dashboard.module.ts
│   │   │       ├── dashboard-routing.module.ts
│   │   │       ├── components/
│   │   │       │   ├── search-chat/           ← Search input + history UI
│   │   │       │   ├── results-chart/         ← Chart.js bar/pie/line chart
│   │   │       │   └── results-table/         ← Material table with paginator & sort
│   │   │       └── pages/
│   │   │           └── dashboard-page/        ← Main routed page (data orchestration)
│   │   │
│   │   ├── layout/
│   │   │   └── layout.component.*             ← App shell with MatSidenav
│   │   │
│   │   └── shared/
│   │       └── shared.module.ts               ← Re-exports Angular Material modules
│   │
│   ├── assets/
│   ├── styles.scss                            ← Global CSS tokens & animations
│   └── index.html
│
├── angular.json
├── package.json
├── tsconfig.json
└── README.md
```

---

## Getting Started

### Prerequisites

- **Node.js** ≥ 18.x
- **npm** ≥ 9.x
- **Angular CLI** 16.x (`npm install -g @angular/cli@16`)
- The backend API running at `https://localhost:7113`

### Installation

```bash
# Clone the repository
git clone <repo-url>
cd ollama-app

# Install dependencies
npm install
```

### Running the App

```bash
# Start the development server
npm start
# or
ng serve
```

The app will be available at **http://localhost:4200**.

> ⚠️ The backend API must be running at `https://localhost:7113` for queries to work. See [Backend API](#backend-api) section.

### Running Tests

```bash
npm test
```

---

## Backend API

The Angular frontend communicates with an **ASP.NET Core Web API** at:

```
POST https://localhost:7113/api/query
```

### Request Payload
```json
{
  "query": "Show all permits created in 2024"
}
```

### Response Payload
```json
{
  "sqlQuery": "SELECT * FROM Permits WHERE YEAR(CreatedOn) = 2024",
  "data": [
    {
      "PermitNumber": "P-001",
      "ProjectTitle": "Office Renovation",
      "AuthorizationStatus": "Approved",
      "NoOfFloors": 3,
      "CreatedOn": "2024-01-15T00:00:00"
    }
  ]
}
```

### Displayed Data Fields

The app filters and displays only the following fields from the API response to keep the UI clean:

| Field | Type | Description |
|---|---|---|
| `PermitNumber` | string | Unique permit identifier |
| `ProjectTitle` | string | Name/title of the project |
| `AuthorizationStatus` | string | Approval status |
| `NoOfFloors` | number | Number of floors |
| `ApplicationNumber` | string | Application reference |
| `PolicyNumber` | string | Policy reference |
| `CreatedOn` | date string | Record creation date |

---

## Key Components

### `DashboardPageComponent`
The **smart/container component** that orchestrates all data flow using `RxJS`:
- Uses a `Subject<string>` + `switchMap` to cancel in-flight API calls when a new query is submitted.
- Exposes `results$`, `history$`, and `isLoading$` as Observables consumed via the `async` pipe in the template.

### `SearchChatComponent`
A **presentational component** for the query input:
- `ReactiveFormsModule` with `FormControl` (required, minLength: 2 validation)
- Emits `searchSubmitted` event to parent on form submit or `Enter` keypress
- Shows clickable query history items

### `ResultsChartComponent`
Dynamic chart using **Chart.js via ng2-charts**:
- Auto-detects string columns (for X-axis labels) and numeric columns (for datasets)
- Supports **Bar**, **Line**, **Pie**, and **Doughnut** chart types (toggle button)
- Falls back to grouped count chart if no numeric columns are found
- Uses `OnChanges` + `BaseChartDirective.update()` for efficient re-renders

### `ResultsTableComponent`
Paginated, sortable table using **Angular Material**:
- `MatTableDataSource` for client-side filtering, sorting, and pagination
- `MatSort` and `MatPaginator` integrated via `@ViewChild`
- Formats dates to `en-IN` locale and booleans to Yes/No
- Renders PascalCase column keys as human-readable headers

---

## Services & Interceptors

### `QueryService`
- Sends `POST` requests to `/api/query` using `HttpClient`
- Manages a **query history** of the last 10 unique queries
- Persists history to `localStorage` under the key `query_history`
- Exposes `history$` as a `BehaviorSubject`-backed Observable

### `LoadingService`
- Tracks multiple concurrent HTTP requests with a counter
- Exposes `isLoading$` Observable (true only when ≥1 request is pending)

### `ErrorHandlerService`
- Displays error messages via `MatSnackBar` (top-center, 5-second duration)
- Uses the `error-snackbar` CSS class for custom error styling

### `ApiInterceptor` (HTTP Interceptor)
- Automatically calls `LoadingService.show()` on every outgoing request
- Calls `LoadingService.hide()` in `finalize()` — fires on both success and error
- Catches `HttpErrorResponse` and routes it through `ErrorHandlerService`

---

## Routing

| Path | Module | Component | Notes |
|---|---|---|---|
| `/` | AppRoutingModule | `LayoutComponent` | Shell with sidenav |
| `/dashboard` | DashboardModule (lazy) | `DashboardPageComponent` | Main feature page |
| `**` | — | — | Redirects to `/dashboard` |

The `DashboardModule` is **lazy-loaded** via dynamic `import()`, improving initial bundle size.

---

## Styling & Design System

The app uses a **CSS custom property (variable) design system** defined in `src/styles.scss`:

| Token | Value | Usage |
|---|---|---|
| `--primary-color` | `#4f46e5` (Indigo) | Buttons, toolbar, accents |
| `--accent-color` | `#0ea5e9` (Cyan) | Gradient endpoint, highlights |
| `--bg-color` | `#f8fafc` (Slate 50) | Page background |
| `--surface-color` | `#ffffff` | Cards and panels |
| `--text-primary` | `#0f172a` (Slate 900) | Main body text |
| `--text-secondary` | `#64748b` (Slate 500) | Subtitles, hints |
| `--border-color` | `#f1f5f9` | Subtle dividers |
| `--transition-fast` | `200ms ease-in-out` | Hover micro-animations |
| `--transition-normal` | `300ms ease-in-out` | Component transitions |

**Font:** [Inter](https://fonts.google.com/specimen/Inter) (Google Fonts) — weights 300, 400, 500, 600, 700

**Animations:** `fadeInUp` and `fadeIn` keyframes for smooth content entrance

---

## Scripts

| Command | Description |
|---|---|
| `npm start` | Start dev server at http://localhost:4200 |
| `npm run build` | Production build to `dist/` |
| `npm run watch` | Build in watch mode (development config) |
| `npm test` | Run unit tests via Karma + Jasmine |
| `ng generate component <name>` | Scaffold a new Angular component |

---

## Dependencies Summary

```json
{
  "dependencies": {
    "@angular/*":          "^16.2.x",   // Core Angular framework
    "@angular/material":   "^16.2.14",  // Material UI components
    "@angular/cdk":        "^16.2.14",  // Component Dev Kit
    "bootstrap":           "^5.3.8",    // Utility CSS
    "chart.js":            "^4.4.1",    // Chart rendering engine
    "ng2-charts":          "^5.0.4",    // Angular + Chart.js integration
    "rxjs":                "~7.8.0",    // Reactive Extensions
    "zone.js":             "~0.13.0"    // Angular change detection
  }
}
```

---

> Built with ❤️ using Angular 16, Angular Material, Chart.js, and Ollama (Llama 3)
