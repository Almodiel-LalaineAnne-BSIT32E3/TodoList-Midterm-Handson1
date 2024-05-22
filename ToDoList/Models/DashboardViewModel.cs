using System.Collections.Generic;
using ToDoList.Domain;

namespace ToDoList.Models
{
    public class DashboardViewModel
    {
       
        public List<ToDoItem> ToDoItems { get; set; }

        public List<ToDoItem> PendingToDoItems { get; set; }

        public List<ToDoItem> DoneToDoItems { get; set; }

        public string Username { get; set; }  
        public int PendingCount { get; set; } 
        public int DoneCount { get; set; }    

        
        public DashboardViewModel()
        {
            ToDoItems = new List<ToDoItem>();
            PendingToDoItems = new List<ToDoItem>();
            DoneToDoItems = new List<ToDoItem>();
        }
    }
}