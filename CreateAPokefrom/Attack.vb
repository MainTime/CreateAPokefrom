Public Class Attack

    <Newtonsoft.Json.JsonProperty>
    Property Name As String

    <Newtonsoft.Json.JsonProperty>
    Property Damage As Integer

    <Newtonsoft.Json.JsonProperty>
    Property IsContinuous As Boolean

    <Newtonsoft.Json.JsonProperty>
    Property Type As PokefromTypes

    <Newtonsoft.Json.JsonProperty>
    Property Level As Integer

    Overrides Function ToString() As String
        Return Newtonsoft.Json.JsonConvert.SerializeObject(Me)
    End Function
    Shared Function FromString(str) As Attack
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Attack)(str)
    End Function
End Class
