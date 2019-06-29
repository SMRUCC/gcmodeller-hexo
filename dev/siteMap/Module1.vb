﻿Imports Microsoft.VisualBasic.Serialization.JSON
Imports r = System.Text.RegularExpressions.Regex

Module Module1

    Sub Main()
        Call scanArticles(App.Command)
    End Sub

    Sub scanArticles(root As String)
        Call New DbJson With {
            .lastupdated = Now,
            .articles = root.EnumerateFiles("*.md") _
                .Select(Function(path) parseArticle(path, root)) _
                .ToArray
        }.GetJson _
         .SaveTo($"{root}/db.json")
    End Sub

    Private Function parseArticle(path As String, root As String) As article
        Dim markdown As String = path.ReadAllText
        Dim tags = r.Matches(markdown, "[<]![-]{2}.+?[-]{2}[>]", RegexICSng) _
            .EachValue _
            .Select(Function(tag)
                        Dim str = Mid(tag, 5)
                        Dim text = Mid(str, 1, str.Length - 3)

                        Return text.Trim
                    End Function) _
            .ToArray
        ' Dim time =  

        Return New article With {
            .url = path.Replace(root, "")
        }
    End Function

End Module

Public Class DbJson

    Public Property articles As article()
    Public Property lastupdated As Date

End Class

Public Class article

    Public Property title As String
    Public Property url As String
    Public Property topics As String()
    Public Property time As Date

End Class