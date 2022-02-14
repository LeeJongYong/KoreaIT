using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevDapper.Models;
using Dapper;

namespace DevDapper.Repositories
{
    public class MaximServiceRepository
    {
        // DataBase Connection 개체 생성
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        // 입력
        public Maxim AddMaxim(Maxim model)
        {
            // Insert 실행 후 Identity 값을 되돌려 받음
            string sql = @"Insert into Maxims (Name, Content) values (@Name, @Content);
                            Select Cast(SCOPE_IDENTITY() AS int);
            ";
            var id = db.Query<int>(sql, model).Single();
            model.Id = id;
            return model;
        }

        // 출력
        public List<Maxim> GetMaxims()
        {
            string sql = "select Id, Name, Content, CreationDate From Maxims order by Id Asc";
            return db.Query<Maxim>(sql).ToList();
        }

        // 상세
        public Maxim GetMaximById(int id)
        {
            string sql = "select Id, Name, Content, CreationDate from Maxims where Id = @Id";
            return db.Query<Maxim>(sql, new { Id = id }).SingleOrDefault();
        }

        // 수정
        public Maxim UpdateMaxim(Maxim model)
        {
            string sql = "update Maxims set Name = @Name, Content = @Content where Id = @Id";
            db.Execute(sql, model);
            return model;
        }

        // 삭제
        public void RemoveMaxim(int id)
        {
            string sql = "Delete Maxims where Id = @Id";
            db.Execute(sql, new { Id = id });
        }
    }
}