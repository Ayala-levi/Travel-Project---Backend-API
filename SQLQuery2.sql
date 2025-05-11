-- טבלה ראשית: משתמשים (יכולים להיות מטיילים או מדריכים)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL
);

-- טבלה לקשר יחיד-ליחיד: פרטי משתמש נוספים
CREATE TABLE UserDetails (
    UserID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    PhoneNumber VARCHAR(20),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- טבלה לקשר יחיד-לרבים: טיולים מודרכים (כל טיול נוצר על ידי משתמש אחד)
CREATE TABLE Tours (
    TourID INT PRIMARY KEY IDENTITY(1,1),
    OrganizerID INT NOT NULL,
    TourName VARCHAR(100) NOT NULL,
    Description TEXT,
    Location VARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    FOREIGN KEY (OrganizerID) REFERENCES Users(UserID)
);

-- טבלה לקשר רבים-לרבים: מטיילים מצטרפים לטיולים
CREATE TABLE Participants (
    UserID INT NOT NULL,
    TourID INT NOT NULL,
    RegistrationDate DATETIME2 DEFAULT GETDATE(), -- שימוש ב-DATETIME2 ו-GETDATE()
    PRIMARY KEY (UserID, TourID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TourID) REFERENCES Tours(TourID)
);