'Imports
Imports System.IO.Ports

Public Class scrTerreno

#Region "VARIABLES"

    Dim seriesStr() = {"Riego", "Combustible", "Fertilizante", "Pesticida"}
    Dim tagStr() = {"1", "2", "3", "4"}

    'BlueCom
    Dim WithEvents SerialPort As New IO.Ports.SerialPort

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

    ''' <summary>
    ''' Valida que el puerto este libre
    ''' Se encarga de configurar y abrir el puerto seleccionado
    ''' Muestra al usuario el estado de la conexión
    ''' </summary>
    Private Sub ConectBlueSerial()

        'Validación
        Try

            'Configuramos Velocidad y Nombre
            SerialPort.BaudRate = 115200
            SerialPort.PortName = "COM5"

            'Abrimos el puerto
            SerialPort.Open()

            rtbBlueCom.AppendText(">> Iniciando conexión Bluetooth " + vbCrLf)
            rtbBlueCom.AppendText(">> ................................" + vbCrLf)

        Catch ex As Exception

            'Cerramos el puerto en caso de estar abierto y causar error
            SerialPort.Close()

            rtbBlueCom.AppendText(">> Error de COM - Re inciando Bluetooth" + vbCrLf)
            rtbBlueCom.AppendText(">> ................................" + vbCrLf)

        End Try

        'Línea final
        rtbBlueCom.ScrollToCaret()

    End Sub

#End Region

#Region "DELEGATE"

    'Creamos el método delegado, el nombre lo eligimos nosostros
    Delegate Sub uidDelegado(ByVal [text] As String)

    'Creamos el objeto delegado a dataBlueCom, direcciona al método a llamar y le pasa como parámetro el Texto
    Dim delegadoBluetooth As New uidDelegado(AddressOf dataBlueCom)

    ''' <summary>
    ''' Recibe como cadena el dato recibido por bluetooth
    ''' Muestra en el rich text box
    ''' Lo descompone en los datos individuales y los almacena en sus variables
    ''' Actualiza el dashboard
    ''' </summary>
    ''' <param name="dato"></param>
    Sub dataBlueCom(ByVal dato As String)

        'RTB
        rtbBlueCom.AppendText(">> Bluetooth: " + dato + vbCrLf)

        'Split Data
        Dim datoStr() As String = dato.Split(",")

        'Debug
        rtbBlueCom.AppendText(">> T: " + datoStr(0) + " >> Pa: " + datoStr(1) + " >> Alt: " + datoStr(2) + " >> Ts: " + datoStr(3) + " >> Hr: " + datoStr(4) + " >> Lux: " + datoStr(5) + " >> Lum: " + datoStr(6) + vbCrLf)

        rtbBlueCom.ScrollToCaret()

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

    ''' <summary>
    ''' Se encarga de llamar al método para realizar la conexión al bluetooth
    ''' Informa al usuario del estado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        'Validación Open / Close
        If (btnConectar.Text = "Conectar") Then

            'Texto
            btnConectar.Text = "Desconectar"

            'BlueCom
            ConectBlueSerial()

        Else

            'Texto
            btnConectar.Text = "Conectar"

            'Cerramos el puerto en caso de estar abierto y causar error
            SerialPort.Close()

        End If

        'Consola
        If (SerialPort.IsOpen) Then

            rtbBlueCom.AppendText("" + vbCrLf)
            rtbBlueCom.AppendText(">> Sensores bluetooth listo." + vbCrLf)

        Else

            rtbBlueCom.AppendText("" + vbCrLf)
            rtbBlueCom.AppendText(">> Error en bluetooth com" + vbCrLf)

        End If

        rtbBlueCom.ScrollToCaret()

    End Sub

    ''' <summary>
    ''' Recibe los datos seriales hasta recibir una nueva línea.
    ''' Invoca al método delegado para mostrar los datos en consola y actualizar el dashboard.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        'Excepción controlada
        Try

            'BlueCom
            Dim str As String = SerialPort.ReadTo("#")

            'Invoke, llama al método delegado y le pasa como argumento una cadena con el dato recibido.
            Invoke(delegadoBluetooth, str)

        Catch ex As Exception

        End Try

    End Sub

#End Region

End Class