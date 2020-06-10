'//IMPORTANDO LIBRERIA INPUT / OUTPUT 
Imports System.IO
Public Class FrmMostraArchivo


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '//LISTANDO LAS UNIDADES DE DISCO - MOSTRANDO HORA
        Me.TmrHora.Enabled = True
        Listar_Unidades()
        Me.CboUnidades.SelectedIndex = 0

        Mostrar_Hora()

    End Sub

    Sub Mostrar_Hora()

        '//SE MUESTRA LA HORA EN FORMATO 12 HORAS
        'If DateTime.Now.Hour < 12 Then
        '    Me.LblHora.Text = "Fecha y Hora: " & DateTime.Now & " a.m."
        'Else
        '    Me.LblHora.Text = "Fecha y Hora: " & DateTime.Now & " p.m."
        'End If
        Me.LblHora.Text = "Fecha y Hora: " & DateTime.Now

    End Sub

    Sub Listar_Unidades()

        '//SE RECORRE LA LISTA DE TODOS LOS DISCOS Y LOS AGREGA A COMBOBOX
        For Each Unidades As String In Directory.GetLogicalDrives
            CboUnidades.Items.Add(Unidades)
        Next

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        '//SE ACTUALIZA LA LISTA DE UNIDADES - SE REALIZA UN NUEVO RECORRIDO
        Me.CboUnidades.Items.Clear()
        Listar_Unidades()
        Me.CboUnidades.SelectedIndex = 0
        MsgBox("Lista de Unidades de Disco," & Chr(13) & "actualizadas correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "MostraArchivos v3.0")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("Jossip Jair Escalaya Juarez - HuntSoft" & Chr(13) & "Celular: 947141863 ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Gracias por utilizar MostraArchivos v3.0 - HuntSoft")
        Application.Exit()
    End Sub

    Private Sub TmrHora_Tick(sender As Object, e As EventArgs) Handles TmrHora.Tick
        Mostrar_Hora()
    End Sub

    Sub Mostrar_Archivos()

        '//EJECUTANDO COMANDO PARA VISUALIZAR ARCHIVOS 

        Try
            Dim Cadena As String = Me.CboUnidades.Text 'SE TOMA LA SELECCION DEL COMBOBOX
            Dim comando As String = Mid(Cadena, 1, 2) & " && " & "ATTRIB /D /S -R -H -S *.*"  'CON MID SE SELECCIONA LA CADENA EN DESDE LA POSICION 1 A 2
            Shell("cmd.exe /c" & comando) 'SE EJECUTA EL CMD, Y SE TOMA EL COMANDO
            MsgBox("Espere un momento..." & Chr(13) & "Ejecutando la Consola de Comandos", MsgBoxStyle.Information, "MostraArchivos v3.0")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
        MsgBox("Ya se muestran sus archivos", MsgBoxStyle.Information, "MostraArchivos v3.0")

    End Sub

    Private Sub BtnMostrarArchivos_Click(sender As Object, e As EventArgs) Handles BtnMostrarArchivos.Click
        Mostrar_Archivos()
    End Sub

    Private Sub FrmMostraArchivo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        MsgBox("Jossip Jair Escalaya Juarez - HuntSoft" & Chr(13) & "Celular: 947141863 ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Gracias por utilizar MostraArchivos v3.0 - HuntSoft")
     
    End Sub
End Class