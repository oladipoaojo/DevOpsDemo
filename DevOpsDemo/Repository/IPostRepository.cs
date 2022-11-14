using System;
using DevOpsDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsDemo.Repository
{
    interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
