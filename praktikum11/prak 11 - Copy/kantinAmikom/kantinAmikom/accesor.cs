using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace kantinAmikom
{
    public class accesor
    {
        // untuk mengambil data dari tabel pedagang
        public static System.Data.Linq.Table<pedagang> Getpedagangtable()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return dc.GetTable<pedagang>();
        }

        //untuk insert atau update data tabel pedagang
        public static void insertorupdatepedagang(int idpedagang, string namapedagang, string alamatpedagang)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var caripedagang = (from p in dc.GetTable<pedagang>() where p.id == idpedagang select p).SingleOrDefault();

            if (caripedagang == null)
            {
                try
                {
                    Table<pedagang> datapedagang = accesor.Getpedagangtable();
                    pedagang pdg = new pedagang();
                    pdg.id = idpedagang;
                    pdg.nama = namapedagang;
                    pdg.alamat = alamatpedagang;

                    datapedagang.InsertOnSubmit(pdg);
                    datapedagang.Context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }

            else
            {
                try
                {
                    caripedagang.nama = namapedagang;
                    caripedagang.alamat = alamatpedagang;

                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
            }

        }

        //untuk delete data tabel pendagang
        public static void deletepedagang(int idpedagang)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var caripedagang = (from p in dc.GetTable<pedagang>() where p.id == idpedagang select p).SingleOrDefault();


            try
            {
                dc.pedagangs.DeleteOnSubmit(caripedagang);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}
