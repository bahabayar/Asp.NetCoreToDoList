
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Core.UnitOfWorks
{
   public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
