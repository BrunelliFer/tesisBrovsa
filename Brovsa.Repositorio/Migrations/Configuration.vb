Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports Brovsa.Entidades

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of Repositorio)

        Public Sub New()
            AutomaticMigrationsEnabled = True
        End Sub

        Protected Overrides Sub Seed(context As Repositorio)
            context.Roles.AddOrUpdate(Function(x) x.Nombre, New Rol() With {.Nombre = "Admin"})
            context.Roles.AddOrUpdate(Function(x) x.Nombre, New Rol() With {.Nombre = "Atencion Al Cliente"})
            context.SaveChanges()
            context.Usuarios.AddOrUpdate(Function(x) x.NombreDeUsuario, New Usuario() With {.NombreDeUsuario = "Admin", .Habilitado = True, .FechaDeAlta = DateTime.Now, .Password = "123", .RolId = 1})
            context.SaveChanges()
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data.
        End Sub

    End Class

End Namespace
