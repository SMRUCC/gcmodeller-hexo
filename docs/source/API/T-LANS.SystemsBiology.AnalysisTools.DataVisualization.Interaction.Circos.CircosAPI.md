﻿---
title: CircosAPI
---

# CircosAPI
_namespace: [LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos](N-LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.html)_

Shoal shell interaction with circos perl program to draw a circle diagram of a bacteria genome.

### Methods

#### __geneHighlights
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.__geneHighlights(System.Collections.Generic.IEnumerable{LANS.SystemsBiology.Assembly.NCBI.GenBank.CsvExports.GeneDumpInfo},System.Collections.Generic.Dictionary{System.String,System.String},LANS.SystemsBiology.ComponentModel.Loci.Strands)
```
生成基因组的基因片段

|Parameter Name|Remarks|
|--------------|-------|
|anno|-|
|Colors|-|
|Strands|-|


#### CreateDoc
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.CreateDoc
```
Creats a new circos plots configuration document.

#### DoorOperon
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.DoorOperon(System.String)
```
Door之中的操纵子以heatmap的形式绘制

|Parameter Name|Remarks|
|--------------|-------|
|DOOR|Door文件的文件路径|


#### GenerateBlastnAlignment
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.GenerateBlastnAlignment(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,LANS.SystemsBiology.NCBI.Extensions.NCBIBlastResult.AlignmentTable,System.Double,System.Double,LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Karyotype.Highlights.IdentityColors)
```
The blast result alignment will be mapping on the circos plot circle individual as the highlights element in the circos plot.

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|table|-|
|r1|-|
|rInner|-|


#### GenerateGeneCircle
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.GenerateGeneCircle(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,System.Collections.Generic.IEnumerable{LANS.SystemsBiology.Assembly.NCBI.GenBank.CsvExports.GeneDumpInfo},System.Boolean,System.String,System.Boolean,System.Boolean,System.Boolean)
```


|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|anno|-|
|IDRegex|基因的名称的正则表达式解析字符串。如果为空字符串，则默认输出全部的名称|
|onlyGeneName|当本参数为真的时候，** IDRegex **参数失效|


#### GetIdeogram
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.GetIdeogram(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos)
```
还没有ideogram文档的时候，则会返回一个新的文档

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|


#### RNAVisualize
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.RNAVisualize(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,LANS.SystemsBiology.Assembly.NCBI.GenBank.TabularFormat.PTT)
```
使用Highlighs来显示RNA分子在基因组之上的位置

#### SetBasicProperty
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.SetBasicProperty(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,LANS.SystemsBiology.SequenceModel.FASTA.FastaToken,System.Collections.Generic.IEnumerable{Microsoft.VisualBasic.ComponentModel.TripleKeyValuesPair},System.Int32)
```


|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|NT|-|
|Bands|-|
|loophole|默认为0，没有缺口|


#### SetIdeogramRadius
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.SetIdeogramRadius(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Ideogram,System.Double)
```
其他的圆圈都会发生变化，则每一次修改之后都需要重新计算圆圈的位置

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|r|-|

> 
>  圆圈的最大值只能够到达1.2了？？？
>  相对的大小是和ideogram有关的
>  1/ideogram.radius
>  

#### SetIdeogramWidth
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.SetIdeogramWidth(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Ideogram,System.Int32)
```
Invoke set the ideogram width in the circos plot drawing, if the width value is set to ZERO,
 then the ideogram circle will be empty on the drawing but this is different with the ideogram
 configuration document was not included in the circos main configuration.

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|width|-|


#### SetPlotElementOrientation
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.SetPlotElementOrientation(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Nodes.Plots.Plot,System.String)
```


|Parameter Name|Remarks|
|--------------|-------|
|Element|-|
|Orientation|-|


#### setProperty
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.setProperty(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,System.String,System.String)
```
Invoke set of the property value in the circos document object.

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|name|-|
|value|-|


#### SetRadius
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.SetRadius(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,System.Collections.Generic.IEnumerable{System.Double[]})
```


|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|r|从外圈到内圈的|


#### WriteData
```csharp
LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.CircosAPI.WriteData(LANS.SystemsBiology.AnalysisTools.DataVisualization.Interaction.Circos.Documents.Configurations.Circos,System.String,System.Boolean)
```
Save the circos plots configuration object as the default configuration file: circos.conf

|Parameter Name|Remarks|
|--------------|-------|
|doc|-|
|outDIR|-|
|Debug|-|




