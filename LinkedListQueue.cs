﻿using StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
     class LinkedListQueue
    {
       // Node head = null;
        QNode front, rear;

        public LinkedListQueue()
        {
            this.front = this.rear = null;
        }
        public void Enqueue(int key)
        {
            QNode temp = new QNode(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

           
            this.rear.next = temp;
            this.rear = temp;
            
        }
        internal void Display()
        {
            QNode temp = this.front;
            if (temp==null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp!=null)
            {
                
                Console.WriteLine(temp.key+" is Enqueue");
                temp=temp.next;
            }
        }
    }
}
