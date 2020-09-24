-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2020 at 10:31 AM
-- Server version: 10.1.40-MariaDB
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mobilyaccounting`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_ACOUNT_RECEIPT_INFO` (`_C_ACOUNT_ID` INT(11), `_C_ANAME` VARCHAR(30), `_R_TOTAL` DOUBLE, `_R_CODE` VARCHAR(11), `_R_CREATED_AT` DATETIME)  BEGIN

	INSERT 
	INTO 
		`accounts_receipt_info`(
			`C_ACOUNT_ID`, 
			`C_ANAME`, 
			`R_TOTAL`, 
			`R_CODE`, 
			`R_CREATED_AT`) 
	VALUES (
			_C_ACOUNT_ID, 
			_C_ANAME, 
			_R_TOTAL, 
			_R_CODE, 
			_R_CREATED_AT
	);


	UPDATE 
		`clients_account` 
	SET 
		`A_RECEIPT_VAL` = A_RECEIPT_VAL + _R_TOTAL
	WHERE 
		A_ID = _C_ACOUNT_ID;


END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_ACOUNT_RECEIPT_ITEMS` (`ACC_TYPE` BOOL, `_A_R_INFO_CODE` VARCHAR(30), `_AR_ITEM_NAME` VARCHAR(255), `_AR_ITEM_PROD_ID` INT(30), `_AR_ITEM_TYPE` VARCHAR(30), `_AR_ITEM_QUANTITY` INT(30), `_AR_PRICE` DOUBLE, `_AR_TOTAL_PRICE` DOUBLE, `_AR_CREATED_AT` DATETIME)  BEGIN
	INSERT 
	INTO 
		`accounts_receipt_items`(
			`A_R_INFO_CODE`, 
			`AR_ITEM_NAME`, 
			`AR_ITEM_PROD_ID`, 
			`AR_ITEM_TYPE`, 
			`AR_ITEM_QUANTITY`, 
			`AR_PRICE`, 
			`AR_TOTAL_PRICE`, 
			`AR_CREATED_AT`) 
	VALUES (
			_A_R_INFO_CODE, 
			_AR_ITEM_NAME , 
			_AR_ITEM_PROD_ID , 
			_AR_ITEM_TYPE , 
			_AR_ITEM_QUANTITY , 
			_AR_PRICE , 
			_AR_TOTAL_PRICE , 
			_AR_CREATED_AT
		);

	IF ACC_TYPE = true THEN
		UPDATE 
			`products` 
		SET 
			`P_QUANTITY`= P_QUANTITY  -  _AR_ITEM_QUANTITY 
		WHERE 
			P_ID = _AR_ITEM_PROD_ID;
    END IF;
		

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_CASH_TO_ACC` (`_C_ACOUNT_ID` INT(11), `_C_ACC_TYPE` VARCHAR(30), `_C_ANAME` VARCHAR(30), `_C_CASH_TOTAL` DOUBLE, `_C_NOTE` TEXT, `_C_CREATED_AT` DATETIME)  BEGIN
	INSERT 
	INTO 
		`accounts_cash_info`(
			`C_ACOUNT_ID`, 
			`C_ACC_TYPE`, 
			`C_ANAME`, 
			`C_CASH_TOTAL`,
			`C_NOTE`, 
			`C_CREATED_AT`) 
	VALUES (
			_C_ACOUNT_ID, 
			_C_ACC_TYPE, 
			_C_ANAME, 
			_C_CASH_TOTAL,
			_C_NOTE,
			_C_CREATED_AT
	);

	UPDATE 
		`clients_account` 
	SET 
		`A_CASH_VAL`= A_CASH_VAL + _C_CASH_TOTAL
	WHERE 
		A_ID = _C_ACOUNT_ID;



END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_CATEGORY` (IN `_C_NAME` VARCHAR(255) CHARSET utf8mb4, IN `_C_DESKRIPTION` VARCHAR(255) CHARSET utf8mb4)  BEGIN
	INSERT 
	INTO 
		`categories`
		(`C_NAME`, `C_DESKRIPTION`) 
	VALUES (_C_NAME, _C_DESKRIPTION );
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_CLIENT_ACCOUNT` (`_A_STORE_NAME` VARCHAR(30), `_A_C_NAME` VARCHAR(255), `_A_C_PHONE` INT(11), `_A_TYPE` VARCHAR(30), `_A_DESKRIPTION` TEXT, `_CREATED_AT` DATETIME)  BEGIN

	DECLARE ACC_ID INT DEFAULT 0;

	INSERT 
	INTO 
		`clients_account`(
		`A_STORE_NAME`, 
		`A_C_NAME`, 
		`A_C_PHONE`, 
		`A_TYPE`, 
		`A_DESKRIPTION`) 
	VALUES (
		_A_STORE_NAME, 
		_A_C_NAME, 
		_A_C_PHONE, 
		_A_TYPE, 
		_A_DESKRIPTION
		);

	SELECT  `A_ID` 
	INTO ACC_ID
	FROM `clients_account`
	ORDER BY A_ID
	DESC LIMIT 1 ;

	INSERT 
	INTO `accounts_receipt_info`( `C_ACOUNT_ID`, `C_ANAME`, R_TOTAL, R_CREATED_AT )
	VALUES ( ACC_ID, _A_C_NAME, 00.0, _CREATED_AT );

	INSERT 
	INTO `accounts_cash_info`(`C_ACOUNT_ID`, C_ACC_TYPE, C_ANAME, `C_CASH_TOTAL`, C_CREATED_AT) 
	VALUES ( ACC_ID, _A_TYPE, _A_C_NAME, 00.0 , _CREATED_AT );


END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_DEVICE_REPAIRING` (IN `_R_OWNER_NAME` VARCHAR(30) CHARSET utf8mb4, IN `_R_OWNER_PHONE` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_NAME` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_TYPE` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_STATE` VARCHAR(255) CHARSET utf8mb4, IN `_R_COST` DOUBLE, IN `_R_IS_PAY` BOOLEAN, IN `_R_IS_REPAIR` BOOLEAN, IN `_R_IS_DELIVERED` BOOLEAN, IN `_R_NOTE` VARCHAR(255) CHARSET utf8mb4, `_R_CREATED_AT` DATETIME)  BEGIN
	INSERT 
	INTO `repair`(
		`R_OWNER_NAME`, 
		`R_OWNER_PHONE`, 
		`R_DEVICE_NAME`, 
		`R_DEVICE_TYPE`, 
		`R_DEVICE_STATE`, 
		`R_COST`,
		`R_IS_PAY`, 
		`R_IS_REPAIR`, 
		`R_IS_DELIVERED`, 
		`R_NOTE`,
		R_CREATED_AT)
	VALUES  (
		_R_OWNER_NAME, 
		_R_OWNER_PHONE,  
		_R_DEVICE_NAME,  
		_R_DEVICE_TYPE,  
		_R_DEVICE_STATE,  
		_R_COST,
		_R_IS_PAY,   
		_R_IS_REPAIR,  
		_R_IS_DELIVERED, 
		_R_NOTE,
		_R_CREATED_AT);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_PRODUCT` (`_P_NAME` VARCHAR(255), `_P_PRICE` DOUBLE, `_P_PRICE_SELL` DOUBLE, `_P_QUANTITY` INT(30), `_P_DESKRIPTION` TEXT, `_P_BARCODE` VARCHAR(255), `_P_CATE_ID` INT(11), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	INSERT 
	INTO 
		`PRODUCTs`(
			 `P_NAME`, 
			 `P_PRICE`, 
			 `P_PRICE_SELL`, 
			 `P_QUANTITY`, 
			 `P_DESKRIPTION`,
			 `P_BARCODE`,
			 `P_CATE_ID`,
			 `P_IS_ITEM_INNER`) 
	VALUES (
		     _P_NAME, 
			 _P_PRICE, 
			 _P_PRICE_SELL, 
			 _P_QUANTITY, 
			 _P_DESKRIPTION,
			 _P_BARCODE,
			 _P_CATE_ID,
			 _P_IS_ITEM_INNER);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_RECEIPT_INFO` (`_R_I_NAME` VARCHAR(255), `_R_I_PHONE` VARCHAR(255), `_R_I_TOTAL` DOUBLE, `_R_I_DISCOUNT` DOUBLE, `_R_I_TYPE` VARCHAR(255), `_R_I_NO` VARCHAR(30), `_R_I_CREATED_AT` DATETIME)  BEGIN

INSERT INTO `receipt_info`
			(`R_I_NAME`, 
			`R_I_PHONE`, 
			`R_I_TOTAL`,
			`R_I_DISCOUNT`,
			`R_I_TYPE`, 
			`R_I_NO`,  
			`R_I_CREATED_AT`) 
	VALUES (
	 _R_I_NAME,  
	 _R_I_PHONE, 
	 _R_I_TOTAL, 
	 _R_I_DISCOUNT,
	 _R_I_TYPE,  
	 _R_I_NO, 
	 _R_I_CREATED_AT );
	SELECT LAST_INSERT_ID();

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_RECEIPT_ITEMS` (IN `_R_ITEM_NAME` VARCHAR(30), IN `_R_ITEM_PRODUCT_ID` INT(11), IN `_R_ITEM_PRICE` DOUBLE, IN `_R_ITEM_COUNT` INT(11), IN `_R_ITEM_DISCOUNT` DOUBLE, IN `_R_ITEM_TOTAL` DOUBLE, IN `_R_ITEM_FINAL_TOTAL` DOUBLE, IN `_R_INFO_NO` VARCHAR(30), IN `_R_ITEM_CRETED_AT` DATETIME)  BEGIN

	DECLARE BUY_PRICE DOUBLE DEFAULT 0;
	    
    SELECT P_PRICE_SELL
    INTO BUY_PRICE
    FROM products
	WHERE P_ID = _R_ITEM_PRODUCT_ID;
	
	INSERT INTO `receipt_ITEMS`
		(`R_ITEM_NAME`, 
		`R_ITEM_PRODUCT_ID`, 
		`R_ITEM_PRICE`, 
		`R_ITEM_BUY_PRICE`, 
		`R_TOTAL_BUY_PRICE`,
		`R_ITEM_COUNT`, 
		`R_ITEM_DISCOUNT`,  
		`R_ITEM_TOTAL`, 
		`R_ITEM_FINAL_TOTAL`, 
		`R_INFO_NO`, 
		`R_ITEM_CRETED_AT`) 
	VALUES 
		(_R_ITEM_NAME, 
		_R_ITEM_PRODUCT_ID, 
		_R_ITEM_PRICE,
		BUY_PRICE, 
		BUY_PRICE * _R_ITEM_COUNT , 
		_R_ITEM_COUNT,
		_R_ITEM_DISCOUNT,
		_R_ITEM_TOTAL, 
		_R_ITEM_FINAL_TOTAL, 
		_R_INFO_NO, 
		_R_ITEM_CRETED_AT);

	UPDATE 
		`products` 
	SET 
		`P_QUANTITY`= P_QUANTITY  -  _R_ITEM_COUNT 
		
	WHERE P_ID = _R_ITEM_PRODUCT_ID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_RECEIPT_ITEMS2` (IN `_R_ITEM_NAME` VARCHAR(255), IN `_R_ITEM_PRICE` DOUBLE, IN `_R_ITEM_QUANTITY` INT(11), IN `_R_ITEM_DISCOUNT` DOUBLE, IN `_R_ITEM_TOTAL` DOUBLE, IN `_R_ITEM_TOTAL_DIS` DOUBLE, IN `_R_ITEM_PRODUCT_ID` INT(11), IN `_R_ITEM_ADDED_AT` DATETIME)  BEGIN

	DECLARE BUY_PRICE DOUBLE DEFAULT 0;
	    
    SELECT P_PRICE_SELL
    INTO BUY_PRICE
    FROM products
	WHERE P_ID = _R_ITEM_PRODUCT_ID;

	
	INSERT 
	INTO 
		`receipt` (
			`R_ITEM_NAME`, 
			`R_ITEM_PRICE`,
            `R_ITEM_PRICE_SELL`,
            `R_TOTAL_PRICE_SELL`,
			`R_ITEM_QUANTITY`, 
			`R_ITEM_DISCOUNT`, 
			`R_ITEM_TOTAL`, 
			`R_ITEM_TOTAL_DIS`,
			`R_ITEM_PRODUCT_ID`, 
			`R_ITEM_ADDED_AT`) 
	VALUES (
		_R_ITEM_NAME, 
		_R_ITEM_PRICE,
         BUY_PRICE,
	     BUY_PRICE * _R_ITEM_QUANTITY,
		_R_ITEM_QUANTITY, 
		_R_ITEM_DISCOUNT, 
		_R_ITEM_TOTAL,
		_R_ITEM_TOTAL_DIS,
		_R_ITEM_PRODUCT_ID, 
		_R_ITEM_ADDED_AT);
        
	UPDATE 
		`products` 
	SET 
		`P_QUANTITY`= P_QUANTITY  -  _R_ITEM_QUANTITY 
		
	WHERE P_ID = _R_ITEM_PRODUCT_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECk_IS_BARCODE_EXISTS` (`_P_BARCODE` VARCHAR(255))  BEGIN
	SELECT * FROM `products` WHERE P_BARCODE = _P_BARCODE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECk_IS_CATEGORY_EXISTS` (`_C_NAME` VARCHAR(255))  BEGIN
	SELECT * FROM `categories` WHERE C_NAME = _C_NAME;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_IS_PRODUCT_EXISTS` (`_P_NAME` VARCHAR(255), `_P_BARCODE` BOOL)  BEGIN
	SELECT 
		* 
	FROM 
		`products` 
	WHERE 
		P_NAME =_P_NAME 
		AND 
		P_BARCODE = _P_BARCODE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_IS_PRODUCT_TYPE` (`_P_NAME` VARCHAR(255), `_P_BARCODE` VARCHAR(255), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	SELECT 
		`P_ID`, 
		`P_NAME`, 
		`P_PRICE`, 
		`P_PRICE_SELL`, 
		`P_QUANTITY`, 
		`P_DESKRIPTION`, 
		`P_BARCODE`, 
		`P_CATE_ID`, 
		`P_IS_ITEM_INNER` 
	FROM 
		`products` 
	WHERE 
		P_NAME = _P_NAME 
		AND 
		P_BARCODE = _P_BARCODE 
		AND 
		P_IS_ITEM_INNER = _P_IS_ITEM_INNER;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_IS_PRODUCT_TYPE_AND_CODE` (`_P_BARCODE` VARCHAR(255), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	SELECT 
		`P_ID`, 
		`P_NAME`, 
		`P_PRICE`, 
		`P_PRICE_SELL`, 
		`P_QUANTITY`, 
		`P_DESKRIPTION`, 
		`P_BARCODE`, 
		`P_CATE_ID`, 
		`P_IS_ITEM_INNER` 
	FROM 
		`products` 
	WHERE 
		P_BARCODE = _P_BARCODE 
		AND 
		P_IS_ITEM_INNER = _P_IS_ITEM_INNER;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_IS_PRODUCT_TYPE_AND_NAME` (`_P_NAME` VARCHAR(255), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	SELECT 
		`P_ID`, 
		`P_NAME`, 
		`P_PRICE`, 
		`P_PRICE_SELL`, 
		`P_QUANTITY`, 
		`P_DESKRIPTION`, 
		`P_BARCODE`, 
		`P_CATE_ID`, 
		`P_IS_ITEM_INNER` 
	FROM 
		`products` 
	WHERE 
		P_NAME = _P_NAME 
		AND 
		P_IS_ITEM_INNER = _P_IS_ITEM_INNER;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_PASSWORD` (`_U_NAME` VARCHAR(11), `_OLD_PASS` VARCHAR(11))  BEGIN
	SELECT `ID`, `U_NAME`, `PWD`, `USER_TYPE` FROM `tbl_users` WHERE U_NAME = _U_NAME AND PWD = _OLD_PASS;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECk_PRODUCT_QUANTITY` (`_P_ID` INT(11))  BEGIN
	SELECT P_QUANTITY FROM `products` WHERE P_ID = _P_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_DEVICE` (`_R_ID` INT)  BEGIN
	DELETE FROM `repair` WHERE R_ID = _R_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_PRODUCT` (`_P_ID` INT(11))  BEGIN
	DELETE FROM `products` WHERE P_ID = _P_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DELETE_RECEIPT` (`_R_I_ID` INT(11))  BEGIN
	DELETE FROM `receipt_info` WHERE R_I_ID = _R_I_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ACOUNT_RECEIPT_ITEMS` (IN `_A_R_INFO_CODE` VARCHAR(30))  BEGIN
	SELECT 
		`AR_ID` as "الرقم", 
		`A_R_INFO_CODE` as "رقم الفاتورة", 
		`AR_ITEM_NAME` as " اسم الصنف", 
		`AR_ITEM_PROD_ID` as "رقم الصنف", 
		`AR_ITEM_TYPE` as "نوع الصنف", 
		`AR_ITEM_QUANTITY` as "الكمية", 
		`AR_PRICE` as "السعر", 
		`AR_TOTAL_PRICE` as "الجمالي سعر الكمية", 
		`AR_CREATED_AT` as "تحرر في" 
	FROM 
		`accounts_receipt_items` 
	WHERE 
		A_R_INFO_CODE = _A_R_INFO_CODE
	ORDER BY `AR_ID` DESC;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_ACCOUNT_CASH` (IN `_C_ID` INT(11))  BEGIN
	SELECT
		 `C_ID` as "الرقم", 
		 `C_ACOUNT_ID` as "رقم الحساب", 
		 `C_ACC_TYPE` as "نوع الحساب", 
		 `C_ANAME` as "اسم العميل", 
		 `C_CASH_TOTAL` as "المبلغ", 
		 `C_NOTE` as " ملاحظات ", 
		 `C_CREATED_AT` as "تحرر في" 
	FROM 
		`accounts_cash_info` 
	WHERE 
		C_ACOUNT_ID = _C_ID
	ORDER BY `C_ID` DESC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_ACCOUNT_RECEIPT` (IN `_C_ACOUNT_ID` INT(11))  BEGIN
	SELECT 
		`A_R_ID` as "الرقم", 
                `C_ACOUNT_ID` as "رقم الحساب", 
                `C_ANAME` as "اسم العميل", 
                `R_TOTAL` as "المبلغ", 
                `R_CODE` as "رقم الفاتورة", 
                `R_CREATED_AT` as "تحرر في" 
	FROM 
		 `accounts_receipt_info` 
	WHERE 
		 C_ACOUNT_ID = _C_ACOUNT_ID
	ORDER BY `A_R_ID` DESC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_CATEGORIES` ()  BEGIN	
	SELECT * FROM categories;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_CLIENTS_ACCOUNT` (IN `_A_TYPE` VARCHAR(30))  BEGIN
	SELECT
		 `A_ID` AS "الرقم", 
		 `A_STORE_NAME` AS "اسم المحل", 
		 `A_C_NAME` AS "اسم العميل", 
		 `A_C_PHONE` AS "رقم الهاتف",
		 `A_TYPE` AS "نوع الحساب", 
		`A_RECEIPT_VAL` AS "قيمة الفواتير", 
		`A_CASH_VAL` AS "قيمة النقدية", 
		A_RECEIPT_VAL -  A_CASH_VAL as "الصافي",
		 `A_DESKRIPTION` AS "الوصف" 
	FROM 
		`clients_account`
	WHERE
		A_TYPE = _A_TYPE;
    -- INNER JOIN 
		-- accounts_receipt_info 
	-- ON 
		-- accounts_receipt_info.C_ACOUNT_ID=clients_account.A_ID;
    -- INNER JOIN 
		-- accounts_cash_info 
	-- ON 
		-- accounts_cash_info.C_ACOUNT_ID=clients_account.A_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_DEVICE_REPAIRING` ()  BEGIN
	SELECT
		`R_ID` as "الرقم", 
		`R_OWNER_NAME` as "ااسم العميل", 
		`R_OWNER_PHONE` as "هاتف العميل", 
		`R_DEVICE_NAME` as "اسم الجهاز", 
		`R_DEVICE_TYPE` as "نوع الجهاز", 
		`R_DEVICE_STATE` as " العطل",
                `R_COST` as "التكلفه" ,
		`R_IS_PAY` as "تم الدفع",		
		`R_IS_REPAIR` as "تم التصليح", 
		`R_IS_DELIVERED` as "تم التسليم", 
		`R_NOTE` as "ملاحظات",
        `R_CREATED_AT` as "التاريخ"
	 FROM `repair`
     ORDER BY `R_ID` DESC;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_PRODUCTS` (IN `_P_IS_ITEM_INNER` INT)  BEGIN
	SELECT 
		`P_ID` as "الرقم", 
		`P_NAME` as "الصنف", 
		`P_PRICE` as "سعر البيع",
        `P_PRICE_SELL` as "السعر", 
		`P_QUANTITY` as "الكميه",
        `P_PRICE` * `P_QUANTITY` as "مجموع الكميه وسعر البيع",
        `P_PRICE_SELL` * `P_QUANTITY` as "مجموع الكميه والسعر",
		(P_PRICE * P_QUANTITY) - (P_PRICE_SELL * P_QUANTITY) as "صافي الربح",
        `P_BARCODE` as "كود",
        `P_IS_ITEM_INNER` as "النوع",
        `C_NAME` as "القسم",
        `P_DESKRIPTION` as "الوصف"
	FROM 
		`products`
    INNER JOIN categories ON categories.C_ID=products.P_CATE_ID
	WHERE
    	P_IS_ITEM_INNER = _P_IS_ITEM_INNER

    ORDER BY `P_ID` DESC;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_ALL_RECEIPT_INFO` ()  BEGIN
	SELECT 
		`R_I_ID` as "الرقم", 
		`R_I_NAME` as "اسم العميل", 
		`R_I_PHONE` as "هاتف ", 
		`R_I_TOTAL` as "الاجمالي", 
		`R_I_TYPE` as "النوع",
        `R_I_NO` as "رقم الفاتورة",
		`R_I_CREATED_AT` as "تحرر في يوم"
	 FROM `receipt_info`
     ORDER BY `R_I_ID` DESC;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_CLIENTS_ACC_CRED_STATISTICS` ()  NO SQL
BEGIN
    
    SELECT 
       SUM(A_CASH_VAL) AS "مجموع المبلغ دائن المسدد",
       SUM(A_RECEIPT_VAL) AS "مجموع مبلع الفواتير الدائن ",
       SUM(A_RECEIPT_VAL) - SUM(A_CASH_VAL) AS " صافي المبلغ المطلوب سداده "
   
   FROM 
    	clients_account

    WHERE
    	A_TYPE = "دائن";
    	
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_CLIENTS_ACC_DEBIT_STATISTICS` ()  NO SQL
BEGIN

	SELECT 
       SUM(A_CASH_VAL) AS "مجموع المبلغ المدين المحصل",
       SUM(A_RECEIPT_VAL) AS "مجموع مبلع الفواتير المدين",
   	   SUM(A_RECEIPT_VAL) - SUM(A_CASH_VAL) AS " صافي المبلغ المطلوب تحصيله "
   
   FROM 
    	clients_account

    WHERE
    	A_TYPE = "مدين";
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_DEVICE_REPAIRING` (IN `_R_ID` INT(11))  BEGIN
	SELECT 
		R_OWNER_NAME,
		R_OWNER_PHONE,
		R_DEVICE_STATE,
        R_NOTE,
        R_CREATED_AT
	FROM 
		`repair` 
	WHERE 
		R_ID =_R_ID ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_PRODUCTS_STATISTICS` ()  SELECT 
    SUM(`P_PRICE`) AS " محموع سعر كل الاصناف بسعر البيع ", 
    SUM(`P_PRICE_SELL`) AS "محموع سعر كل الاصناف بسعر الشراء",
    SUM(`P_PRICE`) - SUM(`P_PRICE_SELL`) AS "صافي ريح المحل",
    SUM(`P_QUANTITY`) AS " عدد كل اصناف المحل"
FROM 
	`products`$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_REPAIR_STATISTICS` ()  BEGIN
	SELECT 
		DATE(`R_CREATED_AT`) as "التاريخ",  
		SUM(`R_COST`)  AS " مجموع تكلفة صيانة يوم "
	FROM 
		`repair` 
	WHERE
		R_IS_PAY = TRUE
	GROUP BY  DATE(R_CREATED_AT) DESC;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_SALES_STATISTICS` ()  BEGIN
	SELECT 
		DATE(`R_ITEM_CRETED_AT`) as "التاريخ", 
        SUM(`R_ITEM_FINAL_TOTAL`) as " صافي اجمالي الدخل", 	    				   		   SUM(`R_TOTAL_BUY_PRICE`) as "اجمالي الدخل بسعر البيع",
        SUM(`R_ITEM_FINAL_TOTAL`) - SUM(`R_TOTAL_BUY_PRICE`) as "صافي الربح",
		SUM(`R_ITEM_COUNT`) as "عدد القطع المباعه",
        SUM(`R_ITEM_DISCOUNT`) as "اجمالي_الخصومات"

	FROM `receipt_items`
	GROUP BY  DATE(R_ITEM_CRETED_AT) DESC;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_PRODUCT` (`_P_NAME` VARCHAR(255))  BEGIN
	SELECT * FROM `products` WHERE P_NAME = _P_NAME;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_PRODUCT_BARCODE` (`_P_BARCODE` VARCHAR(30), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	SELECT * FROM `products` WHERE P_BARCODE = _P_BARCODE AND P_IS_ITEM_INNER = _P_IS_ITEM_INNER ;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_PRODUCT_BY_CODE` (IN `_P_IS_ITEM_INNER` INT, IN `_P_BARCODE` VARCHAR(255))  BEGIN
	SELECT
    
    	`P_ID` as "الرقم", 
		`P_NAME` as "الاسم", 
		`P_PRICE` as "سعر البيع",
        `P_PRICE_SELL` as "السعر", 
		`P_QUANTITY` as "الكميه",
        `P_PRICE` * `P_QUANTITY` as "مجموع الكميه وسعر البيع",
        `P_PRICE_SELL` * `P_QUANTITY` as "مجموع الكميه والسعر",
		(P_PRICE * P_QUANTITY) - (P_PRICE_SELL * P_QUANTITY) as "صافي الربح",
        `P_BARCODE` as "كود",
        `P_IS_ITEM_INNER` as "النوع" ,
        `P_DESKRIPTION` as "الوصف"
    
    FROM `products` WHERE  P_IS_ITEM_INNER = _P_IS_ITEM_INNER AND P_BARCODE = _P_BARCODE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_RECEIPT_BY_NO` (IN `_R_I_NO` VARCHAR(30))  BEGIN
	SELECT 
	`R_I_ID` as "الرقم", 
		`R_I_NAME` as "اسم العميل", 
		`R_I_PHONE` as "هاتف ", 
		`R_I_TOTAL` as "الاجمالي", 
		`R_I_TYPE` as "النوع",
        `R_I_NO` as "رقم الفاتورة",
		`R_I_CREATED_AT` as "تحرر في يوم"
	 FROM `receipt_info`
	 WHERE 
	 R_I_NO = _R_I_NO;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_RECEIPT_ITEMS` (IN `_R_I_NO` VARCHAR(30))  BEGIN
	SELECT 
    	 `R_ITEM_NAME` as "الاسم", 
         `R_ITEM_PRICE` as "السعر", 
         `R_ITEM_COUNT` as "الكمية",
         `R_ITEM_DISCOUNT` as "الخصم",
         `R_ITEM_TOTAL` as "مجموع قبل الخصم",
         `R_ITEM_FINAL_TOTAL` as "مجموع بعد الخصم",
         `R_ITEM_CRETED_AT` AS "تاريخ البيع"
    FROM `receipt_items` WHERE R_INFO_NO = _R_I_NO;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SEARCH_REPAIRING` (IN `_R_OWNER_PHONE` VARCHAR(30))  BEGIN
	SELECT
		`R_ID` as "الرقم", 
		`R_OWNER_NAME` as "اسم العميل", 
		`R_OWNER_PHONE` as "هاتف العميل", 
		`R_DEVICE_NAME` as "اسم الجهاز", 
		`R_DEVICE_TYPE` as "نوع الجهاز", 
		`R_DEVICE_STATE` as " العطل",
        `R_COST` as "التكلفه" ,
		`R_IS_PAY` as "اتم الدفع",		
		`R_IS_REPAIR` as "تم التصليح", 
		`R_IS_DELIVERED` as "تم التسليم", 
		`R_NOTE` as "ملاحظات"
	 FROM `repair`
	 WHERE 
		R_OWNER_PHONE = _R_OWNER_PHONE;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LOGIN` (`_U_NAME` VARCHAR(255), `_PWD` VARCHAR(255))  BEGIN

	SELECT * FROM tbl_users WHERE U_NAME=_U_NAME AND PWD=_PWD;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_CLIENT_ACCOUNT` (`_A_ID` INT(11), `_A_STORE_NAME` VARCHAR(30), `_A_C_NAME` VARCHAR(255), `_A_C_PHONE` INT(11), `_A_TYPE` VARCHAR(30), `_A_DESKRIPTION` TEXT)  BEGIN
	UPDATE 
		`clients_account` 
	SET 
		`A_STORE_NAME`=_A_STORE_NAME,
		`A_C_NAME`=_A_C_NAME,
		`A_C_PHONE`=_A_C_PHONE,
		`A_TYPE`=_A_TYPE,
		`A_DESKRIPTION`=_A_DESKRIPTION
	WHERE A_ID = _A_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_DEVICE` (IN `_R_ID` INT(11), IN `_R_OWNER_NAME` VARCHAR(30) CHARSET utf8mb4, IN `_R_OWNER_PHONE` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_NAME` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_TYPE` VARCHAR(30) CHARSET utf8mb4, IN `_R_DEVICE_STATE` VARCHAR(255) CHARSET utf8mb4, IN `_R_COST` DOUBLE, IN `_R_IS_PAY` BOOLEAN, IN `_R_IS_REPAIR` BOOLEAN, IN `_R_IS_DELIVERED` BOOLEAN, IN `_R_NOTE` VARCHAR(255) CHARSET utf8mb4)  BEGIN
	UPDATE `repair`
	SET 

		`R_OWNER_NAME`=_R_OWNER_NAME,
		`R_OWNER_PHONE`=_R_OWNER_PHONE,
		`R_DEVICE_NAME`=_R_DEVICE_NAME,
		`R_DEVICE_TYPE`=_R_DEVICE_TYPE,
		`R_DEVICE_STATE`=_R_DEVICE_STATE,
		`R_COST` = _R_COST,
		`R_IS_PAY`=_R_IS_PAY,
		`R_IS_REPAIR`=_R_IS_REPAIR,
		`R_IS_DELIVERED`=_R_IS_DELIVERED,
		`R_NOTE`=_R_NOTE
	WHERE R_ID = _R_ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_PASSWORD` (`_ID` INT(11), `_NEW_PASS` VARCHAR(255))  BEGIN
	UPDATE `tbl_users` SET `PWD`=_NEW_PASS  WHERE ID = _ID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UPDATE_PRODUCT` (`_P_ID` INT(11), `_P_NAME` VARCHAR(255), `_P_PRICE` DOUBLE, `_P_PRICE_SELL` DOUBLE, `_P_QUANTITY` INT(30), `_P_DESKRIPTION` TEXT, `_P_BARCODE` VARCHAR(255), `_P_CATE_ID` INT(11), `_P_IS_ITEM_INNER` BOOL)  BEGIN
	UPDATE 
		`products` 
	SET 
		`P_NAME`=_P_NAME,
		`P_PRICE`=_P_PRICE,
		`P_PRICE_SELL`=_P_PRICE_SELL,
		`P_QUANTITY`=_P_QUANTITY,
		`P_DESKRIPTION`=_P_DESKRIPTION,
		`P_BARCODE` = _P_BARCODE,
		`P_CATE_ID`= _P_CATE_ID,
		`P_IS_ITEM_INNER` = _P_IS_ITEM_INNER
	WHERE 
		 P_ID = _P_ID;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `accounts_cash_info`
--

CREATE TABLE `accounts_cash_info` (
  `C_ID` int(11) NOT NULL,
  `C_ACOUNT_ID` int(11) NOT NULL,
  `C_ACC_TYPE` varchar(30) NOT NULL,
  `C_ANAME` varchar(30) NOT NULL,
  `C_CASH_TOTAL` double NOT NULL,
  `C_NOTE` text NOT NULL,
  `C_CREATED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `accounts_cash_info`
--

INSERT INTO `accounts_cash_info` (`C_ID`, `C_ACOUNT_ID`, `C_ACC_TYPE`, `C_ANAME`, `C_CASH_TOTAL`, `C_NOTE`, `C_CREATED_AT`) VALUES
(1, 1, 'مدين', 'حسين السيد', 0, '', '2020-09-15 15:45:55'),
(2, 2, 'مدين', 'خالد حسام', 0, '', '2020-09-15 15:51:46'),
(3, 1, 'مدين', 'حسين السيد', 200, 'مجهولة برص مجموعة من الأحرف بشكل عشوائي أخذتها من نص، لتكوّن كتيّب بمثابة دليل أو مرجع شكلي لهذه الأحرف', '2020-09-15 16:21:03'),
(4, 3, 'دائن', 'werw', 0, '', '2020-09-16 00:34:47');

-- --------------------------------------------------------

--
-- Table structure for table `accounts_receipt_info`
--

CREATE TABLE `accounts_receipt_info` (
  `A_R_ID` int(11) NOT NULL,
  `C_ACOUNT_ID` int(11) NOT NULL,
  `C_ANAME` varchar(30) NOT NULL,
  `R_TOTAL` double NOT NULL,
  `R_CODE` varchar(30) NOT NULL,
  `R_CREATED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `accounts_receipt_info`
--

INSERT INTO `accounts_receipt_info` (`A_R_ID`, `C_ACOUNT_ID`, `C_ANAME`, `R_TOTAL`, `R_CODE`, `R_CREATED_AT`) VALUES
(1, 1, 'حسين السيد', 0, '', '2020-09-15 15:45:55'),
(2, 2, 'خالد حسام', 0, '', '2020-09-15 15:51:46'),
(3, 1, 'حسين السيد', 326, '201915fh5f', '2020-09-15 16:19:56'),
(4, 1, 'حسين السيد', 19.25, '203216jieg', '2020-09-16 00:32:22'),
(5, 1, 'حسين السيد', 96.25, '203416v11h', '2020-09-16 00:34:06'),
(6, 3, 'werw', 0, '', '2020-09-16 00:34:47'),
(7, 3, 'werw', 192.5, '2035163968', '2020-09-16 00:35:10');

-- --------------------------------------------------------

--
-- Table structure for table `accounts_receipt_items`
--

CREATE TABLE `accounts_receipt_items` (
  `AR_ID` int(11) NOT NULL,
  `A_R_INFO_CODE` varchar(30) NOT NULL,
  `AR_ITEM_NAME` varchar(255) NOT NULL,
  `AR_ITEM_PROD_ID` int(11) NOT NULL,
  `AR_ITEM_TYPE` varchar(30) NOT NULL,
  `AR_ITEM_QUANTITY` int(30) NOT NULL,
  `AR_PRICE` double NOT NULL,
  `AR_TOTAL_PRICE` double NOT NULL,
  `AR_CREATED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `accounts_receipt_items`
--

INSERT INTO `accounts_receipt_items` (`AR_ID`, `A_R_INFO_CODE`, `AR_ITEM_NAME`, `AR_ITEM_PROD_ID`, `AR_ITEM_TYPE`, `AR_ITEM_QUANTITY`, `AR_PRICE`, `AR_TOTAL_PRICE`, `AR_CREATED_AT`) VALUES
(1, '201915fh5f', 'شاحن ايفون', 41, ' قطع داخلي ', 12, 19.25, 231, '2020-09-15 16:19:57'),
(2, '201915fh5f', 'شاحن سامسونج', 40, ' قطع داخلي ', 5, 19, 95, '2020-09-15 16:19:57'),
(3, '203216jieg', 'شاحن ايفون', 41, ' قطع داخلي ', 1, 19.25, 19.25, '2020-09-16 00:32:22'),
(4, '203416v11h', 'شاحن ايفون', 41, ' قطع داخلي ', 5, 19.25, 96.25, '2020-09-16 00:34:06'),
(5, '2035163968', 'شاحن ايفون', 41, ' قطع داخلي ', 10, 19.25, 192.5, '2020-09-16 00:35:10');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `C_ID` int(11) NOT NULL,
  `C_NAME` varchar(255) NOT NULL,
  `C_DESKRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`C_ID`, `C_NAME`, `C_DESKRIPTION`) VALUES
(10, 'شواحن', '');

-- --------------------------------------------------------

--
-- Table structure for table `clients_account`
--

CREATE TABLE `clients_account` (
  `A_ID` int(11) NOT NULL,
  `A_STORE_NAME` varchar(30) NOT NULL,
  `A_C_NAME` varchar(255) NOT NULL,
  `A_C_PHONE` int(11) NOT NULL,
  `A_TYPE` varchar(30) NOT NULL,
  `A_CASH_OPERATION_ID` int(11) NOT NULL,
  `A_RECEIPT_ID` int(11) NOT NULL,
  `A_RECEIPT_VAL` double NOT NULL,
  `A_CASH_VAL` double NOT NULL,
  `A_ACTIVE` tinyint(1) NOT NULL,
  `A_DESKRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clients_account`
--

INSERT INTO `clients_account` (`A_ID`, `A_STORE_NAME`, `A_C_NAME`, `A_C_PHONE`, `A_TYPE`, `A_CASH_OPERATION_ID`, `A_RECEIPT_ID`, `A_RECEIPT_VAL`, `A_CASH_VAL`, `A_ACTIVE`, `A_DESKRIPTION`) VALUES
(1, 'السيد للصيانه', 'حسين السيد', 1155721425, 'مدين', 0, 0, 441.5, 200, 0, 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة'),
(2, 'الامل للجملة ', 'خالد حسام', 1550314558, 'مدين', 0, 0, 0, 0, 0, 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة'),
(3, 'rrrr', 'werw', 35346, 'دائن', 0, 0, 192.5, 0, 0, 'wetweryweryer');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `P_ID` int(11) NOT NULL,
  `P_NAME` varchar(255) NOT NULL,
  `P_PRICE` double NOT NULL,
  `P_PRICE_SELL` double NOT NULL,
  `P_QUANTITY` int(30) NOT NULL,
  `P_DESKRIPTION` text NOT NULL,
  `P_BARCODE` varchar(255) NOT NULL,
  `P_CATE_ID` int(11) NOT NULL,
  `P_IS_ITEM_INNER` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`P_ID`, `P_NAME`, `P_PRICE`, `P_PRICE_SELL`, `P_QUANTITY`, `P_DESKRIPTION`, `P_BARCODE`, `P_CATE_ID`, `P_IS_ITEM_INNER`) VALUES
(40, 'شاحن سامسونج', 19, 12.5, 1, 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة', '50d', 10, 1),
(41, 'شاحن ايفون', 19.25, 14, 10, 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة', '60g', 10, 1);

-- --------------------------------------------------------

--
-- Table structure for table `receipt_info`
--

CREATE TABLE `receipt_info` (
  `R_I_ID` int(11) NOT NULL,
  `R_I_NAME` varchar(255) NOT NULL,
  `R_I_PHONE` varchar(255) NOT NULL,
  `R_I_TOTAL` double NOT NULL,
  `R_I_DISCOUNT` double NOT NULL,
  `R_I_TYPE` varchar(255) NOT NULL,
  `R_I_NO` varchar(255) NOT NULL,
  `R_I_CREATED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `receipt_info`
--

INSERT INTO `receipt_info` (`R_I_ID`, `R_I_NAME`, `R_I_PHONE`, `R_I_TOTAL`, `R_I_DISCOUNT`, `R_I_TYPE`, `R_I_NO`, `R_I_CREATED_AT`) VALUES
(1, 'new client name', 'new client phone', 71.25, 5, 'مبيعات', '2006153nms', '2020-09-15 17:06:17'),
(2, 'new client name', 'new client phone', 69, 8, 'مبيعات', '202415ni0p', '2020-09-15 17:24:49'),
(3, 'new client name', 'new client phone', 111.5, 2.5, 'مبيعات', '203615erxi', '2020-09-15 17:36:40'),
(4, 'new client name', 'new client phone', 14.5, 4.5, 'مبيعات', '203915l6j5', '2020-09-15 17:39:14'),
(5, 'new client name', 'new client phone', 87, 8, 'مبيعات', '202416m2qc', '2020-09-16 16:24:02'),
(6, 'new client name', 'new client phone', 161.25, 11, 'مبيعات', '200020ctpi', '2020-09-20 10:00:17');

-- --------------------------------------------------------

--
-- Table structure for table `receipt_items`
--

CREATE TABLE `receipt_items` (
  `R_ITEM_ID` int(11) NOT NULL,
  `R_ITEM_NAME` varchar(255) NOT NULL,
  `R_ITEM_PRODUCT_ID` int(11) NOT NULL,
  `R_ITEM_PRICE` double NOT NULL,
  `R_ITEM_BUY_PRICE` double NOT NULL,
  `R_TOTAL_BUY_PRICE` double NOT NULL,
  `R_ITEM_COUNT` int(11) NOT NULL,
  `R_ITEM_DISCOUNT` double NOT NULL,
  `R_ITEM_TOTAL` double NOT NULL,
  `R_ITEM_FINAL_TOTAL` double NOT NULL,
  `R_INFO_NO` varchar(255) NOT NULL,
  `R_ITEM_CRETED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `receipt_items`
--

INSERT INTO `receipt_items` (`R_ITEM_ID`, `R_ITEM_NAME`, `R_ITEM_PRODUCT_ID`, `R_ITEM_PRICE`, `R_ITEM_BUY_PRICE`, `R_TOTAL_BUY_PRICE`, `R_ITEM_COUNT`, `R_ITEM_DISCOUNT`, `R_ITEM_TOTAL`, `R_ITEM_FINAL_TOTAL`, `R_INFO_NO`, `R_ITEM_CRETED_AT`) VALUES
(1, 'شاحن سامسونج', 40, 19, 12.5, 37.5, 3, 5, 57, 52, '2006153nms', '2020-09-15 17:06:18'),
(2, 'شاحن ايفون', 41, 19.25, 14, 14, 1, 0, 19.25, 19.25, '2006153nms', '2020-09-15 17:06:18'),
(3, 'شاحن ايفون', 41, 19.25, 14, 56, 4, 8, 77, 69, '202415ni0p', '2020-09-15 17:24:49'),
(4, 'شاحن سامسونج', 40, 19, 12.5, 75, 6, 2, 114, 111.5, '203615erxi', '2020-09-15 17:36:40'),
(5, 'شاحن سامسونج', 40, 19, 12.5, 12.5, 1, 4, 19, 14.5, '203915l6j5', '2020-09-15 17:39:14'),
(6, 'شاحن سامسونج', 40, 19, 12.5, 62.5, 5, 8, 95, 87, '202416m2qc', '2020-09-16 16:24:03'),
(7, 'شاحن ايفون', 41, 19.25, 14, 70, 5, 3, 96.25, 93.25, '200020ctpi', '2020-09-20 10:00:17'),
(8, 'شاحن سامسونج', 40, 19, 12.5, 50, 4, 8, 76, 68, '200020ctpi', '2020-09-20 10:00:17');

-- --------------------------------------------------------

--
-- Table structure for table `repair`
--

CREATE TABLE `repair` (
  `R_ID` int(11) NOT NULL,
  `R_OWNER_NAME` varchar(30) NOT NULL,
  `R_OWNER_PHONE` varchar(30) NOT NULL,
  `R_DEVICE_NAME` varchar(30) NOT NULL,
  `R_DEVICE_TYPE` varchar(30) NOT NULL,
  `R_DEVICE_STATE` varchar(255) NOT NULL,
  `R_COST` double NOT NULL,
  `R_IS_PAY` tinyint(1) NOT NULL,
  `R_IS_REPAIR` tinyint(1) NOT NULL,
  `R_IS_DELIVERED` tinyint(1) NOT NULL,
  `R_NOTE` text NOT NULL,
  `R_CREATED_AT` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `repair`
--

INSERT INTO `repair` (`R_ID`, `R_OWNER_NAME`, `R_OWNER_PHONE`, `R_DEVICE_NAME`, `R_DEVICE_TYPE`, `R_DEVICE_STATE`, `R_COST`, `R_IS_PAY`, `R_IS_REPAIR`, `R_IS_DELIVERED`, `R_NOTE`, `R_CREATED_AT`) VALUES
(1, 'احمد علي ', '01155721425', 'j4', 'سامسونج', 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة', 250, 1, 0, 0, 'المطابع ودور النشر. كان لوريم إيبسوم ولايزال المعيار للنص الشكلي منذ القرن الخامس عشر عندما قامت مطبعة', '2020-09-15 15:43:23'),
(2, 'عماد محمود', '01550314558', 'g48', 'سامسونج', 'ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت ', 15, 1, 1, 0, 'ليس هناك أي كلمات أو عبارات محرجة أو غير لائقة مخبأة في هذا النص. بينما تعمل جميع مولّدات نصوص لوريم إيبسوم على الإنترنت ', '2020-09-18 07:10:48'),
(3, 'بهاء السيد', '01144873524', 'ter54', 'نوكيا', 'لوريم إيبسوم وهي \"consectetur\"، وخلال تتبعه لهذه الكلمة في الأدب اللاتيني اكتشف المصدر الغير قابل للشك', 120, 1, 0, 0, 'لوريم إيبسوم وهي \"consectetur\"، وخلال تتبعه لهذه الكلمة في الأدب اللاتيني اكتشف المصدر الغير قابل للشك', '2020-09-18 07:44:43'),
(4, 'جلال احمد', '0155421448', 'y56', 'ايفون', 'لوريم إيبسوم وهي \"consectetur\"، وخلال تتبعه لهذه الكلمة في الأدب اللاتيني اكتشف المصدر الغير قابل للشك', 300, 0, 1, 0, 'لوريم إيبسوم وهي \"consectetur\"، وخلال تتبعه لهذه الكلمة في الأدب اللاتيني اكتشف المصدر الغير قابل للشك', '2020-10-28 07:47:07');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `ID` int(11) NOT NULL,
  `U_NAME` varchar(255) NOT NULL,
  `PWD` varchar(255) NOT NULL,
  `USER_TYPE` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`ID`, `U_NAME`, `PWD`, `USER_TYPE`) VALUES
(1, 'root', '147', 'aminstritor'),
(2, 'root2', '147', 'worder');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts_cash_info`
--
ALTER TABLE `accounts_cash_info`
  ADD PRIMARY KEY (`C_ID`),
  ADD KEY `C_ACOUNT_ID` (`C_ACOUNT_ID`) USING BTREE;

--
-- Indexes for table `accounts_receipt_info`
--
ALTER TABLE `accounts_receipt_info`
  ADD PRIMARY KEY (`A_R_ID`),
  ADD KEY `C_ACOUNT_ID` (`C_ACOUNT_ID`) USING BTREE,
  ADD KEY `R_CODE` (`R_CODE`) USING BTREE;

--
-- Indexes for table `accounts_receipt_items`
--
ALTER TABLE `accounts_receipt_items`
  ADD PRIMARY KEY (`AR_ID`),
  ADD KEY `A_R_INFO_CODE` (`A_R_INFO_CODE`,`AR_ITEM_PROD_ID`) USING BTREE,
  ADD KEY `AR_ITEM_PROD_ID` (`AR_ITEM_PROD_ID`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`C_ID`);

--
-- Indexes for table `clients_account`
--
ALTER TABLE `clients_account`
  ADD PRIMARY KEY (`A_ID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`P_ID`),
  ADD KEY `P_CATE_ID` (`P_CATE_ID`) USING BTREE;

--
-- Indexes for table `receipt_info`
--
ALTER TABLE `receipt_info`
  ADD PRIMARY KEY (`R_I_ID`),
  ADD KEY `R_I_NO` (`R_I_NO`) USING BTREE;

--
-- Indexes for table `receipt_items`
--
ALTER TABLE `receipt_items`
  ADD PRIMARY KEY (`R_ITEM_ID`),
  ADD KEY `R_ITEM_PRODUCT_ID` (`R_ITEM_PRODUCT_ID`) USING BTREE,
  ADD KEY `R_INFO_NO` (`R_INFO_NO`) USING BTREE;

--
-- Indexes for table `repair`
--
ALTER TABLE `repair`
  ADD PRIMARY KEY (`R_ID`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts_cash_info`
--
ALTER TABLE `accounts_cash_info`
  MODIFY `C_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `accounts_receipt_info`
--
ALTER TABLE `accounts_receipt_info`
  MODIFY `A_R_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `accounts_receipt_items`
--
ALTER TABLE `accounts_receipt_items`
  MODIFY `AR_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `C_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `clients_account`
--
ALTER TABLE `clients_account`
  MODIFY `A_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `P_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `receipt_info`
--
ALTER TABLE `receipt_info`
  MODIFY `R_I_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `receipt_items`
--
ALTER TABLE `receipt_items`
  MODIFY `R_ITEM_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `repair`
--
ALTER TABLE `repair`
  MODIFY `R_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_users`
--
ALTER TABLE `tbl_users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accounts_cash_info`
--
ALTER TABLE `accounts_cash_info`
  ADD CONSTRAINT `accounts_cash_info_ibfk_1` FOREIGN KEY (`C_ACOUNT_ID`) REFERENCES `clients_account` (`A_ID`);

--
-- Constraints for table `accounts_receipt_info`
--
ALTER TABLE `accounts_receipt_info`
  ADD CONSTRAINT `accounts_receipt_info_ibfk_1` FOREIGN KEY (`C_ACOUNT_ID`) REFERENCES `clients_account` (`A_ID`);

--
-- Constraints for table `accounts_receipt_items`
--
ALTER TABLE `accounts_receipt_items`
  ADD CONSTRAINT `accounts_receipt_items_ibfk_1` FOREIGN KEY (`A_R_INFO_CODE`) REFERENCES `accounts_receipt_info` (`R_CODE`),
  ADD CONSTRAINT `accounts_receipt_items_ibfk_2` FOREIGN KEY (`AR_ITEM_PROD_ID`) REFERENCES `products` (`P_ID`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`P_CATE_ID`) REFERENCES `categories` (`C_ID`);

--
-- Constraints for table `receipt_items`
--
ALTER TABLE `receipt_items`
  ADD CONSTRAINT `receipt_items_ibfk_1` FOREIGN KEY (`R_ITEM_PRODUCT_ID`) REFERENCES `products` (`P_ID`),
  ADD CONSTRAINT `receipt_items_ibfk_2` FOREIGN KEY (`R_INFO_NO`) REFERENCES `receipt_info` (`R_I_NO`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
