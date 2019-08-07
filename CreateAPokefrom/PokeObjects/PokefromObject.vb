Public Class PokefromObject

    <Newtonsoft.Json.JsonProperty>
    Property Name0 As String
    <Newtonsoft.Json.JsonProperty>
    Property Name1 As String
    <Newtonsoft.Json.JsonProperty>
    Property Name2 As String
    <Newtonsoft.Json.JsonProperty>
    Property Name3 As String

    <Newtonsoft.Json.JsonProperty>
    Property Level As Integer

    <Newtonsoft.Json.JsonProperty>
    Property Health As Integer

    <Newtonsoft.Json.JsonProperty>
    Property Attacks As List(Of Attack)

    <Newtonsoft.Json.JsonProperty>
    Property Type0 As PokefromTypes
    <Newtonsoft.Json.JsonProperty>
    Property Type1 As PokefromTypes
    <Newtonsoft.Json.JsonProperty>
    Property Type2 As PokefromTypes
    <Newtonsoft.Json.JsonProperty>
    Property Type3 As PokefromTypes


    <Newtonsoft.Json.JsonProperty>
    Property LevelUp1 As Integer
    <Newtonsoft.Json.JsonProperty>
    Property LevelUp2 As Integer
    <Newtonsoft.Json.JsonProperty>
    Property LevelUp3 As Integer

    <Newtonsoft.Json.JsonProperty>
    Property Gender As Boolean

    <Newtonsoft.Json.JsonProperty>
    Property ContinuousDamage

    <Newtonsoft.Json.JsonProperty>
    Property Texture1
    <Newtonsoft.Json.JsonProperty>
    Property Texture2
    <Newtonsoft.Json.JsonProperty>
    Property Texture3
    <Newtonsoft.Json.JsonProperty>
    Property Texture4

    <Newtonsoft.Json.JsonProperty>
    Property CatchIndex As Integer

    Public ReadOnly Property IsAlive() As String
        Get
            If Health <= 0 Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Sub GenerateCatchIndex(rnd As Random)
        CatchIndex = rnd.Next(1, 100)
    End Sub

    Shared Function FromCode(str) As PokefromObject
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of PokefromObject)(str)
    End Function

    Function ToCode()
        Return Newtonsoft.Json.JsonConvert.SerializeObject(Me)
    End Function
End Class
