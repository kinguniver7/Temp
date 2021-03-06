﻿using System.ComponentModel.DataAnnotations;

namespace SCA.Domain
{
    /// <summary>
    /// Пользователь системы
    /// </summary>
    public class SystemUser : IdentityEntity
    {
        [Required]
        [MaxLength(255)]
        public virtual string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string LastName { get; set; }

        [MaxLength(500)]
        public virtual string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        [Required]
        public virtual SystemUserType Type { get; set; }
    }
}
