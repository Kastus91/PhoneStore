using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Domain.Responce
{
    public class BaseResponse<T> : IBaseResponce<T>
    {
        public string Description { get; set; }

        public TaskStatus StatusCode { get; set; }
        public T Data { get;}
    }

    public interface IBaseResponce<T>
    {
        T Data { get;}
    }
}
