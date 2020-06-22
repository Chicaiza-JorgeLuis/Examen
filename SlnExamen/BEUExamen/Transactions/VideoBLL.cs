using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUExamen.Transactions
{
    public class VideoBLL
    {
        public static void Create(Video v)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Video.Add(v);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }


        public static Video Get(int? id)
        {
            Entities db = new Entities();
            return db.Video.Find(id);
        }

        public static void Update(Video video)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Video.Attach(video);
                        db.Entry(video).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Video video = db.Video.Find(id);
                        db.Entry(video).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }


        public static List<Video> List()
        {
            Entities db = new Entities();
            //Instancia del contexto

            /*List<Alumno> alumons = db.Alumnoes.ToList();
            List<Alumno> resultado = new List<Alumno>();
            foreach (Alumno a in alumons) {
                if (a.sexo == "M") {
                    resultado.Add(a);
                }
            }
            return resultado;*/
            //SQL -> SELECT * FROM dbo.Alumno WHERE sexo = 'M'
            //return db.Alumnoes.Where(x => x.sexo == "M").ToList();

            return db.Video.ToList();

            //Los metodos del EntityFramework se denomina Linq, 
            //y la evluacion de condiciones lambda
        }


    }
}
