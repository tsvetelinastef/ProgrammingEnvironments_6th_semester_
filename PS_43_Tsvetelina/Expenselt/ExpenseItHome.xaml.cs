﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        private DateTime _lastChecked;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime LastChecked
        {
            get { return _lastChecked; }
            set
            {
                _lastChecked = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
                }
            }
        }
        public List<Person> ExpenseDataSource { get; set; }
        public string MainCaptionText { get; set; }
        public ExpenseItHome()
        {
            InitializeComponent();
            InitExpenseDataSource();
            LastChecked = DateTime.Now;
            this.DataContext = this;
        }

        private void InitExpenseDataSource()
        {
            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                    Name = "Mike",
                    Department = "Legal",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Lunch", ExpenseAmount=50},
                        new Expense() {ExpenseType="Transportation", ExpenseAmount=20},
                    }
                },
                new Person()
                {
                    Name = "Lisa",
                    Department = "Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Document printing", ExpenseAmount=50},
                        new Expense() {ExpenseType="Gift", ExpenseAmount=150},
                    }
                },
                new Person()
                {
                    Name = "John",
                    Department = "Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Magazine subscription", ExpenseAmount=50},
                        new Expense() {ExpenseType="New Machine", ExpenseAmount=600},
                        new Expense() {ExpenseType="Software", ExpenseAmount=500},
                    }
                },
                new Person()
                {
                    Name = "Mary",
                    Department = "Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Dinner", ExpenseAmount=100},
                    }
                },
                new Person()
                {
                    Name = "Theo",
                    Department = "Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Dinner", ExpenseAmount=100},
                    }
                },
                new Person()
                {
                    Name = "James",
                    Department = "Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Laptop", ExpenseAmount=1000},
                    }
                },
                new Person()
                {
                    Name = "David",
                    Department = "Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() {ExpenseType="Shoes", ExpenseAmount=80},
                    }
                },
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var report = new ExpenceReport(peopleListBox.SelectedItem);
            Close();
            report.Show();
        }
    }
}
