Drop DATABASE OnlineMarket;
CREATE DATABASE OnlineMarket;
Use OnlineMarket;

CREATE TABLE Cityes (
    city_id INT PRIMARY KEY not null,
    name varchar(50)
);

CREATE TABLE ItemTypes (
    item_types_id INT PRIMARY KEY not null,
    name varchar(255)
);

CREATE TABLE Items (
    item_id INT PRIMARY KEY not null,
    name varchar(255),
    item_types_id Int,
	FOREIGN KEY (item_types_id) REFERENCES ItemTypes(item_types_id)
);

CREATE TABLE Custumers (
    custumer_id INT PRIMARY KEY not null,
    name varchar(255),
    birthday Date,
    city_id Int,
	FOREIGN KEY (city_id) REFERENCES Cityes(city_id)
);

CREATE TABLE Orders (
    order_id INT PRIMARY KEY not null,
    custumer_id Int,
	FOREIGN KEY (custumer_id) REFERENCES Custumers(custumer_id)
);

CREATE TABLE OrdersItems (
    order_id INT PRIMARY KEY not null,
    item_id Int,
	FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (item_id) REFERENCES Items(item_id)
);

