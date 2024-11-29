# **Custom Login, Registration, Email Verification, and Password Recovery in ASP.NET Core MVC**

## **Project Overview**

This project demonstrates how to implement **custom login**, **registration**, **email verification**, and **password recovery** pages in an **ASP.NET Core MVC application** using the **Identity framework**. It leverages ASP.NET Core’s built-in **Identity** functionality and integrates a custom approach for managing user data, email verification, password recovery, and session management.

### **Key Features**
- **Custom User Authentication**: Build login and registration forms from scratch using ASP.NET Core Identity.
- **Password Management**: Implement password change and recovery features to enhance user security.
- **Email Verification**: Send email verification messages to users during the registration process.
- **User Sessions**: Support for "Remember Me" functionality using cookies to keep users logged in.
- **User Logout**: Allow users to log out and access login/registration pages.
- **Database Integration**: Uses SQL Server to manage user data and integrates with Entity Framework for data operations.

---

## **Technologies Used**

### Core Technologies:
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)

### Additional Technologies:
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

---

## **Setup Instructions**

Follow these steps to set up and run the project locally.

### **1. Clone the Repository**

Clone the repository to your local machine:

```bash
git clone https://github.com/your-username/CustomIdentityApp.git
cd CustomIdentityApp
```

### **2. Install Dependencies**

Ensure that you have the **.NET SDK** installed. Run the following command to restore the dependencies:

```bash
dotnet restore
```

### **3. Configure the Database**

The project uses **SQL Server** for storing user information. The connection string is located in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CustomIdentityDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

If you're using a different database server, update the connection string accordingly.

### **4. Apply Migrations**

Run the following commands to apply the initial migrations and set up the database:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### **5. Run the Application**

Start the application using the following command:

```bash
dotnet run
```

This will start the application locally. You can now access it in your browser at `https://localhost:5001`.

---

## **Screenshots**

### **Login Page**
![Web capture_29-11-2024_9134_localhost](https://github.com/user-attachments/assets/4150f0a3-0aa2-45c8-9fe4-bbe47d279247)

### **Registration Page**
![Web capture_29-11-2024_9110_localhost](https://github.com/user-attachments/assets/40c18751-446c-497a-a76e-08f2dd58eec9)

### **Email Verification Page**
![Web capture_29-11-2024_923_localhost](https://github.com/user-attachments/assets/44e6da0f-c28b-4a24-8bb0-d57df5565fb8)

### **Password Recovery Page**
![Web capture_29-11-2024_9234_localhost](https://github.com/user-attachments/assets/742a350a-836f-4706-8b8b-66b41535a46a)

---

## **Contributing**

Contributions are welcome! You can help improve this project by:

- Fixing bugs
- Adding new features
- Improving documentation
- Reporting issues

### **How to Contribute**

1. Fork the repository.
2. Clone your fork locally.
3. Create a new branch for your feature or fix:
   ```bash
   git checkout -b feature-branch-name
   ```
4. Commit your changes with a descriptive message:
   ```bash
   git commit -m "Add feature description"
   ```
5. Push your changes to your fork:
   ```bash
   git push origin feature-branch-name
   ```
6. Open a pull request to the main repository.

---

## **Licenses and Acknowledgements**

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## **Key Insights**

- **User Authentication**: Customizing login and registration forms ensures better control over the user experience and enhances security by leveraging ASP.NET Core Identity.
- **Password Management**: Implementing password recovery and change functionalities provides a secure method for users to maintain and update their credentials.
- **Email Verification**: Verifying user emails ensures that only valid users can access the application, adding an extra layer of security.
- **MVC Architecture**: The **Model-View-Controller (MVC)** pattern in ASP.NET Core allows for clean separation of concerns, making the application more modular and maintainable.
- **Session Management**: Managing user sessions with cookies improves user convenience and ensures that users remain authenticated across different pages.

---

## **Contact**

For inquiries or support, feel free to open an issue on the repository or contact me directly:

- **Email**: dilndilruksha0@gmail.com
- **GitHub**: [@dilrukshax](https://github.com/dilrukshax)

---
