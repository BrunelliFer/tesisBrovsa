Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Usuario
    Public Property Id As Integer
    Public Property NombreDeUsuario As String
    Public Property Password As String
    Public Property Habilitado As Boolean
    Public Property FechaDeAlta As DateTime
    <ForeignKey("RolId")>
    Public Overridable Property Rol As Rol
    Public Property RolId As Integer


End Class
