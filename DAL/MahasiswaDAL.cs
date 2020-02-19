using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WorkshopASPCore21.Models;

namespace WorkshopASPCore21.DAL
{
    public class MahasiswaDAL : IMahasiswa
    {
        private IConfiguration _config;
        public MahasiswaDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Mahasiswa> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Mahasiswa GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }
    }
}