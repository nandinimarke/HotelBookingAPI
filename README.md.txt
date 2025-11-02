# 🏨 HotelBookingAPI

A simple **ASP.NET Core Web API** built with **C#**, **Entity Framework Core**, and **SQL Server** to manage hotel room bookings.
This project demonstrates CRUD operations, EF Core integration, and RESTful API design — perfect for learning or showcasing backend development skills.

---

## 🚀 Features

* Create, Read, Update, and Delete hotel bookings
* SQL Server database using Entity Framework Core
* Swagger UI for API testing
* Postman collection for easy testing
* Built with Visual Studio 2022

---

## 🧱 Tech Stack

* **Backend:** ASP.NET Core Web API (C#)
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **IDE:** Visual Studio 2022
* **Testing:** Postman

---

## ⚙️ Setup Instructions

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/yourusername/HotelBookingAPI.git
```

### 2️⃣ Open in Visual Studio

* Open the `.sln` file
* Restore NuGet packages if prompted

### 3️⃣ Configure SQL Connection

In `appsettings.json`, set your connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=HotelBookingDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4️⃣ Apply Migrations

In **Package Manager Console**:

```powershell
Add-Migration InitialCreate
Update-Database
```

### 5️⃣ Run the Project

Press **F5** or **Ctrl + F5** → The API opens with Swagger UI.

---

## 🧪 Postman Collection

To test endpoints easily:

1. Import `HotelBookingAPI.postman_collection.json` into Postman
2. Test endpoints:

   * `POST /api/HotelBooking/CreateEdit`
   * `GET /api/HotelBooking/GetAll`
   * `GET /api/HotelBooking/Get?id=1`
   * `DELETE /api/HotelBooking/Delete?id=1`

---

## 📸 Sample JSON (for POST)

```json
{
  "roomNo": 101,
  "clientName": "John Doe"
}
```

---

## 👨‍💻 Author

Nandini Marke
