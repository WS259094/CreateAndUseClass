using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUseClass.UserBehaviors


{
    class clsUserDetails
    {

        private string m_sName;
        private int m_iAge;

        public string GetName()
        {
            return m_sName;
        }

        public void SetName(string sName)
        {
            m_sName = sName;
        }

        public int GetAge()
        {
            return m_iAge;
        }
        public void SetAge(int iAge)
        {
            m_iAge = iAge;
        }
    }
}
