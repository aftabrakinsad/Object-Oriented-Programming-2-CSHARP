CREATE TABLE User_info_family (
FNAME VARCHAR (50) NOT NULL,
UNIQUE_ID NVARCHAR (50) NOT NULL,
EMAIL VARCHAR (50) NOT NULL,
PASS NVARCHAR (50) NOT NULL
);

INSERT INTO User_info_family VALUES ('Rakin Sad Aftab', '20419911', 'aftab@gmail.com', '1111');
INSERT INTO User_info_family VALUES ('Saiful Islam', '20425851', 'saif@gmail.com', '2222');
INSERT INTO User_info_family VALUES ('Nuhan Ahmed', '20430681', 'nuhan@gmail.com', '3333');
INSERT INTO User_info_family VALUES ('sjhbvjhs5', '4545', 'a@gmail.com', '44545');
INSERT INTO User_info_family VALUES ('jekbn', '51615', 'b@gmail.com', '412341');
INSERT INTO User_info_family VALUES ('bhdvsh', '777777', 'a@gmail.com', '999999');

SELECT * FROM User_info_family