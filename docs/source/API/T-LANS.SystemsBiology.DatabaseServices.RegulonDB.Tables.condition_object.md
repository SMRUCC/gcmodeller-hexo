﻿---
title: condition_object
---

# condition_object
_namespace: [LANS.SystemsBiology.DatabaseServices.RegulonDB.Tables](N-LANS.SystemsBiology.DatabaseServices.RegulonDB.Tables.html)_

--
 
 DROP TABLE IF EXISTS `condition_object`;
 /*!40101 SET @saved_cs_client = @@character_set_client */;
 /*!40101 SET character_set_client = utf8 */;
 CREATE TABLE `condition_object` (
 `cond_effect_link_id` char(12) NOT NULL,
 `object_id` char(12) NOT NULL
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 /*!40101 SET character_set_client = @saved_cs_client */;
 
 --



