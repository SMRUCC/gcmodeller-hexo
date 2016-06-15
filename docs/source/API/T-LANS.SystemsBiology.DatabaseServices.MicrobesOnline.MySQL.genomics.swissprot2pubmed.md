﻿---
title: swissprot2pubmed
---

# swissprot2pubmed
_namespace: [LANS.SystemsBiology.DatabaseServices.MicrobesOnline.MySQL.genomics](N-LANS.SystemsBiology.DatabaseServices.MicrobesOnline.MySQL.genomics.html)_

--
 
 DROP TABLE IF EXISTS `swissprot2pubmed`;
 /*!40101 SET @saved_cs_client = @@character_set_client */;
 /*!40101 SET character_set_client = utf8 */;
 CREATE TABLE `swissprot2pubmed` (
 `id` varchar(20) NOT NULL DEFAULT '',
 `accession` varchar(20) NOT NULL DEFAULT '',
 `PubMedId` int(20) unsigned NOT NULL DEFAULT '0',
 `isDetailed` tinyint(1) NOT NULL DEFAULT '0',
 KEY `accession` (`accession`),
 KEY `id` (`id`)
 ) ENGINE=MyISAM DEFAULT CHARSET=latin1;
 /*!40101 SET character_set_client = @saved_cs_client */;
 
 --



