using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public delegate void Notify();

    class A
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process A Started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

    class B
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process B Started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

    class Demo_Eventation
    {
        public void something_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }

        public void registEvent()
        {
            A a = new A();
            a.ProcessCompleted += something_ProcessCompleted;
            B b = new B();
            b.ProcessCompleted += something_ProcessCompleted;
        }

        public void runEvent()
        {
            A a = new A();
            a.ProcessCompleted += something_ProcessCompleted;
            B b = new B();
            b.ProcessCompleted += something_ProcessCompleted;

            a.StartProcess();
            b.StartProcess();
        }
    }
}
