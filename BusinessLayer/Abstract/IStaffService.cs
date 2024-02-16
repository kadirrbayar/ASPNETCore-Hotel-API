using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStaffService:IGenericService<Staff>
    {
        int TStaffCount();
        List<Staff> TLast4Staff();
    }
}
