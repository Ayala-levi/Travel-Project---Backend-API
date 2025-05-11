# Travel Project - Backend API

[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-%23512BD4.svg?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

This backend project, built with C# and the .NET environment, provides a powerful API for managing information related to travels, users, and registrations. The project is implemented using a modern 4-layer architecture, ensuring separation of concerns, easy maintenance, and scalability.

## Architecture

The project is built using a 4-layer architecture:

1.  **Travel.Api**: The API layer responsible for receiving HTTP requests and providing responses. It includes Controllers that handle the logic of the endpoints.
2.  **Travel.Core**: The core layer containing the domain entities, repository interfaces, and service interfaces. This layer represents the business logic of the application.
    * **Entities**: Represents the data structure (such as `Participant`, `Tour`, `User`, `UserDetail`).
    * **Repositories**: Defines interfaces for data access.
    * **Services**: Defines interfaces for business services.
3.  **Travel.Data**: The data access layer, responsible for communication with the database. It uses Entity Framework Core for managing the data.
    * **Migrations**: Contains scripts for managing database schema changes.
    * **Repositories**: Concrete implementations of the repository interfaces from the Core layer.
    * `DataContext.cs`: The Entity Framework Core context that defines the database tables and enables interaction with them.
4.  **Travel.Service**: (May be an additional service layer or a different name for another layer) Contains specific business services.

## Explanation of the Four Layers

You can find an explanation of each layer at the following link:
```bash
https://github.com/Ayala-levi/Product-4LayerArch-API.git
```
## Technologies Used

* **C#**: The primary programming language.
* **.NET**: The runtime and development framework.
* **ASP.NET Core**: For building the API.
* **Entity Framework Core (EF Core)**: An ORM (Object-Relational Mapper) tool for easy database access.
* **Swagger/OpenAPI**: For automatic API documentation generation and testing.
* **Dependency Injection**: For managing dependencies between components.

## Installation and Running

1.  **Prerequisites**:
    * [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
    * Visual Studio or another .NET-supported development tool.
    * Access to a SQL Server database.

2.  **Clone the Project**:
    ```bash
    git clone https://github.com/Ayala-levi/Travel-Project---Backend-API.git
    cd Travel
    ```

3.  **Update the Database Connection String**:
    * Open the `Travel.Data\DataContext.cs` file.
    * Locate the following section within the `OnConfiguring` method:
        ```csharp
        optionsBuilder.UseSqlServer("Server=???;Database=???;Integrated Security=True;TrustServerCertificate=True;");
        ```
    * **Replace the connection string** `"Server=server_name;Database=name_of_database;Integrated Security=True;TrustServerCertificate=True;"` with your database connection details.

4.  **Apply Migrations (if necessary)**:
    If there are pending migrations, apply them to create the database schema:
    ```bash
    dotnet ef database update -p Travel.Data -s Travel.Api
    ```

5.  **Run the Project**:
    Navigate to the `Travel.Api` directory in the command line and execute:
    ```bash
    dotnet run
    ```
    Alternatively, you can run directly from Visual Studio.

6.  **Access the API**:
    Once running, the API will be accessible at a default address (usually `http://localhost:5XXX`). You can access the Swagger documentation at `/swagger` (e.g., `http://localhost:5XXX/swagger`).
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Travel Project - Backend API

[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-%23512BD4.svg?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

פרויקט Backend זה, שנבנה ב-#C ובסביבת .NET, מספק API עוצמתי לניהול מידע הקשור לטיולים, משתמשים והרשמות. הפרויקט מיושם בארכיטקטורת 4 שכבות מודרנית, המבטיחה הפרדת דאגות, תחזוקה קלה וסקיילביליות.

## ארכיטקטורה

הפרויקט בנוי בארכיטקטורת 4 שכבות:

1.  **Travel.Api**: שכבת ה-API האחראית על קבלת בקשות HTTP ומתן תגובות. כוללת בקרים (Controllers) המטפלים בלוגיקה של נקודות הקצה (Endpoints).
2.  **Travel.Core**: שכבת הליבה המכילה את ישויות הדומיין (Entities), ממשקי ה-Repositories וה-Services. שכבה זו מייצגת את הלוגיקה העסקית של האפליקציה.
    * **Entities**: מייצגת את מבנה הנתונים (כגון `Participant`, `Tour`, `User`, `UserDetail`).
    * **Repositories**: מגדירה ממשקים לגישה לנתונים.
    * **Services**: מגדירה ממשקים לשירותים עסקיים.
3.  **Travel.Data**: שכבת גישה לנתונים, האחראית על התקשורת עם מסד הנתונים. משתמשת ב-Entity Framework Core לניהול המידע.
    * **Migrations**: מכילה סקריפטים לניהול שינויי סכימת מסד הנתונים.
    * **Repositories**: מימושים קונקרטיים של ממשקי ה-Repositories משכבת ה-Core.
    * `DataContext.cs`: הקשר (Context) של Entity Framework Core המגדיר את טבלאות מסד הנתונים ומאפשר אינטראקציה איתו.
4.  **Travel.Service**: (ייתכן שזו שכבת שירותים נוספת או שם שונה לשכבה אחרת) מכילה שירותים עסקיים ספציפיים.
## הסבר על ארבעת השכבות
הסבר על כל שכבה תוכלו למצוא בקישור הבא:
 ```bash
https://github.com/Ayala-levi/Product-4LayerArch-API.git
 ```
## טכנולוגיות בשימוש

* **#C**: שפת התכנות העיקרית.
* **.NET**: סביבת הריצה והפיתוח.
* **ASP.NET Core**: לבניית ה-API.
* **Entity Framework Core (EF Core)**: כלי ORM (Object-Relational Mapper) לגישה נוחה למסד הנתונים.
* **Swagger/OpenAPI**: ליצירת תיעוד אוטומטי של ה-API ובדיקתו.
* **Dependency Injection**: לניהול תלויות בין רכיבים.

## התקנה והרצה

1.  **דרישות מקדימות**:
    * [.NET SDK](https://dotnet.microsoft.com/download) מותקן על המחשב שלך.
    * Visual Studio או כלי פיתוח אחר התומך ב-.NET.
    * גישה למסד נתונים של SQL Server.

2.  **שכפול הפרויקט**:
    ```bash
    git clone https://github.com/Ayala-levi/Travel-Project---Backend-API.git
    cd Travel
    ```

3.  **עדכון מחרוזת החיבור למסד הנתונים**:
    * פתח את קובץ `Travel.Data\DataContext.cs`.
    * אתר את הקטע הבא בתוך המתודה `OnConfiguring`:
        ```csharp
        optionsBuilder.UseSqlServer("Server=???;Database=???;Integrated Security=True;TrustServerCertificate=True;");
        ```
    * **החלף את מחרוזת החיבור** `"Server=server_name;Database=name_of_database;Integrated Security=True;TrustServerCertificate=True;"` בפרטי החיבור למסד הנתונים שלך.

4.  **ביצוע מיגרציות (במידת הצורך)**:
    אם קיימות מיגרציות שלא הופעלו, יש לבצע אותן כדי ליצור את סכימת מסד הנתונים:
    ```bash
    dotnet ef database update -p Travel.Data -s Travel.Api
    ```

5.  **הרצת הפרויקט**:
    נווט לתיקיית `Travel.Api` בשורת הפקודה ובצע:
    ```bash
    dotnet run
    ```
    או, ניתן להריץ ישירות מתוך Visual Studio.

6.  **גישה ל-API**:
    לאחר ההרצה, ה-API יהיה זמין בכתובת ברירת מחדל (לרוב `http://localhost:5XXX`). ניתן לגשת לתיעוד Swagger בכתובת `/swagger` (לדוגמה, `http://localhost:5XXX/swagger`).

