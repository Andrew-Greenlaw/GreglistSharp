-- Active: 1666715478973@@SG-mirror-push-8951-6845-mysql-master.servers.mongodirector.com@3306@garbageCollector
CREATE TABLE
IF NOT EXISTS jobs(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  company VARCHAR(255) NOT NULL,
  jobTitle VARCHAR(255) NOT NULL,
  hours int NOT NULL CHECK(hours <= 80),
  rate DECIMAL(10,2) NOT NULL CHECK(rate >= 7.25),
  description VARCHAR(255) NOT NULL
);
INSERT INTO jobs(company,jobTitle,hours,rate,description)
VALUES ("Microsoft","CEO",40,10000,"Bill Gates said im done.");
SELECT * FROM jobs