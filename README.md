# 📈 DychaApp – Stock Investment Support Application

**Dycha** is a desktop application built using **C#** and **Windows Forms**, designed to support stock market investors by simplifying portfolio analysis, risk assessment, and investment tracking.

This project was created as a **university coursework assignment** (a stock exchange project) and includes a **complete feasibility study** and detailed functional documentation as part of the deliverables.

---

## 🎯 Purpose

The goal of Dycha is to offer a lightweight and user-friendly tool for individual investors to:

- Track and manage their investment portfolios
- Calculate average purchase prices
- Estimate potential profits/losses based on different stock prices
- Analyze market trends and historical performance
- Simulate risk levels for future investments

It addresses the gap between overly complex financial tools and the needs of beginner-to-intermediate users who seek clarity and simplicity in their analysis.

---

## 📄 Documentation

This repository includes full documentation for the project:

- `Feasibility Study Report` – Covers project viability, requirements, market analysis, and development strategy
- `System Requirements Specification (SRS)` – Functional, non-functional requirements, architecture, and use cases
- `Functional Testing Report` – Manual test results, detected issues, and quality evaluation

---

## 🛠️ Technologies Used

- **C# / .NET**
- **Windows Forms**
- **Firebase** (Authentication & Cloud Firestore)
- **Finnhub Stock API** (for real-time market data)
- **Google Finance integration** (for interactive charts)

---

## ⚙️ Key Features

- 🔐 Secure user registration and login (Firebase Authentication)
- 📊 Real-time stock data dashboard with charts
- 📁 Portfolio management with gains/loss tracking
- 🧮 Risk and return calculator
- ☁️ Cloud-based data storage and synchronization

---

## 🧪 Testing & Quality

- Manual testing was conducted according to the SRS document
- 9 functional test cases were executed; 3 defects were reported
- Known issues:
  - Google login issues due to embedded browser security
  - Over-sensitive risk calculator algorithm
  - Stability problems under long use with external APIs
- Overall quality rated as **Good**, with improvement suggestions provided

---

## 👨‍💻 Team

Developed by:
- Bartosz Goździkiewicz
- Iga Kaczmarek
- Aleksander Kominiak
- Kacper Domiński
- Jakub Gorządek

---

## 📌 Notes

- The app is developed as a **Windows-only desktop solution**
- It is intended for educational and analytical purposes, not real-time trading
- Future enhancements may include:
  - Improved risk modeling
  - Web or hybrid versions
  - API usage optimizations

---

## 🔗 External Resources

- [Firebase Documentation](https://firebase.google.com/docs)
- [Finnhub Stock API](https://finnhub.io/docs/api)
- [Google Finance](https://www.google.com/finance)

---

Feel free to fork, explore, or contribute!
