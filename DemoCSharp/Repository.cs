using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp
{
    public class Repository<TRepoType> where TRepoType:IEntity
    {
        private List<TRepoType> _repo;

        public Repository()
        {
            _repo = new List<TRepoType>();
        }

        public void Add(TRepoType item)
        {
            _repo.Add(item);
        }

        public async Task<List<TRepoType>> GetTopCredits()
        {
            //List<TRepoType> list = new List<TRepoType>();
            //foreach(var item in _repo)
            //{
            //    if (item.Credit > 5)
            //        list.Add(item);
            //}
            //return list;

            //return _repo.Where(item => item.Credit > 5).ToList();

            return (from item in _repo
                 where item.Credit > 5
                 select item).ToList();
            
        }
    }
}
