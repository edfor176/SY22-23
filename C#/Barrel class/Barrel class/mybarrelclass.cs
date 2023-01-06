using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrel_class
   {
    internal class mybarrelclass
{
    int m_size;
    int m_gallons;

    public mybarrelclass(int size)
    {
        m_size = size;
    }
    public void fill(int gallons)
    {
        m_gallons += gallons;
        if (m_gallons > m_size)
            m_gallons = 0;

    }
    public void drain(int gallons)
    {

    }
    public override string ToString()
    {
        return "barrel has :" + m_gallons + "gallons";

    }


} 
}