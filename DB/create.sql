CREATE TABLE `regisrer_directory` (
	`id` int NOT NULL AUTO_INCREMENT,
	`name` varchar(50) NULL,
	`description` varchar(100) NULL,
	`ping_api_path` varchar(255) NULL,
	`version_api_path` varchar(255) NULL,
	`create_date` datetime NOT NULL,
	PRIMARY KEY (`id`) 
);