Public Class scrTerreno

#Region "VARIABLES"

    Dim seriesStr() = {"Riego", "Combustible", "Fertilizante", "Pesticida"}
    Dim tagStr() = {"1", "2", "3", "4"}

#End Region

#Region "FUNCIONES"

#End Region

#Region "METODOS"

    ''' <summary>
    ''' Carga valores iniciales para las etiquetas.
    ''' Crea la gráfica inicial.
    ''' </summary>
    Private Sub Init()

        'Labels
        lblCultivo.Text = "Maíz"
        lblIni.Text = "Mayo"
        lblFin.Text = "Septiembre"

        'Gráficas
        'chrtTotal.Series.Add("Riego")
        chrtTotal.Series(seriesStr(0)).Points.AddXY(tagStr(0), 1000)
        chrtTotal.Series(seriesStr(1)).Points.AddXY(tagStr(0), 5000)
        chrtTotal.Series(seriesStr(2)).Points.AddXY(tagStr(0), 100)
        chrtTotal.Series(seriesStr(3)).Points.AddXY(tagStr(0), 300)

        chrtTotal.Series(seriesStr(0)).Points.AddXY(tagStr(1), 500)
        chrtTotal.Series(seriesStr(1)).Points.AddXY(tagStr(1), 2500)
        chrtTotal.Series(seriesStr(2)).Points.AddXY(tagStr(1), 300)
        chrtTotal.Series(seriesStr(3)).Points.AddXY(tagStr(1), 600)

        chrtTotal.Series(seriesStr(0)).Points.AddXY(tagStr(2), 250)
        chrtTotal.Series(seriesStr(1)).Points.AddXY(tagStr(2), 2150)
        chrtTotal.Series(seriesStr(2)).Points.AddXY(tagStr(2), 1000)
        chrtTotal.Series(seriesStr(3)).Points.AddXY(tagStr(2), 1200)

        chrtTotal.Series(seriesStr(0)).Points.AddXY(tagStr(3), 125)
        chrtTotal.Series(seriesStr(1)).Points.AddXY(tagStr(3), 1250)
        chrtTotal.Series(seriesStr(2)).Points.AddXY(tagStr(3), 100)
        chrtTotal.Series(seriesStr(3)).Points.AddXY(tagStr(3), 300)

    End Sub
#End Region

#Region "EVENTOS"

    ''' <summary>
    ''' Carga los valores iniciales para los label y gráficas.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub scrTerreno_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Iniciales
        Init()

    End Sub

#End Region

End Class