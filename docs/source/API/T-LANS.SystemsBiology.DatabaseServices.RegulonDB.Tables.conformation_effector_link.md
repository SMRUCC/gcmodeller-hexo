﻿---
title: conformation_effector_link
---

# conformation_effector_link
_namespace: [LANS.SystemsBiology.DatabaseServices.RegulonDB.Tables](N-LANS.SystemsBiology.DatabaseServices.RegulonDB.Tables.html)_

--
 
 DROP TABLE IF EXISTS `conformation_effector_link`;
 /*!40101 SET @saved_cs_client = @@character_set_client */;
 /*!40101 SET character_set_client = utf8 */;
 CREATE TABLE `conformation_effector_link` (
 `effector_id` char(12) NOT NULL,
 `conformation_id` char(12) NOT NULL
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 /*!40101 SET character_set_client = @saved_cs_client */;
 
 --



