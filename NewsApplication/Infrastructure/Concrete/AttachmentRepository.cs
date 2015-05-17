using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsApplication.Infrastructure.Abstract;
using NewsApplication.Models.Entity;
using NewsApplication.Infrastructure.Concrete;

namespace NewsApplication.Infrastructure.Concrete
{
    public class AttachmentRepository : RepositoryBase<Attachment>, IAttachmentRepository
    {
    }

    public interface IAttachmentRepository : IRepository<Attachment> { }
}