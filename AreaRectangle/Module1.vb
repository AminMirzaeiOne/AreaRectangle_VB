' Module declaration
Module Module1

    ' Main program entry point
    Sub Main()

        ' Create a new Rectangle object from the AreaRectangle namespace
        Dim rectangle As AreaRectangle.Rectangle = New AreaRectangle.Rectangle()

        ' Set console foreground color to cyan for user prompt
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt user to enter the rectangle's width
        System.Console.Write("Pls Enter Width: ")

        ' Set console foreground color to yellow for user input
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the entered width as an integer and assign it to the rectangle's Width property
        rectangle.Width = Convert.ToInt32(Console.ReadLine())

        ' Set console foreground color back to cyan for user prompt
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt user to enter the rectangle's height
        System.Console.Write("Pls Enter Height: ")

        ' Set console foreground color to yellow for user input
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the entered height as an integer and assign it to the rectangle's Height property
        rectangle.Height = Convert.ToInt32(Console.ReadLine())

        ' Newline character for better formatting
        System.Console.WriteLine()

        ' Set console foreground color to blue for area output
        System.Console.ForegroundColor = ConsoleColor.Blue

        ' Display a message before the calculated area
        System.Console.Write("Area Rectangle: ")

        ' Set console background and foreground colors for area display
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White

        ' Calculate and print the area using the rectangle's RectangleArea function
        System.Console.WriteLine(rectangle.RectangleArea())

        ' Reset console colors to default
        System.Console.ResetColor()

        ' Set console foreground color to magenta for separator line
        System.Console.ForegroundColor = ConsoleColor.Magenta

        ' Print a separator line
        System.Console.WriteLine("-----------------------")

        ' Set console foreground color to red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red

        ' Print programmer information including GitHub username
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Wait for user to press any key before closing the console
        System.Console.ReadKey()

    End Sub

End Module

' Public class definition for Rectangle (assuming it's in a separate file)
Public Class Rectangle
    ' Public property for rectangle width
    Public Property Width As Integer
    ' Public property for rectangle height
    Public Property Height As Integer

    ' Public function to calculate and return the rectangle area
    Public Function RectangleArea() As Integer
        Return Width * Height
    End Function
End Class
