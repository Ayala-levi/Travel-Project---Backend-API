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
    git clone <כתובת ה-Git של הפרויקט>
    cd Travel
    ```

3.  **עדכון מחרוזת החיבור למסד הנתונים**:
    * פתח את קובץ `Travel.Data\DataContext.cs`.
    * אתר את הקטע הבא בתוך המתודה `OnConfiguring`:
        ```csharp
        optionsBuilder.UseSqlServer("Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=MyShop_db;Integrated Security=True;TrustServerCertificate=True;");
        ```
    * **החלף את מחרוזת החיבור** `"Server=DESKTOP-783IDMP\\SQLEXPRESS;Database=MyShop_db;Integrated Security=True;TrustServerCertificate=True;"` בפרטי החיבור למסד הנתונים שלך.

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

## נקודות קצה (דוגמאות)

*(כאן יופיעו פירוט של נקודות הקצה של ה-API לאחר שתספק לי אותן)*

## תרומה

*(אם אתה מעוניין לקבל תרומות לפרויקט, ציין כאן כיצד)*

## מילות מפתח

`C#`, `.NET`, `ASP.NET Core`, `API`, `Backend`, `Entity Framework Core`, `EF Core`, `ארכיטקטורת 4 שכבות`, `Repository Pattern`, `Service Layer`, `Swagger`, `OpenAPI`, `Dependency Injection`, `מסד נתונים`, `SQL Server`, `מיגרציות`, `טיולים`, `משתמשים`, `הרשמות`.

---

אני מקווה שזה נראה מרשים להתחלה! מה תרצה להוסיף או לשנות?
