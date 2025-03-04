CREATE TABLE people (
    people_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    birthday DATE NOT NULL
);

CREATE TABLE job (
    job_id INT PRIMARY KEY AUTO_INCREMENT,
    company_name VARCHAR(255) NOT NULL,
    job_name VARCHAR(255) NOT NULL
);

CREATE TABLE people_job (
    people_id INT,
    job_id INT,
    entry_date DATE NOT NULL,
    quitting_date DATE,
    active BOOLEAN NOT NULL,
    PRIMARY KEY (people_id, job_id),
    FOREIGN KEY (people_id) REFERENCES people(people_id) ON DELETE CASCADE,
    FOREIGN KEY (job_id) REFERENCES job(job_id) ON DELETE CASCADE
);

-- Insert data into people table
INSERT INTO people (name, first_name, birthday) VALUES
('Doe', 'John', '1990-05-15'),
('Smith', 'Alice', '1985-08-22'),
('Johnson', 'Robert', '1992-11-30');

-- Insert data into job table
INSERT INTO job (company_name, job_name) VALUES
('TechCorp', 'Software Engineer'),
('TechCorp', 'Data Analyst'),
('BizInc', 'Project Manager'),
('BizInc', 'Marketing Specialist');

-- Insert data into people_job table
INSERT INTO people_job (people_id, job_id, entry_date, quitting_date, active) VALUES
(1, 1, '2020-01-10', '2022-06-30', FALSE),
(1, 3, '2022-07-01', NULL, TRUE),
(2, 2, '2019-03-15', '2021-12-31', FALSE),
(2, 4, '2022-01-01', NULL, TRUE),
(3, 1, '2018-09-05', '2020-12-15', FALSE),
(3, 3, '2021-01-10', NULL, TRUE);
