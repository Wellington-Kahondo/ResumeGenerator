using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Authorization.Users;
using ResumeGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ResumeGenerator.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "DOB")]
        public virtual DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual RefListGender? Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual RefListTitle? Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
         public virtual RefListRace? Race { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual User User { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "ID/Passport Number")]
        public virtual string IdentificationNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string CellNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [EmailAddress]
        [Display(Name = "Email")]
        public virtual string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual StoredFile StoredFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool IsAdmin { get; set; }
    }
}
