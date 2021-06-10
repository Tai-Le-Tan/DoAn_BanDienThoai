﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Contact
    {
        public int ContactID { get; set; }
        [Display(Name = "Họ Và Tên")]
        [Required(ErrorMessage = "Họ Tên Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Họ Tên Không Được Vượt Quá 250 Kí Tự")]
        public string FullName { get; set; }
        [Display(Name = "Email")]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Email Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Email Không Được Vượt Quá 250 Kí Tự")]
        public string Email { get; set; }
        [Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Số Điện Thoại Không Được Bỏ Trống")]
        [MaxLength(11, ErrorMessage = "Số Điện Thoại Vượt Quá 11 Kí Tự")]
        public string Phone { get; set; }
        [Display(Name = "Nội dung")]
        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Mời Bạn Nhập Nội Dung")]
        public string Content { get; set; }

        public bool ViewStatus { get; set; }
        [Display(Name = "Ngày đăng")]
        public Nullable<System.DateTime> CreatedAt { get; set; }
    }
}
