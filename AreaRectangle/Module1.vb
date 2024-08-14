Module Module1

    Sub Main()
        Dim rectangle As AreaRectangle.Rectangle = New AreaRectangle.Rectangle()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Width: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        rectangle.Width = Convert.ToInt32(Console.ReadLine())
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Height: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        rectangle.Height = Convert.ToInt32(Console.ReadLine())
        System.Console.WriteLine()
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.Write("Area Rectangle : ")
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.WriteLine(rectangle.RectangleArea())
        System.Console.ResetColor()
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()
    End Sub

End Module

Public Class Rectangle
    Public Property Width As Integer
    Public Property Height As Integer

    Public Function RectangleArea() As Integer
        Return Width * Height
    End Function
End Class

