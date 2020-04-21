Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports Brovsa.Entidades

Public Class Repositorio
    Inherits DbContext

    Public Sub New()
        MyBase.New("cn")
    End Sub


    Public Property Usuarios As DbSet(Of Usuario)
    Public Property Roles As DbSet(Of Rol)


    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub

End Class
