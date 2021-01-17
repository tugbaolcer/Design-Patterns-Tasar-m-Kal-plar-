using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesignExample
{
    public interface IIteration
    {
        //Bir sonraki elemenı getirir.
        Personnel NextItem();
        //Bir sonraki eylemde eleman var mı?
        bool HasItem();
        //Mevcut elemanı getirir.
        Personnel CurrentItem();
    }
}
