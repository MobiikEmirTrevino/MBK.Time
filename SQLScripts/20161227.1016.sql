

/************ Update: Schemas ***************/

/* Add Schema: time */
CREATE SCHEMA [time];



/************ Update: Tables ***************/

/******************** Add Table: time.timeTask ************************/

/* Build Table Structure */
CREATE TABLE time.timeTask
(
	GuidTask UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NULL,
	Hours INTEGER NULL,
	HoursWorked BIGINT NULL,
	StartDate DATETIME NULL,
	EndDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE time.timeTask ADD CONSTRAINT pktimeTask
	PRIMARY KEY (GuidTask);