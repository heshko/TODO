using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Domain
{
    class Task
    {
      
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public  Task(string title,DateTime dueDate)
        {
          Title = title;
            DueDate = dueDate;
        }





    }
}
