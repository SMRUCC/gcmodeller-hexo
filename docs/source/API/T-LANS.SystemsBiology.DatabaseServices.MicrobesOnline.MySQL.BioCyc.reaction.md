﻿---
title: reaction
---

# reaction
_namespace: [LANS.SystemsBiology.DatabaseServices.MicrobesOnline.MySQL.BioCyc](N-LANS.SystemsBiology.DatabaseServices.MicrobesOnline.MySQL.BioCyc.html)_

--
 
 DROP TABLE IF EXISTS `reaction`;
 /*!40101 SET @saved_cs_client = @@character_set_client */;
 /*!40101 SET character_set_client = utf8 */;
 CREATE TABLE `reaction` (
 `rxnId` varchar(255) NOT NULL,
 `name` varchar(255) DEFAULT NULL,
 PRIMARY KEY (`rxnId`)
 ) ENGINE=MyISAM DEFAULT CHARSET=latin1;
 /*!40101 SET character_set_client = @saved_cs_client */;
 
 --



