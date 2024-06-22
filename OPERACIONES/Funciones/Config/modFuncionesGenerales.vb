Module modFuncionesGenerales
    Public Function GetFormByName(ByVal formName As String) As Form
        If (formName = String.Empty) Then Return Nothing
        For Each frm As Form In Application.OpenForms
            If (frm.Name.ToUpperInvariant() = formName.ToUpperInvariant()) Then
                ' Devolvemos la referencia del formulario.
                Return frm
            End If
        Next
        ' No está abierto el formulario especificado
        Return Nothing
    End Function
    Public vgusuario As String = "UNKNOWN"
    Public vgalias As String = "UNKNOWN"
End Module
