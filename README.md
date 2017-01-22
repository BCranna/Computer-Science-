# Computer-Science-
Module Module1
    
    Dim found As Boolean
    Dim item As String
    Dim currentsize As Integer
    Dim names(9) As String

    Function search(ByRef found As Boolean, ByVal names() As String) As Boolean
        Dim low As Integer = 0
        Dim high As Integer = 4
        Dim mid As Integer = (high + low / 2)
        found = 0
        Do While low <= high
            mid = (high + low / 2)
            If names(mid) = item Then
                found = True
                Exit Do
            ElseIf names(mid) > item Then
                high = mid - 1
            ElseIf names(mid) < item Then
                low = mid
            End If
        Loop
        If Not found Then
            found = False
        End If
        Return found
    End Function
    Sub initalise()
    'initialises the array with 5 values and sets the value of current size
        names(0) = "Andrew"
        names(1) = "Ben"
        names(2) = "Cam"
        names(3) = "Dave"
        names(4) = "Ed"
        currentsize = 5
    End Sub
    Function enqueueu(ByVal nametoadd) As String
    'adds an item to the queue, will implement shunt
        Dim count As Integer = 0
        While nametoadd <= names(count)
            count = count + 1
            If nametoadd >= names(count) Then
                Exit While
            End If
        End While
        nametoadd = names(count)
        currentsize = currentsize + 1
    End Function
    Sub Main()
        Dim nametoadd As String
        initalise()
        Dim op As Char = ""
        'starting the case select
        While op <> "4"
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("1. Search")
            Console.WriteLine("2. Add")
            Console.WriteLine("3. Look at stored names")
            Console.WriteLine("4. Exit")
            op = Console.ReadLine
            found = 0
            Select Case op

                Case Is = "1"
                'search option
                    Console.WriteLine("What name are you looking for?")
                    item = Console.ReadLine
                    search(found, names)
                    If found = True Then
                        Console.WriteLine("Found, it's in position ")
                    ElseIf found = False Then
                        Console.WriteLine("cams a faggot and it's not found")
                    End If
                Case Is = "2"
                'enqueue option
                    Console.WriteLine("add")
                    nametoadd = Console.ReadLine
                    enqueueu(nametoadd)
                Case Is = "3"
                'peek option
                    For count = 1 To currentsize
                        Console.WriteLine(names(count))
                    Next
                    Console.ReadLine()
                Case Is = "4"
                'exit
            End Select
        End While
    End Sub
End Module
