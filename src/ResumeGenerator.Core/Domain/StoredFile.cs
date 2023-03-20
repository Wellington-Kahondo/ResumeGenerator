using Abp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeGenerator.Domain
{
    public class StoredFile : Entity<Guid>
    {
        [NotMapped]
        public virtual IFormFile File { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string FileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Description { get; set; }
        public virtual string ContentDisposion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //public virtual Guid ResumeId { get; set; }
        //public virtual Resume Resume { get; set; }
    }
}
