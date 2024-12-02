using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJunproForm
{
    internal class BaseService
    {
        public virtual void Insert(object obj)
        {

        }

        public virtual void Update(object obj)
        {

        }

        public virtual void Delete(object obj)
        {

        }
    }

    internal class KaryawanService : BaseService
    {
        public override void Insert(object obj)
        {
            base.Insert(obj);
        }

        public override void Update(object obj)
        {
            base.Update(obj);
        }

        public override void Delete(object obj)
        {
            base.Delete(obj);
        }
    }
}
