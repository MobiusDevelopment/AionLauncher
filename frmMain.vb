Imports System.IO

Public Class frmMain
    Dim INI_FILE As String = "AionLauncher.ini"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make form invisible
        Me.Visible = False

        'get info from file, if it exists
        Dim shellCommand = ""
        If File.Exists(INI_FILE) Then
            Using fileReader As StreamReader = New StreamReader(INI_FILE)
                shellCommand = fileReader.ReadLine
            End Using
        End If

        'execute
        Try
            Shell(shellCommand, vbNormalFocus)
        Catch ex As Exception
            MsgBox("File not found! Try checking your files.", MsgBoxStyle.Critical)
        End Try

        'close
        End
    End Sub
End Class
