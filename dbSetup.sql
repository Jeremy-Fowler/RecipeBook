CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS families(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  members int NOT NULL,
  creatorId VARCHAR(255) NOT NULL,

  FOREIGN KEY(creatorId) REFERENCES accounts(id)
)default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS recipes(
  id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
  familyId int,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,

  FOREIGN KEY(familyId) REFERENCES families(id)
)default charset utf8 COMMENT '';