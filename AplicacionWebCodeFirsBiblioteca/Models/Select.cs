using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace AplicacionWebCodeFirsBiblioteca.Models
{
    public class Select
    {
        
        public Usuarios BuscarUsuario(Usuarios usu, Contexto contexto)
        {
           Usuarios usuario= contexto.usuarios.FirstOrDefault(u=>u.dni_usuario==usu.dni_usuario);
            return usuario;
        }

        public Accesos BuscarAcceso(Accesos acs, Contexto contexto)
        {
            Accesos acceso = contexto.accesos.FirstOrDefault(a => a.codigo_acceso == acs.codigo_acceso);
            return acceso;
        }
        public Autores BuscarAutores(Autores aut, Contexto contexto)
        {

            Autores autor = contexto.autores.FirstOrDefault(au => au.nombre_autor == aut.nombre_autor);
            return autor;
        }
        public Colecciones BuscarColecciones(Colecciones colec, Contexto contexto)
        {
            Colecciones coleccion = contexto.colecciones.FirstOrDefault(c => c.nombre_coleccion == colec.nombre_coleccion);
            return coleccion;
        }
        public Editoriales BuscarEditoriales(Editoriales edito, Contexto contexto)
        {

            Editoriales editorial = contexto.editoriales.FirstOrDefault(e => e.nombre_editorial == edito.nombre_editorial);
            return editorial;
        }
        public Estados_Prestamos BuscarEstaPresta(Estados_Prestamos estaPres, Contexto contexto)
        {

            Estados_Prestamos estadoprestamo = contexto.estados_Prestamos.FirstOrDefault(ep => ep.codigo_estado_prestamo == estaPres.codigo_estado_prestamo);
            return estadoprestamo;
        }
        public Generos BuscarGeneros(Generos gene, Contexto contexto)
        {

            Generos genero = contexto.generos.FirstOrDefault(g => g.nombre_genero == gene.nombre_genero);
            return genero;
        }
        public Libros BuscarLibros(Libros lib, Contexto contexto)
        {

            Libros libro = contexto.libros.FirstOrDefault(l => l.isbn_libro == lib.isbn_libro);
            return libro;
        }
        public Prestamos BuscarPrestamos(Prestamos presta, Contexto contexto)
        {

            Prestamos prestamo = contexto.prestamos.FirstOrDefault(p => p.fch_inicio_prestamo == presta.fch_inicio_prestamo);
            return prestamo;
        }
        }
    }
}

