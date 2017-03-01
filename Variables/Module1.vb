Module Module1

    Sub Main()
        Dim myNum As Integer
        myNum = 5
        'Or
        Dim myNumb As Integer = 7
        Console.WriteLine(myNumb)



        Dim myString As String = "Hello New Programmer!"
        Console.WriteLine(myString)
        ''CInt() convert to integer
        'CStr() convert to string 
        ' CDbl() convert to double  
        '   CChar() Convert to character



        Dim myChar As Char = "A"

        Dim myDouble As Double = 5.4

        Dim myBoolean As Boolean = True

        Console.WriteLine(myNum.ToString())
        Console.WriteLine(CStr(myDouble))
        Console.ReadLine()
        Dim userValue As String
        Console.WriteLine("Please enter something:")
        userValue = Console.ReadLine()
        Console.WriteLine("You entered " & userValue)
        If userValue = "something" Then
            Console.WriteLine("Write something else smartass")
            Console.ReadLine()

        Else
            Console.WriteLine("Thank you for your cooperation")

        End If  ' IF-Then Else Statement
        'Better to not write code over and over again create methods to compact code
        'Elseif need Then statement after condtion statement

        Console.WriteLine("Please enter in 1, 2, or 3")
        Dim userValue2 As String = Console.ReadLine()

        Dim user2Value As String = IIf(userValue2 = "1", "hey", "nay")
        Console.WriteLine("You got a {0} because you picked {1}", user2Value, userValue2)
        'IIF (item true , do this , if false do this) can referene a variable in a output 
        'statement by using {start with 0} and then variable name


        For index = 1 To 10
            If index = 7 Then
                Console.WriteLine("Found Seven!")
                Exit For 'Like a break statement to jump out of for next (for loop)
            End If

        Next

        'For Next (for loop) that steps backward 1
        For index = 10 To 5 Step -1
            Console.WriteLine(myNum)

        Next
        Console.ReadLine()



    End Sub

End Module
