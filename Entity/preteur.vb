'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class preteur
    Public Property id_preteur As String

    Public Overridable Property individu As individu
    Public Overridable Property prets As ICollection(Of pret) = New HashSet(Of pret)
    Public Overridable Property retours As ICollection(Of retour) = New HashSet(Of retour)

End Class
