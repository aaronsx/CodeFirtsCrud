using DAL;
using Microsoft.EntityFrameworkCore;

namespace AplicacionWebCodeFirsBiblioteca.Models
{
    public class Remove
    {
        public void DeleteUsuario(Usuarios usu, Contexto contexto)
        {
            contexto.Remove<Usuarios>(usu);
            contexto.SaveChanges();

        }

        public void DeleteAcceso(Accesos acs, Contexto contexto)
        {
           
            contexto.Remove<Accesos>(acs);
            contexto.SaveChanges();
        }
        public void DeleteAutores(Autores aut, Contexto contexto)
        {
            
            contexto.Remove<Autores>(aut);
            contexto.SaveChanges();
        }
        public void DeleteColecciones(Colecciones colec, Contexto contexto)
        {

            contexto.Remove<Colecciones>(colec);
            contexto.SaveChanges();
        }
        public void DeleteEditoriales(Editoriales edito, Contexto contexto)
        {

            contexto.Remove<Editoriales>(edito);
            contexto.SaveChanges();
        }
        public void DeleteEstaPresta(Estados_Prestamos estaPres, Contexto contexto)
        {

            contexto.Remove<Estados_Prestamos>(estaPres);
            contexto.SaveChanges();
        }
        public void DeleteGeneros(Generos genero, Contexto contexto)
        {

            contexto.Remove<Generos>(genero);
            contexto.SaveChanges();
        }
        public void DeleteLibros(Libros libro, Contexto contexto)
        {

            contexto.Remove<Libros>(libro);
            contexto.SaveChanges();
        }
        public void DeletePrestamos(Prestamos presta, Contexto contexto)
        {

            contexto.Remove<Prestamos>(presta);
            contexto.SaveChanges();
        }
        public void DeleteRelAutoLibr(Rel_Autores_Libros relAuLi, Contexto contexto)
        {

            contexto.Remove<Rel_Autores_Libros>(relAuLi);
            contexto.SaveChanges();
        }
        public void DeleteRelLibrPres(Rel_Libros_Prestamos relLiPr, Contexto contexto)
        {
            contexto.Remove<Rel_Libros_Prestamos>(relLiPr);
            contexto.SaveChanges();
        }
    }
}
