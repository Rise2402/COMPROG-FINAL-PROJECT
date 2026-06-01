USE HRApplicantSystemDB;

CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    RoleID INT NOT NULL,
    FullName VARCHAR(150) NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Username VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,

    FOREIGN KEY (RoleID)
    REFERENCES Roles(RoleID)
);

CREATE TABLE ApplicantAccounts (
    ApplicantAccountID INT AUTO_INCREMENT PRIMARY KEY,
    Email VARCHAR(150) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    DateCreated DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Applicants (
    ApplicantID INT AUTO_INCREMENT PRIMARY KEY,
    ApplicantAccountID INT NOT NULL,

    FirstName VARCHAR(100),
    MiddleName VARCHAR(100),
    LastName VARCHAR(100),

    BirthDate DATE,
    Gender VARCHAR(20),

    AddressLine VARCHAR(255),
    City VARCHAR(100),
    Province VARCHAR(100),

    ContactNumber VARCHAR(30),

    Education TEXT,
    Skills TEXT,
    WorkExperience TEXT,

    FOREIGN KEY (ApplicantAccountID)
    REFERENCES ApplicantAccounts(ApplicantAccountID)
);

CREATE TABLE Departments (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE EmploymentTypes (
    EmploymentTypeID INT AUTO_INCREMENT PRIMARY KEY,
    EmploymentTypeName VARCHAR(100) NOT NULL
);

CREATE TABLE JobVacancies (
    JobVacancyID INT AUTO_INCREMENT PRIMARY KEY,

    DepartmentID INT NOT NULL,
    EmploymentTypeID INT,

    JobTitle VARCHAR(150) NOT NULL,
    Description TEXT,
    Qualifications TEXT,

    VacancyCount INT DEFAULT 1,

    Status ENUM('Open','Closed') DEFAULT 'Open',

    DatePosted DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID),

    FOREIGN KEY (EmploymentTypeID)
    REFERENCES EmploymentTypes(EmploymentTypeID)
);

CREATE TABLE RequirementTypes (
    RequirementTypeID INT AUTO_INCREMENT PRIMARY KEY,
    RequirementName VARCHAR(150) NOT NULL
);

CREATE TABLE Applications (
    ApplicationID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicantID INT NOT NULL,
    JobVacancyID INT NOT NULL,

    ApplicationDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    CurrentStatus ENUM(
        'Draft',
        'Submitted',
        'Under Review',
        'Shortlisted',
        'For Interview',
        'For Assessment',
        'For Final Review',
        'Accepted',
        'Rejected',
        'Withdrawn'
    ) DEFAULT 'Draft',

    HRReviewStarted BOOLEAN DEFAULT FALSE,

    FOREIGN KEY (ApplicantID)
    REFERENCES Applicants(ApplicantID),

    FOREIGN KEY (JobVacancyID)
    REFERENCES JobVacancies(JobVacancyID),

    UNIQUE(ApplicantID, JobVacancyID)
);

CREATE TABLE ApplicantDocuments (
    DocumentID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicantID INT NOT NULL,
    RequirementTypeID INT NOT NULL,

    FileName VARCHAR(255),
    FilePath VARCHAR(500),

    SubmissionDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    Status ENUM('Submitted','Missing') DEFAULT 'Submitted',

    HRRemarks TEXT,

    FOREIGN KEY (ApplicantID)
    REFERENCES Applicants(ApplicantID),

    FOREIGN KEY (RequirementTypeID)
    REFERENCES RequirementTypes(RequirementTypeID)
);

CREATE TABLE ScreeningResults (
    ScreeningID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT NOT NULL,
    ScreenedBy INT NOT NULL,

    ScreeningDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    Result ENUM('Qualified','Not Qualified'),

    Remarks TEXT,

    FOREIGN KEY (ApplicationID)
    REFERENCES Applications(ApplicationID),

    FOREIGN KEY (ScreenedBy)
    REFERENCES Users(UserID)
);

CREATE TABLE InterviewTypes (
    InterviewTypeID INT AUTO_INCREMENT PRIMARY KEY,
    InterviewTypeName VARCHAR(100)
);

CREATE TABLE InterviewSchedules (
    InterviewScheduleID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT NOT NULL,
    InterviewTypeID INT,

    InterviewDate DATETIME NOT NULL,

    Interviewer VARCHAR(150),

    ModeOrLocation VARCHAR(255),

    Status ENUM('Scheduled','Completed','Cancelled')
        DEFAULT 'Scheduled',

    FOREIGN KEY (ApplicationID)
    REFERENCES Applications(ApplicationID),

    FOREIGN KEY (InterviewTypeID)
    REFERENCES InterviewTypes(InterviewTypeID)
);

CREATE TABLE InterviewEvaluations (
    EvaluationID INT AUTO_INCREMENT PRIMARY KEY,

    InterviewScheduleID INT NOT NULL,

    Score DECIMAL(5,2),

    Remarks TEXT,

    Result ENUM('Pass','Fail'),

    Recommendation TEXT,

    EvaluatedBy INT,

    EvaluationDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (InterviewScheduleID)
    REFERENCES InterviewSchedules(InterviewScheduleID),

    FOREIGN KEY (EvaluatedBy)
    REFERENCES Users(UserID)
);

CREATE TABLE HiringDecisions (
    DecisionID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT NOT NULL,

    DecisionBy INT NOT NULL,

    DecisionDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    FinalDecision ENUM('Accepted','Rejected','On Hold'),

    FinalRemarks TEXT,

    FOREIGN KEY (ApplicationID)
    REFERENCES Applications(ApplicationID),

    FOREIGN KEY (DecisionBy)
    REFERENCES Users(UserID)
);

CREATE TABLE ApplicationStatusHistory (
    StatusHistoryID INT AUTO_INCREMENT PRIMARY KEY,

    ApplicationID INT NOT NULL,

    StatusName VARCHAR(50),

    Remarks TEXT,

    ChangedBy INT,

    DateChanged DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (ApplicationID)
    REFERENCES Applications(ApplicationID),

    FOREIGN KEY (ChangedBy)
    REFERENCES Users(UserID)
);

CREATE TABLE AssessmentTypes (
    AssessmentTypeID INT AUTO_INCREMENT PRIMARY KEY,
    AssessmentName VARCHAR(100)
);

CREATE TABLE AuditTrail (
    AuditID INT AUTO_INCREMENT PRIMARY KEY,

    UserID INT,

    ActionTaken VARCHAR(255),

    TableAffected VARCHAR(100),

    RecordID INT,

    ActionDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    Details TEXT,

    FOREIGN KEY (UserID)
    REFERENCES Users(UserID)
);

INSERT INTO Roles(RoleName)
VALUES
('Admin'),
('HR Staff'),
('HR Manager');

INSERT INTO Departments(DepartmentName)
VALUES
('Human Resources'),
('Information Technology'),
('Finance'),
('Marketing'),
('Operations');

INSERT INTO EmploymentTypes(EmploymentTypeName)
VALUES
('Full Time'),
('Part Time'),
('Contractual'),
('Internship');

INSERT INTO RequirementTypes(RequirementName)
VALUES
('Resume'),
('Government ID'),
('Transcript of Records'),
('Certificate of Employment'),
('Training Certificates');

INSERT INTO InterviewTypes(InterviewTypeName)
VALUES
('Phone Interview'),
('Online Interview'),
('Face-to-Face Interview'),
('Panel Interview');

INSERT INTO AssessmentTypes(AssessmentName)
VALUES
('Technical Exam'),
('Aptitude Test'),
('Personality Test');