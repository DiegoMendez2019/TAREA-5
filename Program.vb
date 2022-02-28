Imports System

Module Program
    Private Esperar As Char

    Sub Main()
        Dim n, a, x As Integer
        Dim esperar As Char
        While esperar <> "z" And esperar <> "Z"


            Try
                'Primero el numero a calcular el factorial

                a = 1
                Console.WriteLine("Ingrese el numero:")
                n = Console.ReadLine()

                For y = 1 To n
                    a = a * y
                Next
                Console.WriteLine("El factorial es: " + a.ToString)
                'este es para contar los numeros
                For u = 0 To a
                    If (u Mod 4) Then 'el mod es para dividir el numero que toca en 4 y si es verdad entra al if
                        x = x + 1
                    End If

                Next
                Console.WriteLine("Existen " + a.ToString + " numeros multiplos de 4 en " + a.ToString)


            Catch ex As Exception

            End Try
            Console.WriteLine()
            Console.Write("Presione la z o Z para salir del programa")
            Esperar = Console.ReadKey.KeyChar
        End While

    End Sub

End Module
