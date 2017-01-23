Module Module1

    Dim found As Boolean
    Dim item As String
    Dim currentsize As Integer
    Dim names(9) As String

    Function search(ByRef found As Boolean, ByVal names() As String, ByRef mid As Integer) As Boolean
        Dim low As Integer = 0
        Dim high As Integer = 4
        'resets the value of found so the do loop actually works
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
        Return mid
    End Function
    Function testSearch(ByRef found As Boolean, ByVal names() As String, ByRef mid As Integer)
        Randomize()
        Dim random As Integer
        random = Int((currentsize * Rnd()) - 1)
        Dim low As Integer = 0
        Dim high As Integer = currentsize
        found = 0
        Do While low <= high
            mid = (high + low / 2)
            If mid = rnd Then
                found = True
                Exit Do
                    ElseIf mid > random Then
                high = mid - 1
                    ElseIf mid < random Then
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
        Dim mid As Integer
        Dim nametoadd As String
        initalise()
        Dim op As Char = ""
        'starting the case select
        While op <> "6"
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("1. Search")
            Console.WriteLine("2. Add")
            Console.WriteLine("3. Look at stored names")
            Console.WriteLine("4. testSearch")
            op = Console.ReadLine
            found = 0
            Select Case op

                Case Is = "1"
                    'search option
                    Console.WriteLine("What name are you looking for?")
                    item = Console.ReadLine
                    search(found, names, mid)
                    If found = True Then
                        Console.WriteLine("Found, it's in position " & mid + 1)
                    ElseIf found = False Then
                        Console.WriteLine("it's not found")
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
                    'tests to see if the search is working by selecting a random value out of the array 
                    testSearch(found, names, mid)
                    If found = True Then
                        Console.WriteLine("search is working")
                    ElseIf found = False Then
                        Console.WriteLine("search isn't working")
                    End If
                Case Is = "6"
                    'exit
            End Select
        End While
    End Sub

End Module
