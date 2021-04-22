
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Core.UnitOfWorks
{
   public interface IUnitOfWorks
    {
        Task CommitAsync();
        void Commit();
    }
}
