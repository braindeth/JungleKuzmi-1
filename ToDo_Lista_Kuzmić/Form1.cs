using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_Lista_Kuzmić
{
    public partial class Form1 : Form
    {
        public Glavna g;
        public Form1()
        {
            InitializeComponent();
            g = new Glavna();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowToDo();
            ShowInProgress();
            ShowDone();
        }

        private void ShowToDo()
        {
            TodoListBox.Items.Clear();
            foreach (Lista t in g.fetchToDo())
            {
                TodoListBox.Items.Add(t.Name);
            }
        }
        private void ShowInProgress()
        {
            InprogressBox.Items.Clear();
            foreach (Lista t in g.fetchInProg())
            {
                InprogressBox.Items.Add(t.Name);
            }
        }
        private void ShowDone()
        {
            DoneListBox.Items.Clear();
            foreach (Lista t in g.fetchDone())
            {
                DoneListBox.Items.Add(t.Name);
            }
        }
        private void startedGumb_Click(object sender, EventArgs e)
        {
            g.markInProgress(TodoListBox.SelectedIndex);
            ShowToDo();
            ShowInProgress();
            ShowDone();
        }

        private void doneGumb_Click(object sender, EventArgs e)
        {
            g.markDone(InprogressBox.SelectedIndex);
            ShowToDo();
            ShowInProgress();
            ShowDone();
        }


      

        private void obrisiGumb_Click(object sender, EventArgs e)
        {
            g.Obrisi(DoneListBox.SelectedIndex);
            ShowToDo();
            ShowInProgress();
            ShowDone();
        }

        private void TodoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails(g.fetchDetailsTodo(TodoListBox.SelectedIndex));
           
        }

        private void InprogressBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails(g.fetchDetailsInprog(InprogressBox.SelectedIndex));
           
        }

        private void DoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetails(g.fetchTaskDelete(DoneListBox.SelectedIndex));
           
        }

        private void ShowDetails(Lista t)
        {
            if (t != null)
            {
                namebox.Text = t.Name;
                dateTimePicker1.Value = t.Date;
                descbox.Text = t.Desc;
            }
            else
            {
                namebox.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                descbox.Text = "";
            }
        }

        private void dodajGumb_Click(object sender, EventArgs e)
        {
            Lista t = new Lista();
            t.Name = namebox.Text;
            t.Desc = descbox.Text;
            t.Date = dateTimePicker1.Value;
            t.State = 0;
            g.Dodaj(t);
            ShowToDo();
            ShowInProgress();
            ShowDone();
            namebox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            descbox.Text = "";
        }
    }
}
