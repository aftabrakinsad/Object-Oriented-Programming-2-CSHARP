CREATE TABLE ARMYMAN (
Username VARCHAR (50) NOT NULL,
PASS NVARCHAR (50) NOT NULL,
Uni_id NVARCHAR (50) NOT NULL,
Location_A VARCHAR (50) NOT NULL,
MISSION_NAME VARCHAR (50) NOT NULL,
Statuss VARCHAR (50) NOT NULL
);

INSERT INTO ARMYMAN VALUES ('rakinsadaftab', '222222', '20419911', 'Dhaka Cantonment','OML', 'MIA');
INSERT INTO ARMYMAN VALUES ('saifulislam', '111111', '20425851', 'Chittagong Cantonment','OLMS', 'Active');
INSERT INTO ARMYMAN VALUES ('nuhanahmed', '333333', '20430681', 'Jessore Cantonment','OTL', 'KIA');
INSERT INTO ARMYMAN VALUES ('mdamir', '444444', '20000000', 'Postogola Cantonment','OLMS', 'Active');

SELECT * FROM ARMYMAN