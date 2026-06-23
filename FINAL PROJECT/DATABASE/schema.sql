-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: hrapplicantsystemdb
-- ------------------------------------------------------
-- Server version	8.0.46

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `applicantaccounts`
--

DROP TABLE IF EXISTS `applicantaccounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicantaccounts` (
  `ApplicantAccountID` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(150) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `IsActive` tinyint(1) DEFAULT '1',
  `DateCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ApplicantAccountID`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicantaccounts`
--

LOCK TABLES `applicantaccounts` WRITE;
/*!40000 ALTER TABLE `applicantaccounts` DISABLE KEYS */;
INSERT INTO `applicantaccounts` VALUES (1,'applicant@test.com','123456',1,'2026-05-31 15:40:55'),(2,'test@123.com','123',1,'2026-05-31 17:46:51'),(3,'leigh@gmail.com','12345',1,'2026-06-01 15:22:32'),(4,'leigh123@gmail.com','123',1,'2026-06-09 10:43:53'),(5,'leighmacawile@gmail.com','123',1,'2026-06-11 11:27:15');
/*!40000 ALTER TABLE `applicantaccounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicantdocuments`
--

DROP TABLE IF EXISTS `applicantdocuments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicantdocuments` (
  `DocumentID` int NOT NULL AUTO_INCREMENT,
  `ApplicantID` int NOT NULL,
  `RequirementTypeID` int NOT NULL,
  `FileName` varchar(255) DEFAULT NULL,
  `FilePath` varchar(500) DEFAULT NULL,
  `SubmissionDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Status` enum('Submitted','Missing') DEFAULT 'Submitted',
  `HRRemarks` text,
  PRIMARY KEY (`DocumentID`),
  KEY `ApplicantID` (`ApplicantID`),
  KEY `RequirementTypeID` (`RequirementTypeID`),
  CONSTRAINT `applicantdocuments_ibfk_1` FOREIGN KEY (`ApplicantID`) REFERENCES `applicants` (`ApplicantID`),
  CONSTRAINT `applicantdocuments_ibfk_2` FOREIGN KEY (`RequirementTypeID`) REFERENCES `requirementtypes` (`RequirementTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicantdocuments`
--

LOCK TABLES `applicantdocuments` WRITE;
/*!40000 ALTER TABLE `applicantdocuments` DISABLE KEYS */;
INSERT INTO `applicantdocuments` VALUES (3,1,1,'GROUP-1-CAMPAIGN.pdf','C:\\Users\\Leigh Andrei\\Downloads\\GROUP-1-CAMPAIGN.pdf','2026-06-06 19:26:34','Submitted',NULL),(7,2,1,'HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','C:\\Users\\Leigh Andrei\\Downloads\\HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','2026-06-09 15:44:35','Submitted',NULL),(8,2,2,'HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','C:\\Users\\Leigh Andrei\\Downloads\\HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','2026-06-09 15:44:44','Submitted',NULL),(9,2,3,'HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','C:\\Users\\Leigh Andrei\\Downloads\\HR_Applicant_Process_Windows_App_Capstone_Requirements.pdf','2026-06-09 15:44:51','Submitted',NULL),(12,3,1,'MACAWILE QUIZ#3.pdf','C:\\Users\\Leigh Andrei\\Downloads\\MACAWILE QUIZ#3.pdf','2026-06-11 11:30:11','Submitted',NULL),(13,3,2,'MACAWILE QUIZ#3.pdf','C:\\Users\\Leigh Andrei\\Downloads\\MACAWILE QUIZ#3.pdf','2026-06-11 11:29:17','Submitted',NULL),(14,3,3,'Quiz #3.pdf','C:\\Users\\Leigh Andrei\\Downloads\\Quiz #3.pdf','2026-06-11 11:29:45','Submitted',NULL);
/*!40000 ALTER TABLE `applicantdocuments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicants`
--

DROP TABLE IF EXISTS `applicants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicants` (
  `ApplicantID` int NOT NULL AUTO_INCREMENT,
  `ApplicantAccountID` int NOT NULL,
  `FirstName` varchar(100) DEFAULT NULL,
  `MiddleName` varchar(100) DEFAULT NULL,
  `LastName` varchar(100) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Gender` varchar(20) DEFAULT NULL,
  `AddressLine` varchar(255) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `Province` varchar(100) DEFAULT NULL,
  `ContactNumber` varchar(30) DEFAULT NULL,
  `Education` text,
  `Skills` text,
  `WorkExperience` text,
  PRIMARY KEY (`ApplicantID`),
  KEY `ApplicantAccountID` (`ApplicantAccountID`),
  CONSTRAINT `applicants_ibfk_1` FOREIGN KEY (`ApplicantAccountID`) REFERENCES `applicantaccounts` (`ApplicantAccountID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicants`
--

LOCK TABLES `applicants` WRITE;
/*!40000 ALTER TABLE `applicants` DISABLE KEYS */;
INSERT INTO `applicants` VALUES (1,2,'Leigh Andrei','sample','Macawile','2026-06-05','Male','sample','sample','sample','sample','School: sample | Course: sample | Year Graduated: sample','samplesamplesamplesample','Company: sample | Position: sample | Years Worked: sample | Description: samplesamplesample'),(2,4,'Leigh','','Macawile','2007-06-02','Male','ph1','GMA','Cavite','09918018148','School: GMATHS | Course: STEM | Year Graduated: 2024','SAMPLE SAMPLE SAMPLE','Company: SAMPLE Company | Position: IT | Years Worked: 3 | Description: SAMPLE SAMPLE SAMPLE SAMPLE SAMPLE'),(3,5,'leigh','','macawile','2007-06-02','Male','ph1','sample','sample','09918018148','School: sample | Course: sample | Year Graduated: 2025','sample','Company: sample | Position: sample | Years Worked: 11 | Description: sample');
/*!40000 ALTER TABLE `applicants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applications`
--

DROP TABLE IF EXISTS `applications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applications` (
  `ApplicationID` int NOT NULL AUTO_INCREMENT,
  `ApplicantID` int NOT NULL,
  `JobVacancyID` int NOT NULL,
  `ApplicationDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `CurrentStatus` enum('Draft','Submitted','Under Review','Shortlisted','For Interview','For Assessment','For Final Review','Accepted','Rejected','Withdrawn') DEFAULT 'Draft',
  `HRReviewStarted` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`ApplicationID`),
  UNIQUE KEY `ApplicantID` (`ApplicantID`,`JobVacancyID`),
  KEY `JobVacancyID` (`JobVacancyID`),
  CONSTRAINT `applications_ibfk_1` FOREIGN KEY (`ApplicantID`) REFERENCES `applicants` (`ApplicantID`),
  CONSTRAINT `applications_ibfk_2` FOREIGN KEY (`JobVacancyID`) REFERENCES `jobvacancies` (`JobVacancyID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applications`
--

LOCK TABLES `applications` WRITE;
/*!40000 ALTER TABLE `applications` DISABLE KEYS */;
INSERT INTO `applications` VALUES (1,1,1,'2026-06-06 18:03:30','Shortlisted',1),(2,1,4,'2026-06-06 19:41:18','For Interview',1),(3,2,3,'2026-06-09 10:47:51','For Final Review',1),(4,1,3,'2026-06-09 15:26:32','For Final Review',0),(5,3,1,'2026-06-11 11:28:55','For Final Review',0),(6,3,2,'2026-06-18 11:44:24','Accepted',1);
/*!40000 ALTER TABLE `applications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicationstatushistory`
--

DROP TABLE IF EXISTS `applicationstatushistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `applicationstatushistory` (
  `StatusHistoryID` int NOT NULL AUTO_INCREMENT,
  `ApplicationID` int NOT NULL,
  `StatusName` varchar(50) DEFAULT NULL,
  `Remarks` text,
  `ChangedBy` int DEFAULT NULL,
  `DateChanged` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`StatusHistoryID`),
  KEY `ApplicationID` (`ApplicationID`),
  KEY `ChangedBy` (`ChangedBy`),
  CONSTRAINT `applicationstatushistory_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `applications` (`ApplicationID`),
  CONSTRAINT `applicationstatushistory_ibfk_2` FOREIGN KEY (`ChangedBy`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicationstatushistory`
--

LOCK TABLES `applicationstatushistory` WRITE;
/*!40000 ALTER TABLE `applicationstatushistory` DISABLE KEYS */;
INSERT INTO `applicationstatushistory` VALUES (7,1,'Draft','Application created.',NULL,'2026-06-06 18:03:30'),(8,1,'Submitted','Application submitted by applicant.',NULL,'2026-06-06 18:04:28'),(9,1,'Submitted','Application submitted by applicant.',NULL,'2026-06-06 18:11:05'),(10,2,'Draft','Application created.',NULL,'2026-06-06 19:41:18'),(11,2,'Submitted','Application submitted by applicant.',NULL,'2026-06-06 19:49:39'),(14,2,'Under Review','Status updated by HR.',1,'2026-06-08 23:21:41'),(15,2,'Rejected','SAMPLE SAMPLE',1,'2026-06-09 10:29:20'),(16,1,'Under Review','HR started reviewing application.',1,'2026-06-09 10:29:21'),(17,1,'Shortlisted','Screening completed.',1,'2026-06-09 10:29:51'),(18,1,'Shortlisted','gfgfgfg',1,'2026-06-09 10:31:08'),(19,1,'For Interview','Status updated by HR.',1,'2026-06-09 10:31:22'),(20,3,'Draft','Application created.',NULL,'2026-06-09 10:47:51'),(21,3,'Submitted','Application submitted by applicant.',NULL,'2026-06-09 10:52:04'),(22,3,'Under Review','HR started reviewing application.',1,'2026-06-09 10:52:32'),(23,3,'Shortlisted','NICE',1,'2026-06-09 10:53:53'),(24,3,'Shortlisted','Screening completed.',1,'2026-06-09 15:07:28'),(25,3,'For Interview','Interview scheduled.',1,'2026-06-09 15:13:00'),(26,3,'Accepted','Status updated by HR.',2,'2026-06-09 15:25:33'),(27,2,'Submitted','Application submitted by applicant.',NULL,'2026-06-09 15:26:09'),(28,4,'Draft','Application created.',NULL,'2026-06-09 15:26:32'),(29,2,'Under Review','HR started reviewing application.',2,'2026-06-09 15:27:01'),(30,2,'Shortlisted','Screening completed.',2,'2026-06-09 15:27:12'),(31,3,'Shortlisted','Status updated by HR.',2,'2026-06-09 15:27:48'),(32,3,'Accepted','Status updated by HR.',3,'2026-06-09 15:39:19'),(33,4,'For Interview','Status updated by HR.',1,'2026-06-09 15:47:01'),(34,2,'For Interview','Interview scheduled.',1,'2026-06-09 15:48:00'),(35,4,'Under Review','Status updated by HR.',1,'2026-06-09 16:05:13'),(36,2,'Under Review','Status updated by HR.',1,'2026-06-09 16:05:18'),(37,1,'Under Review','Status updated by HR.',1,'2026-06-09 16:05:24'),(38,4,'Shortlisted','Screening completed.',1,'2026-06-09 22:08:20'),(39,4,'For Interview','Interview scheduled.',1,'2026-06-09 22:08:37'),(40,2,'Shortlisted','Screening completed.',1,'2026-06-09 22:23:46'),(41,2,'For Interview','Interview scheduled.',1,'2026-06-09 22:24:34'),(42,4,'For Final Review','Status updated by HR.',1,'2026-06-09 22:31:01'),(43,3,'For Final Review','good',1,'2026-06-09 22:42:40'),(44,1,'Shortlisted','Screening completed.',1,'2026-06-11 11:25:45'),(45,5,'Draft','Application created.',NULL,'2026-06-11 11:28:55'),(46,5,'Under Review','Status updated by HR.',1,'2026-06-11 11:30:49'),(47,5,'Shortlisted','good',1,'2026-06-11 11:31:03'),(48,5,'For Interview','Interview scheduled.',1,'2026-06-11 11:31:22'),(49,5,'For Final Review','good',1,'2026-06-11 11:31:36'),(50,6,'Draft','Application created.',NULL,'2026-06-18 11:44:24'),(51,6,'Submitted','Application submitted by applicant.',NULL,'2026-06-18 11:44:39'),(52,6,'Under Review','HR started reviewing application.',1,'2026-06-18 11:45:19'),(53,6,'Shortlisted','good',1,'2026-06-18 11:45:56'),(54,6,'For Interview','Interview scheduled.',1,'2026-06-18 11:46:26'),(55,6,'For Final Review','good',1,'2026-06-18 11:48:11'),(56,6,'Accepted','nice',1,'2026-06-18 11:48:28');
/*!40000 ALTER TABLE `applicationstatushistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessmenttypes`
--

DROP TABLE IF EXISTS `assessmenttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assessmenttypes` (
  `AssessmentTypeID` int NOT NULL AUTO_INCREMENT,
  `AssessmentName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`AssessmentTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assessmenttypes`
--

LOCK TABLES `assessmenttypes` WRITE;
/*!40000 ALTER TABLE `assessmenttypes` DISABLE KEYS */;
INSERT INTO `assessmenttypes` VALUES (1,'Technical Exam'),(2,'Aptitude Test'),(3,'Personality Test');
/*!40000 ALTER TABLE `assessmenttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `audittrail`
--

DROP TABLE IF EXISTS `audittrail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `audittrail` (
  `AuditID` int NOT NULL AUTO_INCREMENT,
  `UserID` int DEFAULT NULL,
  `ActionTaken` varchar(255) DEFAULT NULL,
  `TableAffected` varchar(100) DEFAULT NULL,
  `RecordID` int DEFAULT NULL,
  `ActionDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Details` text,
  PRIMARY KEY (`AuditID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `audittrail_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audittrail`
--

LOCK TABLES `audittrail` WRITE;
/*!40000 ALTER TABLE `audittrail` DISABLE KEYS */;
/*!40000 ALTER TABLE `audittrail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departments` (
  `DepartmentID` int NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(100) NOT NULL,
  PRIMARY KEY (`DepartmentID`),
  UNIQUE KEY `DepartmentName` (`DepartmentName`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (3,'Finance'),(1,'Human Resources'),(2,'Information Technology'),(4,'Marketing'),(5,'Operations');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employmenttypes`
--

DROP TABLE IF EXISTS `employmenttypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employmenttypes` (
  `EmploymentTypeID` int NOT NULL AUTO_INCREMENT,
  `EmploymentTypeName` varchar(100) NOT NULL,
  PRIMARY KEY (`EmploymentTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employmenttypes`
--

LOCK TABLES `employmenttypes` WRITE;
/*!40000 ALTER TABLE `employmenttypes` DISABLE KEYS */;
INSERT INTO `employmenttypes` VALUES (1,'Full Time'),(2,'Part Time'),(4,'Internship');
/*!40000 ALTER TABLE `employmenttypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hiringdecisions`
--

DROP TABLE IF EXISTS `hiringdecisions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hiringdecisions` (
  `DecisionID` int NOT NULL AUTO_INCREMENT,
  `ApplicationID` int NOT NULL,
  `DecisionBy` int NOT NULL,
  `DecisionDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `FinalDecision` enum('Accepted','Rejected','On Hold') DEFAULT NULL,
  `FinalRemarks` text,
  PRIMARY KEY (`DecisionID`),
  KEY `ApplicationID` (`ApplicationID`),
  KEY `DecisionBy` (`DecisionBy`),
  CONSTRAINT `hiringdecisions_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `applications` (`ApplicationID`),
  CONSTRAINT `hiringdecisions_ibfk_2` FOREIGN KEY (`DecisionBy`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hiringdecisions`
--

LOCK TABLES `hiringdecisions` WRITE;
/*!40000 ALTER TABLE `hiringdecisions` DISABLE KEYS */;
/*!40000 ALTER TABLE `hiringdecisions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `interviewevaluations`
--

DROP TABLE IF EXISTS `interviewevaluations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `interviewevaluations` (
  `EvaluationID` int NOT NULL AUTO_INCREMENT,
  `InterviewScheduleID` int NOT NULL,
  `Score` decimal(5,2) DEFAULT NULL,
  `Remarks` text,
  `Result` enum('Pass','Fail') DEFAULT NULL,
  `Recommendation` text,
  `EvaluatedBy` int DEFAULT NULL,
  `EvaluationDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`EvaluationID`),
  KEY `InterviewScheduleID` (`InterviewScheduleID`),
  KEY `EvaluatedBy` (`EvaluatedBy`),
  CONSTRAINT `interviewevaluations_ibfk_1` FOREIGN KEY (`InterviewScheduleID`) REFERENCES `interviewschedules` (`InterviewScheduleID`),
  CONSTRAINT `interviewevaluations_ibfk_2` FOREIGN KEY (`EvaluatedBy`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interviewevaluations`
--

LOCK TABLES `interviewevaluations` WRITE;
/*!40000 ALTER TABLE `interviewevaluations` DISABLE KEYS */;
INSERT INTO `interviewevaluations` VALUES (1,2,10.00,'good','Pass','improve',1,'2026-06-09 22:21:25'),(2,3,10.00,'good','Pass','none',1,'2026-06-09 22:25:03'),(3,4,1.00,'bad','Fail','bye',1,'2026-06-09 22:35:07'),(4,1,100.00,'good','Pass','none',1,'2026-06-09 22:42:40'),(5,5,100.00,'good','Pass','good',1,'2026-06-11 11:31:36'),(6,6,100.00,'good','Pass','more',1,'2026-06-18 11:48:11');
/*!40000 ALTER TABLE `interviewevaluations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `interviewschedules`
--

DROP TABLE IF EXISTS `interviewschedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `interviewschedules` (
  `InterviewScheduleID` int NOT NULL AUTO_INCREMENT,
  `ApplicationID` int NOT NULL,
  `InterviewTypeID` int DEFAULT NULL,
  `InterviewDate` datetime NOT NULL,
  `Interviewer` varchar(150) DEFAULT NULL,
  `ModeOrLocation` varchar(255) DEFAULT NULL,
  `Status` enum('Scheduled','Completed','Cancelled') DEFAULT 'Scheduled',
  PRIMARY KEY (`InterviewScheduleID`),
  KEY `ApplicationID` (`ApplicationID`),
  KEY `InterviewTypeID` (`InterviewTypeID`),
  CONSTRAINT `interviewschedules_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `applications` (`ApplicationID`),
  CONSTRAINT `interviewschedules_ibfk_2` FOREIGN KEY (`InterviewTypeID`) REFERENCES `interviewtypes` (`InterviewTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interviewschedules`
--

LOCK TABLES `interviewschedules` WRITE;
/*!40000 ALTER TABLE `interviewschedules` DISABLE KEYS */;
INSERT INTO `interviewschedules` VALUES (1,3,2,'2026-07-10 15:00:37','Admin Head','Zoom','Completed'),(2,2,2,'2026-06-09 05:00:00','Admin','Zoom','Completed'),(3,4,2,'2026-06-10 22:08:25','Admin','Zoom','Completed'),(4,2,3,'2026-06-10 22:24:24','admin','pup','Completed'),(5,5,2,'2026-06-12 11:31:10','admin','zoom','Completed'),(6,6,2,'2026-06-19 00:00:00','Admin','Zoom','Completed');
/*!40000 ALTER TABLE `interviewschedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `interviewtypes`
--

DROP TABLE IF EXISTS `interviewtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `interviewtypes` (
  `InterviewTypeID` int NOT NULL AUTO_INCREMENT,
  `InterviewTypeName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`InterviewTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interviewtypes`
--

LOCK TABLES `interviewtypes` WRITE;
/*!40000 ALTER TABLE `interviewtypes` DISABLE KEYS */;
INSERT INTO `interviewtypes` VALUES (1,'Phone Interview'),(2,'Online Interview'),(3,'Face-to-Face Interview'),(4,'Panel Interview');
/*!40000 ALTER TABLE `interviewtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobvacancies`
--

DROP TABLE IF EXISTS `jobvacancies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jobvacancies` (
  `JobVacancyID` int NOT NULL AUTO_INCREMENT,
  `DepartmentID` int NOT NULL,
  `EmploymentTypeID` int DEFAULT NULL,
  `JobTitle` varchar(150) NOT NULL,
  `Description` text,
  `Qualifications` text,
  `VacancyCount` int DEFAULT '1',
  `Status` enum('Open','Closed') DEFAULT 'Open',
  `DatePosted` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`JobVacancyID`),
  KEY `DepartmentID` (`DepartmentID`),
  KEY `EmploymentTypeID` (`EmploymentTypeID`),
  CONSTRAINT `jobvacancies_ibfk_1` FOREIGN KEY (`DepartmentID`) REFERENCES `departments` (`DepartmentID`),
  CONSTRAINT `jobvacancies_ibfk_2` FOREIGN KEY (`EmploymentTypeID`) REFERENCES `employmenttypes` (`EmploymentTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobvacancies`
--

LOCK TABLES `jobvacancies` WRITE;
/*!40000 ALTER TABLE `jobvacancies` DISABLE KEYS */;
INSERT INTO `jobvacancies` VALUES (1,2,1,'Junior Software Developer','Develop and maintain HR Applicant System modules.','BSIT/BSCS Graduate\nKnowledge of C#\nKnowledge of MySQL\nGood communication skills',2,'Open','2026-06-05 22:21:40'),(2,2,1,'System Analyst','Analyze business processes and prepare system requirements.','BSIT/BSCS Graduate\nStrong analytical skills\nKnowledge of SDLC\nGood communication skills',1,'Open','2026-06-06 19:39:29'),(3,2,1,'Database Administrator','Maintain and optimize company databases.','BSIT/BSCS Graduate\nKnowledge of MySQL\nDatabase backup and recovery skills',1,'Open','2026-06-06 19:39:29'),(4,2,1,'Technical Support Specialist','Provide technical support and troubleshoot IT issues.','Graduate of any IT-related course\nStrong troubleshooting skills\nGood customer service',2,'Open','2026-06-06 19:39:29'),(5,4,1,'Marketing Assistant','Assist in marketing campaigns and social media management.','Marketing or Business Graduate\nExcellent communication skills\nCreative mindset',2,'Open','2026-06-06 19:39:29'),(6,3,1,'Accounting Assistant','Assist with financial reports and accounting records.','Accountancy or Finance Graduate\nKnowledge of bookkeeping\nAttention to detail',2,'Open','2026-06-06 19:39:29'),(7,1,NULL,'HR Job',NULL,'SAMPLE SAMPLE SAMPLE',2,'Closed','2026-06-08 13:57:35'),(8,1,NULL,'HR',NULL,'GOOD COMMUNICATION',4,'Closed','2026-06-18 11:43:14');
/*!40000 ALTER TABLE `jobvacancies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobvacancyrequirements`
--

DROP TABLE IF EXISTS `jobvacancyrequirements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jobvacancyrequirements` (
  `JobVacancyRequirementID` int NOT NULL AUTO_INCREMENT,
  `JobVacancyID` int NOT NULL,
  `RequirementTypeID` int NOT NULL,
  PRIMARY KEY (`JobVacancyRequirementID`),
  KEY `JobVacancyID` (`JobVacancyID`),
  KEY `RequirementTypeID` (`RequirementTypeID`),
  CONSTRAINT `jobvacancyrequirements_ibfk_1` FOREIGN KEY (`JobVacancyID`) REFERENCES `jobvacancies` (`JobVacancyID`),
  CONSTRAINT `jobvacancyrequirements_ibfk_2` FOREIGN KEY (`RequirementTypeID`) REFERENCES `requirementtypes` (`RequirementTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobvacancyrequirements`
--

LOCK TABLES `jobvacancyrequirements` WRITE;
/*!40000 ALTER TABLE `jobvacancyrequirements` DISABLE KEYS */;
INSERT INTO `jobvacancyrequirements` VALUES (1,1,1),(2,1,2),(3,1,3),(4,2,1),(5,2,2),(6,2,3),(7,3,1),(8,3,2),(9,3,3),(10,3,5),(11,4,1),(12,4,2),(13,5,1),(14,5,2),(15,5,3),(16,6,1),(17,6,2),(18,6,3),(19,6,4);
/*!40000 ALTER TABLE `jobvacancyrequirements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requirementtypes`
--

DROP TABLE IF EXISTS `requirementtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requirementtypes` (
  `RequirementTypeID` int NOT NULL AUTO_INCREMENT,
  `RequirementName` varchar(150) NOT NULL,
  PRIMARY KEY (`RequirementTypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requirementtypes`
--

LOCK TABLES `requirementtypes` WRITE;
/*!40000 ALTER TABLE `requirementtypes` DISABLE KEYS */;
INSERT INTO `requirementtypes` VALUES (1,'Resume'),(2,'Government ID'),(3,'Transcript of Records'),(4,'Certificate of Employment'),(5,'Training Certificates');
/*!40000 ALTER TABLE `requirementtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `RoleID` int NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(50) NOT NULL,
  PRIMARY KEY (`RoleID`),
  UNIQUE KEY `RoleName` (`RoleName`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Admin'),(3,'HR Manager'),(2,'HR Staff');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `screeningresults`
--

DROP TABLE IF EXISTS `screeningresults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `screeningresults` (
  `ScreeningID` int NOT NULL AUTO_INCREMENT,
  `ApplicationID` int NOT NULL,
  `ScreenedBy` int NOT NULL,
  `ScreeningDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Result` enum('Qualified','Not Qualified') DEFAULT NULL,
  `Remarks` text,
  PRIMARY KEY (`ScreeningID`),
  KEY `ApplicationID` (`ApplicationID`),
  KEY `ScreenedBy` (`ScreenedBy`),
  CONSTRAINT `screeningresults_ibfk_1` FOREIGN KEY (`ApplicationID`) REFERENCES `applications` (`ApplicationID`),
  CONSTRAINT `screeningresults_ibfk_2` FOREIGN KEY (`ScreenedBy`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `screeningresults`
--

LOCK TABLES `screeningresults` WRITE;
/*!40000 ALTER TABLE `screeningresults` DISABLE KEYS */;
INSERT INTO `screeningresults` VALUES (1,2,1,'2026-06-09 10:29:20','Not Qualified','SAMPLE SAMPLE'),(2,1,1,'2026-06-09 10:29:51','Qualified',''),(3,1,1,'2026-06-09 10:31:08','Qualified','gfgfgfg'),(4,3,1,'2026-06-09 10:53:53','Qualified','NICE'),(5,3,1,'2026-06-09 15:07:28','Qualified',''),(6,2,2,'2026-06-09 15:27:12','Qualified',''),(7,4,1,'2026-06-09 22:08:20','Qualified',''),(8,2,1,'2026-06-09 22:23:46','Qualified',''),(9,1,1,'2026-06-11 11:25:45','Qualified',''),(10,5,1,'2026-06-11 11:31:03','Qualified','good'),(11,6,1,'2026-06-18 11:45:56','Qualified','good');
/*!40000 ALTER TABLE `screeningresults` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `RoleID` int NOT NULL,
  `FullName` varchar(150) NOT NULL,
  `Email` varchar(150) NOT NULL,
  `Username` varchar(100) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `IsActive` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Email` (`Email`),
  UNIQUE KEY `Username` (`Username`),
  KEY `RoleID` (`RoleID`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`RoleID`) REFERENCES `roles` (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,1,'System Administrator','admin@company.com','admin','admin123',1),(2,2,'John HR Staff','hrstaff@company.com','hrstaff','staff123',1),(3,3,'Jane HR Manager','hrmanager@company.com','hrmanager','manager123',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-23 15:09:02
