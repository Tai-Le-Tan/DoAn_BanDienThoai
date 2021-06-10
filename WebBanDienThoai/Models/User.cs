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

    public partial class User
    {
        public int UserID { get; set; }
        [Display(Name = "Tên Truy Cập")]
        [Required(ErrorMessage = "Tên Truy Cập Không Được Bỏ Trống")]
        [MaxLength(50, ErrorMessage = "Tên Truy Cập Không Được Vượt Quá 50 Kí Tự")]
        [Column(TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật Khẩu Không Được Bỏ Trống")]
        [Display(Name = "Mật Khẩu")]
        [MaxLength(250, ErrorMessage = "Mật Khẩu Không Được Vượt Quá 250 Kí Tự")]
        [Column(TypeName = "varchar")]
       // [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Họ Và Tên Không Được Bỏ Trống")]
        [Display(Name = "Họ Và Tên")]
        public string Fullname { get; set; }
        [Display(Name = "Hình Ảnh")]
        [MaxLength(250, ErrorMessage = "Tên Hình Ảnh Không Được Vượt Quá 250 Kí Tự")]

        public string Image { get; set; }
        [Display(Name = "Email")]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Email Không Được Bỏ Trống")]
        [MaxLength(50, ErrorMessage = "Email Không Được Quá 50 Kí Tự")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Địa Chỉ Không Được Bỏ Trống")]
        [Display(Name = "Địa Chỉ")]
        [MaxLength(150, ErrorMessage = "Địa Chỉ Không Được Vượt Quá 150 Kí Tự")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Số Điện Thoại Không Được Bỏ Trống")]
        [Display(Name = "Số Điện Thoại")]
        [MaxLength(20, ErrorMessage = "Số Điện Thoại Không Được Vượt Quá 20 Kí Tự")]

        public string Phone { get; set; }

        [NotMapped]
        [Display(Name = "Nhập lại Mật Khẩu")]
        [MaxLength(250, ErrorMessage = "Mật Khẩu Không Được Vượt Quá 250 Kí Tự")]
        [Column(TypeName = "varchar")]
        [DataType(DataType.Password)]
        public string ComfirmPass { get; set; }
        [NotMapped]
        [Display(Name = "Nhập mật khẩu mới")]
        [DataType(DataType.Password)]
        [MaxLength(250, ErrorMessage = "Mật Khẩu Không Được Vượt Quá 250 Kí Tự")]
        [Column(TypeName = "varchar")]
        public string Passnew { get; set; }
        [NotMapped]
        [Compare("Passnew")]
        [MaxLength(250, ErrorMessage = "Mật Khẩu Không Được Vượt Quá 250 Kí Tự")]
        [Column(TypeName = "varchar")]
        [Display(Name = "Nhập lại Mật Khẩu")]
        [DataType(DataType.Password)]
        public string ComfirmPass1 { get; set; }
       

        [Display(Name = "Ngày Cập Nhật")]
        public Nullable<System.DateTime> CreatedAt { get; set; }
        [Display(Name = "Trạng Thái")]
        public bool Status { get; set; }

    }
}
