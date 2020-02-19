using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WorkshopASPCore21.Models;
using System;

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
            List<Mahasiswa> lstMhs = new List<Mahasiswa>();
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Mahasiswa 
                                  order by Nama asc";
                SqlCommand cmd = new SqlCommand(strSql,conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows){
                    while(dr.Read()){
                        lstMhs.Add(new Mahasiswa{
                            Nim = dr["Nim"].ToString(),
                            Nama = dr["Nama"].ToString(),
                            IPK = Convert.ToDouble(dr["IPK"]),
                            Email = dr["Email"].ToString()
                        });
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return lstMhs;
            }
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