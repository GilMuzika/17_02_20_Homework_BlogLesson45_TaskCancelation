using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_02_20_Homework_BlogLesson45_TaskCancelation
{
    public partial class Form1 : Form
    {
        private Random _rnd = new Random();
        private Task task;
        private Task taskToFault;
        private CancellationTokenSource tokenS = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            txtNumber.Text = _rnd.Next(100000, 1000000000).ToString();
            txtNumber.KeyUp += (object sender, KeyEventArgs e) => 
                {
                    if (!Int32.TryParse(txtNumber.Text, out int afterparseNum)) 
                    {
                        txtNumber.Text = _rnd.Next(100000, 1000000000).ToString();
                        MessageBox.Show("You must enter only numbers");
                    }
                };
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            int accumulate = 0;

            if (task != null && task.Status == TaskStatus.Running) return;
            Int32.TryParse(txtNumber.Text, out int afterparseNum);
            task = Task.Factory.StartNew<int>(() => 
                {
                    
                    for (int i = 1; i <= afterparseNum; i++)
                    {
                        Thread.Sleep(10);
                        if(lblNumber.InvokeRequired)
                        {
                            lblNumber.Invoke((Action)delegate { lblNumber.Text = accumulate.ToString(); });
                        }
                        else lblNumber.Text = accumulate.ToString();
                        accumulate += i;
                   
                        try
                        {
                            tokenS.Token.ThrowIfCancellationRequested();
                        }
                        catch(Exception ex)
                        {
                            if (ex.GetType().Name == "OperationCanceledException") { break; }
                            

                        }
                    }
                    
                    return accumulate;

                }, tokenS.Token).ContinueWith((Task<int> t) => { return accumulate; });               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tokenS.Cancel();
            Task task2 = Task.Factory.StartNew(() => 
            {
                if(!task.IsCanceled) MessageBox.Show((task as Task<int>).Result.ToString());                
            });
                       
            
            
        }

        private void btnCreateTaskToFauls_Click(object sender, EventArgs e)
        {
            int[] intArr = new int[] {1, 2, 3, 4, 5 };            
            taskToFault = Task.Factory.StartNew<int>(() =>
                {                    

                        return intArr[100];

                });

            
            
        }

        private void btnInvestigateException_Click(object sender, EventArgs e)
        {
            if(taskToFault.IsFaulted)
            {
                taskToFault.Exception.Handle((exc) => 
                {
                    MessageBox.Show($"{exc.GetType().Name}\n\n{exc.Message}\n\n{exc.StackTrace}");
                    return true;
                });
            }
            MessageBox.Show(taskToFault.IsFaulted.ToString());
        }
    }
}
