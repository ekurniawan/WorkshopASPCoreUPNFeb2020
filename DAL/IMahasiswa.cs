using System.Collections.Generic;
using WorkshopASPCore21.Models;

namespace WorkshopASPCore21.DAL
{
    public interface IMahasiswa
    {
        IEnumerable<Mahasiswa> GetAll();
        Mahasiswa GetById(string id);
        void Insert(Mahasiswa mhs);
        void Update(Mahasiswa mhs);
        void Delete(string id);
    }
}