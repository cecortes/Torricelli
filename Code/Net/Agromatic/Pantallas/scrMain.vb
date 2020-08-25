Public Class scrMain

#Region "VARIABLES"

#End Region

#Region "FUNCIONES"

#End Region

#Region "METODOS"

    ''' <summary>
    ''' Se encarga de crear un nuevo objeto del tipo Form
    ''' Busca el formulario recibido como parámetro en la colección
    ''' Asigna la creación del formulario recibido al objeto creado
    ''' Le asigna los parámetros necesarios para mostrarlo
    ''' Lo muestra y lo trae al frente
    ''' </summary>
    ''' <typeparam name="MiForm"></typeparam>
    Private Sub AbrirFormPanel(Of MiForm As {Form, New})()

        'Objeto
        Dim form As Form

        'Busca el formulario en la colección
        form = pnlWrapp.Controls.OfType(Of MiForm)().FirstOrDefault()

        'Si el formulario no es encontrado / no existe
        If form Is Nothing Then
            form = New MiForm()
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.Dock = DockStyle.Fill
            pnlWrapp.Controls.Add(form)
            pnlWrapp.Tag = form
            form.Show()
            form.BringToFront()
        Else
            form.BringToFront()
        End If

    End Sub

#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Cierra el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Minimiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click

        'Valida el estado de la pantalla para tomar la acción correspondiente
        If Me.WindowState = 0 Then
            'Max
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = 2 Then
            'Min
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    ''' <summary>
    ''' Minimiza el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ''' <summary>
    ''' Cambia el color del botón seleccionado
    ''' Cambia el color de los demás botones
    ''' Muestra el formulario de Terreno
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTerr_Click(sender As Object, e As EventArgs) Handles btnTerr.Click

        'Colores
        btnTerr.Normalcolor = Color.FromArgb(20, 204, 96)
        btnCultivos.Normalcolor = Color.FromArgb(3, 3, 25)
        btnMetro.Normalcolor = Color.FromArgb(3, 3, 25)
        btnRecur.Normalcolor = Color.FromArgb(3, 3, 25)

        'Panel
        AbrirFormPanel(Of scrTerreno)()

    End Sub

    ''' <summary>
    ''' Cambia el color del botón seleccionado
    ''' Cambia el color de los demás botones
    ''' Muestra el formulario de Cultivo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCultivos_Click(sender As Object, e As EventArgs) Handles btnCultivos.Click

        'Colores
        btnCultivos.Normalcolor = Color.FromArgb(20, 204, 96)
        btnTerr.Normalcolor = Color.FromArgb(3, 3, 25)
        btnMetro.Normalcolor = Color.FromArgb(3, 3, 25)
        btnRecur.Normalcolor = Color.FromArgb(3, 3, 25)

        'Panel
        AbrirFormPanel(Of ScrCultivos)()

    End Sub

    ''' <summary>
    ''' Cambia el color del botón seleccionado
    ''' Cambia el color de los demás botones
    ''' Muestra el formulario de Metrología
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMetro_Click(sender As Object, e As EventArgs) Handles btnMetro.Click

        'Colores
        btnMetro.Normalcolor = Color.FromArgb(20, 204, 96)
        btnTerr.Normalcolor = Color.FromArgb(3, 3, 25)
        btnCultivos.Normalcolor = Color.FromArgb(3, 3, 25)
        btnRecur.Normalcolor = Color.FromArgb(3, 3, 25)

        'Panel
        AbrirFormPanel(Of ScrMetro)()

    End Sub

    ''' <summary>
    ''' Cambia el color del botón seleccionado
    ''' Cambia el color de los demás botones
    ''' Muestra el formulario de Recursos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRecur_Click(sender As Object, e As EventArgs) Handles btnRecur.Click

        'Colores
        btnRecur.Normalcolor = Color.FromArgb(20, 204, 96)
        btnTerr.Normalcolor = Color.FromArgb(3, 3, 25)
        btnCultivos.Normalcolor = Color.FromArgb(3, 3, 25)
        btnMetro.Normalcolor = Color.FromArgb(3, 3, 25)

        'Panel
        AbrirFormPanel(Of ScrRecursos)()

    End Sub

#End Region

End Class
