'Kendall Callister
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/callkend/Fortune-Cookie.git

Option Explicit On
Option Strict On

Module FortuneCookie

    Sub main()
        Dim randomNumber As Int16

        'Generates a random number.
        VBMath.Randomize()
        randomNumber = Int(3 * Rnd() + 1)

        'random number generates a fortune
        Select Case randomNumber
            Case 1
                Console.WriteLine("A friend asks only for your time not your money.")
            Case 2
                Console.WriteLine("A faithful friend is a strong defense.")
            Case 3
                Console.WriteLine("A dubious friend may be an enemy in camouflage.")

        End Select

        Console.ReadLine()
    End Sub

End Module
