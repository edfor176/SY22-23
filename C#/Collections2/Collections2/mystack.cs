using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    internal class mystack
    {
        private int[]m_nums = new int[10];
        private int m_count = 0;
            
        public void push(int num)
        {
            m_nums[m_count] = num;
        }
        public int pop()
        {
             return m_nums[m_count--]; 
        }
        public int peak()
        {
            return m_nums[m_count]; 
        }
        public int count()
        {
            return m_count-1; 
        }
    }
}
