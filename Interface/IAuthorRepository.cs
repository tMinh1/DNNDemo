using Christoc.Modules.TuanMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christoc.Modules.TuanMVC.Interface
{
    internal interface IAuthorRepository
    {
        Task<IEnumerable<Test_Author>> Gets(string TuKhoa);
        Task<Test_Author> Get(int ID);
        Task<Test_Author> Add(Test_Author data);
        Task<Test_Author> Edit(Test_Author data);
        Task<int> Delete(int ID);
    }
}
