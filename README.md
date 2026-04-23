# TicketApplicationSystem#  Ticket Application System

> **Module:** Software Design and Testing C# — SDT621 | NQF Level 6
> **Assessment:** Week 2 Friday Project | 24 April 2026
> **Institution:** CTU Training Solutions (PTY) Ltd

---

##  Group Members

| Name | Student Number | Role |
|---|---|---|
| Jandre Van Zyl | 20230660 | Member 1 — Project Manager / GitHub Coordinator |
| Dewald Van Jaarsveldt | | Member 2 — UI Developer |
| Tyler Davel | | Member 3 — Logic Developer |
| Vehan Kuhn | | Member 4 — Tester & Documentation Specialist |

---

##  Project Overview

A **C# Windows Forms Application** that calculates travel ticket prices for passengers. The system collects passenger details, applies business pricing rules and discounts, and displays a full ticket summary.

Built collaboratively by a group of 4 students using **GitHub version control**.

---

##  Features

- Enter passenger name, age, and travel distance
- Select gender — Male or Female
- Select travel category — One, Two, or Three
- Calculate ticket price based on category rate × distance
- Apply discount rules automatically
- Display full ticket summary
- Clear form and exit buttons

---

##  Business / Pricing Rules

### Category Rates

| Category | Rate per km |
|---|---|
| One | R20 |
| Two | R35 |
| Three | R50 |

### Discount Rules

| Rule | Condition | Result |
|---|---|---|
| Child discount | Age < 12 | Ticket is **FREE** |
| Gender discount | Passenger is Female | **50% off** final price |

### Calculation Formula
```
price = category_rate × distance

if age < 12:
    price = 0

if female:
    price = price × 0.5
```

---

##  Project Structure

```
TicketApplicationSystem/              ← GitHub repository root
│
├── README.md                         ← Project documentation
├── .gitignore                        ← Ignores bin, obj, .vs folders
├── Screenshots/                      ← Evidence screenshots (Member 4)
├── Docs/                             ← Test plan and bug report (Member 4)
│
└── TicketApplicationSystem/          ← Visual Studio project folder
    ├── Form1.cs                      ← Button events and UI logic
    ├── Form1.Designer.cs             ← Auto-generated form layout
    ├── Form1.resx                    ← Form resources
    ├── TicketCalculator.cs           ← Pricing and discount logic
    ├── Program.cs                    ← Application entry point
    └── TicketApplicationSystem.csproj
```

---

##  Naming Conventions

### Controls
| Control | Prefix | Example |
|---|---|---|
| TextBox | `txt` | `txtName`, `txtAge`, `txtDistance` |
| RadioButton | `rdb` | `rdbMale`, `rdbFemale` |
| ComboBox | `cmb` | `cmbCategory` |
| Button | `btn` | `btnCalculate`, `btnClear`, `btnExit` |
| Label | `lbl` | `lblName`, `lblGender` |
| GroupBox | `grp` | `grpGender` |

### Code
| Type | Convention | Example |
|---|---|---|
| Variables | camelCase | `ticketPrice`, `passengerName` |
| Methods | PascalCase | `CalculatePrice()`, `ValidateInputs()` |
| Constants | UPPER_CASE | `RATE_CATEGORY_ONE` |
| Classes | PascalCase | `TicketCalculator` |

---

##  Branch Structure

| Branch | Owner | Purpose |
|---|---|---|
| `main` | Member 1 | Final merged production code |
| `Dev-project-management-Jandre_Van_Zyl` | Member 1 | Repo setup, README, coordination |
| `Dev-ui-design-Dewald_Van_Jaarsveldt` | Member 2 | Form layout and controls |
| `Dev-logic-module-Tyler_Davel` | Member 3 | Pricing, validation, button logic |
| `Dev-testing-docs-Vehan_Kuhn` | Member 4 | Testing, screenshots, documentation |

---

##  How to Run

**Requirements:** Visual Studio 2019/2022 | .NET Framework 4.7.2+

```bash
# 1. Clone the repository
git clone https://github.com/20230660/TicketApplicationSystem.git

# 2. Open in Visual Studio
# Open TicketApplicationSystem.sln

# 3. Run the application
# Press F5 or click Start
```

---

##  Test Results

| # | Test Case | Input | Expected | Pass/Fail |
|---|---|---|---|---|
| 1 | Adult Male, Cat One | Age: 25, Male, Cat 1, 30km | R600 | |
| 2 | Adult Female, Cat Two | Age: 30, Female, Cat 2, 20km | R350 | |
| 3 | Adult Female, Cat Three | Age: 22, Female, Cat 3, 40km | R1000 | |
| 4 | Child under 12 | Age: 8, Male, Cat 1, 50km | R0 (FREE) | |
| 5 | Child Female under 12 | Age: 6, Female, Cat 2, 30km | R0 (FREE) | |
| 6 | Empty name field | Name: (blank) | Validation error | |
| 7 | Non-numeric age | Age: "abc" | Validation error | |
| 8 | Non-numeric distance | Distance: "xyz" | Validation error | |
| 9 | No category selected | Category: (none) | Validation error | |
| 10 | No gender selected | Gender: (none) | Validation error | |

---

##  GitHub Contribution Evidence

| Name | Branch | Files Modified | Key Commits |
|---|---|---|---|
| Jandre Van Zyl | Dev-project-management-Jandre_Van_Zyl | README.md, .gitignore, project structure | Created project structure and initial setup |
| Dewald Van Jaarsveldt | Dev-ui-design-Dewald_Van_Jaarsveldt | Form1.cs, Form1.Designer.cs | |
| Tyler Davel | Dev-logic-module-Tyler_Davel | TicketCalculator.cs, Form1.cs | |
| Vehan Kuhn | Dev-testing-docs-Vehan_Kuhn | Docs/, Screenshots/ | |

---

##  Challenges Faced

_To be completed by the group before final submission._

---

##  Conclusion

_To be completed by the group before final submission._

---

*CTU Training Solutions (PTY) Ltd | MICT SETA Accredited | Registration No: ACC/2006/07/186*
