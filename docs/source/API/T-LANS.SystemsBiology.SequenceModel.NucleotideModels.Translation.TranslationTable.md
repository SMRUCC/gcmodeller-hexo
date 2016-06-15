﻿---
title: TranslationTable
---

# TranslationTable
_namespace: [LANS.SystemsBiology.SequenceModel.NucleotideModels.Translation](N-LANS.SystemsBiology.SequenceModel.NucleotideModels.Translation.html)_

transl_table=1 标准密码子表

### Methods

#### IsStopCoden
```csharp
LANS.SystemsBiology.SequenceModel.NucleotideModels.Translation.TranslationTable.IsStopCoden(System.Int32)
```
判断某一个密码子是否为终止密码子

|Parameter Name|Remarks|
|--------------|-------|
|hash|该密码子的哈希值|

_returns: 这个密码子是否为一个终止密码_

#### ToCodonCollection
```csharp
LANS.SystemsBiology.SequenceModel.NucleotideModels.Translation.TranslationTable.ToCodonCollection(LANS.SystemsBiology.SequenceModel.NucleotideModels.NucleicAcid)
```
没有终止密码子

|Parameter Name|Remarks|
|--------------|-------|
|SequenceData|-|


#### Translate
```csharp
LANS.SystemsBiology.SequenceModel.NucleotideModels.Translation.TranslationTable.Translate(System.String,System.Boolean)
```
将一条核酸链翻译为蛋白质序列

|Parameter Name|Remarks|
|--------------|-------|
|NucleicAcid|-|




### Properties

#### CodenTable

