using System.ComponentModel.DataAnnotations;

namespace PegawaiMVC.Models
{
    public class Pegawai
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string Nama {get; set;}
        public string Alamat {get; set;}
        public string Jabatan {get; set;}

        [Display(Name="Jenis Kelamin")]
        public string JenisKelamin {get; set;}

        [Display(Name="Tanggal Lahir")]
        [DataType(DataType.Date)]
        public DateTime? TanggalLahir {get;set;}

        [Display(Name="Tanggal Masuk Kerja")]
        [DataType(DataType.Date)]
        public DateTime? TanggalMasukKerja {get; set;}
    }
}