using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevMvcTaskList.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class TaskRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public void addTask(TaskModel model)
        {
            db.Execute(@"insert into tasks (Title, IsCompleted) values (@Title, cast('false' as Bit))", model);
        }

        public List<TaskModel> getTasks()
        {
            return db.Query<TaskModel>("select * from tasks order by Id desc").ToList();
        }

        public void completeTask(int id)
        {
            db.Execute(@"update Tasks set IsCompleted = ~IsCompleted where Id = @Id", new { id });
        }
    }
}