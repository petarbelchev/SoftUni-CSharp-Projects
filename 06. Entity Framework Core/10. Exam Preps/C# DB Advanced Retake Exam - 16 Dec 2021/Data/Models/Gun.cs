﻿using Artillery.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artillery.Data.Models
{
	public class Gun
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey(nameof(Manufacturer))]
		public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;

		[Required]
		[Range(100, 1_350_000)]
		public int GunWeight { get; set; }

		[Required]
		[Range(2.00, 35.00)]
		public double BarrelLength { get; set; }

        public int? NumberBuild { get; set; }

		[Required]
		[Range(1, 100_000)]
        public int Range { get; set; }

		[Required]
        public GunType GunType { get; set; }

		[Required]
		[ForeignKey(nameof(Shell))]
        public int ShellId { get; set; }
        public Shell Shell { get; set; } = null!;

        public virtual ICollection<CountryGun> CountriesGuns { get; set; } = null!;
    }
}
