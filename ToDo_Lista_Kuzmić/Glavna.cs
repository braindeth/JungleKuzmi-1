using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Lista_Kuzmić
{
    public class Glavna
    {
        List<Lista> Tasks { get; set; }
        public Glavna()
        {
            Tasks = new List<Lista>();
        }

        public void Dodaj(Lista task)
        {
            Tasks.Add(task);
        }

        public void Obrisi(int id)
        {
            Tasks.Remove(fetchTaskDelete(id));
        }

        public Lista fetchTaskDelete(int id)
        {
            int i = 0;
            foreach (Lista t in Tasks)
            {
                if (t.State == 2) ;
                {
                    if (i == id)
                    {
                        return t;
                    }
                    i++;
                }
            }
            return null;
        }

        public void markInProgress(int id)
        {
            int i = 0;
            foreach (Lista t in Tasks)
            {
                if (t.State == 0)
                {
                    if (i == id)
                    {
                        t.State = 1;
                        break;
                    }
                    i++;
                }   
            }
        }

        public void markDone(int id)
        {
            int i = 0;
            foreach (Lista t in Tasks)
            {
                if (t.State == 1)
                {
                    if (i == id)
                    {
                        t.State = 2;
                        break;
                    }
                    i++;
                }     
            }
        }
        public List<Lista> fetchToDo()
        {
            List<Lista> todo = new List<Lista>();
            foreach (Lista t in Tasks)
            {
                if (t.State == 0)
                {
                    todo.Add(t);
                }
            }
            return todo;
        }

        public List<Lista> fetchInProg()
        {
            List<Lista> inProg = new List<Lista>();
            foreach (Lista t in Tasks)
            {
                if (t.State == 1)
                {
                    inProg.Add(t);
                }
            }
            return inProg;

        }

        public List<Lista> fetchDone()
        {
            List<Lista> done = new List<Lista>();
            foreach (Lista t in Tasks)
            {
                if (t.State == 2)
                {
                    done.Add(t);
                }
            }
            return done;
        }

        public Lista fetchDetailsTodo(int id)
        {
            int i = 0;
            foreach (Lista t in Tasks)
            {
                if (t.State == 0) ;
                {
                    if (i == id)
                    {
                        return t;
                    }
                    i++;
                }
            }
            return null;
        }

        public Lista fetchDetailsInprog(int id)
        {
            int i = 0;
            foreach (Lista t in Tasks)
            {
                if (t.State == 1) ;
                {
                    if (i == id)
                    {
                        return t;
                    }
                    i++;
                }
            }
            return null;
        }
    }
}
