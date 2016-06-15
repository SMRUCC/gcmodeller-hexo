﻿---
title: instance_data
---

# instance_data
_namespace: [LANS.SystemsBiology.Assembly.GeneOntology.MySQL.Tables](N-LANS.SystemsBiology.Assembly.GeneOntology.MySQL.Tables.html)_

--
 
 DROP TABLE IF EXISTS `instance_data`;
 /*!40101 SET @saved_cs_client = @@character_set_client */;
 /*!40101 SET character_set_client = utf8 */;
 CREATE TABLE `instance_data` (
 `release_name` varchar(255) DEFAULT NULL,
 `release_type` varchar(255) DEFAULT NULL,
 `release_notes` text,
 `ontology_data_version` varchar(255) DEFAULT NULL,
 UNIQUE KEY `release_name` (`release_name`)
 ) ENGINE=MyISAM DEFAULT CHARSET=latin1;
 /*!40101 SET character_set_client = @saved_cs_client */;
 
 --



