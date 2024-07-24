Imports System
Module Program
    Sub Main(args As String())
        Dim namesList As New List(Of String)
        Dim names As String
        Dim JulySal As New List(Of Decimal)
        Dim JuneSal As New List(Of Decimal)
        Dim AugustSal As New List(Of Decimal)
        Dim sal As Decimal
        Do
            Console.Write("Names:")
            names = Console.ReadLine
            If names.ToLower() = "done" Then
                Exit Do
            End If
            namesList.Add(names)
            Console.Write("June Salary:")
            sal = Console.ReadLine
            JuneSal.Add(sal)
            Console.Write("July sal:")
            sal = Console.ReadLine
            JulySal.Add(sal)
            Console.Write("Aug Salary:")
            sal = Console.ReadLine
            AugustSal.Add(sal)

        Loop While names.ToLower <> "done"
        Console.WriteLine("Names" & vbTab & "June" & vbTab & "July" & vbTab & "August")
        For i = 0 To namesList.Count - 1
            Console.WriteLine(namesList(i) & vbTab & JuneSal(i) & vbTab & JulySal(i) & vbTab & AugustSal(i))
        Next
    End Sub
End Module
