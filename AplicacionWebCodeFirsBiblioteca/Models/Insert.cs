using DAL;
using Microsoft.EntityFrameworkCore;

namespace AplicacionWebCodeFirsBiblioteca.Models
{
    public class Insert
    {

        public void AddUsuario(Usuarios usu, Contexto contexto) 
        {

            contexto.Add<Usuarios>(usu);
            contexto.SaveChanges();
           
  
        }

        public void AddAcceso(Accesos acs, Contexto contexto)
        {
            contexto.Add<Accesos>(acs);
            contexto.SaveChanges();
        }
        public void AddAutores(Autores aut, Contexto contexto)
        {

            contexto.Add<Autores>(aut);
            contexto.SaveChanges();
        }
        public void AddColecciones(Colecciones colec, Contexto contexto)
        {

            contexto.Add<Colecciones>(colec);
            contexto.SaveChanges();
        }
        public void AddEditoriales(Editoriales edito, Contexto contexto)
        {

            contexto.Add<Editoriales>(edito);
            contexto.SaveChanges();
        }
        public void AddEstaPresta(Estados_Prestamos estaPres, Contexto contexto)
        {

            contexto.Add<Estados_Prestamos>(estaPres);
            contexto.SaveChanges();
        }
        public void AddGeneros(Generos genero, Contexto contexto)
        {

            contexto.Add<Generos>(genero);
            contexto.SaveChanges();
        }
        public void AddLibros(Libros libro, Contexto contexto)
        {

            contexto.Add<Libros>(libro);
            contexto.SaveChanges();
        }
        public void AddPrestamos(Prestamos presta, Contexto contexto)
        {

            contexto.Add<Prestamos>(presta);
            contexto.SaveChanges();
        }
        public void AddRelAutoLibr(Rel_Autores_Libros relAuLi, Contexto contexto)
        {
            contexto.Add<Rel_Autores_Libros>(relAuLi);
            contexto.SaveChanges();
        }
        public void AddRelLibrPres(Rel_Libros_Prestamos relLiPr, Contexto contexto)
        {

            contexto.Add<Rel_Libros_Prestamos>(relLiPr);
            contexto.SaveChanges();
        }
    }
}
