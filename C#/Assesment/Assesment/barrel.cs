using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class barrel
    {
        public int m_gal;
    public barrel (int g)
    {
        m_gal = g;
    }
        public void fill(int n)
        {
            m_gal += n ;
        }
        public void drain(int n)
        {
            m_gal -= n;
        }
    }
}
