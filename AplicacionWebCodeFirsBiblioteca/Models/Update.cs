using DAL;

namespace AplicacionWebCodeFirsBiblioteca.Models
{
    public class Update
    {
        public void AcutalizarUsuario(Usuarios usu, Contexto contexto)
        {
            contexto.Update<Usuarios>(usu);
            contexto.SaveChanges();

        }

        public void AcutalizarAcceso(Accesos acs, Contexto contexto)
        {

            contexto.Update<Accesos>(acs);
            contexto.SaveChanges();
        }
        public void AcutalizarAutores(Autores aut, Contexto contexto)
        {

            contexto.Update<Autores>(aut);
            contexto.SaveChanges();
        }
        public void AcutalizarColecciones(Colecciones colec, Contexto contexto)
        {

            contexto.Update<Colecciones>(colec);
            contexto.SaveChanges();
        }
        public void AcutalizarEditoriales(Editoriales edito, Contexto contexto)
        {

            contexto.Update<Editoriales>(edito);
            contexto.SaveChanges();
        }
        public void AcutalizarEstaPresta(Estados_Prestamos estaPres, Contexto contexto)
        {

            contexto.Update<Estados_Prestamos>(estaPres);
            contexto.SaveChanges();
        }
        public void AcutalizarGeneros(Generos genero, Contexto contexto)
        {

            contexto.Update<Generos>(genero);
            contexto.SaveChanges();
        }
        public void AcutalizarLibros(Libros libro, Contexto contexto)
        {

            contexto.Update<Libros>(libro);
            contexto.SaveChanges();
        }
        public void AcutalizarPrestamos(Prestamos presta, Contexto contexto)
        {

            contexto.Update<Prestamos>(presta);
            contexto.SaveChanges();
        }
        public void AcutalizarRelAutoLibr(Rel_Autores_Libros relAuLi, Contexto contexto)
        {

            contexto.Update<Rel_Autores_Libros>(relAuLi);
            contexto.SaveChanges();
        }
        public void AcutalizarRelLibrPres(Rel_Libros_Prestamos relLiPr, Contexto contexto)
        {
            contexto.Update<Rel_Libros_Prestamos>(relLiPr);
            contexto.SaveChanges();
        }
    }
}
