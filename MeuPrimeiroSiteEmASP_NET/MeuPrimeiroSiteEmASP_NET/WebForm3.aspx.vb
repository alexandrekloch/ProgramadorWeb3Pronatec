Public Class WebForm3
    Inherits System.Web.UI.Page
    Const a As Integer = 1
    Const b As Integer = 2
    Const c As Integer = 3
    Const d As Integer = 4
    Const e As Integer = 5
    Const f As Integer = 6
    Const g As Integer = 7
    Const h As Integer = 8
    Const i As Integer = 9
    Const j As Integer = 10
    Const k As Integer = 11
    Const l As Integer = 12
    Const m As Integer = 13
    Const n As Integer = 14
    Const o As Integer = 15
    Const p As Integer = 16
    Const q As Integer = 17
    Const r As Integer = 18
    Const s As Integer = 19
    Const t As Integer = 20
    Const u As Integer = 21
    Const v As Integer = 22
    Const w As Integer = 23
    Const x As Integer = 24
    Const y As Integer = 25
    Const z As Integer = 26

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, ev As EventArgs) Handles Button1.Click
        Dim texto As String = TextBox1.Text
        Dim total As Integer = 26

        For index = 0 To texto.Length - 1
            If texto.Substring(index, 1) = "a" Or texto.Substring(index, 1) = "A" Then
                total += a
            End If
            If texto.Substring(index, 1) = "b" Or texto.Substring(index, 1) = "B" Then
                total += b
            End If
            If texto.Substring(index, 1) = "c" Or texto.Substring(index, 1) = "C" Then
                total += c
            End If
            If texto.Substring(index, 1) = "d" Or texto.Substring(index, 1) = "D" Then
                total += d
            End If
            If texto.Substring(index, 1) = "e" Or texto.Substring(index, 1) = "E" Then
                total += e
            End If
            If texto.Substring(index, 1) = "f" Or texto.Substring(index, 1) = "F" Then
                total += f
            End If
            If texto.Substring(index, 1) = "g" Or texto.Substring(index, 1) = "G" Then
                total += g
            End If
            If texto.Substring(index, 1) = "h" Or texto.Substring(index, 1) = "H" Then
                total += h
            End If
            If texto.Substring(index, 1) = "i" Or texto.Substring(index, 1) = "I" Then
                total += i
            End If
            If texto.Substring(index, 1) = "j" Or texto.Substring(index, 1) = "J" Then
                total += j
            End If
            If texto.Substring(index, 1) = "k" Or texto.Substring(index, 1) = "K" Then
                total += k
            End If
            If texto.Substring(index, 1) = "l" Or texto.Substring(index, 1) = "L" Then
                total += l
            End If
            If texto.Substring(index, 1) = "m" Or texto.Substring(index, 1) = "M" Then
                total += m
            End If
            If texto.Substring(index, 1) = "n" Or texto.Substring(index, 1) = "N" Then
                total += n
            End If
            If texto.Substring(index, 1) = "o" Or texto.Substring(index, 1) = "O" Then
                total += o
            End If
            If texto.Substring(index, 1) = "p" Or texto.Substring(index, 1) = "P" Then
                total += p
            End If
            If texto.Substring(index, 1) = "q" Or texto.Substring(index, 1) = "Q" Then
                total += q
            End If
            If texto.Substring(index, 1) = "r" Or texto.Substring(index, 1) = "R" Then
                total += r
            End If
            If texto.Substring(index, 1) = "s" Or texto.Substring(index, 1) = "S" Then
                total += s
            End If
            If texto.Substring(index, 1) = "t" Or texto.Substring(index, 1) = "T" Then
                total += t
            End If
            If texto.Substring(index, 1) = "u" Or texto.Substring(index, 1) = "U" Then
                total += u
            End If
            If texto.Substring(index, 1) = "v" Or texto.Substring(index, 1) = "V" Then
                total += v
            End If
            If texto.Substring(index, 1) = "w" Or texto.Substring(index, 1) = "W" Then
                total += w
            End If
            If texto.Substring(index, 1) = "x" Or texto.Substring(index, 1) = "X" Then
                total += x
            End If
            If texto.Substring(index, 1) = "y" Or texto.Substring(index, 1) = "Y" Then
                total += y
            End If
            If texto.Substring(index, 1) = "z" Or texto.Substring(index, 1) = "Z" Then
                total += z
            End If
        Next
        Dim literal1 As New Literal
        literal1.Text = "Número Primo<BR>"
        Label1.Text = total

        For index = 2 To total / 2
            If total Mod index = 0 Then
                literal1.Text = "Este número não é primo!<BR>"
            End If

        Next
        form1.Controls.Add(literal1)




    End Sub
End Class